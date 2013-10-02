using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business.ModPedido;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;

namespace Adquisiciones.View.Busquedas
{
    public partial class FrmFiltroBusquedaPedido : XtraForm
    {
        private IPedidoService service;
        private BindingSource bsSource;
        private Almacen almacen;

        public FrmFiltroBusquedaPedido()
        {
            InitializeComponent();
        }

        public FrmFiltroBusquedaPedido(IPedidoService service,BindingSource bsSource,Almacen almacen): this()
        {
            this.service = service;
            this.bsSource = bsSource;
            this.almacen = almacen;

            Inicializar();
        }

        private void Inicializar()
        {
            var fechatemp = DateTime.Today;
            var fecha1 = new DateTime(fechatemp.Year, fechatemp.Month, 1);
            deInicial.DateTime = fecha1;
            deFinal.DateTime = DateTime.Now;

            bsProveedor.DataSource = service.PedidoDao.CargarCatalogo<Proveedor>("CveProveedor");
            
        }

        private void CmdBusquedaClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var tiposList = new List<int>();
            if(cbMayor.Checked)
                tiposList.Add(1);

            if(cbMenor.Checked)
                tiposList.Add(2);

            if(cbDonacion.Checked)
                tiposList.Add(3);

            if(cbExtramuro.Checked)
                tiposList.Add(4);

            if (cbAjuste.Checked)
                tiposList.Add(5);

            var tipos = tiposList.ToArray();

            Proveedor provSeleccionado = null;

            if (searchLookUpProveedor.EditValue != null)
                provSeleccionado = searchLookUpEditProveedor.GetFocusedRow() as Proveedor;

            var source = service.PedidoDao.CargarPedidos(almacen,
            deInicial.EditValue,deFinal.EditValue,(int)seInicial.Value,(int)seFinal.Value,tipos,
            provSeleccionado );

            foreach (Pedido pedido in source)
            {
                if (!pedido.EstadoPedido.Trim().Equals("C") && !pedido.EstadoPedido.Trim().Equals("P"))
                {
                    pedido.EstadoPedido = "A";
                }

                try
                {
                    var partidaAlmacen = service.PedidoDao.CargarPartidaAlmacen(pedido);
                    pedido.AlmacenDestino = partidaAlmacen[0];
                    pedido.PartidaString = partidaAlmacen[1];
                }
                catch (Exception ex)
                {
                }
            }
            
            
            bsSource.DataSource = source;

            Cursor.Current = Cursors.Default;

            XtraMessageBox.Show(@"Busqueda Finalizada, " + source.Count + " registros encontrados.",
                             @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmFiltroBusquedaPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            this.Hide();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            Inicializar();
            seInicial.Value = 0;
            seFinal.Value = 0;
            searchLookUpProveedor.EditValue = null;
            cbMayor.Checked = true;
            cbMenor.Checked = false;
            cbDonacion.Checked = false;
            cbAjuste.Checked = false;
        }

    }
}