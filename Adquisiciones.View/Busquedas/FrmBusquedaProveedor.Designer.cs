namespace Adquisiciones.View
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.cmdConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.cmdBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.gcProveedor = new DevExpress.XtraGrid.GridControl();
            this.bsProveedores = new System.Windows.Forms.BindingSource(this.components);
            this.gvProveedor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.cmdConsultar);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmdImprimir);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmdBuscar);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gcProveedor);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(889, 628);
            this.splitContainerControl1.SplitterPosition = 90;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Image = global::Adquisiciones.View.Properties.Resources.busqueda;
            this.cmdConsultar.Location = new System.Drawing.Point(174, 22);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(133, 57);
            this.cmdConsultar.TabIndex = 2;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.Click += new System.EventHandler(this.CmdConsultarClick);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Image = global::Adquisiciones.View.Properties.Resources.printer;
            this.cmdImprimir.Location = new System.Drawing.Point(336, 22);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(145, 57);
            this.cmdImprimir.TabIndex = 1;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.Click += new System.EventHandler(this.CmdImprimirClick);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Image = global::Adquisiciones.View.Properties.Resources.busqueda;
            this.cmdBuscar.Location = new System.Drawing.Point(12, 22);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(133, 57);
            this.cmdBuscar.TabIndex = 0;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.Click += new System.EventHandler(this.CmdBuscarClick);
            // 
            // gcProveedor
            // 
            this.gcProveedor.DataSource = this.bsProveedores;
            this.gcProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcProveedor.Location = new System.Drawing.Point(0, 0);
            this.gcProveedor.MainView = this.gvProveedor;
            this.gcProveedor.Name = "gcProveedor";
            this.gcProveedor.Size = new System.Drawing.Size(889, 532);
            this.gcProveedor.TabIndex = 1;
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
            this.ClientSize = new System.Drawing.Size(889, 628);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmBusquedaProveedor";
            this.Text = "Proveedor::Busqueda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton cmdBuscar;
        private DevExpress.XtraGrid.GridControl gcAnexo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAnexo;
        private DevExpress.XtraEditors.SimpleButton cmdImprimir;
        private DevExpress.XtraGrid.GridControl gcProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.BindingSource bsProveedores;
        private DevExpress.XtraEditors.SimpleButton cmdConsultar;

    }
}