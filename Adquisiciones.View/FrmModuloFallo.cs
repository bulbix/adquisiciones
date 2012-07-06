using System;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Business.ModFallo;
using Adquisiciones.Data.Entities;
using log4net;
using Spring.Context.Support;

namespace Adquisiciones.View
{
    public partial class FrmModuloFallo : DevExpress.XtraEditors.XtraForm
    {

        ///<summary>
        ///</summary>
        public IFalloService FalloService;

        ///<summary>
        ///</summary>
        public Anexo AnexoSelect;

        private static readonly ILog Log =
           LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        ///<summary>
        ///</summary>
        public FrmModuloFallo()
        {
            InitializeComponent();
         
            var ctx = ContextRegistry.GetContext();
            FalloService = ctx["falloService"] as IFalloService;

            dtpFallo.DateTime = DateTime.Now;
            //Nos Suscribimos al Evento
            if (FalloService != null) FalloService.FalloProceso += OnProcesoFallo;
        }


        protected void OnProcesoFallo(object sender, FalloProcesoEvento e)
        {
            pgbFallo.EditValue = e.Porcentaje;
            pgbFallo.Text = e.Porcentaje.ToString();
        }

        
        private void BtnProcesarClick(object sender, EventArgs e)
        {
            try
            {

                var falloCentinela = new Fallo();
                falloCentinela.Anexo = AnexoSelect;
                falloCentinela.FechaFallo = dtpFallo.DateTime;

                //Se usa un fallo centinela para las validaciones
                if (!Util.DatosValidos(falloCentinela, lblNumErrors, listaError))
                {
                    return;
                }

                if (FalloService.CotizacionDao.ExisteAnexoFallo(AnexoSelect))
                {
                    var result = MessageBox.Show(@"El anexo ya tiene fallo desea continuar",
                                                 @"Adquisiciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                        return;
                }

                var lista = FalloService.GenerarFallo(AnexoSelect, dtpFallo.DateTime);

                if (lista.Count > 0)
                {
                    MessageBox.Show(@"Fallo realizado Exitosamente Anexo " + AnexoSelect.NumeroAnexo,
                                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(@"El anexo no tiene ni una cotizacion",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en el fallo " + ee.Message,
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }
        }

        private void SearchLookUpAnexoEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpAnexo.EditValue != null)
            {
                //Pinta el instituto y la descripcion del anexo
                var idAnexo = (long)searchLookUpAnexo.EditValue;
                AnexoSelect = FalloService.AnexoDao.Get(idAnexo);
                this.Text = @"Fallo-Anexo::" + AnexoSelect;}
            else
            {
                AnexoSelect = null;
                
            }
        }
        private void FrmCargaFalloDevLoad(object sender, EventArgs e)
        {
            var anexos = FalloService.AnexoDao.
                CargarAnexosWithCotizacion(FrmModuloModulo.AlmacenSelec);
            bsAnexos.DataSource = anexos;
        }

      
        
    }
}