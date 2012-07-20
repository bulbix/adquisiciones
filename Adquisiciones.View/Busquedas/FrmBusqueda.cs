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

namespace Adquisiciones.View
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
            var source = Servicio.ConsultarEntityAll(FrmModuloModulo.AlmacenSelec, "");
            bsSource.DataSource = source;
        }

        private void CmdBuscarClick(object sender, EventArgs e)
        {
            Buscar();
        }

        private void CmdConsultarClick(object sender, EventArgs e)
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
                MessageBox.Show(@"No hay elemento seleccionado", @"Adquisiciones",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdEliminarClick(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(@"Esta seguro de eliminar el elemento seleccionado?", @"Adquisiciones",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    GetServicio();
                    Servicio.EliminarEntity(GvGeneral.GetFocusedRow(), TypeEntity.Name);
                    MessageBox.Show(@"Elemento seleccionado borrado", @"Adquisiciones",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Buscar();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Elemento seleccionado aosciado otro modulo", @"Adquisiciones",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmdReporteClick(object sender, EventArgs e)
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
                MessageBox.Show(@"No hay elemento seleccionado", @"Adquisiciones",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void GetServicio()
        {
            var ctx = ContextRegistry.GetContext();
            Servicio = ctx[NombreService] as IFormBusqueda;
        }

        private void FrmBusquedaGeneralLoad(object sender, EventArgs e)
        {
            
        }

        private void CmdImprimirClick(object sender, EventArgs e)
        {
            GvGeneral.ShowPrintPreview();
        }
    }
}