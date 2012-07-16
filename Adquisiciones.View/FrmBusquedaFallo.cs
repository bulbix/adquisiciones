using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business.ModAnexo;
using Adquisiciones.Business.ModCotizacion;
using Adquisiciones.Business.ModFallo;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using Spring.Context.Support;
using Form = Spring.Windows.Forms.Form;


namespace Adquisiciones.View
{
    
    ///<summary>
    ///</summary>
    public partial class FrmBusquedaFallo :XtraForm
    {
        ///<summary>
        ///</summary>
        public IFalloService FalloService { get; set; }


        ///<summary>
        ///</summary>
        public FrmBusquedaFallo()
        {
            InitializeComponent();
            var ctx = ContextRegistry.GetContext();
            FalloService = ctx["falloService"] as IFalloService;
        }

        private void Buscar()
        {
            var fallos = FalloService.FalloDao.CargarFallos(FrmModuloModulo.AlmacenSelec);
            bsFallos.DataSource = fallos;
            
        }

        private void CmdBuscarClick(object sender, EventArgs e)
        {
           Buscar();
        }

        private void CmdImprimirClick(object sender, EventArgs e)
        {
            gvAnexo.ShowPrintPreview();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var anexoSelect = (gvAnexo.GetFocusedRow() as Fallo).Anexo;
                var forma = new FrmModuloReportes("reporteTabla", anexoSelect);
                forma.MdiParent = this.MdiParent;
                forma.Show();}
            catch (Exception ee)
            {
                MessageBox.Show(@"No hay anexo seleccionado", @"Adquisiciones", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void bsAnexos_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            var falloSelect = gvAnexo.GetFocusedRow() as Fallo;
            FalloService.FalloDao.Delete(falloSelect);
            MessageBox.Show(@"Fallo seleccionado borrado", @"Adquisiciones", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            Buscar();

        }


    }
}