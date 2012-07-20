﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business.ModPedido;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;

namespace Adquisiciones.View
{
    public partial class FrmBusquedaPedido : FrmBusqueda
    {
        public IPedidoService PedidoService { get; set; }

        public FrmBusquedaPedido()
        {
            InitializeComponent();
            base.TypeEntity = typeof(Pedido);
            base.NombreService = "pedidoService";
            base.NombreReporte = "reportePedido";
            base.TypeForma = typeof(FrmModuloPedido);
            base.GvGeneral = gvPedido;
            PedidoService = base.Servicio as IPedidoService;
        }

        protected override void Buscar()
        {
            base.Buscar();
            foreach (Pedido pedido in base.bsSource)
            {
                pedido.Automatico = pedido.Requisicion == null ? false : true;
            }
        }
    }
}