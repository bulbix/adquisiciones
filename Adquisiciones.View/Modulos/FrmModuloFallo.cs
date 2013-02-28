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

        #region Variables
        public IFalloService FalloService { get; set; }
        public Anexo AnexoSelect;
        #endregion

        #region Constructores
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

            var anexos = FalloService.AnexoDao.CargarAnexosWithCotizacion(AlmacenActual);
            bsAnexos.DataSource = anexos;

            Nuevo();
            
            //Nos Suscribimos al Evento
            if (FalloService != null) FalloService.FalloProceso += OnProcesoFallo;
        }
        #endregion

        #region Metodos
        public override void Guardar()
        {
            try
            {

                var falloCentinela = new Fallo();
                falloCentinela.Anexo = AnexoSelect;
                falloCentinela.FechaFallo = FalloService.AnexoDao.FechaServidor();

                //Se usa un fallo centinela para las validaciones
                if (!Util.DatosValidos(falloCentinela, lblNumErrors, listaError))
                    return;

                if (FalloService.CotizacionDao.ExisteAnexoFallo(AnexoSelect))
                {
                   XtraMessageBox.Show(@"El anexo ya tiene fallo eliminelo antes",
                                                 @"Adquisiciones", MessageBoxButtons.OK,
                                                 MessageBoxIcon.Information);
                  return;
                }

                var lista = FalloService.GuardarFallo(AnexoSelect, falloCentinela.FechaFallo.Value);

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
            lblFecha.Text = String.Format("{0:dd/MM/yyyy}", FalloService.AnexoDao.FechaServidor());
            pgbFallo.EditValue = 0;
            pgbFallo.Text = string.Empty;
            searchLookUpAnexo.EditValue = null;
        }

        protected void OnProcesoFallo(object sender, FalloProcesoEvento e)
        {
            pgbFallo.EditValue = e.Porcentaje;
            pgbFallo.Update();
        }
        #endregion

        #region Eventos
        private void SearchLookUpAnexoEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpAnexo.EditValue != null)
            {
                var anexoSeleccionado = searchLookUpEditAnexo.GetFocusedRow() as Anexo;

                if (anexoSeleccionado != null)
                {
                    AnexoSelect = anexoSeleccionado;
                    this.Text = @"Fallo-Anexo::" + AnexoSelect;
                }
            }
            else
            {
                AnexoSelect = null;
            }
        }
        #endregion

    }
}