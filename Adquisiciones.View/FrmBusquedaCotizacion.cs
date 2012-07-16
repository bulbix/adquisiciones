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
using Form = Spring.Windows.Forms.Form;
namespace Adquisiciones.View
{
    
    ///<summary>
    ///</summary>
    public partial class FrmBusquedaCotizacion : XtraForm
    {
        ///<summary>
        ///</summary>
        public ICotizacionService CotizacionService { get; set; }


        ///<summary>
        ///</summary>
        public FrmBusquedaCotizacion()
        {
            InitializeComponent();
            var ctx = ContextRegistry.GetContext();
            CotizacionService = ctx["cotizacionService"] as ICotizacionService;
           
        }

        private void Buscar()
        {
            var cotizaciones = CotizacionService.CotizacionDao.
               CargarCotizaciones(FrmModuloModulo.AlmacenSelec);

            bsCotizaciones.DataSource = cotizaciones;
            
        }


        private void CmdBuscarClick(object sender, EventArgs e)
        {
            Buscar();
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

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            var cotizaSelect = gvCotizacion.GetFocusedRow() as Cotizacion;
            CotizacionService.EliminaCotizacion(cotizaSelect);
            MessageBox.Show(@"Cotizacion seleccionada borrada", @"Adquisiciones", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            Buscar();

        }
    }
}