using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Data.Dao.Catalogos;
using Adquisiciones.Data.Entities;
using DevExpress.XtraBars;

namespace Adquisiciones.View.Busquedas
{
    public partial class FrmBusquedaArticulo : FrmBusqueda
    {

        public IArticuloDao ArticuloDao { get; set; }

        public FrmBusquedaArticulo(FrmAdquisiciones padre)
        {
            InitializeComponent();

            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;

            InitializeComponent();
            base.TypeEntity = typeof(Articulo);
            base.NombreService = "articuloDao";
            base.NombreReporte = "";
            //base.TypeForma = typeof(FrmCatalogoPartida);
            base.GvGeneral = gvArticulo;
            GetServicio();
            ArticuloDao = base.Servicio as IArticuloDao;

            base.ObtenerPerfil();
            
            cmdConsultar.Visibility = BarItemVisibility.Never;
            cmdReporte.Visibility = BarItemVisibility.Never;
            cmdEliminar.Visibility = BarItemVisibility.Never;
        }


        protected override void Buscar()
        {
            var forma = new FrmFiltroBusquedaArticulo(ArticuloDao, bsSource, AlmacenActual);
            forma.ShowDialog();
        }
    }
}
