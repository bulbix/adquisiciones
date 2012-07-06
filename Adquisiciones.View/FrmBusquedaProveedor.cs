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
    public partial class FrmBusquedaProveedor : DevExpress.XtraEditors.XtraForm
    {
        public ICotizacionService CotizacionService;

        public FrmBusquedaProveedor()
        {
            InitializeComponent();
            var ctx = ContextRegistry.GetContext();
            CotizacionService = ctx["cotizacionService"] as ICotizacionService;
        }

        private void CmdBuscarClick(object sender, EventArgs e)
        {
            var proveedores = CotizacionService.ProveedorDao.FindAll();
            bsProveedores.DataSource = proveedores;
        }

        private void CmdImprimirClick(object sender, EventArgs e)
        {
            gvProveedor.ShowPrintPreview();

        }

        private void CmdConsultarClick(object sender, EventArgs e)
        {
            try
            {
                var provSelect = gvProveedor.GetFocusedRow() as Proveedor;
                var forma = new FrmCatalogoProveedor(provSelect);
                forma.MdiParent = this.MdiParent;
                forma.Show();
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"No hay proveedor seleccionado", @"Adquisiciones", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
    }
}