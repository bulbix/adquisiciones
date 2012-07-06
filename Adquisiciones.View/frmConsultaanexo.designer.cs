namespace Adquisiciones.View
{
    partial class FrmConsultaanexo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaanexo));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvAnexo = new System.Windows.Forms.DataGridView();
            this.Licitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instituto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Techo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnexo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
           
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(713, 375);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(58, 58);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // dgvAnexo
            // 
            this.dgvAnexo.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvAnexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnexo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Licitacion,
            this.Instituto,
            this.Descripción,
            this.Tipo,
            this.Techo,
            this.Iva});
            this.dgvAnexo.Location = new System.Drawing.Point(29, 26);
            this.dgvAnexo.Name = "dgvAnexo";
            this.dgvAnexo.Size = new System.Drawing.Size(742, 343);
            this.dgvAnexo.TabIndex = 10;
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
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descripción.Width = 390;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tipo.Width = 30;
            // 
            // Techo
            // 
            this.Techo.HeaderText = "Techo Presupuestal";
            this.Techo.Name = "Techo";
            this.Techo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Iva
            // 
            this.Iva.HeaderText = "IVA";
            this.Iva.Name = "Iva";
            this.Iva.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Iva.Width = 30;
            // 
            // frmConsultaanexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 442);
            this.Controls.Add(this.dgvAnexo);
            this.Controls.Add(this.btnAceptar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(803, 476);
            this.MinimumSize = new System.Drawing.Size(803, 476);
            this.Name = "FrmConsultaanexo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anexo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnexo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvAnexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Licitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instituto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Techo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iva;
    }
}