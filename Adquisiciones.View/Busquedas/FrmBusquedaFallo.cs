using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business.ModFallo;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;

namespace Adquisiciones.View
{
    public partial class FrmBusquedaFallo : FrmBusqueda
    {
        public IFalloService FalloService { get; set; }

        public FrmBusquedaFallo(){
            InitializeComponent();

            base.TypeEntity = typeof(Fallo);
            base.NombreService = "falloService";
            base.NombreReporte = "reporteTabla";
            base.GvGeneral = gvAnexo;
            FalloService = base.Servicio as IFalloService;
        }
    }
}