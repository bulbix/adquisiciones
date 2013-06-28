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
    public partial class FrmFiltroBusquedaPedido : DevExpress.XtraEditors.XtraForm
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
        }

        private void CmdBusquedaClick(object sender, EventArgs e)
        {
            var tiposList = new List<int>();
            if(cbMayor.Checked)
                tiposList.Add(1);

            if(cbMenor.Checked)
                tiposList.Add(2);

            if(cbDonacion.Checked)
                tiposList.Add(3);

            if(cbExtramuro.Checked)
                tiposList.Add(4);

            var tipos = tiposList.ToArray();

            var source = service.PedidoDao.CargarPedidos(almacen,
            deInicial.EditValue,deFinal.EditValue,(int)seInicial.Value,(int)seFinal.Value,tipos );

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
        }

        private void FrmFiltroBusquedaPedido_Load(object sender, EventArgs e)
        {
            var fechatemp = DateTime.Today;
            var fecha1 = new DateTime(fechatemp.Year, fechatemp.Month, 1);
            deInicial.DateTime = fecha1;
            deFinal.DateTime = DateTime.Now;
        }
    }
}