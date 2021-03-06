﻿namespace Adquisiciones.View.Busquedas
{
    partial class FrmBusquedaAnexo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gcAnexo = new DevExpress.XtraGrid.GridControl();
            this.gvAnexo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnCotizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaComparativaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAnexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcAnexo
            // 
            this.gcAnexo.DataSource = this.bsSource;
            this.gcAnexo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAnexo.Location = new System.Drawing.Point(0, 91);
            this.gcAnexo.MainView = this.gvAnexo;
            this.gcAnexo.Name = "gcAnexo";
            this.gcAnexo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gcAnexo.Size = new System.Drawing.Size(884, 485);
            this.gcAnexo.TabIndex = 4;
            this.gcAnexo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAnexo});
            // 
            // gvAnexo
            // 
            this.gvAnexo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn7,
            this.gridColumnCotizacion,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gvAnexo.GridControl = this.gcAnexo;
            this.gvAnexo.Name = "gvAnexo";
            this.gvAnexo.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAnexo.OptionsView.ShowAutoFilterRow = true;
            this.gvAnexo.OptionsView.ShowGroupedColumns = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Numero";
            this.gridColumn2.FieldName = "NumeroAnexo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 102;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Fecha";
            this.gridColumn1.FieldName = "FechaAnexo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 49;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Descripcion";
            this.gridColumn3.FieldName = "DesAnexo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 166;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Presupuesto";
            this.gridColumn4.DisplayFormat.FormatString = "c2";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "TechoPresupuestal";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 61;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Verificar";
            this.gridColumn7.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            this.gridColumn7.Width = 53;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.TieneCotizacionClick);
            // 
            // gridColumnCotizacion
            // 
            this.gridColumnCotizacion.Caption = "Tiene Cotizacion";
            this.gridColumnCotizacion.FieldName = "TieneCotizacion";
            this.gridColumnCotizacion.Name = "gridColumnCotizacion";
            this.gridColumnCotizacion.OptionsColumn.AllowEdit = false;
            this.gridColumnCotizacion.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumnCotizacion.Visible = true;
            this.gridColumnCotizacion.VisibleIndex = 8;
            this.gridColumnCotizacion.Width = 54;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Modifico";
            this.gridColumn5.FieldName = "Usuario";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.gridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 9;
            this.gridColumn5.Width = 107;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Fecha Mod";
            this.gridColumn6.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn6.FieldName = "FechaModificacion";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 10;
            this.gridColumn6.Width = 83;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Iva";
            this.gridColumn8.FieldName = "Iva";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            this.gridColumn8.Width = 55;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Licitacion";
            this.gridColumn9.FieldName = "TipoLicitacion";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 72;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Contrato";
            this.gridColumn10.FieldName = "TipoContrato";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 6;
            this.gridColumn10.Width = 61;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 67);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaComparativaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // tablaComparativaToolStripMenuItem
            // 
            this.tablaComparativaToolStripMenuItem.Name = "tablaComparativaToolStripMenuItem";
            this.tablaComparativaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.tablaComparativaToolStripMenuItem.Text = "Tabla Comparativa";
            this.tablaComparativaToolStripMenuItem.Click += new System.EventHandler(this.tablaComparativaToolStripMenuItem_Click);
            // 
            // FrmBusquedaAnexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 598);
            this.Controls.Add(this.gcAnexo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBusquedaAnexo";
            this.Text = "Busqueda::Anexo";
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.gcAnexo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAnexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcAnexo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAnexo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCotizacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaComparativaToolStripMenuItem;
    }
}