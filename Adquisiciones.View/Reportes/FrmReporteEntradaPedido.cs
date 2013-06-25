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
        public FrmReporteEntradaPedido()
        {
            InitializeComponent();
        }


        private void CmdReporteClick(object sender, EventArgs e)
        {
            var forma = new FrmModuloReportes();

            var idTipoPedido = 1;

            if(rbMenor.Checked)
                idTipoPedido = 2;

            var tipoPedido = new CatTipopedido(idTipoPedido);

            var ordenado = Ordenado.Pedido;

            if (rbProveedor.Checked)
                ordenado = Ordenado.Proveedor;
            
            forma.MdiParent = this.MdiParent;
            forma.Show();
            forma.ReporteEntradaPedido(deInicial.DateTime, deFinal.DateTime, tipoPedido, ordenado);
        }
    }
}