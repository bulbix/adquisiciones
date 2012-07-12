namespace Adquisiciones.View
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.cmdEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.cmdBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.gcAnexo = new DevExpress.XtraGrid.GridControl();
            this.bsAnexos = new System.Windows.Forms.BindingSource(this.components);
            this.gvAnexo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnCotizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAnexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnexo)).BeginInit();
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
            this.splitContainerControl1.Panel2.Controls.Add(this.gcAnexo);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(866, 554);
            this.splitContainerControl1.SplitterPosition = 90;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Image = global::Adquisiciones.View.Properties.Resources.cancelar;
            this.cmdEliminar.Location = new System.Drawing.Point(635, 22);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(133, 57);
            this.cmdEliminar.TabIndex = 5;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::Adquisiciones.View.Properties.Resources.printer;
            this.simpleButton1.Location = new System.Drawing.Point(474, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(145, 57);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Imprimir Anexo";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Image = global::Adquisiciones.View.Properties.Resources.busqueda;
            this.cmdConsultar.Location = new System.Drawing.Point(164, 22);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(133, 57);
            this.cmdConsultar.TabIndex = 3;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.Click += new System.EventHandler(this.CmdConsultarClick);
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Image = global::Adquisiciones.View.Properties.Resources.printer;
            this.cmdImprimir.Location = new System.Drawing.Point(313, 22);
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
            this.gcAnexo.DataSource = this.bsAnexos;
            this.gcAnexo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAnexo.Location = new System.Drawing.Point(0, 0);
            this.gcAnexo.MainView = this.gvAnexo;
            this.gcAnexo.Name = "gcAnexo";
            this.gcAnexo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gcAnexo.Size = new System.Drawing.Size(866, 458);
            this.gcAnexo.TabIndex = 0;
            this.gcAnexo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAnexo});
            // 
            // bsAnexos
            // 
            this.ComponentObserver.SetObserveComponent(this.bsAnexos, true);
            // 
            // gvAnexo
            // 
            this.gvAnexo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumnCotizacion});
            this.gvAnexo.GridControl = this.gcAnexo;
            this.gvAnexo.Name = "gvAnexo";
            this.ComponentObserver.SetObserveComponent(this.gvAnexo, true);
            this.gvAnexo.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAnexo.OptionsView.ShowAutoFilterRow = true;
            this.gvAnexo.OptionsView.ShowGroupedColumns = true;
            this.gvAnexo.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Numero";
            this.gridColumn2.FieldName = "NumeroAnexo";
            this.gridColumn2.Name = "gridColumn2";
            this.ComponentObserver.SetObserveComponent(this.gridColumn2, true);
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 123;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Fecha";
            this.gridColumn1.FieldName = "FechaAnexo";
            this.gridColumn1.Name = "gridColumn1";
            this.ComponentObserver.SetObserveComponent(this.gridColumn1, true);
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 152;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Descripcion";
            this.gridColumn3.FieldName = "DesAnexo";
            this.gridColumn3.Name = "gridColumn3";
            this.ComponentObserver.SetObserveComponent(this.gridColumn3, true);
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 189;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Presupuesto";
            this.gridColumn4.DisplayFormat.FormatString = "c2";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "TechoPresupuestal";
            this.gridColumn4.Name = "gridColumn4";
            this.ComponentObserver.SetObserveComponent(this.gridColumn4, true);
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 130;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Modifico";
            this.gridColumn5.FieldName = "Usuario";
            this.gridColumn5.Name = "gridColumn5";
            this.ComponentObserver.SetObserveComponent(this.gridColumn5, true);
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 335;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Verificar";
            this.gridColumn7.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn7.Name = "gridColumn7";
            this.ComponentObserver.SetObserveComponent(this.gridColumn7, true);
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.ComponentObserver.SetObserveComponent(this.repositoryItemButtonEdit1, true);
            this.repositoryItemButtonEdit1.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // gridColumnCotizacion
            // 
            this.gridColumnCotizacion.Caption = "Tiene Cotizacion";
            this.gridColumnCotizacion.FieldName = "TieneCotizacion";
            this.gridColumnCotizacion.Name = "gridColumnCotizacion";
            this.ComponentObserver.SetObserveComponent(this.gridColumnCotizacion, true);
            this.gridColumnCotizacion.OptionsColumn.AllowEdit = false;
            this.gridColumnCotizacion.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumnCotizacion.Visible = true;
            this.gridColumnCotizacion.VisibleIndex = 6;
            this.gridColumnCotizacion.Width = 103;
            // 
            // FrmBusquedaAnexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 554);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmBusquedaAnexo";
            this.Text = "Anexo::Busqueda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAnexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton cmdBuscar;
        private DevExpress.XtraGrid.GridControl gcAnexo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAnexo;
        private DevExpress.XtraEditors.SimpleButton cmdImprimir;
        private System.Windows.Forms.BindingSource bsAnexos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton cmdConsultar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCotizacion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.SimpleButton cmdEliminar;

    }
}