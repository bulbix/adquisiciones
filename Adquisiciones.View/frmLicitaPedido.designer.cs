namespace Adquisiciones.View
{
    partial class FrmLicitaPedido
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
            this.gbxPedido = new System.Windows.Forms.GroupBox();
            this.cbxIva = new System.Windows.Forms.ComboBox();
            this.cbxRequisicion = new System.Windows.Forms.ComboBox();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.cbxActividad = new System.Windows.Forms.ComboBox();
            this.txtCarga = new System.Windows.Forms.Button();
            this.txtLicitacion = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.dtpFechapedido = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaentraga2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaentrega = new System.Windows.Forms.DateTimePicker();
            this.txtDesfundamento = new System.Windows.Forms.TextBox();
            this.txtDeslicitacion = new System.Windows.Forms.TextBox();
            this.txtDesarea = new System.Windows.Forms.TextBox();
            this.txtFundamento = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblFundamento = new System.Windows.Forms.Label();
            this.lblFechaentrega = new System.Windows.Forms.Label();
            this.lblFechapedido = new System.Windows.Forms.Label();
            this.lblLicitacion = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblRequisicion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbxPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPedido
            // 
            this.gbxPedido.Controls.Add(this.cbxIva);
            this.gbxPedido.Controls.Add(this.cbxRequisicion);
            this.gbxPedido.Controls.Add(this.cbxCargo);
            this.gbxPedido.Controls.Add(this.cbxActividad);
            this.gbxPedido.Controls.Add(this.txtCarga);
            this.gbxPedido.Controls.Add(this.txtLicitacion);
            this.gbxPedido.Controls.Add(this.txtFecha);
            this.gbxPedido.Controls.Add(this.dtpFechapedido);
            this.gbxPedido.Controls.Add(this.dtpFechaentraga2);
            this.gbxPedido.Controls.Add(this.dtpFechaentrega);
            this.gbxPedido.Controls.Add(this.txtDesfundamento);
            this.gbxPedido.Controls.Add(this.txtDeslicitacion);
            this.gbxPedido.Controls.Add(this.txtDesarea);
            this.gbxPedido.Controls.Add(this.txtFundamento);
            this.gbxPedido.Controls.Add(this.txtArea);
            this.gbxPedido.Controls.Add(this.lblIva);
            this.gbxPedido.Controls.Add(this.lblCargo);
            this.gbxPedido.Controls.Add(this.lblActividad);
            this.gbxPedido.Controls.Add(this.lblFundamento);
            this.gbxPedido.Controls.Add(this.lblFechaentrega);
            this.gbxPedido.Controls.Add(this.lblFechapedido);
            this.gbxPedido.Controls.Add(this.lblLicitacion);
            this.gbxPedido.Controls.Add(this.lblArea);
            this.gbxPedido.Controls.Add(this.lblFecha);
            this.gbxPedido.Controls.Add(this.lblRequisicion);
            this.gbxPedido.Location = new System.Drawing.Point(25, 12);
            this.gbxPedido.Name = "gbxPedido";
            this.gbxPedido.Size = new System.Drawing.Size(713, 245);
            this.gbxPedido.TabIndex = 0;
            this.gbxPedido.TabStop = false;
            this.gbxPedido.Text = "Datos del Pedido";
            // 
            // cbxIva
            // 
            this.cbxIva.FormattingEnabled = true;
            this.cbxIva.Location = new System.Drawing.Point(662, 205);
            this.cbxIva.Name = "cbxIva";
            this.cbxIva.Size = new System.Drawing.Size(39, 21);
            this.cbxIva.TabIndex = 61;
            // 
            // cbxRequisicion
            // 
            this.cbxRequisicion.FormattingEnabled = true;
            this.cbxRequisicion.Location = new System.Drawing.Point(117, 22);
            this.cbxRequisicion.Name = "cbxRequisicion";
            this.cbxRequisicion.Size = new System.Drawing.Size(84, 21);
            this.cbxRequisicion.TabIndex = 60;
            this.cbxRequisicion.SelectedIndexChanged += new System.EventHandler(this.cbxRequisicion_SelectedIndexChanged);
            // 
            // cbxCargo
            // 
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Location = new System.Drawing.Point(415, 205);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(176, 21);
            this.cbxCargo.TabIndex = 59;
            // 
            // cbxActividad
            // 
            this.cbxActividad.FormattingEnabled = true;
            this.cbxActividad.Location = new System.Drawing.Point(120, 204);
            this.cbxActividad.Name = "cbxActividad";
            this.cbxActividad.Size = new System.Drawing.Size(136, 21);
            this.cbxActividad.TabIndex = 58;
            // 
            // txtCarga
            // 
            this.txtCarga.Location = new System.Drawing.Point(212, 20);
            this.txtCarga.Name = "txtCarga";
            this.txtCarga.Size = new System.Drawing.Size(44, 23);
            this.txtCarga.TabIndex = 57;
            this.txtCarga.Text = "Carga";
            this.txtCarga.UseVisualStyleBackColor = true;
            this.txtCarga.Click += new System.EventHandler(this.txtCarga_Click);
            // 
            // txtLicitacion
            // 
            this.txtLicitacion.Location = new System.Drawing.Point(120, 92);
            this.txtLicitacion.Name = "txtLicitacion";
            this.txtLicitacion.ReadOnly = true;
            this.txtLicitacion.Size = new System.Drawing.Size(118, 20);
            this.txtLicitacion.TabIndex = 56;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(624, 22);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(77, 20);
            this.txtFecha.TabIndex = 55;
            // 
            // dtpFechapedido
            // 
            this.dtpFechapedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechapedido.Location = new System.Drawing.Point(120, 128);
            this.dtpFechapedido.Name = "dtpFechapedido";
            this.dtpFechapedido.Size = new System.Drawing.Size(100, 20);
            this.dtpFechapedido.TabIndex = 54;
            // 
            // dtpFechaentraga2
            // 
            this.dtpFechaentraga2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaentraga2.Location = new System.Drawing.Point(601, 128);
            this.dtpFechaentraga2.Name = "dtpFechaentraga2";
            this.dtpFechaentraga2.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaentraga2.TabIndex = 52;
            // 
            // dtpFechaentrega
            // 
            this.dtpFechaentrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaentrega.Location = new System.Drawing.Point(471, 128);
            this.dtpFechaentrega.Name = "dtpFechaentrega";
            this.dtpFechaentrega.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaentrega.TabIndex = 51;
            // 
            // txtDesfundamento
            // 
            this.txtDesfundamento.Location = new System.Drawing.Point(212, 165);
            this.txtDesfundamento.Name = "txtDesfundamento";
            this.txtDesfundamento.Size = new System.Drawing.Size(489, 20);
            this.txtDesfundamento.TabIndex = 48;
            // 
            // txtDeslicitacion
            // 
            this.txtDeslicitacion.Location = new System.Drawing.Point(257, 93);
            this.txtDeslicitacion.Name = "txtDeslicitacion";
            this.txtDeslicitacion.ReadOnly = true;
            this.txtDeslicitacion.Size = new System.Drawing.Size(444, 20);
            this.txtDeslicitacion.TabIndex = 47;
            // 
            // txtDesarea
            // 
            this.txtDesarea.Location = new System.Drawing.Point(212, 58);
            this.txtDesarea.Name = "txtDesarea";
            this.txtDesarea.ReadOnly = true;
            this.txtDesarea.Size = new System.Drawing.Size(489, 20);
            this.txtDesarea.TabIndex = 45;
            // 
            // txtFundamento
            // 
            this.txtFundamento.Location = new System.Drawing.Point(120, 165);
            this.txtFundamento.Name = "txtFundamento";
            this.txtFundamento.Size = new System.Drawing.Size(81, 20);
            this.txtFundamento.TabIndex = 41;
            this.txtFundamento.TextChanged += new System.EventHandler(this.txtFundamento_TextChanged);
            this.txtFundamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFundamento_KeyPress);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(120, 58);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(81, 20);
            this.txtArea.TabIndex = 37;
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(621, 207);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(35, 13);
            this.lblIva.TabIndex = 34;
            this.lblIva.Text = "IVA %";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(350, 207);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(44, 13);
            this.lblCargo.TabIndex = 33;
            this.lblCargo.Text = "Cargo a";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(9, 207);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 32;
            this.lblActividad.Text = "Actividad";
            // 
            // lblFundamento
            // 
            this.lblFundamento.AutoSize = true;
            this.lblFundamento.Location = new System.Drawing.Point(7, 165);
            this.lblFundamento.Name = "lblFundamento";
            this.lblFundamento.Size = new System.Drawing.Size(95, 13);
            this.lblFundamento.TabIndex = 31;
            this.lblFundamento.Text = "Fundamento Legal";
            // 
            // lblFechaentrega
            // 
            this.lblFechaentrega.AutoSize = true;
            this.lblFechaentrega.Location = new System.Drawing.Point(348, 131);
            this.lblFechaentrega.Name = "lblFechaentrega";
            this.lblFechaentrega.Size = new System.Drawing.Size(77, 13);
            this.lblFechaentrega.TabIndex = 30;
            this.lblFechaentrega.Text = "Fecha Entrega";
            // 
            // lblFechapedido
            // 
            this.lblFechapedido.AutoSize = true;
            this.lblFechapedido.Location = new System.Drawing.Point(7, 131);
            this.lblFechapedido.Name = "lblFechapedido";
            this.lblFechapedido.Size = new System.Drawing.Size(73, 13);
            this.lblFechapedido.TabIndex = 29;
            this.lblFechapedido.Text = "Fecha Pedido";
            // 
            // lblLicitacion
            // 
            this.lblLicitacion.AutoSize = true;
            this.lblLicitacion.Location = new System.Drawing.Point(7, 96);
            this.lblLicitacion.Name = "lblLicitacion";
            this.lblLicitacion.Size = new System.Drawing.Size(52, 13);
            this.lblLicitacion.TabIndex = 28;
            this.lblLicitacion.Text = "Licitación";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(7, 61);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(29, 13);
            this.lblArea.TabIndex = 27;
            this.lblArea.Text = "Área";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(554, 29);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 26;
            this.lblFecha.Text = "Fecha";
            // 
            // lblRequisicion
            // 
            this.lblRequisicion.AutoSize = true;
            this.lblRequisicion.Location = new System.Drawing.Point(7, 29);
            this.lblRequisicion.Name = "lblRequisicion";
            this.lblRequisicion.Size = new System.Drawing.Size(62, 13);
            this.lblRequisicion.TabIndex = 25;
            this.lblRequisicion.Text = "Requisición";
            // 
            // btnAceptar
            // 
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(606, 263);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(58, 58);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.Location = new System.Drawing.Point(680, 263);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(58, 58);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmLicitaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 330);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbxPedido);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(773, 368);
            this.MinimumSize = new System.Drawing.Size(773, 368);
            this.Name = "FrmLicitaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.frmLicitaPedido_Load);
            this.gbxPedido.ResumeLayout(false);
            this.gbxPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPedido;
        private System.Windows.Forms.TextBox txtDesfundamento;
        private System.Windows.Forms.TextBox txtDeslicitacion;
        private System.Windows.Forms.TextBox txtDesarea;
        private System.Windows.Forms.TextBox txtFundamento;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblFundamento;
        private System.Windows.Forms.Label lblFechaentrega;
        private System.Windows.Forms.Label lblFechapedido;
        private System.Windows.Forms.Label lblLicitacion;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblRequisicion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker dtpFechaentraga2;
        private System.Windows.Forms.DateTimePicker dtpFechaentrega;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.DateTimePicker dtpFechapedido;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.ComboBox cbxActividad;
        private System.Windows.Forms.Button txtCarga;
        private System.Windows.Forms.TextBox txtLicitacion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cbxRequisicion;
        private System.Windows.Forms.ComboBox cbxIva;

    }
}