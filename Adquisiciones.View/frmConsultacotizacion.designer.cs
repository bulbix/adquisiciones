namespace Adquisiciones.View
{
    partial class FrmConsultacotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultacotizacion));
            this.dgvConsultacotizacion = new System.Windows.Forms.DataGridView();
            this.Licitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instituto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultacotizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultacotizacion
            // 
            this.dgvConsultacotizacion.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvConsultacotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultacotizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Licitacion,
            this.Instituto,
            this.Clave,
            this.Descripcion});
            this.dgvConsultacotizacion.Location = new System.Drawing.Point(30, 29);
            this.dgvConsultacotizacion.Name = "dgvConsultacotizacion";
            this.dgvConsultacotizacion.Size = new System.Drawing.Size(740, 327);
            this.dgvConsultacotizacion.TabIndex = 0;
            // 
            // Licitacion
            // 
            this.Licitacion.HeaderText = "Licitación";
            this.Licitacion.Name = "Licitacion";
            this.Licitacion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Instituto
            // 
            this.Instituto.HeaderText = "Instituto";
            this.Instituto.Name = "Instituto";
            this.Instituto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Instituto.Width = 50;
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave Proveedor";
            this.Clave.Name = "Clave";
            this.Clave.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Clave.Width = 50;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descripcion.Width = 500;
            // 
            // btnAceptar
            // 
            
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(712, 372);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(58, 58);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmConsultacotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 442);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvConsultacotizacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(803, 476);
            this.MinimumSize = new System.Drawing.Size(803, 476);
            this.Name = "FrmConsultacotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotización";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultacotizacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultacotizacion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Licitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instituto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}