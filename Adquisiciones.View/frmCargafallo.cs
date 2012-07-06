using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Adquisiciones.Business.ModFallo;
using Adquisiciones.Data.Entities;
using Spring.Context.Support;

namespace Adquisiciones.View
{
    ///<summary>
    ///</summary>
    public partial class FrmCargafallo : Form
    {
        #region Campos
        ///<summary>
        ///</summary>
        public IFalloService FalloService;
        ///<summary>
        ///</summary>
        public Anexo AnexoSelect;

        #endregion

        #region Contructores
        ///<summary>
        ///</summary>
        public FrmCargafallo()
        {
            InitializeComponent();
            var ctx = ContextRegistry.GetContext();
            FalloService = ctx["falloService"] as IFalloService;

            //Nos Suscribimos al Evento
            if (FalloService != null) FalloService.FalloProceso += OnProcesoFallo;
            
            BindearListaAnexo();
        }
        #endregion

        #region Eventos

        private void OnProcesoFallo(object sender,FalloProcesoEvento e)
        {
            pgbFallo.Value = e.Porcentaje;
        }

        private void BtnCerrarClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvAnexoRowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var anexos = bsListaAnexo.DataSource as List<Anexo>;
            if (anexos != null) AnexoSelect = anexos[e.RowIndex];
        }

        private void BtnCargaLicitacionesClick(object sender, EventArgs e)
        {
            bsListaAnexo.DataSource = FalloService.AnexoDao.
                CargarAnexosByCotizacion((int)nudFecha.Value,FrmModulo.AlmacenSelec.IdAlmacen);

        }

        private void BtnProcesarClick(object sender, EventArgs e)
        {
            FalloService.GenerarFallo(AnexoSelect, dtpFallo.Value);
            
            MessageBox.Show(@"Fallo realizado Exitosamente Anexo " + AnexoSelect.NumeroAnexo,
                @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        
        #region Metodos
       
        private void BindearListaAnexo()
        {
            
            bsListaAnexo.DataSource = new List<Anexo>();
            dgvAnexo.AutoGenerateColumns = false;
            dgvAnexo.AutoSize = true;
            dgvAnexo.DataSource = bsListaAnexo;
          
            DataGridViewColumn column = new DataGridViewTextBoxColumn 
            { DataPropertyName = "NumeroAnexo", Name = "Licitacion" };
            dgvAnexo.Columns.Add(column);

            column = new DataGridViewTextBoxColumn 
            { DataPropertyName = "DesAnexo", Name = "Descripcion" };
            dgvAnexo.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TipoLicitacion",
                Name = "Tipo",
            };
            dgvAnexo.Columns.Add(column);

            column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaAnexo",
                Name = "Fecha",
            };
            dgvAnexo.Columns.Add(column);

        }

#endregion

      

    }
}
