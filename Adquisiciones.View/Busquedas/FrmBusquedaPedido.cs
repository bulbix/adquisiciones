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
using DevExpress.XtraEditors;

namespace Adquisiciones.View.Busquedas
{
    public partial class FrmBusquedaPedido : FrmBusqueda
    {
        #region Variables
        public IPedidoService PedidoService { get; set; }
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
        }
        #endregion

        #region Metodos
        protected override void Buscar()
        {
            base.Buscar();
            foreach (Pedido pedido in base.bsSource)
            {
                if (!pedido.EstadoPedido.Trim().Equals("C") && !pedido.EstadoPedido.Trim().Equals("P"))
                {
                    pedido.EstadoPedido = "A";

                }

                pedido.ImporteTotal = pedido.ImporteTotal - pedido.ImporteDescuento;
                decimal cantidadIva = pedido.ImporteTotal.Value * pedido.Iva.Id.Porcentaje / 100;
                pedido.ImporteTotal += cantidadIva; 
                
                pedido.Automatico = pedido.Requisicion == null ? false : true;
            }
        }

        protected override void Eliminar()
        {
            var pedido = GvGeneral.GetFocusedRow() as Pedido;

            if (pedido.Requisicion!=null)
            {
                PedidoService.RequisicionDao.ActualizarEstatusRequisicion(pedido.Requisicion,"A");
            }

            base.Eliminar();
        }
        #endregion
    }
}