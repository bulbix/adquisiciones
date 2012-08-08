using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Data.Entities;
using Adquisiciones.View.Catalogos;
using DevExpress.XtraEditors;

namespace Adquisiciones.View.Busquedas
{
    public partial class FrmBusquedaProveedor : FrmBusqueda
    {
        public FrmBusquedaProveedor()
        {
            InitializeComponent();
            base.TypeEntity = typeof(Proveedor);
            base.NombreService = "cotizacionService";
            base.NombreReporte = "";
            base.TypeForma = typeof(FrmCatalogoProveedor);
            base.GvGeneral = gvProveedor;
            base.ObtenerPerfil();
        }

        protected override void Buscar()
        {
            GetServicio();
            var source = Servicio.ConsultarEntityAll(FrmModuloModulo.AlmacenSelec);
            bsSource.DataSource = source;
        }
    }
}