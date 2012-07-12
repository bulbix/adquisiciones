using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business.ModAnexo;
using Adquisiciones.Business.ModCotizacion;
using Adquisiciones.Business.ModPedido;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using Spring.Context.Support;
using Form = Spring.Windows.Forms.Form;


namespace Adquisiciones.View
{
    
    ///<summary>
    ///</summary>
    public partial class FrmBusquedaPedido : Form
    {
        ///<summary>
        ///</summary>
        public IPedidoService PedidoService { get; set; }


        ///<summary>
        ///</summary>
        public FrmBusquedaPedido()
        {
            InitializeComponent();
            
        }

        private void Buscar()
        {
            var pedidos = PedidoService.PedidoDao.
               CargarPedidos(FrmModuloModulo.AlmacenSelec);
            foreach (var pedido in pedidos)
            {
                pedido.Automatico = pedido.Requisicion == null ? false : true;
            }

            bsPedidos.DataSource = pedidos;
            
        }

        private void CmdBuscarClick(object sender, EventArgs e)
        {
            Buscar();
        }


        private void CmdImprimirClick(object sender, EventArgs e)
        {
            gvPedido.ShowPrintPreview();
        }

        private void CmdConsultarClick(object sender, EventArgs e)
        {
            try
            {
                var pedidoSelect = gvPedido.GetFocusedRow() as Pedido;
                var forma = new FrmModuloPedido(pedidoSelect);
                forma.MdiParent = this.MdiParent;
                forma.Show();
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"No hay pedido seleccionado", @"Adquisiciones",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void SimpleButton1Click(object sender, EventArgs e)
        {
            try
            {
                var pedidoSelect = gvPedido.GetFocusedRow() as Pedido;
                var forma = new FrmModuloReportes("reportePedido", pedidoSelect);
                forma.MdiParent = this.MdiParent;
                forma.Show();
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"No hay pedido seleccionado", @"Adquisiciones", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            var pedidoSelect = gvPedido.GetFocusedRow() as Pedido;
            PedidoService.PedidoDao.Delete(pedidoSelect);
            MessageBox.Show(@"Pedido seleccionado borrado", @"Adquisiciones", MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            Buscar();
        }
    }
}