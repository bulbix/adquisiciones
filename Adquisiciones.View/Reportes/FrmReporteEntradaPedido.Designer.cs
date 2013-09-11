namespace Adquisiciones.View.Reportes
{
    partial class FrmReporteEntradaPedido
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
            this.deInicial = new DevExpress.XtraEditors.DateEdit();
            this.deFinal = new DevExpress.XtraEditors.DateEdit();
            this.rbMenor = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMayor = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPedido = new System.Windows.Forms.RadioButton();
            this.rbProveedor = new System.Windows.Forms.RadioButton();
            this.cmdReporte = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.deInicial.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFinal.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // deInicial
            // 
            this.deInicial.EditValue = null;
            this.deInicial.Location = new System.Drawing.Point(109, 22);
            this.deInicial.Name = "deInicial";
            this.deInicial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deInicial.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deInicial.Size = new System.Drawing.Size(125, 20);
            this.deInicial.TabIndex = 0;
            // 
            // deFinal
            // 
            this.deFinal.EditValue = null;
            this.deFinal.Location = new System.Drawing.Point(255, 22);
            this.deFinal.Name = "deFinal";
            this.deFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFinal.Size = new System.Drawing.Size(121, 20);
            this.deFinal.TabIndex = 1;
            // 
            // rbMenor
            // 
            this.rbMenor.AutoSize = true;
            this.rbMenor.Location = new System.Drawing.Point(6, 54);
            this.rbMenor.Name = "rbMenor";
            this.rbMenor.Size = new System.Drawing.Size(66, 17);
            this.rbMenor.TabIndex = 3;
            this.rbMenor.Text = "Menores";
            this.rbMenor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMayor);
            this.groupBox1.Controls.Add(this.rbMenor);
            this.groupBox1.Location = new System.Drawing.Point(68, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // rbMayor
            // 
            this.rbMayor.AutoSize = true;
            this.rbMayor.Checked = true;
            this.rbMayor.Location = new System.Drawing.Point(6, 20);
            this.rbMayor.Name = "rbMayor";
            this.rbMayor.Size = new System.Drawing.Size(66, 17);
            this.rbMayor.TabIndex = 3;
            this.rbMayor.TabStop = true;
            this.rbMayor.Text = "Mayores";
            this.rbMayor.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbPedido);
            this.groupBox2.Controls.Add(this.rbProveedor);
            this.groupBox2.Location = new System.Drawing.Point(68, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenado";
            // 
            // rbPedido
            // 
            this.rbPedido.AutoSize = true;
            this.rbPedido.Checked = true;
            this.rbPedido.Location = new System.Drawing.Point(6, 20);
            this.rbPedido.Name = "rbPedido";
            this.rbPedido.Size = new System.Drawing.Size(57, 17);
            this.rbPedido.TabIndex = 3;
            this.rbPedido.TabStop = true;
            this.rbPedido.Text = "Pedido";
            this.rbPedido.UseVisualStyleBackColor = true;
            // 
            // rbProveedor
            // 
            this.rbProveedor.AutoSize = true;
            this.rbProveedor.Location = new System.Drawing.Point(6, 54);
            this.rbProveedor.Name = "rbProveedor";
            this.rbProveedor.Size = new System.Drawing.Size(75, 17);
            this.rbProveedor.TabIndex = 3;
            this.rbProveedor.Text = "Proveedor";
            this.rbProveedor.UseVisualStyleBackColor = true;
            // 
            // cmdReporte
            // 
            this.cmdReporte.Location = new System.Drawing.Point(379, 270);
            this.cmdReporte.Name = "cmdReporte";
            this.cmdReporte.Size = new System.Drawing.Size(150, 23);
            this.cmdReporte.TabIndex = 6;
            this.cmdReporte.Text = "Generar Reporte";
            this.cmdReporte.Click += new System.EventHandler(this.CmdReporteClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(240, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(8, 13);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "al";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(57, 25);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Fecha del";
            // 
            // FrmReporteEntradaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 349);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cmdReporte);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deFinal);
            this.Controls.Add(this.deInicial);
            this.Name = "FrmReporteEntradaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de entradas contra pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.deInicial.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFinal.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit deInicial;
        private DevExpress.XtraEditors.DateEdit deFinal;
        private System.Windows.Forms.RadioButton rbMenor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMayor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbPedido;
        private System.Windows.Forms.RadioButton rbProveedor;
        private DevExpress.XtraEditors.SimpleButton cmdReporte;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;

    }
}