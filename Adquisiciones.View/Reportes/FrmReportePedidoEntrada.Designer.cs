namespace Adquisiciones.View.Reportes
{
    partial class FrmReportePedidoEntrada
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbAmbos = new System.Windows.Forms.RadioButton();
            this.rbPedidoConEntrada = new System.Windows.Forms.RadioButton();
            this.rbPedidoSinEntrada = new System.Windows.Forms.RadioButton();
            this.cmdReporte = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbAmbos);
            this.groupBox3.Controls.Add(this.rbPedidoConEntrada);
            this.groupBox3.Controls.Add(this.rbPedidoSinEntrada);
            this.groupBox3.Location = new System.Drawing.Point(26, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // rbAmbos
            // 
            this.rbAmbos.AutoSize = true;
            this.rbAmbos.Checked = true;
            this.rbAmbos.Location = new System.Drawing.Point(9, 20);
            this.rbAmbos.Name = "rbAmbos";
            this.rbAmbos.Size = new System.Drawing.Size(57, 17);
            this.rbAmbos.TabIndex = 4;
            this.rbAmbos.TabStop = true;
            this.rbAmbos.Text = "Ambos";
            this.rbAmbos.UseVisualStyleBackColor = true;
            // 
            // rbPedidoConEntrada
            // 
            this.rbPedidoConEntrada.AutoSize = true;
            this.rbPedidoConEntrada.Location = new System.Drawing.Point(6, 67);
            this.rbPedidoConEntrada.Name = "rbPedidoConEntrada";
            this.rbPedidoConEntrada.Size = new System.Drawing.Size(125, 17);
            this.rbPedidoConEntrada.TabIndex = 3;
            this.rbPedidoConEntrada.Text = "Pedidos Con Entrada";
            this.rbPedidoConEntrada.UseVisualStyleBackColor = true;
            // 
            // rbPedidoSinEntrada
            // 
            this.rbPedidoSinEntrada.AutoSize = true;
            this.rbPedidoSinEntrada.Location = new System.Drawing.Point(6, 44);
            this.rbPedidoSinEntrada.Name = "rbPedidoSinEntrada";
            this.rbPedidoSinEntrada.Size = new System.Drawing.Size(120, 17);
            this.rbPedidoSinEntrada.TabIndex = 3;
            this.rbPedidoSinEntrada.Text = "Pedidos Sin Entrada";
            this.rbPedidoSinEntrada.UseVisualStyleBackColor = true;
            // 
            // cmdReporte
            // 
            this.cmdReporte.Location = new System.Drawing.Point(306, 135);
            this.cmdReporte.Name = "cmdReporte";
            this.cmdReporte.Size = new System.Drawing.Size(150, 23);
            this.cmdReporte.TabIndex = 11;
            this.cmdReporte.Text = "Generar Reporte";
            this.cmdReporte.Click += new System.EventHandler(this.cmdReporte_Click);
            // 
            // FrmReportePedidoEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 251);
            this.Controls.Add(this.cmdReporte);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmReportePedidoEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de pedidos contra entradas";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbAmbos;
        private System.Windows.Forms.RadioButton rbPedidoConEntrada;
        private System.Windows.Forms.RadioButton rbPedidoSinEntrada;
        private DevExpress.XtraEditors.SimpleButton cmdReporte;
    }
}