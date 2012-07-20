namespace Adquisiciones.View
{
    partial class frmPrecios
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
            this.gpb = new System.Windows.Forms.GroupBox();
            this.rtbDesclave = new System.Windows.Forms.RichTextBox();
            this.txtDesunidad = new System.Windows.Forms.TextBox();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.lblCon = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.txtDespartida = new System.Windows.Forms.TextBox();
            this.txtPartida = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.lblUalmacen = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPartida = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.dgvPrecios = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb
            // 
            this.gpb.Controls.Add(this.rtbDesclave);
            this.gpb.Controls.Add(this.txtDesunidad);
            this.gpb.Controls.Add(this.txtCon);
            this.gpb.Controls.Add(this.lblCon);
            this.gpb.Controls.Add(this.txtUnidad);
            this.gpb.Controls.Add(this.txtPresentacion);
            this.gpb.Controls.Add(this.txtDespartida);
            this.gpb.Controls.Add(this.txtPartida);
            this.gpb.Controls.Add(this.txtClave);
            this.gpb.Controls.Add(this.lblPresentacion);
            this.gpb.Controls.Add(this.lblUalmacen);
            this.gpb.Controls.Add(this.lblDescripcion);
            this.gpb.Controls.Add(this.lblPartida);
            this.gpb.Controls.Add(this.lblClave);
            this.gpb.Location = new System.Drawing.Point(26, 32);
            this.gpb.Name = "gpb";
            this.gpb.Size = new System.Drawing.Size(719, 158);
            this.gpb.TabIndex = 0;
            this.gpb.TabStop = false;
            this.gpb.Text = "Datos ";
            // 
            // rtbDesclave
            // 
            this.rtbDesclave.Location = new System.Drawing.Point(92, 45);
            this.rtbDesclave.Name = "rtbDesclave";
            this.rtbDesclave.Size = new System.Drawing.Size(607, 72);
            this.rtbDesclave.TabIndex = 17;
            this.rtbDesclave.Text = "";
            // 
            // txtDesunidad
            // 
            this.txtDesunidad.Location = new System.Drawing.Point(290, 123);
            this.txtDesunidad.Name = "txtDesunidad";
            this.txtDesunidad.Size = new System.Drawing.Size(152, 20);
            this.txtDesunidad.TabIndex = 15;
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(243, 123);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(39, 20);
            this.txtCon.TabIndex = 14;
            this.txtCon.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(212, 126);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(25, 13);
            this.lblCon.TabIndex = 13;
            this.lblCon.Text = "con";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(550, 123);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(117, 20);
            this.txtUnidad.TabIndex = 11;
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Location = new System.Drawing.Point(92, 123);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(100, 20);
            this.txtPresentacion.TabIndex = 10;
            // 
            // txtDespartida
            // 
            this.txtDespartida.Location = new System.Drawing.Point(344, 16);
            this.txtDespartida.Name = "txtDespartida";
            this.txtDespartida.Size = new System.Drawing.Size(355, 20);
            this.txtDespartida.TabIndex = 8;
            // 
            // txtPartida
            // 
            this.txtPartida.Location = new System.Drawing.Point(258, 16);
            this.txtPartida.Name = "txtPartida";
            this.txtPartida.Size = new System.Drawing.Size(71, 20);
            this.txtPartida.TabIndex = 7;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(92, 16);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(51, 20);
            this.txtClave.TabIndex = 6;
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Location = new System.Drawing.Point(20, 127);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(69, 13);
            this.lblPresentacion.TabIndex = 4;
            this.lblPresentacion.Text = "Presentación";
            // 
            // lblUalmacen
            // 
            this.lblUalmacen.AutoSize = true;
            this.lblUalmacen.Location = new System.Drawing.Point(482, 127);
            this.lblUalmacen.Name = "lblUalmacen";
            this.lblUalmacen.Size = new System.Drawing.Size(41, 13);
            this.lblUalmacen.TabIndex = 3;
            this.lblUalmacen.Text = "Unidad";
            this.lblUalmacen.Click += new System.EventHandler(this.lblUalmacen_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(20, 54);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblPartida
            // 
            this.lblPartida.AutoSize = true;
            this.lblPartida.Location = new System.Drawing.Point(212, 19);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(40, 13);
            this.lblPartida.TabIndex = 1;
            this.lblPartida.Text = "Partida";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(20, 19);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave";
            // 
            // dgvPrecios
            // 
            this.dgvPrecios.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvPrecios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Costo,
            this.Marca,
            this.Proveedor});
            this.dgvPrecios.Location = new System.Drawing.Point(26, 207);
            this.dgvPrecios.Name = "dgvPrecios";
            this.dgvPrecios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvPrecios.Size = new System.Drawing.Size(719, 166);
            this.dgvPrecios.TabIndex = 5;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Fecha.Width = 70;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.Width = 70;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.Width = 130;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Proveedor.Width = 410;
            // 
            // frmPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(772, 534);
            this.Controls.Add(this.dgvPrecios);
            this.Controls.Add(this.gpb);
            this.MaximizeBox = false;
            this.Name = "frmPrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Precios";
            this.gpb.ResumeLayout(false);
            this.gpb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb;
        private System.Windows.Forms.Label lblPresentacion;
        private System.Windows.Forms.Label lblUalmacen;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPartida;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtPresentacion;
        private System.Windows.Forms.TextBox txtDespartida;
        private System.Windows.Forms.TextBox txtPartida;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.TextBox txtDesunidad;
        private System.Windows.Forms.DataGridView dgvPrecios;
        private System.Windows.Forms.RichTextBox rtbDesclave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
    }
}