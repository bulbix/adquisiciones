using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Spring.Context.Support;

namespace Adquisiciones.View.Busquedas
{
    public partial class FrmBusqueda : DevExpress.XtraEditors.XtraForm
    {

        protected Type TypeEntity { get; set; }

        protected string NombreService { get; set; }

        protected string NombreReporte { get; set; }

        protected Type TypeForma { get; set; }

        protected IFormBusqueda Servicio { get; set; }

        protected GridView GvGeneral { get; set; }

        public FrmBusqueda()
        {
            InitializeComponent();
        }


        protected virtual void Buscar()
        {
            GetServicio();
            var source = Servicio.ConsultarEntityAll(FrmModuloModulo.AlmacenSelec);
            bsSource.DataSource = source;
        }
        protected void GetServicio()
        {
            var ctx = ContextRegistry.GetContext();
            Servicio = ctx[NombreService] as IFormBusqueda;
        }
      
      
        private void CmdBuscarItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Buscar();

        }

        private void CmdConsultarItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var select = Convert.
                    ChangeType(GvGeneral.GetFocusedRow(), TypeEntity);
                var forma = (Form)TypeForma.GetConstructor(new[] { TypeEntity }).Invoke(new[] { select });

                forma.MdiParent = this.MdiParent;
                forma.Show();
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"No hay elemento seleccionado", @"Adquisiciones",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CmdImprimirItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GvGeneral.ShowPrintPreview();
        }

        private void CmdReporteItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                var select = Convert.
                    ChangeType(GvGeneral.GetFocusedRow(), TypeEntity);

                var forma = new FrmModuloReportes(NombreReporte, select);
                forma.MdiParent = this.MdiParent;
                forma.Show();
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"No hay elemento seleccionado", @"Adquisiciones",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CmdEliminarItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show(@"Esta seguro de eliminar el elemento seleccionado?", @"Adquisiciones",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    GetServicio();
                    Servicio.EliminarEntity(GvGeneral.GetFocusedRow(), TypeEntity.Name);
                    XtraMessageBox.Show(@"Elemento seleccionado borrado", @"Adquisiciones",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Buscar();
                }
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Elemento seleccionado aosciado otro modulo", @"Adquisiciones",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}