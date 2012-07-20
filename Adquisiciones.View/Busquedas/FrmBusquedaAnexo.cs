﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using Adquisiciones.Business.ModAnexo;

namespace Adquisiciones.View
{
    public partial class FrmBusquedaAnexo : FrmBusqueda
    {
        public IAnexoService AnexoService { get; set; }

        public FrmBusquedaAnexo()
        {
            InitializeComponent();
            base.TypeEntity = typeof (Anexo);
            base.NombreService = "anexoService";
            base.NombreReporte = "reporteAnexo";
            base.TypeForma = typeof (FrmModuloAnexo);
            base.GvGeneral = gvAnexo;
            GetServicio();
            AnexoService = base.Servicio as IAnexoService;

        }

        private void TieneCotizacionClick(object sender, EventArgs e)
        {
            var anexoSelect = gvAnexo.GetFocusedRow() as Anexo;
            anexoSelect.TieneCotizacion = AnexoService.AnexoDao.ExisteAnexoCotizacion(anexoSelect);
            gvAnexo.RefreshData();

        }

    }
}