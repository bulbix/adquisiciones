namespace Adquisiciones.View.Modulos
{
    partial class FrmModuloAnexo
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
            this.gcDatosGenerales = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpPartida = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bsPartida = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEditPartida = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmdCargar = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtnumlicitacion = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDesanexo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbxTipolicitacion = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTechopresupuestal = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cbxIva = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbContratoAbierto = new System.Windows.Forms.RadioButton();
            this.rbContratoCerrado = new System.Windows.Forms.RadioButton();
            this.gcAnexoDetalle = new DevExpress.XtraGrid.GridControl();
            this.bsAnexoDetalle = new System.Windows.Forms.BindingSource(this.components);
            this.gvAnexoDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCantidadMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCantidadMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bsAnexo = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumnArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosGenerales)).BeginInit();
            this.gcDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpPartida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPartida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditPartida)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumlicitacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesanexo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTechopresupuestal.Properties)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAnexoDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexoDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnexoDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexo)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.gcDatosGenerales);
            this.splitContainerControl1.Panel2.Controls.Add(this.gcAnexoDetalle);
            this.splitContainerControl1.Size = new System.Drawing.Size(1114, 603);
            this.splitContainerControl1.SplitterPosition = 138;
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.Location = new System.Drawing.Point(641, 28);
            this.lblAlmacen.Visible = true;
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.Location = new System.Drawing.Point(639, 43);
            this.cbxAlmacen.Visible = true;
            this.cbxAlmacen.SelectedIndexChanged += new System.EventHandler(this.CbxAlmacenSelectedIndexChanged);
            // 
            // gcDatosGenerales
            // 
            this.gcDatosGenerales.Controls.Add(this.labelControl3);
            this.gcDatosGenerales.Controls.Add(this.searchLookUpPartida);
            this.gcDatosGenerales.Controls.Add(this.cmdCargar);
            this.gcDatosGenerales.Controls.Add(this.tableLayoutPanel1);
            this.gcDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDatosGenerales.Location = new System.Drawing.Point(0, 0);
            this.gcDatosGenerales.Name = "gcDatosGenerales";
            this.gcDatosGenerales.Size = new System.Drawing.Size(1114, 138);
            this.gcDatosGenerales.TabIndex = 2;
            this.gcDatosGenerales.Text = "Datos Generales";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(293, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Partida:";
            // 
            // searchLookUpPartida
            // 
            this.searchLookUpPartida.EditValue = "";
            this.searchLookUpPartida.Location = new System.Drawing.Point(293, 44);
            this.searchLookUpPartida.Name = "searchLookUpPartida";
            this.searchLookUpPartida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpPartida.Properties.DataSource = this.bsPartida;
            this.searchLookUpPartida.Properties.DisplayMember = "CatPartidaString";
            this.searchLookUpPartida.Properties.NullText = "";
            this.searchLookUpPartida.Properties.ValueMember = "Partida";
            this.searchLookUpPartida.Properties.View = this.searchLookUpEditPartida;
            this.searchLookUpPartida.Size = new System.Drawing.Size(329, 20);
            this.searchLookUpPartida.TabIndex = 17;
            this.searchLookUpPartida.EditValueChanged += new System.EventHandler(this.SearchLookUpPartidaEditValueChanged);
            // 
            // searchLookUpEditPartida
            // 
            this.searchLookUpEditPartida.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn17,
            this.gridColumn18});
            this.searchLookUpEditPartida.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEditPartida.Name = "searchLookUpEditPartida";
            this.searchLookUpEditPartida.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEditPartida.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Partida";
            this.gridColumn17.FieldName = "Partida";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 0;
            this.gridColumn17.Width = 107;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Descripcion";
            this.gridColumn18.FieldName = "DesPartida";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 1;
            this.gridColumn18.Width = 925;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(70, 26);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(137, 41);
            this.cmdCargar.TabIndex = 16;
            this.cmdCargar.Text = "Cargar Excel";
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.15054F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.84946F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFecha, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtnumlicitacion, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDesanexo, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl5, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxTipolicitacion, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTechopresupuestal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxIva, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.69231F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.30769F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1106, 65);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Fecha";
            // 
            // lblFecha
            // 
            this.lblFecha.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblFecha.Location = new System.Drawing.Point(94, 3);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(63, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "labelControl3";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(178, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Licitacion";
            // 
            // txtnumlicitacion
            // 
            this.txtnumlicitacion.Location = new System.Drawing.Point(252, 3);
            this.txtnumlicitacion.Name = "txtnumlicitacion";
            this.txtnumlicitacion.Size = new System.Drawing.Size(218, 20);
            this.txtnumlicitacion.TabIndex = 1;
            this.txtnumlicitacion.Leave += new System.EventHandler(this.TxtnumlicitacionLeave);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(476, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Descripcion";
            // 
            // txtDesanexo
            // 
            this.txtDesanexo.Location = new System.Drawing.Point(558, 3);
            this.txtDesanexo.Name = "txtDesanexo";
            this.txtDesanexo.Properties.LookAndFeel.SkinName = "Blue";
            this.txtDesanexo.Size = new System.Drawing.Size(288, 20);
            this.txtDesanexo.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(852, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Tipo Licitacion";
            // 
            // cbxTipolicitacion
            // 
            this.cbxTipolicitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipolicitacion.FormattingEnabled = true;
            this.cbxTipolicitacion.Location = new System.Drawing.Point(926, 3);
            this.cbxTipolicitacion.Name = "cbxTipolicitacion";
            this.cbxTipolicitacion.Size = new System.Drawing.Size(159, 21);
            this.cbxTipolicitacion.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(3, 34);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(94, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Techo Presupuestal";
            // 
            // txtTechopresupuestal
            // 
            this.txtTechopresupuestal.Location = new System.Drawing.Point(94, 34);
            this.txtTechopresupuestal.Name = "txtTechopresupuestal";
            this.txtTechopresupuestal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTechopresupuestal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTechopresupuestal.Properties.LookAndFeel.SkinName = "Blue";
            this.txtTechopresupuestal.Properties.Mask.EditMask = "c";
            this.txtTechopresupuestal.Size = new System.Drawing.Size(78, 20);
            this.txtTechopresupuestal.TabIndex = 6;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(178, 34);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(31, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "% IVA";
            // 
            // cbxIva
            // 
            this.cbxIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIva.FormattingEnabled = true;
            this.cbxIva.Location = new System.Drawing.Point(252, 34);
            this.cbxIva.Name = "cbxIva";
            this.cbxIva.Size = new System.Drawing.Size(99, 21);
            this.cbxIva.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rbContratoAbierto);
            this.flowLayoutPanel1.Controls.Add(this.rbContratoCerrado);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(558, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(288, 28);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // rbContratoAbierto
            // 
            this.rbContratoAbierto.AutoSize = true;
            this.rbContratoAbierto.Checked = true;
            this.rbContratoAbierto.Location = new System.Drawing.Point(3, 3);
            this.rbContratoAbierto.Name = "rbContratoAbierto";
            this.rbContratoAbierto.Size = new System.Drawing.Size(106, 17);
            this.rbContratoAbierto.TabIndex = 0;
            this.rbContratoAbierto.TabStop = true;
            this.rbContratoAbierto.Text = "Contrato Abierto";
            this.rbContratoAbierto.UseVisualStyleBackColor = true;
            this.rbContratoAbierto.CheckedChanged += new System.EventHandler(this.rbContrato_CheckedChanged);
            // 
            // rbContratoCerrado
            // 
            this.rbContratoCerrado.AutoSize = true;
            this.rbContratoCerrado.Location = new System.Drawing.Point(115, 3);
            this.rbContratoCerrado.Name = "rbContratoCerrado";
            this.rbContratoCerrado.Size = new System.Drawing.Size(110, 17);
            this.rbContratoCerrado.TabIndex = 1;
            this.rbContratoCerrado.Text = "Contrato Cerrado";
            this.rbContratoCerrado.UseVisualStyleBackColor = true;
            this.rbContratoCerrado.CheckedChanged += new System.EventHandler(this.rbContrato_CheckedChanged);
            // 
            // gcAnexoDetalle
            // 
            this.gcAnexoDetalle.DataSource = this.bsAnexoDetalle;
            this.gcAnexoDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAnexoDetalle.Location = new System.Drawing.Point(0, 0);
            this.gcAnexoDetalle.MainView = this.gvAnexoDetalle;
            this.gcAnexoDetalle.Name = "gcAnexoDetalle";
            this.gcAnexoDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit2});
            this.gcAnexoDetalle.Size = new System.Drawing.Size(1114, 459);
            this.gcAnexoDetalle.TabIndex = 8;
            this.gcAnexoDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAnexoDetalle});
            this.gcAnexoDetalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GvAnexoDetalleKeyDown);
            // 
            // gvAnexoDetalle
            // 
            this.gvAnexoDetalle.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAnexoDetalle.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvAnexoDetalle.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAnexoDetalle.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvAnexoDetalle.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAnexoDetalle.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvAnexoDetalle.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvAnexoDetalle.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvAnexoDetalle.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvAnexoDetalle.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvAnexoDetalle.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAnexoDetalle.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvAnexoDetalle.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvAnexoDetalle.Appearance.Empty.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvAnexoDetalle.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvAnexoDetalle.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAnexoDetalle.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvAnexoDetalle.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAnexoDetalle.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvAnexoDetalle.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAnexoDetalle.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvAnexoDetalle.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvAnexoDetalle.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvAnexoDetalle.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvAnexoDetalle.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvAnexoDetalle.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvAnexoDetalle.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvAnexoDetalle.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvAnexoDetalle.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAnexoDetalle.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvAnexoDetalle.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAnexoDetalle.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAnexoDetalle.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAnexoDetalle.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvAnexoDetalle.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAnexoDetalle.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAnexoDetalle.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvAnexoDetalle.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvAnexoDetalle.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAnexoDetalle.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAnexoDetalle.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvAnexoDetalle.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvAnexoDetalle.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvAnexoDetalle.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAnexoDetalle.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAnexoDetalle.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvAnexoDetalle.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvAnexoDetalle.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvAnexoDetalle.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvAnexoDetalle.Appearance.GroupRow.Options.UseFont = true;
            this.gvAnexoDetalle.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAnexoDetalle.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvAnexoDetalle.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvAnexoDetalle.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvAnexoDetalle.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvAnexoDetalle.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvAnexoDetalle.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvAnexoDetalle.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvAnexoDetalle.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvAnexoDetalle.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvAnexoDetalle.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvAnexoDetalle.Appearance.OddRow.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.OddRow.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvAnexoDetalle.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvAnexoDetalle.Appearance.Preview.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.Preview.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvAnexoDetalle.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvAnexoDetalle.Appearance.Row.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.Row.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvAnexoDetalle.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvAnexoDetalle.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvAnexoDetalle.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvAnexoDetalle.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvAnexoDetalle.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvAnexoDetalle.Appearance.VertLine.Options.UseBackColor = true;
            this.gvAnexoDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn8,
            this.gridColumn2,
            this.gridColumn9,
            this.gridColumnDescripcion,
            this.gridColumn4,
            this.gridColumnCantidadMin,
            this.gridColumnCantidadMax});
            this.gvAnexoDetalle.GridControl = this.gcAnexoDetalle;
            this.gvAnexoDetalle.Name = "gvAnexoDetalle";
            this.gvAnexoDetalle.NewItemRowText = "Clck aqui para agregar un nuevo registro";
            this.gvAnexoDetalle.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvAnexoDetalle.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvAnexoDetalle.OptionsCustomization.AllowColumnMoving = false;
            this.gvAnexoDetalle.OptionsCustomization.AllowSort = false;
            this.gvAnexoDetalle.OptionsView.ColumnAutoWidth = false;
            this.gvAnexoDetalle.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAnexoDetalle.OptionsView.EnableAppearanceOddRow = true;
            this.gvAnexoDetalle.OptionsView.ShowAutoFilterRow = true;
            this.gvAnexoDetalle.OptionsView.ShowGroupPanel = false;
            this.gvAnexoDetalle.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.DgvAnexoCellValueChanged);
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Renglon";
            this.gridColumn8.FieldName = "RenglonAnexo";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Articulo";
            this.gridColumn2.FieldName = "Articulo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Articulo";
            this.gridColumn9.FieldName = "CveArt";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            // 
            // gridColumnDescripcion
            // 
            this.gridColumnDescripcion.Caption = "Descripcion";
            this.gridColumnDescripcion.FieldName = "DescripcionArt";
            this.gridColumnDescripcion.Name = "gridColumnDescripcion";
            this.gridColumnDescripcion.OptionsColumn.AllowEdit = false;
            this.gridColumnDescripcion.OptionsColumn.ReadOnly = true;
            this.gridColumnDescripcion.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumnDescripcion.Visible = true;
            this.gridColumnDescripcion.VisibleIndex = 2;
            this.gridColumnDescripcion.Width = 477;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Unidad";
            this.gridColumn4.FieldName = "UnidadArt";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 197;
            // 
            // gridColumnCantidadMin
            // 
            this.gridColumnCantidadMin.Caption = "Cantidad Min";
            this.gridColumnCantidadMin.DisplayFormat.FormatString = "d0";
            this.gridColumnCantidadMin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCantidadMin.FieldName = "CantidadMinimo";
            this.gridColumnCantidadMin.Name = "gridColumnCantidadMin";
            this.gridColumnCantidadMin.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnCantidadMin.Visible = true;
            this.gridColumnCantidadMin.VisibleIndex = 4;
            this.gridColumnCantidadMin.Width = 96;
            // 
            // gridColumnCantidadMax
            // 
            this.gridColumnCantidadMax.Caption = "Cantidad Max";
            this.gridColumnCantidadMax.FieldName = "CantidadMaximo";
            this.gridColumnCantidadMax.Name = "gridColumnCantidadMax";
            this.gridColumnCantidadMax.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnCantidadMax.Visible = true;
            this.gridColumnCantidadMax.VisibleIndex = 5;
            this.gridColumnCantidadMax.Width = 83;
            // 
            // repositoryItemSearchLookUpEdit2
            // 
            this.repositoryItemSearchLookUpEdit2.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit2.Name = "repositoryItemSearchLookUpEdit2";
            this.repositoryItemSearchLookUpEdit2.NullText = "";
            this.repositoryItemSearchLookUpEdit2.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn6,
            this.gridColumn7});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Clave";
            this.gridColumn3.FieldName = "CveArt";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 71;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Descripcion";
            this.gridColumn6.FieldName = "Descripcion";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 604;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Unidad";
            this.gridColumn7.FieldName = "Unidad";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 177;
            // 
            // gridColumnArticulo
            // 
            this.gridColumnArticulo.Caption = "Articulo";
            this.gridColumnArticulo.FieldName = "CveArt";
            this.gridColumnArticulo.Name = "gridColumnArticulo";
            this.gridColumnArticulo.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.gridColumnArticulo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumnArticulo.Visible = true;
            this.gridColumnArticulo.VisibleIndex = 0;
            this.gridColumnArticulo.Width = 84;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmModuloAnexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 693);
            this.Name = "FrmModuloAnexo";
            this.Text = "Captura::Anexo";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosGenerales)).EndInit();
            this.gcDatosGenerales.ResumeLayout(false);
            this.gcDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpPartida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPartida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditPartida)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumlicitacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesanexo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTechopresupuestal.Properties)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAnexoDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexoDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnexoDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcDatosGenerales;
        private DevExpress.XtraEditors.TextEdit txtnumlicitacion;
        private System.Windows.Forms.ComboBox cbxIva;
        private System.Windows.Forms.ComboBox cbxTipolicitacion;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CalcEdit txtTechopresupuestal;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtDesanexo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcAnexoDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAnexoDetalle;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCantidadMin;
        private System.Windows.Forms.BindingSource bsAnexo;
        private System.Windows.Forms.BindingSource bsAnexoDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCantidadMax;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.SimpleButton cmdCargar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpPartida;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEditPartida;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private System.Windows.Forms.BindingSource bsPartida;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rbContratoAbierto;
        private System.Windows.Forms.RadioButton rbContratoCerrado;
    }
}