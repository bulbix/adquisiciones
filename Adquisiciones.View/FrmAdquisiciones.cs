using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.View.Busquedas;
using Adquisiciones.View.Catalogos;
using Adquisiciones.View.Modulos;
using DevExpress.XtraBars;

namespace Adquisiciones.View
{
    public partial class FrmAdquisiciones : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ///<summary>
        ///</summary>
        public FrmAdquisiciones()
        {
            InitializeComponent();
            ObtenerPerfil();
        }

        protected void ObtenerPerfil()
        {
            var modulosUsuario = FrmModuloAcceso.UsuarioLog.UsuarioModulo;
           
            foreach (var moduloUsuario in modulosUsuario)
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
            var forma = new FrmModuloAnexo();
            forma.MdiParent = this;
            forma.Show();

        }

        private void BarButtonCotizacionItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmModuloCotizacion();
            forma.MdiParent = this;
            forma.Show();
        }

        private void BarButtonFalloItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmModuloFallo();
            forma.MdiParent = this;
            forma.Show();
        }

        private void BarButtonItem1ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmCatalogoProveedor();
            forma.MdiParent = this;
            forma.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

            var forma = new FrmBusquedaAnexo();
            forma.MdiParent = this;
            forma.Show();
        }

        private void BarButtonItem3ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmBusquedaCotizacion();
            forma.MdiParent = this;
            forma.Show();

        }

        private void BarButtonItem4ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmBusquedaProveedor();
            forma.MdiParent = this;
            forma.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmBusquedaFallo();
            forma.MdiParent = this;
            forma.Show();

        }

        private void BarButtonPedidoItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmModuloLicitaPedido();
            forma.MdiParent = this;
            forma.Show();
        }

        private void BarButtonPedidoMayorItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmModuloPedido(1);
            forma.Text = @"Pedido Mayor";
            forma.MdiParent = this;
            forma.Show();
        }

        private void BarButtonPedidoMenorItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmModuloPedido(2);
            forma.Text = @"Pedido Menor";
            forma.MdiParent = this;
            forma.Show();

        }

        private void BarButtonPedidoDonacionItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmModuloPedido(3);
            forma.Text = @"Donaciones";
            forma.MdiParent = this;
            forma.Show();
        }

        private void BarButtonPedidoExtraItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmModuloPedido(4);
            forma.Text = @"Extramuros";
            forma.MdiParent = this;
            forma.Show();
        }
        private void FrmAdquisicionesLoad(object sender, EventArgs e)
        {
            txtFechaStatus.Caption = @"Fecha Acceso " + DateTime.Now;
            txtUsuarioStatus.Caption = @"Bienvenid@ " + FrmModuloAcceso.UsuarioLog;
            txtAlmacenStatus.Caption = @"Almacen Actual " + FrmModuloModulo.AlmacenSelec;
        }
        private void BtnCambiarAlmaItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmModuloModulo().ShowDialog();
            //this.Close();

        }

        private void BarButtonItem7ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmBusquedaPedido();
            forma.MdiParent = this;forma.Show();

        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmCatalogoPartida();
            forma.MdiParent = this;
            forma.Show();

        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmCatalogoFundamento();
            forma.MdiParent = this;
            forma.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmBusquedaFundamento();
            forma.MdiParent = this;
            forma.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            var forma = new FrmBusquedaPartida();
            forma.MdiParent = this;
            forma.Show();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Restart();}

        private void FrmAdquisiciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            Process.Start("mailto:lprado@inr.gob.mx");
        }
        

       
    }
}