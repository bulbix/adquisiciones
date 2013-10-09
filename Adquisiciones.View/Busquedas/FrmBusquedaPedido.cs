using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business.ModPedido;
using Adquisiciones.Data.Entities;
using Adquisiciones.View.Modulos;
using Adquisiciones.View.Reportes;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;

namespace Adquisiciones.View.Busquedas
{
    public partial class FrmBusquedaPedido : FrmBusqueda
    {
        #region Variables
        public IPedidoService PedidoService { get; set; }
        private FrmFiltroBusquedaPedido filtroBusquedaPedido;
        
        #endregion

        #region Constructores
        public FrmBusquedaPedido(FrmAdquisiciones padre)
        {
            InitializeComponent();

            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;

            base.TypeEntity = typeof(Pedido);
            base.NombreService = "pedidoService";
            base.NombreReporte = "reportePedido";
            base.TypeForma = typeof(FrmModuloPedido);
            base.GvGeneral = gvPedido;
            GetServicio();
            PedidoService = base.Servicio as IPedidoService;
            base.ObtenerPerfil();
            cmdCancelar.Visibility = BarItemVisibility.Always;
        }
        #endregion

        #region Metodos
        protected override void Buscar()
        {
            if(filtroBusquedaPedido == null)
                filtroBusquedaPedido = new FrmFiltroBusquedaPedido(PedidoService, bsSource, AlmacenActual);

            filtroBusquedaPedido.ShowDialog();
        }

        protected override void Eliminar()
        {
            var pedido = GvGeneral.GetFocusedRow() as Pedido;

            if (pedido != null && pedido.EstadoPedido != "C")
            {
                XtraMessageBox.Show(@"Debe cancelar primero el pedido", @"Adquisiciones",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (pedido.Requisicion!=null)
            {
                PedidoService.RequisicionDao.ActualizarEstatusRequisicion(pedido.Requisicion,"A");
            }

            base.Eliminar();
        }
        #endregion

        private void concentradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pedidos = GetPedidosFiltrado();
            var forma = new FrmModuloReportes("reportePedidoConcentrado", pedidos);
            forma.MdiParent = this.MdiParent;
            forma.Show();

        }

        private void detalladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pedidos = GetPedidosFiltrado();
            var forma = new FrmModuloReportes("reportePedidoDetallado", pedidos);
            forma.MdiParent = this.MdiParent;
            forma.Show();

        }

        private void pedidoVsEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pedidos = GetPedidosFiltrado();
            var forma = new FrmModuloReportes("reportePedidoEntrada", pedidos);
            forma.MdiParent = this.MdiParent;
            forma.Show();
        }

        public List<Pedido> GetPedidosFiltrado()
        {
            var pedidos = new List<Pedido>();
            for (int i = 0; i < gvPedido.DataRowCount; i++)
                pedidos.Add(gvPedido.GetRow(i) as Pedido);

            return pedidos;
        }

        private void entradaVsPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new FrmReporteEntradaPedido("reporteEntradaPedido",this.MdiParent);
            forma.ShowDialog();
        }

        private void pedidoVsEntradaCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pedidos = GetPedidosFiltrado();
            var forma = new FrmReportePedidoEntrada("reportePedidoEntradaCompleto",pedidos,this.MdiParent);
            forma.ShowDialog();
        }

        private void entradaVsPedidoCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new FrmReporteEntradaPedido("reporteEntradaPedidoCompleto",this.MdiParent);
            forma.ShowDialog();

        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pedidos = GetPedidosFiltrado();
            var forma = new FrmModuloReportes("reporteListaPedido", pedidos);
            forma.MdiParent = this.MdiParent;
            forma.Show();
        }

        private void saldoPendienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pedidos = GetPedidosFiltrado();
            var forma = new FrmModuloReportes("reportePedidoSaldo", pedidos);
            forma.MdiParent = this.MdiParent;
            forma.Show();

        }

       
    }
}