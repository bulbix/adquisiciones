namespace Adquisiciones.View
{
    partial class FrmPedidoEntrega
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
            this.bsPedidoEntrega = new System.Windows.Forms.BindingSource();
            this.cmdAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.gcPedidoEntrega = new DevExpress.XtraGrid.GridControl();
            this.gvPedidoEntrega = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemCalcEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.repositoryItemCalcEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.deFechaInicial = new DevExpress.XtraEditors.DateEdit();
            this.deFechaFinal = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.seCantidad = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedidoEntrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidoEntrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidoEntrega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCantidad.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Location = new System.Drawing.Point(34, 427);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(118, 63);
            this.cmdAceptar.TabIndex = 1;
            this.cmdAceptar.Text = "Aceptar";
            this.cmdAceptar.Click += new System.EventHandler(this.CmdAceptarClick);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(200, 427);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(118, 63);
            this.cmdCancelar.TabIndex = 2;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.Click += new System.EventHandler(this.CmdCancelarClick);
            // 
            // gcPedidoEntrega
            // 
            this.gcPedidoEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gcPedidoEntrega.DataSource = this.bsPedidoEntrega;
            this.gcPedidoEntrega.Location = new System.Drawing.Point(34, 96);
            this.gcPedidoEntrega.MainView = this.gvPedidoEntrega;
            this.gcPedidoEntrega.Name = "gcPedidoEntrega";
            this.gcPedidoEntrega.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit2,
            this.repositoryItemPopupContainerEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemCalcEdit1,
            this.repositoryItemDateEdit3,
            this.repositoryItemDateEdit4,
            this.repositoryItemCalcEdit2});
            this.gcPedidoEntrega.Size = new System.Drawing.Size(330, 297);
            this.gcPedidoEntrega.TabIndex = 3;
            this.gcPedidoEntrega.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPedidoEntrega});
            this.gcPedidoEntrega.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GcPedidoEntregaKeyDown);
            // 
            // gvPedidoEntrega
            // 
            this.gvPedidoEntrega.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPedidoEntrega.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvPedidoEntrega.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPedidoEntrega.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoEntrega.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPedidoEntrega.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvPedidoEntrega.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvPedidoEntrega.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvPedidoEntrega.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvPedidoEntrega.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoEntrega.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPedidoEntrega.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvPedidoEntrega.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvPedidoEntrega.Appearance.Empty.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvPedidoEntrega.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoEntrega.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPedidoEntrega.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvPedidoEntrega.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPedidoEntrega.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoEntrega.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPedidoEntrega.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvPedidoEntrega.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvPedidoEntrega.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvPedidoEntrega.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvPedidoEntrega.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvPedidoEntrega.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoEntrega.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvPedidoEntrega.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvPedidoEntrega.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPedidoEntrega.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvPedidoEntrega.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPedidoEntrega.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoEntrega.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPedidoEntrega.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvPedidoEntrega.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPedidoEntrega.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPedidoEntrega.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoEntrega.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvPedidoEntrega.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPedidoEntrega.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPedidoEntrega.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoEntrega.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvPedidoEntrega.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvPedidoEntrega.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPedidoEntrega.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPedidoEntrega.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPedidoEntrega.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvPedidoEntrega.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoEntrega.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvPedidoEntrega.Appearance.GroupRow.Options.UseFont = true;
            this.gvPedidoEntrega.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPedidoEntrega.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvPedidoEntrega.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPedidoEntrega.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoEntrega.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPedidoEntrega.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPedidoEntrega.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvPedidoEntrega.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvPedidoEntrega.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvPedidoEntrega.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvPedidoEntrega.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoEntrega.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.OddRow.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvPedidoEntrega.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvPedidoEntrega.Appearance.Preview.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.Preview.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvPedidoEntrega.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvPedidoEntrega.Appearance.Row.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.Row.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvPedidoEntrega.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvPedidoEntrega.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvPedidoEntrega.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPedidoEntrega.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPedidoEntrega.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvPedidoEntrega.Appearance.VertLine.Options.UseBackColor = true;
            this.gvPedidoEntrega.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvPedidoEntrega.GridControl = this.gcPedidoEntrega;
            this.gvPedidoEntrega.Name = "gvPedidoEntrega";
            this.gvPedidoEntrega.NewItemRowText = "Clck aqui para agregar un nuevo registro";
            this.gvPedidoEntrega.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPedidoEntrega.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvPedidoEntrega.OptionsView.ColumnAutoWidth = false;
            this.gvPedidoEntrega.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPedidoEntrega.OptionsView.EnableAppearanceOddRow = true;
            this.gvPedidoEntrega.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Fecha Inicial";
            this.gridColumn1.ColumnEdit = this.repositoryItemDateEdit3;
            this.gridColumn1.FieldName = "FechaInicial";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 81;
            // 
            // repositoryItemDateEdit3
            // 
            this.repositoryItemDateEdit3.AutoHeight = false;
            this.repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
            this.repositoryItemDateEdit3.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Fecha Final";
            this.gridColumn2.ColumnEdit = this.repositoryItemDateEdit4;
            this.gridColumn2.FieldName = "FechaFinal";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 93;
            // 
            // repositoryItemDateEdit4
            // 
            this.repositoryItemDateEdit4.AutoHeight = false;
            this.repositoryItemDateEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit4.Name = "repositoryItemDateEdit4";
            this.repositoryItemDateEdit4.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cantidad";
            this.gridColumn3.FieldName = "Cantidad";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // repositoryItemSearchLookUpEdit2
            // 
            this.repositoryItemSearchLookUpEdit2.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit2.Name = "repositoryItemSearchLookUpEdit2";
            this.repositoryItemSearchLookUpEdit2.NullText = "";
            this.repositoryItemSearchLookUpEdit2.View = this.gridView5;
            // 
            // gridView5
            // 
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemPopupContainerEdit1
            // 
            this.repositoryItemPopupContainerEdit1.AutoHeight = false;
            this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            this.repositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // repositoryItemCalcEdit1
            // 
            this.repositoryItemCalcEdit1.AutoHeight = false;
            this.repositoryItemCalcEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1";
            // 
            // repositoryItemCalcEdit2
            // 
            this.repositoryItemCalcEdit2.AutoHeight = false;
            this.repositoryItemCalcEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemCalcEdit2.Name = "repositoryItemCalcEdit2";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(31, 411);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(35, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "label1";
            // 
            // deFechaInicial
            // 
            this.deFechaInicial.EditValue = null;
            this.deFechaInicial.Location = new System.Drawing.Point(141, 12);
            this.deFechaInicial.Name = "deFechaInicial";
            this.deFechaInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFechaInicial.Size = new System.Drawing.Size(100, 20);
            this.deFechaInicial.TabIndex = 5;
            // 
            // deFechaFinal
            // 
            this.deFechaFinal.EditValue = null;
            this.deFechaFinal.Location = new System.Drawing.Point(141, 37);
            this.deFechaFinal.Name = "deFechaFinal";
            this.deFechaFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFechaFinal.Size = new System.Drawing.Size(100, 20);
            this.deFechaFinal.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(61, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Fecha Inicial";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(61, 40);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Fecha Final";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(61, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Cantidad";
            // 
            // seCantidad
            // 
            this.seCantidad.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seCantidad.Location = new System.Drawing.Point(141, 64);
            this.seCantidad.Name = "seCantidad";
            this.seCantidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seCantidad.Size = new System.Drawing.Size(100, 20);
            this.seCantidad.TabIndex = 10;
            this.seCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpinEdit1KeyDown);
            // 
            // FrmPedidoEntrega
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 652);
            this.Controls.Add(this.seCantidad);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.deFechaFinal);
            this.Controls.Add(this.deFechaInicial);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.gcPedidoEntrega);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPedidoEntrega";
            this.Text = "Pedido Entrega";
            ((System.ComponentModel.ISupportInitialize)(this.bsPedidoEntrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPedidoEntrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPedidoEntrega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCalcEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCantidad.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmdAceptar;
        private DevExpress.XtraEditors.SimpleButton cmdCancelar;
        private System.Windows.Forms.BindingSource bsPedidoEntrega;
        private DevExpress.XtraGrid.GridControl gcPedidoEntrega;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPedidoEntrega;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repositoryItemCalcEdit2;
        private System.Windows.Forms.Label lblCantidad;
        private DevExpress.XtraEditors.DateEdit deFechaInicial;
        private DevExpress.XtraEditors.DateEdit deFechaFinal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit seCantidad;
    }
}