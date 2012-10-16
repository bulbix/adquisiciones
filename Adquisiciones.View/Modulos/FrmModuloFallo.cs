using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Business.ModFallo;
using Adquisiciones.Data.Entities;
using Adquisiciones.View.Busquedas;
using DevExpress.XtraEditors;
using Spring.Context.Support;

namespace Adquisiciones.View.Modulos
{
    public partial class FrmModuloFallo : FrmModulo
    {

        ///<summary>
        ///</summary>
        public IFalloService FalloService { get; set; }

        ///<summary>
        ///</summary>
        public Anexo AnexoSelect;

        public FrmModuloFallo(FrmAdquisiciones padre)
        {
            InitializeComponent();

            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;
            this.MdiParent = padre;

            base.TypeEntity = typeof(Fallo);
            base.NombreService = "falloService";
            base.NombreReporte = "reporteTabla";
            base.GetServicio();
            FalloService = base.Servicio as IFalloService;
            base.ObtenerPerfil();

            var anexos = FalloService.AnexoDao.
               CargarAnexosWithCotizacion(AlmacenActual);
            bsAnexos.DataSource = anexos;

            dtpFallo.DateTime = DateTime.Now;
            //Nos Suscribimos al Evento
            if (FalloService != null) FalloService.FalloProceso += OnProcesoFallo;
        }

        protected void OnProcesoFallo(object sender, FalloProcesoEvento e)
        {
            pgbFallo.EditValue = e.Porcentaje;
            pgbFallo.Update();
            //pgbFallo.Text = e.Porcentaje.ToString();
        }

        public override void Guardar()
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
                   XtraMessageBox.Show(@"El anexo ya tiene fallo eliminelo antes",
                                                 @"Adquisiciones", MessageBoxButtons.OK,
                                                 MessageBoxIcon.Information);

                  return;
                }

                var lista = FalloService.GuardarFallo(AnexoSelect, dtpFallo.DateTime);

                if (lista.Count > 0)
                {
                    XtraMessageBox.Show(@"Fallo realizado Exitosamente Anexo " + AnexoSelect.NumeroAnexo,
                                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    base.EntityActual = lista[0];
                }
                else
                {
                    XtraMessageBox.Show(@"El anexo no tiene ni una cotizacion",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en el fallo " + ee.Message,
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }
        }

        public override void Nuevo()
        {
            AnexoSelect = null;
            dtpFallo.DateTime = DateTime.Now;
            pgbFallo.EditValue = 0;
            pgbFallo.Text = string.Empty;
        }

        private void SearchLookUpAnexoEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpAnexo.EditValue != null)
            {
                //Pinta el instituto y la descripcion del anexo
                var idAnexo = (long)searchLookUpAnexo.EditValue;
                AnexoSelect = FalloService.AnexoDao.Get(idAnexo);
                this.Text = @"Fallo-Anexo::" + AnexoSelect;
            }
            else
            {
                AnexoSelect = null;

            }
        }

        private void CallFalloBusqueda()
        {
            var forma = new FrmBusquedaFallo(this.MdiParent as FrmAdquisiciones);
            forma.MdiParent = this.MdiParent;
            forma.Show();
            
        }

         protected override void CmdConsultarClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
         {
             CallFalloBusqueda();
         }

        protected override void Eliminar()
        {
            if(FalloService.FalloDao.ExisteFalloRequisicion((EntityActual as Fallo).Anexo))
            {
                XtraMessageBox.Show(@"El fallo ya tiene requisicion",
                   @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            base.Eliminar();
        }
    }
}