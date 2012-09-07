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
        public IFalloService FalloService { get; set; }

        public FrmBusquedaFallo()
        {
            InitializeComponent();
            base.TypeEntity = typeof(Fallo);
            base.NombreService = "falloService";
            base.NombreReporte = "reporteTabla";
            base.GvGeneral = gvAnexo;
            FalloService = base.Servicio as IFalloService;
            base.ObtenerPerfil();
        }



        protected override void CmdConsultarItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("Genere el reporte");
        }

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
    
    }
}