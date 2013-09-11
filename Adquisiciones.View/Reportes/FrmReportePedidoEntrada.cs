using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Data.Dao.ModPedido;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;

namespace Adquisiciones.View.Reportes
{
    public partial class FrmReportePedidoEntrada : XtraForm
    {

        private string reporte;
        private List<Pedido> pedidos;
        private Form parent;

        public FrmReportePedidoEntrada()
        {
            InitializeComponent();
        }

        public FrmReportePedidoEntrada(string reporte, List<Pedido> pedidos,Form parent): this()
        {
            this.reporte = reporte;
            this.pedidos = pedidos;
            this.parent = parent;
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var forma = new FrmModuloReportes();

            var entradaPedido = EntradaPedido.Ambos;

            if (rbPedidoSinEntrada.Checked)
                entradaPedido = EntradaPedido.SinEntrada;

            if (rbPedidoConEntrada.Checked)
                entradaPedido = EntradaPedido.ConEntrada;

            forma.MdiParent = parent;
            forma.Show();

            switch (reporte){
                case "reportePedidoEntradaCompleto":
                    forma.ReportePedidoEntradaCompleto(pedidos,entradaPedido);
                    break;

            }

            Cursor.Current = Cursors.Default;
            this.Close();
        }
    }
}
