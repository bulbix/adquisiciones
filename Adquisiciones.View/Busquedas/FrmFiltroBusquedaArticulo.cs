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
using DevExpress.XtraEditors;

namespace Adquisiciones.View.Busquedas
{
    public partial class FrmFiltroBusquedaArticulo : XtraForm
    {

        private IArticuloDao service;
        private BindingSource bsSource;
        private Almacen almacen;

        public FrmFiltroBusquedaArticulo()
        {
            InitializeComponent();
        }


        public FrmFiltroBusquedaArticulo(IArticuloDao service, 
            BindingSource bsSource, Almacen almacen): this() {
            this.service = service;
            this.bsSource = bsSource;
            this.almacen = almacen;

            bsPartida.DataSource = service.CargarCatalogo<CatPartida>("Partida");
        }

        private void cmdBusqueda_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            var aprox = txtAprox.Text.Length == 0 ? null : txtAprox.Text.ToUpper();
            var partidaSelect = searchLookUpEditPartida.GetFocusedRow() as CatPartida;

            var source = service.ArticulosByPartidaDescripcion(partidaSelect,aprox);

            bsSource.DataSource = source;

            Cursor.Current = Cursors.Default;

            XtraMessageBox.Show(@"Busqueda Finalizada, " + source.Count + " registros encontrados.",
            @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }
    }
}
