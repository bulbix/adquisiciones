namespace Adquisiciones.View.Busquedas
{
    partial class FrmBusquedaFundamento
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
            this.gcFundamento = new DevExpress.XtraGrid.GridControl();
            this.gvFundamento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFundamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFundamento)).BeginInit();
            this.SuspendLayout();
            // 
            // gcFundamento
            // 
            this.gcFundamento.DataSource = this.bsSource;
            this.gcFundamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFundamento.Location = new System.Drawing.Point(0, 69);
            this.gcFundamento.MainView = this.gvFundamento;
            this.gcFundamento.Name = "gcFundamento";
            this.gcFundamento.Size = new System.Drawing.Size(784, 448);
            this.gcFundamento.TabIndex = 5;
            this.gcFundamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFundamento});
            // 
            // gvFundamento
            // 
            this.gvFundamento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn1});
            this.gvFundamento.GridControl = this.gcFundamento;
            this.gvFundamento.Name = "gvFundamento";
            this.gvFundamento.OptionsBehavior.Editable = false;
            this.gvFundamento.OptionsFind.AlwaysVisible = true;
            this.gvFundamento.OptionsView.EnableAppearanceEvenRow = true;
            this.gvFundamento.OptionsView.ShowAutoFilterRow = true;
            this.gvFundamento.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Clave";
            this.gridColumn2.FieldName = "CveFundamento";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 58;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Descripcion";
            this.gridColumn1.FieldName = "DesFundamento";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 587;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Articulo";
            this.gridColumn3.FieldName = "ArtiFundamento";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 62;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Inciso";
            this.gridColumn4.FieldName = "IncisoFundamento";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 73;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Fraccion";
            this.gridColumn5.FieldName = "FraccFundamento";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // FrmBusquedaFundamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 540);
            this.Controls.Add(this.gcFundamento);
            this.Name = "FrmBusquedaFundamento";
            this.Text = "Fundamento::Busqueda";
            this.Controls.SetChildIndex(this.gcFundamento, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFundamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFundamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcFundamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFundamento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}