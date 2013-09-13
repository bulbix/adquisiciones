using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Data.Entities;
using Adquisiciones.View.Catalogos;
using Adquisiciones.View.Reportes;
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



        protected override void Reporte()
        {
            var provs = GetFiltrado();
            var forma = new FrmModuloReportes("reporteProveedor", provs);
            forma.MdiParent = this.MdiParent;
            forma.Show();
        }

        public List<Proveedor> GetFiltrado()
        {
            var provs = new List<Proveedor>();
            for (int i = 0; i < gvProveedor.DataRowCount; i++)
                provs.Add(gvProveedor.GetRow(i) as Proveedor);

            return provs;
        }
       
    }
}