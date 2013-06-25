namespace Adquisiciones.View.Busquedas
{
    partial class FrmBusquedaProveedor
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
            this.gcProveedor = new DevExpress.XtraGrid.GridControl();
            this.gvProveedor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // gcProveedor
            // 
            this.gcProveedor.DataSource = this.bsSource;
            this.gcProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProveedor.Location = new System.Drawing.Point(0, 67);
            this.gcProveedor.MainView = this.gvProveedor;
            this.gcProveedor.Name = "gcProveedor";
            this.gcProveedor.Size = new System.Drawing.Size(708, 308);
            this.gcProveedor.TabIndex = 4;
            this.gcProveedor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProveedor});
            // 
            // gvProveedor
            // 
            this.gvProveedor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn1});
            this.gvProveedor.GridControl = this.gcProveedor;
            this.gvProveedor.Name = "gvProveedor";
            this.gvProveedor.OptionsBehavior.Editable = false;
            this.gvProveedor.OptionsFind.AlwaysVisible = true;
            this.gvProveedor.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProveedor.OptionsView.ShowAutoFilterRow = true;
            this.gvProveedor.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Clave";
            this.gridColumn2.FieldName = "CveProveedor";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 104;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nombre Fiscal";
            this.gridColumn1.FieldName = "NombreFiscal";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 680;
            // 
            // FrmBusquedaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 397);
            this.Controls.Add(this.gcProveedor);
            this.Name = "FrmBusquedaProveedor";
            this.Text = "Proveedor::Busqueda";
            this.Controls.SetChildIndex(this.gcProveedor, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}