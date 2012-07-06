namespace Adquisiciones.View
{
    partial class FrmCargafallo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargafallo));
            this.dgvAnexo = new System.Windows.Forms.DataGridView();
            this.pgbFallo = new System.Windows.Forms.ProgressBar();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.nudFecha = new System.Windows.Forms.NumericUpDown();
            this.btnCargalicitacion = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dtpFallo = new System.Windows.Forms.DateTimePicker();
            this.btnCargaLicitaciones = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.bsListaAnexo = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaAnexo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnexo
            // 
            this.dgvAnexo.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvAnexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnexo.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvAnexo.Location = new System.Drawing.Point(31, 55);
            this.dgvAnexo.Name = "dgvAnexo";
            this.dgvAnexo.ReadOnly = true;
            this.dgvAnexo.Size = new System.Drawing.Size(692, 267);
            this.dgvAnexo.TabIndex = 4;
            this.dgvAnexo.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAnexoRowEnter);
            // 
            // pgbFallo
            // 
            this.pgbFallo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pgbFallo.Location = new System.Drawing.Point(31, 344);
            this.pgbFallo.Name = "pgbFallo";
            this.pgbFallo.Size = new System.Drawing.Size(475, 23);
            this.pgbFallo.TabIndex = 5;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Image = global::Adquisiciones.View.Properties.Resources.accept;
            this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProcesar.Location = new System.Drawing.Point(551, 328);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(83, 58);
            this.btnProcesar.TabIndex = 3;
            this.btnProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.BtnProcesarClick);
            // 
            // nudFecha
            // 
            this.nudFecha.Location = new System.Drawing.Point(31, 17);
            this.nudFecha.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudFecha.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.nudFecha.Name = "nudFecha";
            this.nudFecha.Size = new System.Drawing.Size(57, 20);
            this.nudFecha.TabIndex = 6;
            this.nudFecha.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // btnCargalicitacion
            // 
            this.btnCargalicitacion.Location = new System.Drawing.Point(115, 17);
            this.btnCargalicitacion.Name = "btnCargalicitacion";
            this.btnCargalicitacion.Size = new System.Drawing.Size(114, 23);
            this.btnCargalicitacion.TabIndex = 12;
            this.btnCargalicitacion.Text = "Carga Licitación";
            this.btnCargalicitacion.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::Adquisiciones.View.Properties.Resources.cancelar;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.Location = new System.Drawing.Point(640, 328);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(83, 58);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
            // 
            // dtpFallo
            // 
            this.dtpFallo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFallo.Location = new System.Drawing.Point(622, 17);
            this.dtpFallo.Name = "dtpFallo";
            this.dtpFallo.Size = new System.Drawing.Size(101, 20);
            this.dtpFallo.TabIndex = 18;
            // 
            // btnCargaLicitaciones
            // 
            this.btnCargaLicitaciones.Location = new System.Drawing.Point(106, 14);
            this.btnCargaLicitaciones.Name = "btnCargaLicitaciones";
            this.btnCargaLicitaciones.Size = new System.Drawing.Size(131, 23);
            this.btnCargaLicitaciones.TabIndex = 19;
            this.btnCargaLicitaciones.Text = "Cargar Licitaciones";
            this.btnCargaLicitaciones.UseVisualStyleBackColor = true;
            this.btnCargaLicitaciones.Click += new System.EventHandler(this.BtnCargaLicitacionesClick);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(577, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha:";
            // 
            // FrmCargafallo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 412);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnCargaLicitaciones);
            this.Controls.Add(this.nudFecha);
            this.Controls.Add(this.dtpFallo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pgbFallo);
            this.Controls.Add(this.dgvAnexo);
            this.Controls.Add(this.btnProcesar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(756, 450);
            this.MinimumSize = new System.Drawing.Size(756, 450);
            this.Name = "FrmCargafallo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga Fallo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaAnexo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.DataGridView dgvAnexo;
        private System.Windows.Forms.ProgressBar pgbFallo;
        private System.Windows.Forms.NumericUpDown nudFecha;
        private System.Windows.Forms.Button btnCargalicitacion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DateTimePicker dtpFallo;
        private System.Windows.Forms.Button btnCargaLicitaciones;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.BindingSource bsListaAnexo;

    }
}