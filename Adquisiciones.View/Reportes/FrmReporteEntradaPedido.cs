using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Data.Dao.ModPedido;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;

namespace Adquisiciones.View.Reportes
{
    public partial class FrmReporteEntradaPedido : DevExpress.XtraEditors.XtraForm
    {
        private string reporte;
        private Form parent;

        public FrmReporteEntradaPedido()
        {
            InitializeComponent();
        }

        public FrmReporteEntradaPedido(string reporte, Form parent):this()
        {
            this.reporte = reporte;
            this.parent = parent;
        }


        private void CmdReporteClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var forma = new FrmModuloReportes();

            var idTipoPedido = 1;

            if(rbMenor.Checked)
                idTipoPedido = 2;

            var tipoPedido = new CatTipopedido(idTipoPedido);

            var ordenado = Ordenado.Pedido;

            if (rbProveedor.Checked)
                ordenado = Ordenado.Proveedor;

            forma.MdiParent = parent;
            forma.Show();

            switch(reporte)
            {
                case "reporteEntradaPedido":
                    forma.ReporteEntradaPedido(deInicial.DateTime, deFinal.DateTime, tipoPedido,
                        ordenado);
                    break;
                case "reporteEntradaPedidoCompleto":
                    forma.ReporteEntradaPedidoCompleto(deInicial.DateTime, deFinal.DateTime, tipoPedido,
                        ordenado);
                    break;

            }

            Cursor.Current = Cursors.Default;
            this.Close();

            
        }
    }
}