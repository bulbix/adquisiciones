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
using Form = Spring.Windows.Forms.Form;

namespace Adquisiciones.View
{
    public partial class FrmBusquedaAnexo : Form
    {
        ///<summary>
        ///</summary>
        public IAnexoService AnexoService { get; set; }

        ///<summary>
        ///</summary>
        public FrmBusquedaAnexo()
        {
            InitializeComponent();
        }

        private void Buscar()
        {
            var anexos = AnexoService.AnexoDao.CargarAnexos(FrmModuloModulo.AlmacenSelec);
            bsAnexos.DataSource = anexos;
            
        }

        private void CmdBuscarClick(object sender, EventArgs e)
        {
           Buscar();
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

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            var anexoSelect = gvAnexo.GetFocusedRow() as Anexo;
            AnexoService.AnexoDao.Delete(anexoSelect);
            MessageBox.Show(@"Anexo seleccionado borrado", @"Adquisiciones", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            Buscar();

        }

       
    }
}