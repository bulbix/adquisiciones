using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business.ModAnexo;
using Adquisiciones.Data.Entities;
using Adquisiciones.View.Modulos;
using DevExpress.XtraEditors;

namespace Adquisiciones.View.Busquedas
{
    public partial class FrmBusquedaAnexo : FrmBusqueda
    {
        #region Variables
        public IAnexoService AnexoService { get; set; }
        #endregion

        #region Constructores
        public FrmBusquedaAnexo(FrmAdquisiciones padre)
        {
            InitializeComponent();

            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;

            base.TypeEntity = typeof(Anexo);
            base.NombreService = "anexoService";
            base.NombreReporte = "reporteAnexo";
            base.TypeForma = typeof(FrmModuloAnexo);
            base.GvGeneral = gvAnexo;
            GetServicio();
            AnexoService = base.Servicio as IAnexoService;
            base.ObtenerPerfil();
        }
        #endregion

        #region Metodos
        private void TieneCotizacionClick(object sender, EventArgs e)
        {
            var anexoSelect = gvAnexo.GetFocusedRow() as Anexo;
            anexoSelect.TieneCotizacion = AnexoService.AnexoDao.ExisteAnexoCotizacion(anexoSelect);
            gvAnexo.RefreshData();

        }
        #endregion
    }
}