using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business.ModAnexo;
using Adquisiciones.Business.ModCotizacion;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using Spring.Context.Support;

namespace Adquisiciones.View
{
    
    ///<summary>
    ///</summary>
    public partial class FrmBusquedaCotizacion : DevExpress.XtraEditors.XtraForm
    {
        ///<summary>
        ///</summary>
        public ICotizacionService CotizacionService;


        ///<summary>
        ///</summary>
        public FrmBusquedaCotizacion()
        {
            InitializeComponent();
            var ctx = ContextRegistry.GetContext();
            CotizacionService = ctx["cotizacionService"] as ICotizacionService;
        }

        private void CmdBuscarClick(object sender, EventArgs e)
        {
            var cotizaciones = CotizacionService.CotizacionDao.
                CargarCotizaciones(FrmModuloModulo.AlmacenSelec);

            bsCotizaciones.DataSource = cotizaciones;
        }


        private void CmdImprimirClick(object sender, EventArgs e)
        {
            gvCotizacion.ShowPrintPreview();

        }

        private void CmdConsultarClick(object sender, EventArgs e)
        {

            try
            {
                var cotizaSelect = gvCotizacion.GetFocusedRow() as Cotizacion;
                var forma = new FrmModuloCotizacion(cotizaSelect);
                forma.MdiParent = this.MdiParent;
                forma.Show();
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"No hay cotizacion seleccionada", @"Adquisiciones",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var cotizaSelect = gvCotizacion.GetFocusedRow() as Cotizacion;
                var forma = new FrmModuloReportes("reporteCotizacion",cotizaSelect);
                forma.MdiParent = this.MdiParent;
                forma.Show();}
            catch (Exception ee)
            {
                MessageBox.Show(@"No hay cotizacion seleccionada", @"Adquisiciones", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            var cotizaSelect = gvCotizacion.GetFocusedRow() as Cotizacion;
            cotizaSelect.TieneFallo = CotizacionService.CotizacionDao.ExisteAnexoFallo(cotizaSelect.Anexo);
            gvCotizacion.RefreshData();
        }
    }
}