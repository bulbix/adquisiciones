namespace Adquisiciones.View
{
    partial class FrmBusquedaCotizacion
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
            this.cmdEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.cmdBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.gcCotizacion = new DevExpress.XtraGrid.GridControl();
            this.bsCotizaciones = new System.Windows.Forms.BindingSource(this.components);
            this.gvCotizacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCotizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.cmdEliminar);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmdConsultar);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmdImprimir);
            this.splitContainerControl1.Panel1.Controls.Add(this.cmdBuscar);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gcCotizacion);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(830, 449);
            this.splitContainerControl1.SplitterPosition = 90;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Image = global::Adquisiciones.View.Properties.Resources.cancelar;
            this.cmdEliminar.Location = new System.Drawing.Point(672, 22);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(133, 57);
            this.cmdEliminar.TabIndex = 6;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Adquisiciones.View.Properties.Resources.printer;
            this.simpleButton1.Location = new System.Drawing.Point(498, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(168, 57);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Imprimir Cotizacion";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Image = global::Adquisiciones.View.Properties.Resources.busqueda;
            this.cmdConsultar.Location = new System.Drawing.Point(179, 22);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(133, 57);
            this.cmdConsultar.TabIndex = 3;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.Click += new System.EventHandler(this.CmdConsultarClick);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Image = global::Adquisiciones.View.Properties.Resources.printer;
            this.cmdImprimir.Location = new System.Drawing.Point(335, 22);
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
            // gcCotizacion
            // 
            this.gcCotizacion.DataSource = this.bsCotizaciones;
            this.gcCotizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCotizacion.Location = new System.Drawing.Point(0, 0);
            this.gcCotizacion.MainView = this.gvCotizacion;
            this.gcCotizacion.Name = "gcCotizacion";
            this.gcCotizacion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gcCotizacion.Size = new System.Drawing.Size(830, 353);
            this.gcCotizacion.TabIndex = 0;
            this.gcCotizacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCotizacion});
            // 
            // bsCotizaciones
            // 
            
            // 
            // gvCotizacion
            // 
            this.gvCotizacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn2,
            this.gridColumn6,
            this.gridColumn5});
            this.gvCotizacion.GridControl = this.gcCotizacion;
            this.gvCotizacion.Name = "gvCotizacion";
            
            this.gvCotizacion.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCotizacion.OptionsView.ShowAutoFilterRow = true;
            this.gvCotizacion.OptionsView.ShowGroupedColumns = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Proveedor";
            this.gridColumn1.FieldName = "Proveedor";
            this.gridColumn1.Name = "gridColumn1";
            
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 259;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Fecha";
            this.gridColumn4.FieldName = "FechaCotizacion";
            this.gridColumn4.Name = "gridColumn4";
           
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 61;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Modifico";
            this.gridColumn3.FieldName = "Usuario";
            this.gridColumn3.Name = "gridColumn3";
            
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 350;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Anexo";
            this.gridColumn2.FieldName = "Anexo";
            this.gridColumn2.Name = "gridColumn2";
            
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 142;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Verificar";
            this.gridColumn6.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn6.Name = "gridColumn6";
            
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
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
            this.gridColumn5.Caption = "Tiene Fallo";
            this.gridColumn5.FieldName = "TieneFallo";
            this.gridColumn5.Name = "gridColumn5";
            
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // FrmBusquedaCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 449);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmBusquedaCotizacion";
            this.Text = "Cotizacion::Busqueda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCotizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton cmdBuscar;
        private DevExpress.XtraGrid.GridControl gcCotizacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCotizacion;
        private DevExpress.XtraEditors.SimpleButton cmdImprimir;
        private System.Windows.Forms.BindingSource bsCotizaciones;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton cmdConsultar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.SimpleButton cmdEliminar;

    }
}