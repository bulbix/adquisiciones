using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business.ModAnexo;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using Spring.Context.Support;

namespace Adquisiciones.View
{
    public partial class FrmBusquedaAnexo : DevExpress.XtraEditors.XtraForm
    {
        ///<summary>
        ///</summary>
        public IAnexoService AnexoService;

        ///<summary>
        ///</summary>
        public FrmBusquedaAnexo()
        {
            InitializeComponent();

            var ctx = ContextRegistry.GetContext();
            AnexoService = ctx["anexoService"] as IAnexoService;
        }

        private void CmdBuscarClick(object sender, EventArgs e)
        {
            var anexos = AnexoService.AnexoDao.CargarAnexos(FrmModuloModulo.AlmacenSelec);
           


            bsAnexos.DataSource = anexos;
        }

        private void CmdImprimirClick(object sender, EventArgs e)
        {
            gvAnexo.ShowPrintPreview();
        }

        private void CmdConsultarClick(object sender, EventArgs e)
        {
            try
            {
                var anexoSelect = gvAnexo.GetFocusedRow() as Anexo;
                var forma = new FrmModuloAnexo(anexoSelect);
                forma.MdiParent = this.MdiParent;
                forma.Show();
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"No hay anexo seleccionado", @"Adquisiciones", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                var anexoSelect = gvAnexo.GetFocusedRow() as Anexo;
                var forma = new FrmModuloReportes("reporteAnexo",anexoSelect);
                forma.MdiParent = this.MdiParent;
                forma.Show();
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"No hay anexo seleccionado", @"Adquisiciones", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            var anexoSelect = gvAnexo.GetFocusedRow() as Anexo;
            anexoSelect.TieneCotizacion = AnexoService.
                AnexoDao.ExisteAnexoCotizacion(anexoSelect);
           gvAnexo.RefreshData();

        }

       
    }
}