namespace Adquisiciones.View
{
    partial class FrmImpresionped
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImpresionped));
            this.lblTipopedido = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNumeropedido = new System.Windows.Forms.Label();
            this.gpbImpresion = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gpbImpresion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipopedido
            // 
            this.lblTipopedido.AutoSize = true;
            this.lblTipopedido.Location = new System.Drawing.Point(33, 25);
            this.lblTipopedido.Name = "lblTipopedido";
            this.lblTipopedido.Size = new System.Drawing.Size(79, 13);
            this.lblTipopedido.TabIndex = 0;
            this.lblTipopedido.Text = "Tipo de Pedido";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(33, 59);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblNumeropedido
            // 
            this.lblNumeropedido.AutoSize = true;
            this.lblNumeropedido.Location = new System.Drawing.Point(33, 94);
            this.lblNumeropedido.Name = "lblNumeropedido";
            this.lblNumeropedido.Size = new System.Drawing.Size(44, 13);
            this.lblNumeropedido.TabIndex = 2;
            this.lblNumeropedido.Text = "Número";
            // 
            // gpbImpresion
            // 
            this.gpbImpresion.Controls.Add(this.textBox1);
            this.gpbImpresion.Controls.Add(this.dateTimePicker1);
            this.gpbImpresion.Controls.Add(this.comboBox1);
            this.gpbImpresion.Controls.Add(this.lblTipopedido);
            this.gpbImpresion.Controls.Add(this.lblNumeropedido);
            this.gpbImpresion.Controls.Add(this.lblFecha);
            this.gpbImpresion.Location = new System.Drawing.Point(12, 12);
            this.gpbImpresion.Name = "gpbImpresion";
            this.gpbImpresion.Size = new System.Drawing.Size(263, 131);
            this.gpbImpresion.TabIndex = 3;
            this.gpbImpresion.TabStop = false;
            this.gpbImpresion.Text = "Datos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 20);
            this.textBox1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Mayores",
            "Menores",
            "Donación",
            "Extramuros"});
            this.comboBox1.Location = new System.Drawing.Point(134, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btnAceptar
            // 
           
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(228, 162);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(47, 45);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmImpresionped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 219);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gpbImpresion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmImpresionped";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresión";
            this.gpbImpresion.ResumeLayout(false);
            this.gpbImpresion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTipopedido;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNumeropedido;
        private System.Windows.Forms.GroupBox gpbImpresion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAceptar;
    }
}