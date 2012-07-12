namespace Adquisiciones.View
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
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.bsAnexoDetalle = new System.Windows.Forms.BindingSource(this.components);
            this.bsAnexo = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtpFechaanexo = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDesanexo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTechopresupuestal = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.gcDatosGenerales = new DevExpress.XtraEditors.GroupControl();
            this.txtnumlicitacion = new DevExpress.XtraEditors.TextEdit();
            this.cbxIva = new System.Windows.Forms.ComboBox();
            this.cbxTipolicitacion = new System.Windows.Forms.ComboBox();
            this.cbxInstituto = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.gvAnexoDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAnexoDetalle = new DevExpress.XtraGrid.GridControl();
            this.lblNumErrors = new System.Windows.Forms.Label();
            this.listaError = new System.Windows.Forms.ListBox();
            this.btnConsultar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexoDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaanexo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaanexo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesanexo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTechopresupuestal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosGenerales)).BeginInit();
            this.gcDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumlicitacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnexoDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAnexoDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.DisplayMember = "CveArt";
            this.repositoryItemSearchLookUpEdit1.LookAndFeel.SkinName = "Money Twins";
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.NullText = "";
            this.repositoryItemSearchLookUpEdit1.ValueMember = "CveArt";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Licitacion";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(283, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Fecha";
            // 
            // dtpFechaanexo
            // 
            this.dtpFechaanexo.EditValue = null;
            this.dtpFechaanexo.Location = new System.Drawing.Point(321, 30);
            this.dtpFechaanexo.Name = "dtpFechaanexo";
            this.dtpFechaanexo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaanexo.Properties.LookAndFeel.SkinName = "Blue";
            this.dtpFechaanexo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpFechaanexo.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaanexo.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(433, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Instituto";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 57);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Descripcion";
            // 
            // txtDesanexo
            // 
            this.txtDesanexo.Location = new System.Drawing.Point(83, 57);
            this.txtDesanexo.Name = "txtDesanexo";
            this.txtDesanexo.Properties.LookAndFeel.SkinName = "Blue";
            this.txtDesanexo.Size = new System.Drawing.Size(344, 20);
            this.txtDesanexo.TabIndex = 7;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 93);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Tipo Licitacion";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(227, 93);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(94, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Techo Presupuestal";
            // 
            // txtTechopresupuestal
            // 
            this.txtTechopresupuestal.Location = new System.Drawing.Point(327, 90);
            this.txtTechopresupuestal.Name = "txtTechopresupuestal";
            this.txtTechopresupuestal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTechopresupuestal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtTechopresupuestal.Properties.LookAndFeel.SkinName = "Blue";
            this.txtTechopresupuestal.Size = new System.Drawing.Size(100, 20);
            this.txtTechopresupuestal.TabIndex = 11;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(445, 93);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(31, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "% IVA";
            // 
            // gcDatosGenerales
            // 
            this.gcDatosGenerales.Controls.Add(this.txtnumlicitacion);
            this.gcDatosGenerales.Controls.Add(this.cbxIva);
            this.gcDatosGenerales.Controls.Add(this.cbxTipolicitacion);
            this.gcDatosGenerales.Controls.Add(this.cbxInstituto);
            this.gcDatosGenerales.Controls.Add(this.labelControl7);
            this.gcDatosGenerales.Controls.Add(this.txtTechopresupuestal);
            this.gcDatosGenerales.Controls.Add(this.labelControl6);
            this.gcDatosGenerales.Controls.Add(this.labelControl5);
            this.gcDatosGenerales.Controls.Add(this.txtDesanexo);
            this.gcDatosGenerales.Controls.Add(this.labelControl4);
            this.gcDatosGenerales.Controls.Add(this.labelControl3);
            this.gcDatosGenerales.Controls.Add(this.dtpFechaanexo);
            this.gcDatosGenerales.Controls.Add(this.labelControl2);
            this.gcDatosGenerales.Controls.Add(this.labelControl1);
            this.gcDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDatosGenerales.Location = new System.Drawing.Point(0, 0);
            this.gcDatosGenerales.Name = "gcDatosGenerales";
            this.gcDatosGenerales.Size = new System.Drawing.Size(802, 123);
            this.gcDatosGenerales.TabIndex = 0;
            this.gcDatosGenerales.Text = "Datos Generales";
            // 
            // txtnumlicitacion
            // 
            this.txtnumlicitacion.Location = new System.Drawing.Point(83, 32);
            this.txtnumlicitacion.Name = "txtnumlicitacion";
            this.txtnumlicitacion.Size = new System.Drawing.Size(194, 20);
            this.txtnumlicitacion.TabIndex = 16;
            // 
            // cbxIva
            // 
            this.cbxIva.FormattingEnabled = true;
            this.cbxIva.Location = new System.Drawing.Point(489, 90);
            this.cbxIva.Name = "cbxIva";
            this.cbxIva.Size = new System.Drawing.Size(121, 21);
            this.cbxIva.TabIndex = 15;
            // 
            // cbxTipolicitacion
            // 
            this.cbxTipolicitacion.FormattingEnabled = true;
            this.cbxTipolicitacion.Location = new System.Drawing.Point(86, 90);
            this.cbxTipolicitacion.Name = "cbxTipolicitacion";
            this.cbxTipolicitacion.Size = new System.Drawing.Size(121, 21);
            this.cbxTipolicitacion.TabIndex = 14;
            // 
            // cbxInstituto
            // 
            this.cbxInstituto.FormattingEnabled = true;
            this.cbxInstituto.Location = new System.Drawing.Point(485, 28);
            this.cbxInstituto.Name = "cbxInstituto";
            this.cbxInstituto.Size = new System.Drawing.Size(121, 21);
            this.cbxInstituto.TabIndex = 13;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Image = global::Adquisiciones.View.Properties.Resources.reportes;
            this.btnNuevo.Location = new System.Drawing.Point(498, 607);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(115, 68);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.Image = global::Adquisiciones.View.Properties.Resources.save_icon;
            this.btnGuardar.Location = new System.Drawing.Point(625, 607);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 68);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
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
            this.gridColumnArticulo,
            this.gridColumnDescripcion,
            this.gridColumn4,
            this.gridColumn5});
            this.gvAnexoDetalle.GridControl = this.gcAnexoDetalle;
            this.gvAnexoDetalle.Name = "gvAnexoDetalle";
            this.gvAnexoDetalle.NewItemRowText = "Clck aqui para agregar un nuevo registro";
            this.gvAnexoDetalle.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvAnexoDetalle.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvAnexoDetalle.OptionsView.ColumnAutoWidth = false;
            this.gvAnexoDetalle.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAnexoDetalle.OptionsView.EnableAppearanceOddRow = true;
            this.gvAnexoDetalle.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvAnexoDetalle.OptionsView.ShowAutoFilterRow = true;
            this.gvAnexoDetalle.OptionsView.ShowGroupPanel = false;
            this.gvAnexoDetalle.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn4, DevExpress.Data.ColumnSortOrder.Descending)});
            
            this.gvAnexoDetalle.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.DgvAnexoCellValueChanged);
            this.gvAnexoDetalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GvAnexoDetalleKeyDown);
            // 
            // gridColumnArticulo
            // 
            this.gridColumnArticulo.Caption = "Articulo";
            this.gridColumnArticulo.ColumnEdit = this.repositoryItemSearchLookUpEdit2;
            this.gridColumnArticulo.FieldName = "CveArt";
            this.gridColumnArticulo.Name = "gridColumnArticulo";
            this.gridColumnArticulo.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumnArticulo.Visible = true;
            this.gridColumnArticulo.VisibleIndex = 0;
            this.gridColumnArticulo.Width = 84;
            // 
            // repositoryItemSearchLookUpEdit2
            // 
            this.repositoryItemSearchLookUpEdit2.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit2.Name = "repositoryItemSearchLookUpEdit2";
            this.repositoryItemSearchLookUpEdit2.NullText = "";
            this.repositoryItemSearchLookUpEdit2.View = this.repositoryItemSearchLookUpEdit2View;
            // 
            // repositoryItemSearchLookUpEdit2View
            // 
            this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
            this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
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
            this.gridColumnDescripcion.VisibleIndex = 1;
            this.gridColumnDescripcion.Width = 153;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "PresentacionArt";
            this.gridColumn4.FieldName = "PresentacionArt";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 197;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cantidad";
            this.gridColumn5.DisplayFormat.FormatString = "d0";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "Cantidad";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 84;
            // 
            // gcAnexoDetalle
            // 
            this.gcAnexoDetalle.DataSource = this.bsAnexoDetalle;
            this.gcAnexoDetalle.Location = new System.Drawing.Point(15, 143);
            this.gcAnexoDetalle.MainView = this.gvAnexoDetalle;
            this.gcAnexoDetalle.Name = "gcAnexoDetalle";
            this.gcAnexoDetalle.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit2});
            this.gcAnexoDetalle.Size = new System.Drawing.Size(749, 281);
            this.gcAnexoDetalle.TabIndex = 1;
            this.gcAnexoDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAnexoDetalle});
            // 
            // lblNumErrors
            // 
            this.lblNumErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumErrors.AutoSize = true;
            this.lblNumErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumErrors.Location = new System.Drawing.Point(38, 591);
            this.lblNumErrors.Name = "lblNumErrors";
            this.lblNumErrors.Size = new System.Drawing.Size(58, 13);
            this.lblNumErrors.TabIndex = 108;
            this.lblNumErrors.Text = "0 Errores";
            // 
            // listaError
            // 
            this.listaError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaError.ForeColor = System.Drawing.Color.Red;
            this.listaError.FormattingEnabled = true;
            this.listaError.ItemHeight = 16;
            this.listaError.Location = new System.Drawing.Point(35, 607);
            this.listaError.Name = "listaError";
            this.listaError.Size = new System.Drawing.Size(318, 68);
            this.listaError.TabIndex = 107;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConsultar.Image = global::Adquisiciones.View.Properties.Resources.busqueda;
            this.btnConsultar.Location = new System.Drawing.Point(377, 607);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(115, 68);
            this.btnConsultar.TabIndex = 115;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.BtnRefrescarClick);
            // 
            // FrmModuloAnexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 702);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblNumErrors);
            this.Controls.Add(this.listaError);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gcAnexoDetalle);
            this.Controls.Add(this.gcDatosGenerales);
            this.Name = "FrmModuloAnexo";
            this.Text = "Captura::Anexo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAnexoDevLoad);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexoDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaanexo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaanexo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesanexo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTechopresupuestal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDatosGenerales)).EndInit();
            this.gcDatosGenerales.ResumeLayout(false);
            this.gcDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumlicitacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAnexoDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAnexoDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsAnexo;
        private System.Windows.Forms.BindingSource bsAnexoDetalle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtpFechaanexo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDesanexo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CalcEdit txtTechopresupuestal;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.GroupControl gcDatosGenerales;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit articuloSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private System.Windows.Forms.ComboBox cbxIva;
        private System.Windows.Forms.ComboBox cbxTipolicitacion;
        private System.Windows.Forms.ComboBox cbxInstituto;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAnexoDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.GridControl gcAnexoDetalle;
        private System.Windows.Forms.Label lblNumErrors;
        private System.Windows.Forms.ListBox listaError;
        private DevExpress.XtraEditors.TextEdit txtnumlicitacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        private DevExpress.XtraEditors.SimpleButton btnConsultar;
    }
}