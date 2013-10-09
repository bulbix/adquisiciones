using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business.ModCotizacion;
using Adquisiciones.Data.Entities;
using Adquisiciones.View.Modulos;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace Adquisiciones.View.Busquedas
{
    public partial class FrmBusquedaCotizacion : FrmBusqueda
    {
        #region Variables
        public ICotizacionService CotizacionService { get; set; }
        #endregion

        #region Constructores
        public FrmBusquedaCotizacion(FrmAdquisiciones padre)
        {
            InitializeComponent();

            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;

            base.TypeEntity = typeof(Cotizacion);
            base.NombreService = "cotizacionService";
            base.NombreReporte = "reporteCotizacion"; 
            base.TypeForma = typeof(FrmModuloCotizacion);
            base.GvGeneral = gvCotizacion;
            GetServicio();
            CotizacionService = base.Servicio as ICotizacionService;
            base.ObtenerPerfil();
        }
        #endregion

        #region Eventos
        private void TieneFalloClick(object sender, EventArgs e)
        {
            var cotizaSelect = gvCotizacion.GetFocusedRow() as Cotizacion;
            cotizaSelect.TieneFallo = CotizacionService.CotizacionDao.ExisteAnexoFallo(cotizaSelect.Anexo);
            gvCotizacion.RefreshData();
        }
        #endregion
    }
}