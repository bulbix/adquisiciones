namespace Adquisiciones.View.Busquedas
{
    partial class FrmBusquedaPedido
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
            this.gcPedido = new DevExpress.XtraGrid.GridControl();
            this.gvPedido = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concentradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoVsEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaVsPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoVsEntradaCompletoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaVsPedidoCompletoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedido)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcPedido
            // 
            this.gcPedido.DataSource = this.bsSource;
            this.gcPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPedido.Location = new System.Drawing.Point(0, 93);
            this.gcPedido.MainView = this.gvPedido;
            this.gcPedido.Name = "gcPedido";
            this.gcPedido.Size = new System.Drawing.Size(860, 478);
            this.gcPedido.TabIndex = 4;
            this.gcPedido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPedido});
            // 
            // gvPedido
            // 
            this.gvPedido.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn6,
            this.gridColumn5,
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn2,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18});
            this.gvPedido.GridControl = this.gcPedido;
            this.gvPedido.Name = "gvPedido";
            this.gvPedido.OptionsBehavior.Editable = false;
            this.gvPedido.OptionsFind.AlwaysVisible = true;
            this.gvPedido.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPedido.OptionsView.ShowAutoFilterRow = true;
            this.gvPedido.OptionsView.ShowGroupedColumns = true;
            this.gvPedido.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn2, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Tipo";
            this.gridColumn7.FieldName = "CatTipopedido";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 42;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Requisicion";
            this.gridColumn6.FieldName = "Requisicion";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.gridColumn6.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 11;
            this.gridColumn6.Width = 49;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Proveedor";
            this.gridColumn5.FieldName = "Proveedor";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.gridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 53;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Fundamento";
            this.gridColumn4.FieldName = "Fundamento";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 73;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Fecha";
            this.gridColumn1.FieldName = "FechaPedido";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 52;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Numero";
            this.gridColumn3.FieldName = "NumeroPedido";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 43;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Automatico";
            this.gridColumn2.FieldName = "Automatico";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Boolean;
            this.gridColumn2.Width = 63;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Modifico";
            this.gridColumn8.FieldName = "Usuario";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.gridColumn8.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 15;
            this.gridColumn8.Width = 52;
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
            this.gridColumn9.VisibleIndex = 16;
            this.gridColumn9.Width = 89;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Procedimiento";
            this.gridColumn10.FieldName = "TipoProcedimiento";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            this.gridColumn10.Width = 57;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Area";
            this.gridColumn11.FieldName = "CatArea";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 6;
            this.gridColumn11.Width = 40;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Num Req";
            this.gridColumn12.FieldName = "NumeroRequisicion";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 7;
            this.gridColumn12.Width = 46;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Importe";
            this.gridColumn13.DisplayFormat.FormatString = "C2";
            this.gridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn13.FieldName = "Total";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 12;
            this.gridColumn13.Width = 36;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Actividad";
            this.gridColumn14.FieldName = "CatActividad";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 8;
            this.gridColumn14.Width = 49;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Presupuesto";
            this.gridColumn15.FieldName = "CatPresupuesto";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 9;
            this.gridColumn15.Width = 53;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Estado";
            this.gridColumn16.FieldName = "EstadoPedido";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 10;
            this.gridColumn16.Width = 33;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Partida";
            this.gridColumn17.FieldName = "PartidaString";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 13;
            this.gridColumn17.Width = 44;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Almacen Dest";
            this.gridColumn18.FieldName = "AlmacenDestino";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 14;
            this.gridColumn18.Width = 31;
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Prueba";
            this.barSubItem1.Id = 8;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 69);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detalladoToolStripMenuItem,
            this.concentradoToolStripMenuItem,
            this.pedidoVsEntradaToolStripMenuItem,
            this.entradaVsPedidoToolStripMenuItem,
            this.pedidoVsEntradaCompletoToolStripMenuItem,
            this.entradaVsPedidoCompletoToolStripMenuItem,
            this.pedidoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // detalladoToolStripMenuItem
            // 
            this.detalladoToolStripMenuItem.Name = "detalladoToolStripMenuItem";
            this.detalladoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.detalladoToolStripMenuItem.Text = "Detallado";
            this.detalladoToolStripMenuItem.Click += new System.EventHandler(this.detalladoToolStripMenuItem_Click);
            // 
            // concentradoToolStripMenuItem
            // 
            this.concentradoToolStripMenuItem.Name = "concentradoToolStripMenuItem";
            this.concentradoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.concentradoToolStripMenuItem.Text = "Concentrado";
            this.concentradoToolStripMenuItem.Click += new System.EventHandler(this.concentradoToolStripMenuItem_Click);
            // 
            // pedidoVsEntradaToolStripMenuItem
            // 
            this.pedidoVsEntradaToolStripMenuItem.Name = "pedidoVsEntradaToolStripMenuItem";
            this.pedidoVsEntradaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.pedidoVsEntradaToolStripMenuItem.Text = "Pedido vs Entrada";
            this.pedidoVsEntradaToolStripMenuItem.Click += new System.EventHandler(this.pedidoVsEntradaToolStripMenuItem_Click);
            // 
            // entradaVsPedidoToolStripMenuItem
            // 
            this.entradaVsPedidoToolStripMenuItem.Name = "entradaVsPedidoToolStripMenuItem";
            this.entradaVsPedidoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.entradaVsPedidoToolStripMenuItem.Text = "Entrada vs Pedido";
            this.entradaVsPedidoToolStripMenuItem.Click += new System.EventHandler(this.entradaVsPedidoToolStripMenuItem_Click);
            // 
            // pedidoVsEntradaCompletoToolStripMenuItem
            // 
            this.pedidoVsEntradaCompletoToolStripMenuItem.Name = "pedidoVsEntradaCompletoToolStripMenuItem";
            this.pedidoVsEntradaCompletoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.pedidoVsEntradaCompletoToolStripMenuItem.Text = "Pedido vs Entrada Completo";
            this.pedidoVsEntradaCompletoToolStripMenuItem.Click += new System.EventHandler(this.pedidoVsEntradaCompletoToolStripMenuItem_Click);
            // 
            // entradaVsPedidoCompletoToolStripMenuItem
            // 
            this.entradaVsPedidoCompletoToolStripMenuItem.Name = "entradaVsPedidoCompletoToolStripMenuItem";
            this.entradaVsPedidoCompletoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.entradaVsPedidoCompletoToolStripMenuItem.Text = "Entrada vs Pedido Completo";
            this.entradaVsPedidoCompletoToolStripMenuItem.Click += new System.EventHandler(this.entradaVsPedidoCompletoToolStripMenuItem_Click);
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.pedidoToolStripMenuItem.Text = "Listado Pedidos";
            this.pedidoToolStripMenuItem.Click += new System.EventHandler(this.pedidoToolStripMenuItem_Click);
            // 
            // FrmBusquedaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 594);
            this.Controls.Add(this.gcPedido);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBusquedaPedido";
            this.Text = "Busqueda::Pedido";
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.gcPedido, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedido)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPedido;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPedido;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalladoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concentradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoVsEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaVsPedidoToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private System.Windows.Forms.ToolStripMenuItem pedidoVsEntradaCompletoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaVsPedidoCompletoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
    }
}