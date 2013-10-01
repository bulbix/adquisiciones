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
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gcProveedor.Size = new System.Drawing.Size(1284, 442);
            this.gcProveedor.TabIndex = 4;
            this.gcProveedor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProveedor});
            // 
            // gvProveedor
            // 
            this.gvProveedor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn8,
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn4,
            this.gridColumn7,
            this.gridColumn9});
            this.gvProveedor.GridControl = this.gcProveedor;
            this.gvProveedor.Name = "gvProveedor";
            this.gvProveedor.OptionsBehavior.Editable = false;
            this.gvProveedor.OptionsView.EnableAppearanceEvenRow = true;
            this.gvProveedor.OptionsView.ShowAutoFilterRow = true;
            this.gvProveedor.OptionsView.ShowGroupedColumns = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Clave";
            this.gridColumn2.FieldName = "CveProveedor";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 49;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nombre";
            this.gridColumn1.FieldName = "NombreFiscal";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 225;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "RFC";
            this.gridColumn3.FieldName = "Rfc";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 102;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Giro o Actividad";
            this.gridColumn4.FieldName = "Giro";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 152;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tipo Empresa";
            this.gridColumn6.FieldName = "CatEmpresa";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 68;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Representante";
            this.gridColumn8.FieldName = "NombreRepresentanteCompleto";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 202;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Modifico";
            this.gridColumn7.FieldName = "Usuario";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Fecha Mod";
            this.gridColumn9.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn9.FieldName = "FechaModificacion";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Tipo Persona";
            this.gridColumn5.FieldName = "TipoPersona";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            // 
            // FrmBusquedaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 531);
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}