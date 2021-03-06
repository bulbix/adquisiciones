﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business.ModAnexo;
using Adquisiciones.Business.ModPedido;
using Adquisiciones.Data.Entities;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace Adquisiciones.View.Modulos
{
    public partial class FrmModuloPrecio : FrmModulo
    {

        public IPedidoService PedidoService { get; set; }

        public FrmModuloPrecio(FrmAdquisiciones padre)
        {
            InitializeComponent();

            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;
            AlmacenesCombo(cbxAlmacen, AlmacenActual);

            //base.TypeEntity = typeof(Cotizacion);
            //base.NombreReporte = "reporteCotizacion";
            base.NombreModulo = "Precio";
            base.NombreService = "pedidoService";
            base.GetServicio();
            PedidoService = base.Servicio as IPedidoService;
            base.ObtenerPerfil();

            cmdGuardar.Visibility = BarItemVisibility.Never;
            listaError.Visibility = BarItemVisibility.Never;
            lblNumErrors.Visibility = BarItemVisibility.Never;

           
        }

        private void SetDatosArticulo(Articulo articulo)
        {
            txtPartida.Text = PedidoService.AnexoService.ArticuloDao.GetPartida(articulo).ToString();
            txtDescripcion.Text = articulo.DesArticulo;
            txtPrese.Text = articulo.Presentacion;
            txtPreseCant.Text = articulo.PresentacionCant.ToString();
            txtPreseUnid.Text = articulo.PresentacionUnid;
            txtClave.Enabled = false;
            cbxAlmacen.Enabled = false;
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
             {
                 var detalle = PedidoService.PedidoDao.
                     CargarPrecios((int)txtClave.Value, AlmacenActual);
                 bsPrecioDetalle.DataSource = detalle;

                 if (detalle.Count > 0)
                 {
                     var articulo = detalle[0].Articulo;
                     SetDatosArticulo(articulo);
                 }
                 else
                 {
                     var almacen = cbxAlmacen.SelectedValue as Almacen;
                     var articuloId = new ArticuloId((int) txtClave.Value, almacen);
                     var articulo = PedidoService.AnexoService.
                         ArticuloDao.Get(articuloId);

                     if (articulo != null){
                         SetDatosArticulo(articulo);
                     }
                     else
                     {
                         XtraMessageBox.Show(@"No existe la clave",
                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Nuevo();
                     }
                 }
             }
        }

        public override void Nuevo()
        {
            txtClave.Value = 0;
            txtPartida.Text = "";
            txtDescripcion.Text = "";
            txtPrese.Text = "";
            txtPreseCant.Text = "";
            txtPreseUnid.Text = ""; 
            bsPrecioDetalle.DataSource = null;
            txtClave.Enabled = true;
            cbxAlmacen.Enabled = true;
            txtClave.Focus();
        }
    }
}
