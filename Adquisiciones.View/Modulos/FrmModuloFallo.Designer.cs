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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.lblLicitacion = new System.Windows.Forms.Label();
            this.lblFechac = new System.Windows.Forms.Label();
            this.searchLookUpAnexo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bsAnexos = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEditAnexo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pgbFallo = new DevExpress.XtraEditors.ProgressBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpAnexo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditAnexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbFallo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 70);
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.pgbFallo);
            this.splitContainerControl1.Size = new System.Drawing.Size(770, 330);
            this.splitContainerControl1.SplitterPosition = 128;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableLayoutPanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(770, 128);
            this.groupControl1.TabIndex = 34;
            this.groupControl1.Text = "Datos Generales";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.50183F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.49817F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 391F));
            this.tableLayoutPanel1.Controls.Add(this.lblFecha, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLicitacion, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFechac, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchLookUpAnexo, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(117, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(613, 53);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // lblFecha
            // 
            this.lblFecha.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblFecha.Location = new System.Drawing.Point(57, 3);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(63, 13);
            this.lblFecha.TabIndex = 28;
            this.lblFecha.Text = "labelControl1";
            // 
            // lblLicitacion
            // 
            this.lblLicitacion.AutoSize = true;
            this.lblLicitacion.Location = new System.Drawing.Point(174, 0);
            this.lblLicitacion.Name = "lblLicitacion";
            this.lblLicitacion.Size = new System.Drawing.Size(38, 13);
            this.lblLicitacion.TabIndex = 27;
            this.lblLicitacion.Text = "Anexo";
            // 
            // lblFechac
            // 
            this.lblFechac.AutoSize = true;
            this.lblFechac.Location = new System.Drawing.Point(3, 0);
            this.lblFechac.Name = "lblFechac";
            this.lblFechac.Size = new System.Drawing.Size(40, 13);
            this.lblFechac.TabIndex = 27;
            this.lblFechac.Text = "Fecha:";
            // 
            // searchLookUpAnexo
            // 
            this.searchLookUpAnexo.EditValue = "";
            this.searchLookUpAnexo.Location = new System.Drawing.Point(224, 3);
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
            this.searchLookUpAnexo.Size = new System.Drawing.Size(362, 20);
            this.searchLookUpAnexo.TabIndex = 1;
            this.searchLookUpAnexo.EditValueChanged += new System.EventHandler(this.SearchLookUpAnexoEditValueChanged);
            // 
            // searchLookUpEditAnexo
            // 
            this.searchLookUpEditAnexo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn1});
            this.searchLookUpEditAnexo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEditAnexo.Name = "searchLookUpEditAnexo";
            this.searchLookUpEditAnexo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEditAnexo.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Numero Anexo";
            this.gridColumn4.FieldName = "NumeroAnexo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 152;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Descripcion";
            this.gridColumn5.FieldName = "DesAnexo";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 513;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Contrato";
            this.gridColumn1.FieldName = "TipoContrato";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 367;
            // 
            // pgbFallo
            // 
            this.pgbFallo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbFallo.Location = new System.Drawing.Point(0, 0);
            this.pgbFallo.Name = "pgbFallo";
            this.pgbFallo.Size = new System.Drawing.Size(770, 197);
            this.pgbFallo.TabIndex = 34;
            // 
            // FrmModuloFallo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 423);
            this.Name = "FrmModuloFallo";
            this.Text = "Generar::Fallo";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpAnexo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnexos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditAnexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pgbFallo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpAnexo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEditAnexo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Label lblLicitacion;
        private System.Windows.Forms.Label lblFechac;
        private DevExpress.XtraEditors.ProgressBarControl pgbFallo;
        private System.Windows.Forms.BindingSource bsAnexos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}