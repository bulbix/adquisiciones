﻿namespace Adquisiciones.View.Modulos
{
    partial class FrmModuloLicitaPedido
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
            this.cbxActividad = new System.Windows.Forms.ComboBox();
            this.cbxIva = new System.Windows.Forms.ComboBox();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.lblLicitacion = new DevExpress.XtraEditors.LabelControl();
            this.lblArea = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpFundamento = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bsFundamento = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEditFundamento = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.deFechaFinal = new DevExpress.XtraEditors.DateEdit();
            this.deFechaInicial = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.searchLookUpRequisicion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bsRequisicion = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEditRequisicion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.bsPedido = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpFundamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFundamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditFundamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpRequisicion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequisicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditRequisicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedido)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 70);
            this.splitContainerControl1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtObservaciones);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl11);
            this.splitContainerControl1.Size = new System.Drawing.Size(941, 489);
            this.splitContainerControl1.SplitterPosition = 480;
            // 
            // lblAlmacen
            // 
            this.lblAlmacen.Location = new System.Drawing.Point(133, 11);
            // 
            // cbxAlmacen
            // 
            this.cbxAlmacen.Location = new System.Drawing.Point(200, 6);
            // 
            // cbxActividad
            // 
            this.cbxActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxActividad.FormattingEnabled = true;
            this.cbxActividad.Location = new System.Drawing.Point(121, 192);
            this.cbxActividad.Name = "cbxActividad";
            this.cbxActividad.Size = new System.Drawing.Size(253, 21);
            this.cbxActividad.TabIndex = 6;
            // 
            // cbxIva
            // 
            this.cbxIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIva.FormattingEnabled = true;
            this.cbxIva.Location = new System.Drawing.Point(121, 260);
            this.cbxIva.Name = "cbxIva";
            this.cbxIva.Size = new System.Drawing.Size(121, 21);
            this.cbxIva.TabIndex = 7;
            // 
            // cbxCargo
            // 
            this.cbxCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Location = new System.Drawing.Point(121, 295);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(224, 21);
            this.cbxCargo.TabIndex = 8;
            // 
            // lblLicitacion
            // 
            this.lblLicitacion.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicitacion.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblLicitacion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblLicitacion.Location = new System.Drawing.Point(121, 80);
            this.lblLicitacion.Name = "lblLicitacion";
            this.lblLicitacion.Size = new System.Drawing.Size(93, 16);
            this.lblLicitacion.TabIndex = 54;
            this.lblLicitacion.Text = "labelControl12";
            // 
            // lblArea
            // 
            this.lblArea.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblArea.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblArea.Location = new System.Drawing.Point(121, 39);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(93, 16);
            this.lblArea.TabIndex = 53;
            this.lblArea.Text = "labelControl11";// 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(3, 260);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(21, 13);
            this.labelControl10.TabIndex = 52;
            this.labelControl10.Text = "IVA:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(3, 295);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(38, 13);
            this.labelControl9.TabIndex = 51;
            this.labelControl9.Text = "Cargo a";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(3, 192);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 13);
            this.labelControl8.TabIndex = 50;
            this.labelControl8.Text = "Actividad";
            // 
            // searchLookUpFundamento
            // 
            this.searchLookUpFundamento.Location = new System.Drawing.Point(121, 156);
            this.searchLookUpFundamento.Name = "searchLookUpFundamento";
            this.searchLookUpFundamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpFundamento.Properties.DataSource = this.bsFundamento;
            this.searchLookUpFundamento.Properties.DisplayMember = "DesFundamento";
            this.searchLookUpFundamento.Properties.NullText = "";
            this.searchLookUpFundamento.Properties.ValueMember = "CveFundamento";
            this.searchLookUpFundamento.Properties.View = this.searchLookUpEditFundamento;
            this.searchLookUpFundamento.Size = new System.Drawing.Size(621, 20);
            this.searchLookUpFundamento.TabIndex = 5;
            this.searchLookUpFundamento.EditValueChanged += new System.EventHandler(this.SearchLookUpFundamentoEditValueChanged);
            // 
            // searchLookUpEditFundamento
            // 
            this.searchLookUpEditFundamento.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11});
            this.searchLookUpEditFundamento.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEditFundamento.Name = "searchLookUpEditFundamento";
            this.searchLookUpEditFundamento.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEditFundamento.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Clave";
            this.gridColumn10.FieldName = "CveFundamento";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            this.gridColumn10.Width = 87;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Descripcion";
            this.gridColumn11.FieldName = "DesFundamento";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 1;
            this.gridColumn11.Width = 874;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(3, 156);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(92, 13);
            this.labelControl7.TabIndex = 48;
            this.labelControl7.Text = "Fundamento Legal:";
            // 
            // deFechaFinal
            // 
            this.deFechaFinal.EditValue = null;
            this.deFechaFinal.Location = new System.Drawing.Point(157, 3);
            this.deFechaFinal.Name = "deFechaFinal";
            this.deFechaFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFechaFinal.Size = new System.Drawing.Size(156, 20);
            this.deFechaFinal.TabIndex = 4;
            // 
            // deFechaInicial
            // 
            this.deFechaInicial.EditValue = null;
            this.deFechaInicial.Location = new System.Drawing.Point(3, 3);
            this.deFechaInicial.Name = "deFechaInicial";
            this.deFechaInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFechaInicial.Size = new System.Drawing.Size(148, 20);
            this.deFechaInicial.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(3, 229);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(74, 13);
            this.labelControl6.TabIndex = 45;
            this.labelControl6.Text = "Fecha Entrega:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(3, 118);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "Fecha:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(3, 80);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 42;
            this.labelControl4.Text = "Licitacion:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(3, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(27, 13);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "Area:";
            // 
            // searchLookUpRequisicion
            // 
            this.searchLookUpRequisicion.Location = new System.Drawing.Point(121, 3);
            this.searchLookUpRequisicion.Name = "searchLookUpRequisicion";
            this.searchLookUpRequisicion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpRequisicion.Properties.DataSource = this.bsRequisicion;
            this.searchLookUpRequisicion.Properties.DisplayMember = "NumeroRequisicion";
            this.searchLookUpRequisicion.Properties.NullText = "";
            this.searchLookUpRequisicion.Properties.ValueMember = "NumeroRequisicion";
            this.searchLookUpRequisicion.Properties.View = this.searchLookUpEditRequisicion;
            this.searchLookUpRequisicion.Size = new System.Drawing.Size(621, 20);
            this.searchLookUpRequisicion.TabIndex = 1;
            this.searchLookUpRequisicion.EditValueChanged += new System.EventHandler(this.SearchLookUpRequisicionEditValueChanged);
            // 
            // searchLookUpEditRequisicion
            // 
            this.searchLookUpEditRequisicion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn2,
            this.gridColumn4});
            this.searchLookUpEditRequisicion.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEditRequisicion.Name = "searchLookUpEditRequisicion";
            this.searchLookUpEditRequisicion.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEditRequisicion.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "NumeroRequisicion";
            this.gridColumn1.FieldName = "NumeroRequisicion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 114;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Anexo";
            this.gridColumn3.FieldName = "Anexo";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 168;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "FechaRequisicion";
            this.gridColumn2.FieldName = "FechaRequisicion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 336;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Area";
            this.gridColumn4.FieldName = "CatArea";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 343;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 38;
            this.labelControl1.Text = "Requisición";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(358, 367);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(229, 107);
            this.txtObservaciones.TabIndex = 9;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(274, 370);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(71, 13);
            this.labelControl11.TabIndex = 40;
            this.labelControl11.Text = "Observaciones";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.62032F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.37968F));
            this.tableLayoutPanel1.Controls.Add(this.lblFecha, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchLookUpRequisicion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.cbxCargo, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelControl10, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cbxIva, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelControl6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelControl8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbxActividad, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelControl7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.searchLookUpFundamento, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelControl5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblArea, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblLicitacion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.75325F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.24675F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(935, 328);
            this.tableLayoutPanel1.TabIndex = 57;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.deFechaInicial);
            this.flowLayoutPanel1.Controls.Add(this.deFechaFinal);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(121, 229);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(811, 25);
            this.flowLayoutPanel1.TabIndex = 55;
            // 
            // lblFecha
            // 
            this.lblFecha.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFecha.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblFecha.Location = new System.Drawing.Point(121, 118);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(93, 16);
            this.lblFecha.TabIndex = 56;
            this.lblFecha.Text = "labelControl12";
            // 
            // FrmModuloLicitaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 582);
            this.Name = "FrmModuloLicitaPedido";
            this.Text = "Generar::Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpFundamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFundamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditFundamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpRequisicion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequisicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditRequisicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPedido)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxActividad;
        private System.Windows.Forms.ComboBox cbxIva;
        private System.Windows.Forms.ComboBox cbxCargo;
        private DevExpress.XtraEditors.LabelControl lblLicitacion;
        private DevExpress.XtraEditors.LabelControl lblArea;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpFundamento;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEditFundamento;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit deFechaFinal;
        private DevExpress.XtraEditors.DateEdit deFechaInicial;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpRequisicion;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEditRequisicion;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit txtObservaciones;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.BindingSource bsRequisicion;
        private System.Windows.Forms.BindingSource bsFundamento;
        private System.Windows.Forms.BindingSource bsPedido;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl lblFecha;
    }
}