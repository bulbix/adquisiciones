namespace Adquisiciones.View
{
    partial class FrmReportepedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportepedidos));
            this.gpbReportepedido = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblAl = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gpbReportepedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbReportepedido
            // 
            this.gpbReportepedido.Controls.Add(this.dateTimePicker1);
            this.gpbReportepedido.Controls.Add(this.dtpFecha);
            this.gpbReportepedido.Controls.Add(this.comboBox1);
            this.gpbReportepedido.Controls.Add(this.lblTipo);
            this.gpbReportepedido.Controls.Add(this.lblAl);
            this.gpbReportepedido.Controls.Add(this.lblFecha);
            this.gpbReportepedido.Location = new System.Drawing.Point(12, 26);
            this.gpbReportepedido.Name = "gpbReportepedido";
            this.gpbReportepedido.Size = new System.Drawing.Size(356, 199);
            this.gpbReportepedido.TabIndex = 0;
            this.gpbReportepedido.TabStop = false;
            this.gpbReportepedido.Text = "Datos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mayores",
            "Menores",
            "Donación",
            "Extramuros"});
            this.comboBox1.Location = new System.Drawing.Point(151, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(17, 113);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(79, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo de Pedido";
            // 
            // lblAl
            // 
            this.lblAl.AutoSize = true;
            this.lblAl.Location = new System.Drawing.Point(189, 50);
            this.lblAl.Name = "lblAl";
            this.lblAl.Size = new System.Drawing.Size(15, 13);
            this.lblAl.TabIndex = 1;
            this.lblAl.Text = "al";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(17, 50);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha del";
            // 
            // btnAceptar
            // 
            
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(310, 238);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(58, 58);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(87, 46);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(85, 20);
            this.dtpFecha.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 46);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // frmReportepedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 308);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gpbReportepedido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 342);
            this.MinimumSize = new System.Drawing.Size(390, 342);
            this.Name = "FrmReportepedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte ";
            this.gpbReportepedido.ResumeLayout(false);
            this.gpbReportepedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbReportepedido;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblAl;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}