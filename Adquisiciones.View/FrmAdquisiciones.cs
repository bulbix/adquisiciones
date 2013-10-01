using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business.Seguridad;
using Adquisiciones.Data.Entities;
using Adquisiciones.View.Busquedas;
using Adquisiciones.View.Catalogos;
using Adquisiciones.View.Modulos;
using DevExpress.XtraBars;
using Spring.Context.Support;

namespace Adquisiciones.View
{
    public partial class FrmAdquisiciones : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        /// <summary>
        /// Cada uno con su copia de perfiles y almacen
        /// </summary>
        public IList<UsuarioModulo> ModulosUsuario { get; set; }
        public Almacen AlmacenSelect { get; set; }
        private static int NumInstancias;


        public FrmAdquisiciones(IList<UsuarioModulo> modulosUsuario, Almacen almacen)
        {
            InitializeComponent();

            ++NumInstancias;

            this.ModulosUsuario = modulosUsuario;
            this.AlmacenSelect = almacen;
            ObtenerPerfil();
        }
       
        protected void ObtenerPerfil()
        {
            foreach (var moduloUsuario in ModulosUsuario)
            {
                if (moduloUsuario.Estatus != "A")
                    continue; 
                
                var desModulo = moduloUsuario.Id.Modulo.DesModulo.ToLower().Trim();
               
                if (desModulo.Contains("anexo trabajar"))
                {
                    barButtonAnexo.Visibility = BarItemVisibility.Always;
                }

                if (desModulo.Contains("cotizacion trabajar"))
                {
                    barButtonCotizacion.Visibility = BarItemVisibility.Always;
                }

                if (desModulo.Contains("fallo trabajar"))
                {
                    barButtonFallo.Visibility = BarItemVisibility.Always;
                }

                if (desModulo.Contains("pedido trabajar"))
                {

                    ribbonPagePedido.Visible = true;
                }

                if (desModulo.Contains("catalogo trabajar"))
                {

                    ribbonPageCatalogo.Visible = true;
                }
            }
        }

        private void BarButtonAnexoItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmModuloAnexo(this);
            forma.MdiParent = this;
            forma.Show();

        }

        private void BarButtonCotizacionItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmModuloCotizacion(this);
            forma.MdiParent = this;
            forma.Show();
        }

        private void BarButtonFalloItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmModuloFallo(this);
            forma.MdiParent = this;
            forma.Show();
        }

        private void BarButtonItem1ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmCatalogoProveedor(this);
            forma.MdiParent = this;
            forma.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

            var forma = new FrmBusquedaAnexo(this) { MdiParent = this };
            forma.Show();}

        private void BarButtonItem3ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmBusquedaCotizacion(this);
            forma.MdiParent = this;
            forma.Show();

        }

        private void BarButtonItem4ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmBusquedaProveedor(this);
            forma.MdiParent = this;
            forma.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmBusquedaFallo(this);
            forma.MdiParent = this;
            forma.Show();

        }

        private void BarButtonPedidoItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmModuloLicitaPedido(this);
            forma.MdiParent = this;
            forma.Show();
        }

        private void BarButtonPedidoMayorItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmModuloPedido(1,this);
            forma.Text = @"Pedido Mayor";
            forma.MdiParent = this;
            forma.Show();
        }

        private void BarButtonPedidoMenorItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmModuloPedido(2,this);
            forma.Text = @"Pedido Menor";
            forma.MdiParent = this;
            forma.Show();

        }

        private void BarButtonPedidoDonacionItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmModuloPedido(3,this);
            forma.Text = @"Donaciones";
            forma.MdiParent = this;
            forma.Show();
        }

        private void BarButtonPedidoExtraItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmModuloPedido(4,this);
            forma.Text = @"Extramuros";
            forma.MdiParent = this;
            forma.Show();
        }

        private void FrmAdquisicionesLoad(object sender, EventArgs e)
        {
            txtFechaStatus.Caption = @"Fecha Acceso " + DateTime.Now;
            txtUsuarioStatus.Caption = @"Bienvenid@ " + FrmModuloAcceso.UsuarioLog;
            Text += "@ " + AlmacenSelect;
        }

        private void BtnNewAlmacenItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmModuloModulo(true).ShowDialog();
        }

        private void BarButtonItem7ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmBusquedaPedido(this);
            forma.MdiParent = this;forma.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmCatalogoPartida(this);
            forma.MdiParent = this;
            forma.Show();

        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmCatalogoFundamento(this);
            forma.MdiParent = this;
            forma.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmBusquedaFundamento(this);
            forma.MdiParent = this;
            forma.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmBusquedaPartida(this);
            forma.MdiParent = this;
            forma.Show();
        }

       
        private void FrmAdquisiciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            --NumInstancias;

            if(NumInstancias ==  0)
                Application.Exit();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("mailto:lprado@inr.gob.mx");
        }
       
        private void barButtonItem13_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            //var forma = new FrmAyuda();
            //forma.MdiParent = this;
            //forma.Show();

        }

        private void barButtonPedidoAjuste_ItemClick(object sender, ItemClickEventArgs e)
        {

            var forma = new FrmModuloPedido(5, this);
            forma.Text = @"Ajuste";
            forma.MdiParent = this;
            forma.Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmBusquedaArticulo(this);
            forma.MdiParent = this;
            forma.Show();

        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmModuloPrecio(this);
            forma.MdiParent = this;
            forma.Show();

        }
        

       
    }
}