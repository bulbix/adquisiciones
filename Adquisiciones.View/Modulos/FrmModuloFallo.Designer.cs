namespace Adquisiciones.View.Modulos
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.searchLookUpAnexo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bsAnexos = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblLicitacion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFallo = new DevExpress.XtraEditors.DateEdit();
            this.pgbFallo = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpAnexo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFallo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFallo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbFallo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.pgbFallo);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.searchLookUpAnexo);
            this.groupControl1.Controls.Add(this.lblLicitacion);
            this.groupControl1.Controls.Add(this.lblFecha);
            this.groupControl1.Controls.Add(this.dtpFallo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(628, 92);
            this.groupControl1.TabIndex = 34;
            this.groupControl1.Text = "Datos Generales";
            // 
            // searchLookUpAnexo
            // 
            this.searchLookUpAnexo.EditValue = "";
            this.searchLookUpAnexo.Location = new System.Drawing.Point(170, 38);
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
            this.searchLookUpAnexo.TabIndex = 1;
            this.searchLookUpAnexo.EditValueChanged += new System.EventHandler(this.SearchLookUpAnexoEditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Numero Anexo";
            this.gridColumn4.FieldName = "NumeroAnexo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 137;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Descripcion";
            this.gridColumn5.FieldName = "DesAnexo";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 597;
            // 
            // lblLicitacion
            // 
            this.lblLicitacion.AutoSize = true;
            this.lblLicitacion.Location = new System.Drawing.Point(126, 41);
            this.lblLicitacion.Name = "lblLicitacion";
            this.lblLicitacion.Size = new System.Drawing.Size(38, 13);
            this.lblLicitacion.TabIndex = 27;
            this.lblLicitacion.Text = "Anexo";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(408, 41);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 27;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFallo
            // 
            this.dtpFallo.EditValue = null;
            this.dtpFallo.Location = new System.Drawing.Point(455, 37);
            this.dtpFallo.Name = "dtpFallo";
            this.dtpFallo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFallo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpFallo.Size = new System.Drawing.Size(131, 20);
            this.dtpFallo.TabIndex = 2;
            // 
            // pgbFallo
            // 
            this.pgbFallo.Location = new System.Drawing.Point(53, 17);
            this.pgbFallo.Name = "pgbFallo";
            this.pgbFallo.Size = new System.Drawing.Size(543, 87);
            this.pgbFallo.TabIndex = 34;
            // 
            // FrmModuloFallo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 423);
            this.Name = "FrmModuloFallo";
            this.Text = "Generar::Fallo";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpAnexo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFallo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFallo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbFallo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpAnexo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Label lblLicitacion;
        private System.Windows.Forms.Label lblFecha;
        private DevExpress.XtraEditors.DateEdit dtpFallo;
        private DevExpress.XtraEditors.ProgressBarControl pgbFallo;
        private System.Windows.Forms.BindingSource bsAnexos;
    }
}