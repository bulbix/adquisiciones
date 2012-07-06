namespace Adquisiciones.View
{
    partial class FrmModuloFallo
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
            this.bsAnexos = new System.Windows.Forms.BindingSource(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFallo = new DevExpress.XtraEditors.DateEdit();
            this.btnProcesar = new DevExpress.XtraEditors.SimpleButton();
            this.pgbFallo = new DevExpress.XtraEditors.ProgressBarControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.searchLookUpAnexo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblLicitacion = new System.Windows.Forms.Label();
            this.lblNumErrors = new System.Windows.Forms.Label();
            this.listaError = new System.Windows.Forms.ListBox();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFallo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFallo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbFallo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpAnexo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(482, 41);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 27;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFallo
            // 
            this.dtpFallo.EditValue = null;
            this.dtpFallo.Location = new System.Drawing.Point(529, 37);
            this.dtpFallo.Name = "dtpFallo";
            this.dtpFallo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFallo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpFallo.Size = new System.Drawing.Size(131, 20);
            this.dtpFallo.TabIndex = 28;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(614, 133);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(139, 87);
            this.btnProcesar.TabIndex = 31;
            this.btnProcesar.Text = "Generar";
            this.btnProcesar.Click += new System.EventHandler(this.BtnProcesarClick);
            // 
            // pgbFallo
            // 
            this.pgbFallo.Location = new System.Drawing.Point(21, 133);
            this.pgbFallo.Name = "pgbFallo";
            this.pgbFallo.Size = new System.Drawing.Size(543, 87);
            this.pgbFallo.TabIndex = 32;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.searchLookUpAnexo);
            this.groupControl1.Controls.Add(this.lblLicitacion);
            this.groupControl1.Controls.Add(this.lblFecha);
            this.groupControl1.Controls.Add(this.dtpFallo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(925, 100);
            this.groupControl1.TabIndex = 33;
            this.groupControl1.Text = "Datos Generales";
            // 
            // searchLookUpAnexo
            // 
            this.searchLookUpAnexo.EditValue = "";
            this.searchLookUpAnexo.Location = new System.Drawing.Point(244, 38);
            this.searchLookUpAnexo.Name = "searchLookUpAnexo";
            this.searchLookUpAnexo.Properties.Appearance.ForeColor = System.Drawing.Color.Navy;
            this.searchLookUpAnexo.Properties.Appearance.Options.UseForeColor = true;
            this.searchLookUpAnexo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpAnexo.Properties.DataSource = this.bsAnexos;
            this.searchLookUpAnexo.Properties.DisplayMember = "NumeroAnexo";
            this.searchLookUpAnexo.Properties.NullText = "";
            this.searchLookUpAnexo.Properties.ValueMember = "IdAnexo";
            this.searchLookUpAnexo.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpAnexo.Size = new System.Drawing.Size(196, 20);
            this.searchLookUpAnexo.TabIndex = 28;
            this.searchLookUpAnexo.EditValueChanged += new System.EventHandler(this.SearchLookUpAnexoEditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // lblLicitacion
            // 
            this.lblLicitacion.AutoSize = true;
            this.lblLicitacion.Location = new System.Drawing.Point(200, 41);
            this.lblLicitacion.Name = "lblLicitacion";
            this.lblLicitacion.Size = new System.Drawing.Size(38, 13);
            this.lblLicitacion.TabIndex = 27;
            this.lblLicitacion.Text = "Anexo";
            // 
            // lblNumErrors
            // 
            this.lblNumErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumErrors.AutoSize = true;
            this.lblNumErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumErrors.Location = new System.Drawing.Point(18, 271);
            this.lblNumErrors.Name = "lblNumErrors";
            this.lblNumErrors.Size = new System.Drawing.Size(58, 13);
            this.lblNumErrors.TabIndex = 110;
            this.lblNumErrors.Text = "0 Errores";
            // 
            // listaError
            // 
            this.listaError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaError.ForeColor = System.Drawing.Color.Red;
            this.listaError.FormattingEnabled = true;
            this.listaError.ItemHeight = 16;
            this.listaError.Location = new System.Drawing.Point(15, 287);
            this.listaError.Name = "listaError";
            this.listaError.Size = new System.Drawing.Size(318, 68);
            this.listaError.TabIndex = 109;
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
            // FrmModuloFallo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 462);
            this.Controls.Add(this.lblNumErrors);
            this.Controls.Add(this.listaError);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.pgbFallo);
            this.Controls.Add(this.btnProcesar);
            this.Name = "FrmModuloFallo";
            this.Text = "Generar::Fallo";
            this.Load += new System.EventHandler(this.FrmCargaFalloDevLoad);
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFallo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFallo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbFallo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpAnexo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private DevExpress.XtraEditors.DateEdit dtpFallo;
        private DevExpress.XtraEditors.SimpleButton btnProcesar;
        private System.Windows.Forms.BindingSource bsAnexos;
        private DevExpress.XtraEditors.ProgressBarControl pgbFallo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpAnexo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Label lblLicitacion;
        private System.Windows.Forms.Label lblNumErrors;
        private System.Windows.Forms.ListBox listaError;
    }
}