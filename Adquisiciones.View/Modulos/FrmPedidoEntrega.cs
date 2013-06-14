using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using System.Linq;

namespace Adquisiciones.View
{
    public partial class FrmPedidoEntrega : XtraForm
    {
        #region Variables
        private PedidoDetalle _pedidoDetalle;
        private bool correcto = true;
        
        #endregion

        #region Constructores
        public FrmPedidoEntrega(PedidoDetalle pedidoDetalle)
        {
            InitializeComponent();

            if (pedidoDetalle != null)
            {
                this._pedidoDetalle = pedidoDetalle;
                bsPedidoEntrega.DataSource = pedidoDetalle.PedidoEntrega;
                lblCantidad.Text = @"La cantidad total:" + pedidoDetalle.Cantidad;
            }
        }
        #endregion

        #region Eventos
        private void CmdCancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void CmdAceptarClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GcPedidoEntregaKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                gvPedidoEntrega.DeleteRow(gvPedidoEntrega.FocusedRowHandle);
            }
        }

        private bool validarPedidoEntrega(PedidoEntrega pedidoEntrega)
        {
          
            if (pedidoEntrega.FechaInicial == null || pedidoEntrega.FechaFinal == null)
            {
                XtraMessageBox.Show(@"Fecha inicial y fecha final requeridos",
                                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var fechaInicial = pedidoEntrega.FechaInicial.Value;
            var fechaFinal = pedidoEntrega.FechaFinal.Value;

            if (fechaInicial.CompareTo(fechaFinal) > 0)
            {
                XtraMessageBox.Show(@"Fecha inicial debe ser menor o igual fecha final",
                                @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            decimal? suma = _pedidoDetalle.PedidoEntrega.Sum(entrega => entrega.Cantidad);

            suma += pedidoEntrega.Cantidad;
                
            if (suma > _pedidoDetalle.Cantidad )
            {
                XtraMessageBox.Show(@"La suma de los renglones debe coincidir con " + _pedidoDetalle.Cantidad,
                              @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        
        private void SpinEdit1KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {
                var pedidoEntrega = new PedidoEntrega();
                pedidoEntrega.FechaInicial = deFechaInicial.DateTime;
                pedidoEntrega.FechaFinal = deFechaFinal.DateTime;
                pedidoEntrega.Cantidad = seCantidad.Value;


                if (validarPedidoEntrega(pedidoEntrega))
                {
                    (bsPedidoEntrega.DataSource as List<PedidoEntrega>).Add(pedidoEntrega);
                    gvPedidoEntrega.RefreshData();
                }
            }

        }
        #endregion
    }
}