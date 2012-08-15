namespace Adquisiciones.View.Modulos
{
    partial class FrmModuloCotizacion
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
            this.lblProveedor = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInstituto = new DevExpress.XtraEditors.LabelControl();
            this.lblDesLicitacion = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpProv = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bsProveedor = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEditProv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.searchLookUpAnexo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bsAnexos = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEditAnexo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label45 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechacotizacion = new DevExpress.XtraEditors.DateEdit();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblLicitacion = new System.Windows.Forms.Label();
            this.gcCotizacionDetalle = new DevExpress.XtraGrid.GridControl();
            this.bsCotizacionDetalle = new System.Windows.Forms.BindingSource(this.components);
            this.gvCotizacionDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosGenerales)).BeginInit();
            this.gcDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpAnexo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditAnexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechacotizacion.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechacotizacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCotizacionDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCotizacionDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCotizacionDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 70);
            this.splitContainerControl1.Panel1.Controls.Add(this.gcDatosGenerales);
            this.splitContainerControl1.Panel2.Controls.Add(this.gcCotizacionDetalle);
            this.splitContainerControl1.Size = new System.Drawing.Size(1130, 330);
            this.splitContainerControl1.SplitterPosition = 167;
            // 
            // gcDatosGenerales
            // 
            this.gcDatosGenerales.Controls.Add(this.lblProveedor);
            this.gcDatosGenerales.Controls.Add(this.label3);
            this.gcDatosGenerales.Controls.Add(this.lblInstituto);
            this.gcDatosGenerales.Controls.Add(this.lblDesLicitacion);
            this.gcDatosGenerales.Controls.Add(this.searchLookUpProv);
            this.gcDatosGenerales.Controls.Add(this.searchLookUpAnexo);
            this.gcDatosGenerales.Controls.Add(this.label45);
            this.gcDatosGenerales.Controls.Add(this.label2);
            this.gcDatosGenerales.Controls.Add(this.label1);
            this.gcDatosGenerales.Controls.Add(this.dtpFechacotizacion);
            this.gcDatosGenerales.Controls.Add(this.lblFecha);
            this.gcDatosGenerales.Controls.Add(this.lblLicitacion);
            this.gcDatosGenerales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDatosGenerales.Location = new System.Drawing.Point(0, 0);
            this.gcDatosGenerales.Name = "gcDatosGenerales";
            this.gcDatosGenerales.Size = new System.Drawing.Size(1130, 167);
            this.gcDatosGenerales.TabIndex = 9;
            this.gcDatosGenerales.Text = "Datos Generales";
            // 
            // lblProveedor
            // 
            this.lblProveedor.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblProveedor.Location = new System.Drawing.Point(121, 135);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(148, 16);
            this.lblProveedor.TabIndex = 29;
            this.lblProveedor.Text = "                                     ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Descripcion Proveedor";
            // 
            // lblInstituto
            // 
            this.lblInstituto.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstituto.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblInstituto.Location = new System.Drawing.Point(475, 70);
            this.lblInstituto.Name = "lblInstituto";
            this.lblInstituto.Size = new System.Drawing.Size(160, 16);
            this.lblInstituto.TabIndex = 27;
            this.lblInstituto.Text = "                                        ";
            // 
            // lblDesLicitacion
            // 
            this.lblDesLicitacion.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesLicitacion.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDesLicitacion.Location = new System.Drawing.Point(121, 70);
            this.lblDesLicitacion.Name = "lblDesLicitacion";
            this.lblDesLicitacion.Size = new System.Drawing.Size(148, 16);
            this.lblDesLicitacion.TabIndex = 26;
            this.lblDesLicitacion.Text = "                                     ";
            // 
            // searchLookUpProv
            // 
            this.searchLookUpProv.EditValue = "";
            this.searchLookUpProv.Location = new System.Drawing.Point(121, 98);
            this.searchLookUpProv.Name = "searchLookUpProv";
            this.searchLookUpProv.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.searchLookUpProv.Properties.Appearance.Options.UseForeColor = true;
            this.searchLookUpProv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpProv.Properties.DataSource = this.bsProveedor;
            this.searchLookUpProv.Properties.DisplayMember = "NombreFiscal";
            this.searchLookUpProv.Properties.NullText = "";
            this.searchLookUpProv.Properties.ValueMember = "CveProveedor";
            this.searchLookUpProv.Properties.View = this.searchLookUpEditProv;
            this.searchLookUpProv.Size = new System.Drawing.Size(368, 20);
            this.searchLookUpProv.TabIndex = 3;
            this.searchLookUpProv.EditValueChanged += new System.EventHandler(this.SearchLookUpProvEditValueChanged);
            // 
            // searchLookUpEditProv
            // 
            this.searchLookUpEditProv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEditProv.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEditProv.Name = "searchLookUpEditProv";
            this.searchLookUpEditProv.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEditProv.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Clave";
            this.gridColumn1.FieldName = "CveProveedor";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 91;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre Fiscal";
            this.gridColumn2.FieldName = "NombreFiscal";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 699;
            // 
            // searchLookUpAnexo
            // 
            this.searchLookUpAnexo.EditValue = "";
            this.searchLookUpAnexo.Location = new System.Drawing.Point(121, 26);
            this.searchLookUpAnexo.Name = "searchLookUpAnexo";
            this.searchLookUpAnexo.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.searchLookUpAnexo.Properties.Appearance.Options.UseForeColor = true;
            this.searchLookUpAnexo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpAnexo.Properties.DataSource = this.bsAnexos;
            this.searchLookUpAnexo.Properties.DisplayMember = "NumeroAnexo";
            this.searchLookUpAnexo.Properties.NullText = "";
            this.searchLookUpAnexo.Properties.ValueMember = "IdAnexo";
            this.searchLookUpAnexo.Properties.View = this.searchLookUpEditAnexo;
            this.searchLookUpAnexo.Size = new System.Drawing.Size(196, 20);
            this.searchLookUpAnexo.TabIndex = 1;
            this.searchLookUpAnexo.Tag = "";
            this.searchLookUpAnexo.EditValueChanged += new System.EventHandler(this.SearchLookUpAnexoEditValueChanged);
            // 
            // searchLookUpEditAnexo
            // 
            this.searchLookUpEditAnexo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.searchLookUpEditAnexo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEditAnexo.Name = "searchLookUpEditAnexo";
            this.searchLookUpEditAnexo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEditAnexo.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "IdAnexo";
            this.gridColumn3.FieldName = "IdAnexo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 56;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Numero Anexo";
            this.gridColumn4.FieldName = "NumeroAnexo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 137;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Descripcion";
            this.gridColumn5.FieldName = "DesAnexo";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 597;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(5, 105);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(57, 13);
            this.label45.TabIndex = 23;
            this.label45.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Instituto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Descripción de Anexo";
            // 
            // dtpFechacotizacion
            // 
            this.dtpFechacotizacion.EditValue = null;
            this.dtpFechacotizacion.Location = new System.Drawing.Point(501, 29);
            this.dtpFechacotizacion.Name = "dtpFechacotizacion";
            this.dtpFechacotizacion.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.dtpFechacotizacion.Properties.Appearance.Options.UseForeColor = true;
            this.dtpFechacotizacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechacotizacion.Properties.LookAndFeel.SkinName = "Blue";
            this.dtpFechacotizacion.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpFechacotizacion.Size = new System.Drawing.Size(100, 20);
            this.dtpFechacotizacion.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(401, 32);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(88, 13);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "Fecha Cotizacion";
            // 
            // lblLicitacion
            // 
            this.lblLicitacion.AutoSize = true;
            this.lblLicitacion.Location = new System.Drawing.Point(5, 34);
            this.lblLicitacion.Name = "lblLicitacion";
            this.lblLicitacion.Size = new System.Drawing.Size(38, 13);
            this.lblLicitacion.TabIndex = 1;
            this.lblLicitacion.Text = "Anexo";
            // 
            // gcCotizacionDetalle
            // 
            this.gcCotizacionDetalle.DataSource = this.bsCotizacionDetalle;
            this.gcCotizacionDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCotizacionDetalle.Location = new System.Drawing.Point(0, 0);
            this.gcCotizacionDetalle.MainView = this.gvCotizacionDetalle;
            this.gcCotizacionDetalle.Name = "gcCotizacionDetalle";
            this.gcCotizacionDetalle.Size = new System.Drawing.Size(1130, 158);
            this.gcCotizacionDetalle.TabIndex = 4;
            this.gcCotizacionDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCotizacionDetalle});
            this.gcCotizacionDetalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GvAnexoDetalleKeyDown);
            // 
            // gvCotizacionDetalle
            // 
            this.gvCotizacionDetalle.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCotizacionDetalle.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCotizacionDetalle.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCotizacionDetalle.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvCotizacionDetalle.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCotizacionDetalle.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvCotizacionDetalle.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvCotizacionDetalle.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvCotizacionDetalle.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvCotizacionDetalle.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvCotizacionDetalle.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCotizacionDetalle.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvCotizacionDetalle.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvCotizacionDetalle.Appearance.Empty.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvCotizacionDetalle.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvCotizacionDetalle.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCotizacionDetalle.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCotizacionDetalle.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCotizacionDetalle.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvCotizacionDetalle.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCotizacionDetalle.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvCotizacionDetalle.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvCotizacionDetalle.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvCotizacionDetalle.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvCotizacionDetalle.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvCotizacionDetalle.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvCotizacionDetalle.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvCotizacionDetalle.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvCotizacionDetalle.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCotizacionDetalle.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCotizacionDetalle.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCotizacionDetalle.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCotizacionDetalle.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCotizacionDetalle.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvCotizacionDetalle.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCotizacionDetalle.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCotizacionDetalle.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvCotizacionDetalle.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvCotizacionDetalle.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCotizacionDetalle.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCotizacionDetalle.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvCotizacionDetalle.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvCotizacionDetalle.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvCotizacionDetalle.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCotizacionDetalle.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCotizacionDetalle.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCotizacionDetalle.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvCotizacionDetalle.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvCotizacionDetalle.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvCotizacionDetalle.Appearance.GroupRow.Options.UseFont = true;
            this.gvCotizacionDetalle.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCotizacionDetalle.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCotizacionDetalle.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCotizacionDetalle.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCotizacionDetalle.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCotizacionDetalle.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvCotizacionDetalle.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvCotizacionDetalle.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvCotizacionDetalle.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvCotizacionDetalle.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvCotizacionDetalle.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvCotizacionDetalle.Appearance.OddRow.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.OddRow.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvCotizacionDetalle.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvCotizacionDetalle.Appearance.Preview.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.Preview.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvCotizacionDetalle.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvCotizacionDetalle.Appearance.Row.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.Row.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvCotizacionDetalle.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvCotizacionDetalle.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvCotizacionDetalle.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvCotizacionDetalle.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvCotizacionDetalle.Appearance.VertLine.Options.UseBackColor = true;
            this.gvCotizacionDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13});
            this.gvCotizacionDetalle.GridControl = this.gcCotizacionDetalle;
            this.gvCotizacionDetalle.Name = "gvCotizacionDetalle";
            this.gvCotizacionDetalle.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvCotizacionDetalle.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvCotizacionDetalle.OptionsView.ColumnAutoWidth = false;
            this.gvCotizacionDetalle.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCotizacionDetalle.OptionsView.EnableAppearanceOddRow = true;
            this.gvCotizacionDetalle.OptionsView.ShowAutoFilterRow = true;
            this.gvCotizacionDetalle.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Articulo";
            this.gridColumn7.FieldName = "CveArt";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 55;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Descripcion";
            this.gridColumn8.FieldName = "DescripcionArt";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 145;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Presentacion";
            this.gridColumn9.FieldName = "PresentacionArt";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            this.gridColumn9.Width = 129;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Cantidad";
            this.gridColumn10.DisplayFormat.FormatString = "0";
            this.gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn10.FieldName = "Cantidad";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            this.gridColumn10.Width = 64;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Precio Unitario";
            this.gridColumn11.DisplayFormat.FormatString = "c2";
            this.gridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn11.FieldName = "Precio";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 4;
            this.gridColumn11.Width = 91;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Marca";
            this.gridColumn12.FieldName = "Marca";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 5;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Observaciones";
            this.gridColumn13.FieldName = "Observaciones";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 6;
            this.gridColumn13.Width = 199;
            // 
            // FrmModuloCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 423);
            this.Name = "FrmModuloCotizacion";
            this.Text = "Captura::Cotizacion";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosGenerales)).EndInit();
            this.gcDatosGenerales.ResumeLayout(false);
            this.gcDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpAnexo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditAnexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechacotizacion.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechacotizacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCotizacionDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCotizacionDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCotizacionDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcDatosGenerales;
        private DevExpress.XtraEditors.LabelControl lblProveedor;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LabelControl lblInstituto;
        private DevExpress.XtraEditors.LabelControl lblDesLicitacion;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpProv;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEditProv;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpAnexo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEditAnexo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dtpFechacotizacion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblLicitacion;
        private DevExpress.XtraGrid.GridControl gcCotizacionDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCotizacionDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private System.Windows.Forms.BindingSource bsCotizacionDetalle;
        private System.Windows.Forms.BindingSource bsProveedor;
        private System.Windows.Forms.BindingSource bsAnexos;
    }
}