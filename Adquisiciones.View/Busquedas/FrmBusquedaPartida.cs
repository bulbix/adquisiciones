using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Data.Entities;
using Adquisiciones.View.Catalogos;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace Adquisiciones.View.Busquedas
{
    public partial class FrmBusquedaPartida : FrmBusqueda {

        public FrmBusquedaPartida(FrmAdquisiciones padre)
        {
            InitializeComponent();

            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;

            InitializeComponent(); base.TypeEntity = typeof(CatPartida);
            base.NombreService = "partidaDao";
            base.NombreReporte = "";
            base.TypeForma = typeof(FrmCatalogoPartida);
            base.GvGeneral = gvPartida;
            base.ObtenerPerfil();
        }
        
    }
}