﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;

namespace Adquisiciones.View
{
    public partial class FrmPedidoEntrega : DevExpress.XtraEditors.XtraForm
    {
        private PedidoDetalle _pedidoDetalle;


        ///<summary>
        ///</summary>
        ///<param name="pedidoDetalle"></param>
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

        private void CmdCancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdAceptarClick(object sender, EventArgs e)
        {
            var cantidad = _pedidoDetalle.Cantidad;
            decimal? suma = 0;

            foreach (var pedidoEntrega in _pedidoDetalle.PedidoEntrega)
            {
                if (pedidoEntrega.FechaInicial == null || pedidoEntrega.FechaFinal == null)
                {
                    XtraMessageBox.Show(@"Fecha inicial y fecha final requeridos",
                                       @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var fechaInicial = pedidoEntrega.FechaInicial.Value;
                var fechaFinal = pedidoEntrega.FechaFinal.Value;

                if (fechaInicial.CompareTo(fechaFinal) > 0)
                {
                    XtraMessageBox.Show(@"Fecha inicial debe ser mayor fecha final",
                                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                suma += pedidoEntrega.Cantidad;}

            if (cantidad != suma)
            {
                XtraMessageBox.Show(@"La suma de los renglones debe coincidir con " + cantidad,
                                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                this.Close();
        }

        private void GcPedidoEntregaKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                gvPedidoEntrega.DeleteRow(gvPedidoEntrega.FocusedRowHandle);
            }

        }
    }
}