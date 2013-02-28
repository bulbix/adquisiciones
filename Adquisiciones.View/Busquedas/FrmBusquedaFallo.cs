using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business.ModFallo;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;

namespace Adquisiciones.View.Busquedas
{
    public partial class FrmBusquedaFallo : FrmBusqueda
    {
        #region Variables
        public IFalloService FalloService { get; set; }
        #endregion

        #region Constructores
        public FrmBusquedaFallo(FrmAdquisiciones padre)
        {
            InitializeComponent();

            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;

            base.TypeEntity = typeof(Fallo);
            base.NombreService = "falloService";
            base.NombreReporte = "reporteTabla";
            base.GvGeneral = gvAnexo;
            GetServicio();
            FalloService = base.Servicio as IFalloService;
            base.ObtenerPerfil();
        }
        #endregion

        #region Metodos
        protected override void Eliminar()
        {
            if (FalloService.FalloDao.ExisteFalloRequisicion
                ((GvGeneral.GetFocusedRow() as Fallo).Anexo))
            {
                XtraMessageBox.Show(@"El fallo ya tiene requisicion",
                   @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            base.Eliminar();
        }
        #endregion

        #region Eventos
        protected override void CmdConsultarItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Genere el reporte");
        }
        #endregion
    }
}