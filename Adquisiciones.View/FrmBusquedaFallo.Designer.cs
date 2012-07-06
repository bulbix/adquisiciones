namespace Adquisiciones.View
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.cmdBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.gcAnexo = new DevExpress.XtraGrid.GridControl();
            this.bsFallos = new System.Windows.Forms.BindingSource(this.components);
            this.gvAnexo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAnexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFallos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnexo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton2);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmdImprimir);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmdBuscar);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gcAnexo);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(678, 462);
            this.splitContainerControl1.SplitterPosition = 90;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::Adquisiciones.View.Properties.Resources.printer;
            this.simpleButton2.Location = new System.Drawing.Point(335, 22);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(145, 57);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Imprimir Tabla";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Image = global::Adquisiciones.View.Properties.Resources.printer;
            this.cmdImprimir.Location = new System.Drawing.Point(160, 22);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(145, 57);
            this.cmdImprimir.TabIndex = 1;
            this.cmdImprimir.Text = "Imprimir Listado";
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
            // gcAnexo
            // 
            this.gcAnexo.DataSource = this.bsFallos;
            this.gcAnexo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAnexo.Location = new System.Drawing.Point(0, 0);
            this.gcAnexo.MainView = this.gvAnexo;
            this.gcAnexo.Name = "gcAnexo";
            this.gcAnexo.Size = new System.Drawing.Size(678, 367);
            this.gcAnexo.TabIndex = 1;
            this.gcAnexo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAnexo});
            // 
            // bsFallos
            // 
            this.bsFallos.CurrentChanged += new System.EventHandler(this.bsAnexos_CurrentChanged);
            // 
            // gvAnexo
            // 
            this.gvAnexo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn3});
            this.gvAnexo.GridControl = this.gcAnexo;
            this.gvAnexo.Name = "gvAnexo";
            this.gvAnexo.OptionsBehavior.Editable = false;
            this.gvAnexo.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAnexo.OptionsView.ShowAutoFilterRow = true;
            this.gvAnexo.OptionsView.ShowGroupPanel = false;
            this.gvAnexo.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Modifico";
            this.gridColumn2.FieldName = "Usuario";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 206;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Fecha Fallo";
            this.gridColumn1.FieldName = "FechaFallo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 97;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Anexo";
            this.gridColumn3.FieldName = "Anexo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 357;
            // 
            // FrmBusquedaFallo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 462);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmBusquedaFallo";
            this.Text = "Fallo::Busqueda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAnexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFallos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnexo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton cmdBuscar;
        private DevExpress.XtraEditors.SimpleButton cmdImprimir;
        private System.Windows.Forms.BindingSource bsFallos;
        private DevExpress.XtraGrid.GridControl gcAnexo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAnexo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;

    }
}