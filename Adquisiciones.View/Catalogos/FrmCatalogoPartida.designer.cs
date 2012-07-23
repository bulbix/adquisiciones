namespace Adquisiciones.View.Catalogos
{
    partial class FrmCatalogoPartida
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
            this.btnConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.cbxClase = new System.Windows.Forms.ComboBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClase = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNumErrors = new System.Windows.Forms.Label();
            this.listaError = new System.Windows.Forms.ListBox();
            this.bsPartida = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPartida)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::Adquisiciones.View.Properties.Resources.search;
            this.btnConsultar.Location = new System.Drawing.Point(548, 244);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(120, 95);
            this.btnConsultar.TabIndex = 104;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Adquisiciones.View.Properties.Resources.save_icon;
            this.btnGuardar.Location = new System.Drawing.Point(427, 244);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 95);
            this.btnGuardar.TabIndex = 103;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Adquisiciones.View.Properties.Resources.reportes;
            this.btnNuevo.Location = new System.Drawing.Point(298, 244);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(123, 95);
            this.btnNuevo.TabIndex = 102;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtDescripcion);
            this.groupControl1.Controls.Add(this.cbxClase);
            this.groupControl1.Controls.Add(this.txtClave);
            this.groupControl1.Controls.Add(this.lblClase);
            this.groupControl1.Controls.Add(this.lblDescripcion);
            this.groupControl1.Controls.Add(this.lblClave);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(656, 210);
            this.groupControl1.TabIndex = 105;
            this.groupControl1.Text = "Partida";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(107, 88);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(414, 78);
            this.txtDescripcion.TabIndex = 12;
            this.txtDescripcion.Text = "";
            // 
            // cbxClase
            // 
            this.cbxClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClase.FormattingEnabled = true;
            this.cbxClase.Location = new System.Drawing.Point(385, 44);
            this.cbxClase.Name = "cbxClase";
            this.cbxClase.Size = new System.Drawing.Size(121, 21);
            this.cbxClase.TabIndex = 11;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(107, 45);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(95, 20);
            this.txtClave.TabIndex = 10;
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(319, 47);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(33, 13);
            this.lblClase.TabIndex = 9;
            this.lblClase.Text = "Clase";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(11, 100);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(11, 48);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 7;
            this.lblClave.Text = "Clave";
            // 
            // lblNumErrors
            // 
            this.lblNumErrors.AutoSize = true;
            this.lblNumErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumErrors.Location = new System.Drawing.Point(12, 228);
            this.lblNumErrors.Name = "lblNumErrors";
            this.lblNumErrors.Size = new System.Drawing.Size(58, 13);
            this.lblNumErrors.TabIndex = 107;
            this.lblNumErrors.Text = "0 Errores";
            // 
            // listaError
            // 
            this.listaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaError.ForeColor = System.Drawing.Color.Red;
            this.listaError.FormattingEnabled = true;
            this.listaError.ItemHeight = 16;
            this.listaError.Location = new System.Drawing.Point(12, 244);
            this.listaError.Name = "listaError";
            this.listaError.Size = new System.Drawing.Size(268, 100);
            this.listaError.TabIndex = 106;
            // 
            // FrmCatalogoPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(691, 354);
            this.Controls.Add(this.lblNumErrors);
            this.Controls.Add(this.listaError);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.MaximizeBox = false;
            this.Name = "FrmCatalogoPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo de Partidas";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPartida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnConsultar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbxClase;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNumErrors;
        private System.Windows.Forms.ListBox listaError;
        private System.Windows.Forms.BindingSource bsPartida;
    }
}