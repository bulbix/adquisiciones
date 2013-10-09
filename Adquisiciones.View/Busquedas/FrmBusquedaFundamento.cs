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
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace Adquisiciones.View.Busquedas
{
    public partial class FrmBusquedaFundamento : FrmBusqueda
    {
        public FrmBusquedaFundamento(FrmAdquisiciones padre)
        {
            InitializeComponent();


            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;

            InitializeComponent(); base.TypeEntity = typeof(Fundamento);
            base.NombreService = "fundamentoDao";
            base.NombreReporte = "";
            base.TypeForma = typeof(FrmCatalogoFundamento);
            base.GvGeneral = gvFundamento;
            base.ObtenerPerfil();
        }

        protected override void Reporte()
        {
            var listado = GetFiltrado();
            var forma = new FrmModuloReportes("reporteFundamento", listado);
            forma.MdiParent = this.MdiParent;
            forma.Show();
        }


        public List<Fundamento> GetFiltrado()
        {
            var listado = new List<Fundamento>();
            for (int i = 0; i < gvFundamento.DataRowCount; i++)
                listado.Add(gvFundamento.GetRow(i) as Fundamento);

            return listado;
        }

    }
}