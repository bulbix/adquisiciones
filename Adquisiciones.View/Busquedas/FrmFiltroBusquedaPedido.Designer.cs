namespace Adquisiciones.View.Busquedas
{
    partial class FrmFiltroBusquedaPedido
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAjuste = new System.Windows.Forms.CheckBox();
            this.cbExtramuro = new System.Windows.Forms.CheckBox();
            this.cbDonacion = new System.Windows.Forms.CheckBox();
            this.cbMenor = new System.Windows.Forms.CheckBox();
            this.cbMayor = new System.Windows.Forms.CheckBox();
            this.deFinal = new DevExpress.XtraEditors.DateEdit();
            this.deInicial = new DevExpress.XtraEditors.DateEdit();
            this.seInicial = new DevExpress.XtraEditors.SpinEdit();
            this.seFinal = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cmdBusqueda = new DevExpress.XtraEditors.SimpleButton();
            this.bsProveedor = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpProveedor = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEditProveedor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cmdLimpiar = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Fecha del";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(203, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(8, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "al";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAjuste);
            this.groupBox1.Controls.Add(this.cbExtramuro);
            this.groupBox1.Controls.Add(this.cbDonacion);
            this.groupBox1.Controls.Add(this.cbMenor);
            this.groupBox1.Controls.Add(this.cbMayor);
            this.groupBox1.Location = new System.Drawing.Point(16, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 163);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // cbAjuste
            // 
            this.cbAjuste.AutoSize = true;
            this.cbAjuste.Location = new System.Drawing.Point(15, 113);
            this.cbAjuste.Name = "cbAjuste";
            this.cbAjuste.Size = new System.Drawing.Size(57, 17);
            this.cbAjuste.TabIndex = 4;
            this.cbAjuste.Text = "Ajuste";
            this.cbAjuste.UseVisualStyleBackColor = true;
            // 
            // cbExtramuro
            // 
            this.cbExtramuro.AutoSize = true;
            this.cbExtramuro.Location = new System.Drawing.Point(15, 90);
            this.cbExtramuro.Name = "cbExtramuro";
            this.cbExtramuro.Size = new System.Drawing.Size(76, 17);
            this.cbExtramuro.TabIndex = 3;
            this.cbExtramuro.Text = "Extramuro";
            this.cbExtramuro.UseVisualStyleBackColor = true;
            // 
            // cbDonacion
            // 
            this.cbDonacion.AutoSize = true;
            this.cbDonacion.Location = new System.Drawing.Point(15, 67);
            this.cbDonacion.Name = "cbDonacion";
            this.cbDonacion.Size = new System.Drawing.Size(70, 17);
            this.cbDonacion.TabIndex = 2;
            this.cbDonacion.Text = "Donacion";
            this.cbDonacion.UseVisualStyleBackColor = true;
            // 
            // cbMenor
            // 
            this.cbMenor.AutoSize = true;
            this.cbMenor.Location = new System.Drawing.Point(15, 44);
            this.cbMenor.Name = "cbMenor";
            this.cbMenor.Size = new System.Drawing.Size(56, 17);
            this.cbMenor.TabIndex = 1;
            this.cbMenor.Text = "Menor";
            this.cbMenor.UseVisualStyleBackColor = true;
            // 
            // cbMayor
            // 
            this.cbMayor.AutoSize = true;
            this.cbMayor.Checked = true;
            this.cbMayor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMayor.Location = new System.Drawing.Point(15, 21);
            this.cbMayor.Name = "cbMayor";
            this.cbMayor.Size = new System.Drawing.Size(56, 17);
            this.cbMayor.TabIndex = 0;
            this.cbMayor.Text = "Mayor";
            this.cbMayor.UseVisualStyleBackColor = true;
            // 
            // deFinal
            // 
            this.deFinal.EditValue = null;
            this.deFinal.Location = new System.Drawing.Point(218, 5);
            this.deFinal.Name = "deFinal";
            this.deFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFinal.Size = new System.Drawing.Size(121, 20);
            this.deFinal.TabIndex = 10;
            // 
            // deInicial
            // 
            this.deInicial.EditValue = null;
            this.deInicial.Location = new System.Drawing.Point(72, 5);
            this.deInicial.Name = "deInicial";
            this.deInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deInicial.Size = new System.Drawing.Size(125, 20);
            this.deInicial.TabIndex = 9;
            // 
            // seInicial
            // 
            this.seInicial.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seInicial.Location = new System.Drawing.Point(72, 35);
            this.seInicial.Name = "seInicial";
            this.seInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seInicial.Properties.Mask.EditMask = "n0";
            this.seInicial.Size = new System.Drawing.Size(100, 20);
            this.seInicial.TabIndex = 14;
            // 
            // seFinal
            // 
            this.seFinal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seFinal.Location = new System.Drawing.Point(228, 34);
            this.seFinal.Name = "seFinal";
            this.seFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seFinal.Properties.Mask.EditMask = "n0";
            this.seFinal.Size = new System.Drawing.Size(100, 20);
            this.seFinal.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Numero del";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(203, 37);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(8, 13);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "al";
            // 
            // cmdBusqueda
            // 
            this.cmdBusqueda.Location = new System.Drawing.Point(222, 103);
            this.cmdBusqueda.Name = "cmdBusqueda";
            this.cmdBusqueda.Size = new System.Drawing.Size(150, 23);
            this.cmdBusqueda.TabIndex = 18;
            this.cmdBusqueda.Text = "Generar Busqueda";
            this.cmdBusqueda.Click += new System.EventHandler(this.CmdBusquedaClick);
            // 
            // searchLookUpProveedor
            // 
            this.searchLookUpProveedor.EditValue = "<Null>";
            this.searchLookUpProveedor.Location = new System.Drawing.Point(72, 65);
            this.searchLookUpProveedor.Name = "searchLookUpProveedor";
            this.searchLookUpProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpProveedor.Properties.DataSource = this.bsProveedor;
            this.searchLookUpProveedor.Properties.DisplayMember = "ProveedorString";
            this.searchLookUpProveedor.Properties.NullText = "";
            this.searchLookUpProveedor.Properties.ValueMember = "CveProveedor";
            this.searchLookUpProveedor.Properties.View = this.searchLookUpEditProveedor;
            this.searchLookUpProveedor.Size = new System.Drawing.Size(328, 20);
            this.searchLookUpProveedor.TabIndex = 19;
            // 
            // searchLookUpEditProveedor
            // 
            this.searchLookUpEditProveedor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.searchLookUpEditProveedor.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEditProveedor.Name = "searchLookUpEditProveedor";
            this.searchLookUpEditProveedor.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEditProveedor.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Clave";
            this.gridColumn3.FieldName = "CveProveedor";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 86;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Nombre";
            this.gridColumn4.FieldName = "NombreFiscal";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 766;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 68);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Proveedor";
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(222, 134);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(150, 23);
            this.cmdLimpiar.TabIndex = 21;
            this.cmdLimpiar.Text = "Limpiar Busqueda";
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // FrmFiltroBusquedaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 269);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.searchLookUpProveedor);
            this.Controls.Add(this.cmdBusqueda);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.seFinal);
            this.Controls.Add(this.seInicial);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deFinal);
            this.Controls.Add(this.deInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmFiltroBusquedaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro Busqueda Pedido";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFiltroBusquedaPedido_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.DateEdit deFinal;
        private DevExpress.XtraEditors.DateEdit deInicial;
        private DevExpress.XtraEditors.SpinEdit seInicial;
        private DevExpress.XtraEditors.SpinEdit seFinal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.CheckBox cbDonacion;
        private System.Windows.Forms.CheckBox cbMenor;
        private System.Windows.Forms.CheckBox cbMayor;
        private DevExpress.XtraEditors.SimpleButton cmdBusqueda;
        private System.Windows.Forms.CheckBox cbExtramuro;
        private System.Windows.Forms.CheckBox cbAjuste;
        private System.Windows.Forms.BindingSource bsProveedor;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEditProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton cmdLimpiar;
    }
}