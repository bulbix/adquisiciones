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
        public FrmBusquedaProveedor(FrmAdquisiciones padre)
        {
            InitializeComponent();

            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;

            base.TypeEntity = typeof(Proveedor);
            base.NombreService = "proveedorDao";
            base.NombreReporte = "";
            base.TypeForma = typeof(FrmCatalogoProveedor);
            base.GvGeneral = gvProveedor;
            base.ObtenerPerfil();
        }

        protected override void CmdReporteItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("No hay reporte asociado");
        }
       
    }
}