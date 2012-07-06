namespace Adquisiciones.View
{
    partial class FrmCotizacion
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
            this.lblLicitacion = new System.Windows.Forms.Label();
            this.lblInstituto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.gpbDatosCotizacion = new System.Windows.Forms.GroupBox();
            this.dtpFechacotizacion = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtInstituto = new System.Windows.Forms.TextBox();
            this.btnCargalicitacion = new System.Windows.Forms.Button();
            this.nudFecha = new System.Windows.Forms.NumericUpDown();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtDesproveedor = new System.Windows.Forms.TextBox();
            this.cbxLicitacion = new System.Windows.Forms.ComboBox();
            this.txtDeslicitacion = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.bsCotizacionDetalle = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCotizacion = new System.Windows.Forms.DataGridView();
            this.lblNumErrors = new System.Windows.Forms.Label();
            this.listaError = new System.Windows.Forms.ListBox();
            this.gpbDatosCotizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCotizacionDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLicitacion
            // 
            this.lblLicitacion.AutoSize = true;
            this.lblLicitacion.Location = new System.Drawing.Point(21, 60);
            this.lblLicitacion.Name = "lblLicitacion";
            this.lblLicitacion.Size = new System.Drawing.Size(52, 13);
            this.lblLicitacion.TabIndex = 0;
            this.lblLicitacion.Text = "Licitación";
            // 
            // lblInstituto
            // 
            this.lblInstituto.AutoSize = true;
            this.lblInstituto.Location = new System.Drawing.Point(475, 57);
            this.lblInstituto.Name = "lblInstituto";
            this.lblInstituto.Size = new System.Drawing.Size(44, 13);
            this.lblInstituto.TabIndex = 1;
            this.lblInstituto.Text = "Instituto";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(21, 92);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(126, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción de Licitación";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(21, 125);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 3;
            this.lblProveedor.Text = "Proveedor";
            // 
            // gpbDatosCotizacion
            // 
            this.gpbDatosCotizacion.Controls.Add(this.dtpFechacotizacion);
            this.gpbDatosCotizacion.Controls.Add(this.lblFecha);
            this.gpbDatosCotizacion.Controls.Add(this.txtInstituto);
            this.gpbDatosCotizacion.Controls.Add(this.btnCargalicitacion);
            this.gpbDatosCotizacion.Controls.Add(this.nudFecha);
            this.gpbDatosCotizacion.Controls.Add(this.lblAño);
            this.gpbDatosCotizacion.Controls.Add(this.txtDesproveedor);
            this.gpbDatosCotizacion.Controls.Add(this.cbxLicitacion);
            this.gpbDatosCotizacion.Controls.Add(this.txtDeslicitacion);
            this.gpbDatosCotizacion.Controls.Add(this.txtProveedor);
            this.gpbDatosCotizacion.Controls.Add(this.lblLicitacion);
            this.gpbDatosCotizacion.Controls.Add(this.lblDescripcion);
            this.gpbDatosCotizacion.Controls.Add(this.lblProveedor);
            this.gpbDatosCotizacion.Controls.Add(this.lblInstituto);
            this.gpbDatosCotizacion.Location = new System.Drawing.Point(127, 0);
            this.gpbDatosCotizacion.Name = "gpbDatosCotizacion";
            this.gpbDatosCotizacion.Size = new System.Drawing.Size(698, 162);
            this.gpbDatosCotizacion.TabIndex = 4;
            this.gpbDatosCotizacion.TabStop = false;
            this.gpbDatosCotizacion.Text = "Datos ";
            // 
            // dtpFechacotizacion
            // 
            this.dtpFechacotizacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechacotizacion.Location = new System.Drawing.Point(579, 23);
            this.dtpFechacotizacion.Name = "dtpFechacotizacion";
            this.dtpFechacotizacion.Size = new System.Drawing.Size(97, 20);
            this.dtpFechacotizacion.TabIndex = 14;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(475, 26);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha";
            // 
            // txtInstituto
            // 
            this.txtInstituto.Location = new System.Drawing.Point(549, 52);
            this.txtInstituto.Name = "txtInstituto";
            this.txtInstituto.ReadOnly = true;
            this.txtInstituto.Size = new System.Drawing.Size(127, 20);
            this.txtInstituto.TabIndex = 12;
            // 
            // btnCargalicitacion
            // 
            this.btnCargalicitacion.Location = new System.Drawing.Point(256, 21);
            this.btnCargalicitacion.Name = "btnCargalicitacion";
            this.btnCargalicitacion.Size = new System.Drawing.Size(145, 23);
            this.btnCargalicitacion.TabIndex = 11;
            this.btnCargalicitacion.Text = "Carga Licitación";
            this.btnCargalicitacion.UseVisualStyleBackColor = true;
            this.btnCargalicitacion.Click += new System.EventHandler(this.BtnCargalicitacionClick);
            // 
            // nudFecha
            // 
            this.nudFecha.Location = new System.Drawing.Point(162, 24);
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
            this.nudFecha.Size = new System.Drawing.Size(53, 20);
            this.nudFecha.TabIndex = 10;
            this.nudFecha.Value = new decimal(new int[] {
            2011,
            0,
            0,
            0});
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(96, 26);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(26, 13);
            this.lblAño.TabIndex = 9;
            this.lblAño.Text = "Año";
            // 
            // txtDesproveedor
            // 
            this.txtDesproveedor.Location = new System.Drawing.Point(240, 122);
            this.txtDesproveedor.Name = "txtDesproveedor";
            this.txtDesproveedor.ReadOnly = true;
            this.txtDesproveedor.Size = new System.Drawing.Size(436, 20);
            this.txtDesproveedor.TabIndex = 8;
            // 
            // cbxLicitacion
            // 
            this.cbxLicitacion.FormattingEnabled = true;
            this.cbxLicitacion.Location = new System.Drawing.Point(162, 52);
            this.cbxLicitacion.Name = "cbxLicitacion";
            this.cbxLicitacion.Size = new System.Drawing.Size(200, 21);
            this.cbxLicitacion.TabIndex = 7;
            this.cbxLicitacion.SelectedIndexChanged += new System.EventHandler(this.CbxLicitacionSelectedIndexChanged);
            // 
            // txtDeslicitacion
            // 
            this.txtDeslicitacion.Location = new System.Drawing.Point(162, 89);
            this.txtDeslicitacion.Name = "txtDeslicitacion";
            this.txtDeslicitacion.ReadOnly = true;
            this.txtDeslicitacion.Size = new System.Drawing.Size(514, 20);
            this.txtDeslicitacion.TabIndex = 5;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(162, 122);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(72, 20);
            this.txtProveedor.TabIndex = 4;
            this.txtProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProveedorKeyPress);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::Adquisiciones.View.Properties.Resources.cancelar;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.Location = new System.Drawing.Point(818, 447);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(69, 58);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::Adquisiciones.View.Properties.Resources.search;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConsultar.Location = new System.Drawing.Point(734, 447);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(69, 58);
            this.btnConsultar.TabIndex = 23;
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = global::Adquisiciones.View.Properties.Resources.save_icon;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(652, 447);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 58);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Adquisiciones.View.Properties.Resources.file_new;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(570, 447);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(69, 58);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
            // 
            // dgvCotizacion
            // 
            this.dgvCotizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCotizacion.Location = new System.Drawing.Point(12, 180);
            this.dgvCotizacion.Name = "dgvCotizacion";
            this.dgvCotizacion.Size = new System.Drawing.Size(912, 247);
            this.dgvCotizacion.TabIndex = 26;
            // 
            // lblNumErrors
            // 
            this.lblNumErrors.AutoSize = true;
            this.lblNumErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumErrors.Location = new System.Drawing.Point(9, 431);
            this.lblNumErrors.Name = "lblNumErrors";
            this.lblNumErrors.Size = new System.Drawing.Size(58, 13);
            this.lblNumErrors.TabIndex = 100;
            this.lblNumErrors.Text = "0 Errores";
            // 
            // listaError
            // 
            this.listaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaError.ForeColor = System.Drawing.Color.Red;
            this.listaError.FormattingEnabled = true;
            this.listaError.ItemHeight = 16;
            this.listaError.Location = new System.Drawing.Point(12, 447);
            this.listaError.Name = "listaError";
            this.listaError.Size = new System.Drawing.Size(382, 68);
            this.listaError.TabIndex = 99;
            // 
            // FrmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 526);
            this.Controls.Add(this.lblNumErrors);
            this.Controls.Add(this.listaError);
            this.Controls.Add(this.dgvCotizacion);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gpbDatosCotizacion);
            this.MaximizeBox = false;
            this.Name = "FrmCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotización";
            this.gpbDatosCotizacion.ResumeLayout(false);
            this.gpbDatosCotizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCotizacionDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLicitacion;
        private System.Windows.Forms.Label lblInstituto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.GroupBox gpbDatosCotizacion;
        private System.Windows.Forms.TextBox txtDeslicitacion;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtDesproveedor;
        private System.Windows.Forms.ComboBox cbxLicitacion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCargalicitacion;
        private System.Windows.Forms.NumericUpDown nudFecha;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtInstituto;
        private System.Windows.Forms.DateTimePicker dtpFechacotizacion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.BindingSource bsCotizacionDetalle;
        private System.Windows.Forms.DataGridView dgvCotizacion;
        private System.Windows.Forms.Label lblNumErrors;
        private System.Windows.Forms.ListBox listaError;
    }
}