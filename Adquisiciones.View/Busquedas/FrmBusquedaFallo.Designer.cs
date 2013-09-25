namespace Adquisiciones.View.Busquedas
{
    partial class FrmBusquedaFallo
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
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAnexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcAnexo
            // 
            this.gcAnexo.DataSource = this.bsSource;
            this.gcAnexo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAnexo.Location = new System.Drawing.Point(0, 69);
            this.gcAnexo.MainView = this.gvAnexo;
            this.gcAnexo.Name = "gcAnexo";
            this.gcAnexo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gcAnexo.Size = new System.Drawing.Size(708, 302);
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
            this.gridColumn5});
            this.gvAnexo.GridControl = this.gcAnexo;
            this.gvAnexo.Name = "gvAnexo";
            this.gvAnexo.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAnexo.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Modifico";
            this.gridColumn2.FieldName = "Usuario";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 104;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Fecha Fallo";
            this.gridColumn1.FieldName = "FechaFallo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 91;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Anexo";
            this.gridColumn3.FieldName = "Anexo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 309;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Fecha Mod";
            this.gridColumn4.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn4.FieldName = "FechaModificacion";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 87;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Ampliar Maximos";
            this.gridColumn5.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 96;
            // 
            // FrmBusquedaFallo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 397);
            this.Controls.Add(this.gcAnexo);
            this.Name = "FrmBusquedaFallo";
            this.Text = "Busqueda::Fallo";
            this.Controls.SetChildIndex(this.gcAnexo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAnexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcAnexo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAnexo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}