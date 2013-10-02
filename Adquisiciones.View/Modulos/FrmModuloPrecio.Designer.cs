namespace Adquisiciones.View.Modulos
{
    partial class FrmModuloPrecio
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
            this.gcPrecioDetalle = new DevExpress.XtraGrid.GridControl();
            this.bsPrecioDetalle = new System.Windows.Forms.BindingSource(this.components);
            this.gvPrecioDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtClave = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPartida = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrese = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtPreseCant = new DevExpress.XtraEditors.LabelControl();
            this.txtPreseUnid = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrecioDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrecioDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrecioDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.txtPreseUnid);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtPreseCant);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtPrese);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtDescripcion);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtPartida);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtClave);
            this.splitContainerControl1.Panel2.Controls.Add(this.gcPrecioDetalle);
            this.splitContainerControl1.Size = new System.Drawing.Size(843, 584);
            this.splitContainerControl1.SplitterPosition = 123;
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.Location = new System.Drawing.Point(599, 11);
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.Location = new System.Drawing.Point(666, 3);
            // 
            // gcPrecioDetalle
            // 
            this.gcPrecioDetalle.DataSource = this.bsPrecioDetalle;
            this.gcPrecioDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPrecioDetalle.Location = new System.Drawing.Point(0, 0);
            this.gcPrecioDetalle.MainView = this.gvPrecioDetalle;
            this.gcPrecioDetalle.Name = "gcPrecioDetalle";
            this.gcPrecioDetalle.Size = new System.Drawing.Size(843, 455);
            this.gcPrecioDetalle.TabIndex = 9;
            this.gcPrecioDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrecioDetalle});
            // 
            // gvPrecioDetalle
            // 
            this.gvPrecioDetalle.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPrecioDetalle.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvPrecioDetalle.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPrecioDetalle.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvPrecioDetalle.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPrecioDetalle.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvPrecioDetalle.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvPrecioDetalle.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvPrecioDetalle.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvPrecioDetalle.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvPrecioDetalle.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPrecioDetalle.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvPrecioDetalle.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvPrecioDetalle.Appearance.Empty.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvPrecioDetalle.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvPrecioDetalle.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPrecioDetalle.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvPrecioDetalle.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPrecioDetalle.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvPrecioDetalle.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPrecioDetalle.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvPrecioDetalle.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvPrecioDetalle.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvPrecioDetalle.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvPrecioDetalle.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvPrecioDetalle.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvPrecioDetalle.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvPrecioDetalle.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvPrecioDetalle.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPrecioDetalle.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvPrecioDetalle.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPrecioDetalle.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPrecioDetalle.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPrecioDetalle.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvPrecioDetalle.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPrecioDetalle.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPrecioDetalle.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvPrecioDetalle.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvPrecioDetalle.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPrecioDetalle.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPrecioDetalle.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvPrecioDetalle.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvPrecioDetalle.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvPrecioDetalle.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPrecioDetalle.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPrecioDetalle.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPrecioDetalle.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvPrecioDetalle.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvPrecioDetalle.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvPrecioDetalle.Appearance.GroupRow.Options.UseFont = true;
            this.gvPrecioDetalle.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPrecioDetalle.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvPrecioDetalle.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPrecioDetalle.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPrecioDetalle.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPrecioDetalle.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPrecioDetalle.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvPrecioDetalle.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvPrecioDetalle.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvPrecioDetalle.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvPrecioDetalle.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvPrecioDetalle.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.OddRow.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvPrecioDetalle.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvPrecioDetalle.Appearance.Preview.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.Preview.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvPrecioDetalle.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvPrecioDetalle.Appearance.Row.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.Row.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvPrecioDetalle.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvPrecioDetalle.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvPrecioDetalle.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPrecioDetalle.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPrecioDetalle.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvPrecioDetalle.Appearance.VertLine.Options.UseBackColor = true;
            this.gvPrecioDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvPrecioDetalle.GridControl = this.gcPrecioDetalle;
            this.gvPrecioDetalle.Name = "gvPrecioDetalle";
            this.gvPrecioDetalle.NewItemRowText = "Clck aqui para agregar un nuevo registro";
            this.gvPrecioDetalle.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvPrecioDetalle.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvPrecioDetalle.OptionsBehavior.Editable = false;
            this.gvPrecioDetalle.OptionsCustomization.AllowColumnMoving = false;
            this.gvPrecioDetalle.OptionsCustomization.AllowSort = false;
            this.gvPrecioDetalle.OptionsView.ColumnAutoWidth = false;
            this.gvPrecioDetalle.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPrecioDetalle.OptionsView.EnableAppearanceOddRow = true;
            this.gvPrecioDetalle.OptionsView.ShowAutoFilterRow = true;
            this.gvPrecioDetalle.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Fecha";
            this.gridColumn1.FieldName = "FechaPedido";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Costo";
            this.gridColumn2.DisplayFormat.FormatString = "c4";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "Costo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 84;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Marca";
            this.gridColumn3.FieldName = "Marca";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 100;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Proveedor";
            this.gridColumn4.FieldName = "Proveedor";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 566;
            // 
            // txtClave
            // 
            this.txtClave.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtClave.Location = new System.Drawing.Point(63, 28);
            this.txtClave.Name = "txtClave";
            this.txtClave.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtClave.Properties.Mask.EditMask = "n0";
            this.txtClave.Size = new System.Drawing.Size(78, 20);
            this.txtClave.TabIndex = 10;
            this.txtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClave_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(192, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 16);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Partida";
            // 
            // txtPartida
            // 
            this.txtPartida.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartida.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtPartida.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtPartida.Location = new System.Drawing.Point(245, 29);
            this.txtPartida.Name = "txtPartida";
            this.txtPartida.Size = new System.Drawing.Size(7, 17);
            this.txtPartida.TabIndex = 12;
            this.txtPartida.Text = ".";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(22, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 16);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Clave";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtDescripcion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtDescripcion.Location = new System.Drawing.Point(22, 53);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(7, 17);
            this.txtDescripcion.TabIndex = 14;
            this.txtDescripcion.Text = ".";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(22, 90);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 16);
            this.labelControl5.TabIndex = 15;
            this.labelControl5.Text = "Prese.";
            // 
            // txtPrese
            // 
            this.txtPrese.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrese.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtPrese.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtPrese.Location = new System.Drawing.Point(69, 89);
            this.txtPrese.Name = "txtPrese";
            this.txtPrese.Size = new System.Drawing.Size(7, 17);
            this.txtPrese.TabIndex = 16;
            this.txtPrese.Text = ".";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(192, 89);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(15, 16);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "c/";
            // 
            // txtPreseCant
            // 
            this.txtPreseCant.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreseCant.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtPreseCant.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtPreseCant.Location = new System.Drawing.Point(213, 90);
            this.txtPreseCant.Name = "txtPreseCant";
            this.txtPreseCant.Size = new System.Drawing.Size(7, 17);
            this.txtPreseCant.TabIndex = 18;
            this.txtPreseCant.Text = ".";
            // 
            // txtPreseUnid
            // 
            this.txtPreseUnid.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreseUnid.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtPreseUnid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtPreseUnid.Location = new System.Drawing.Point(256, 90);
            this.txtPreseUnid.Name = "txtPreseUnid";
            this.txtPreseUnid.Size = new System.Drawing.Size(7, 17);
            this.txtPreseUnid.TabIndex = 19;
            this.txtPreseUnid.Text = ".";
            // 
            // FrmModuloPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 674);
            this.Name = "FrmModuloPrecio";
            this.Text = "Busqueda::Precio";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPrecioDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrecioDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrecioDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClave.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPrecioDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrecioDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.BindingSource bsPrecioDetalle;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl txtPartida;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit txtClave;
        private DevExpress.XtraEditors.LabelControl txtPreseUnid;
        private DevExpress.XtraEditors.LabelControl txtPreseCant;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl txtPrese;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl txtDescripcion;
    }
}