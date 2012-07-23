namespace Adquisiciones.View.Catalogos
{
    partial class FrmCatalogoFundamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCatalogoFundamento));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtFraccion = new System.Windows.Forms.TextBox();
            this.txtInciso = new System.Windows.Forms.TextBox();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumErrors = new System.Windows.Forms.Label();
            this.listaError = new System.Windows.Forms.ListBox();
            this.btnConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.bsFundamento = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFundamento)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtDescripcion);
            this.groupControl1.Controls.Add(this.txtFraccion);
            this.groupControl1.Controls.Add(this.txtInciso);
            this.groupControl1.Controls.Add(this.txtArticulo);
            this.groupControl1.Controls.Add(this.txtClave);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(29, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(659, 216);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Fundamento Legal";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(98, 98);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(433, 96);
            this.txtDescripcion.TabIndex = 19;
            this.txtDescripcion.Text = "";
            // 
            // txtFraccion
            // 
            this.txtFraccion.Location = new System.Drawing.Point(302, 58);
            this.txtFraccion.Name = "txtFraccion";
            this.txtFraccion.Size = new System.Drawing.Size(69, 20);
            this.txtFraccion.TabIndex = 18;
            // 
            // txtInciso
            // 
            this.txtInciso.Location = new System.Drawing.Point(302, 32);
            this.txtInciso.Name = "txtInciso";
            this.txtInciso.Size = new System.Drawing.Size(69, 20);
            this.txtInciso.TabIndex = 17;
            // 
            // txtArticulo
            // 
            this.txtArticulo.Location = new System.Drawing.Point(98, 58);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(69, 20);
            this.txtArticulo.TabIndex = 16;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(98, 32);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(69, 20);
            this.txtClave.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fracción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Inciso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Articulo ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Clave ";
            // 
            // lblNumErrors
            // 
            this.lblNumErrors.AutoSize = true;
            this.lblNumErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumErrors.Location = new System.Drawing.Point(32, 231);
            this.lblNumErrors.Name = "lblNumErrors";
            this.lblNumErrors.Size = new System.Drawing.Size(58, 13);
            this.lblNumErrors.TabIndex = 112;
            this.lblNumErrors.Text = "0 Errores";
            // 
            // listaError
            // 
            this.listaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaError.ForeColor = System.Drawing.Color.Red;
            this.listaError.FormattingEnabled = true;
            this.listaError.ItemHeight = 16;
            this.listaError.Location = new System.Drawing.Point(32, 247);
            this.listaError.Name = "listaError";
            this.listaError.Size = new System.Drawing.Size(268, 100);
            this.listaError.TabIndex = 111;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::Adquisiciones.View.Properties.Resources.search;
            this.btnConsultar.Location = new System.Drawing.Point(568, 247);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(120, 95);
            this.btnConsultar.TabIndex = 110;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Adquisiciones.View.Properties.Resources.save_icon;
            this.btnGuardar.Location = new System.Drawing.Point(447, 247);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 95);
            this.btnGuardar.TabIndex = 109;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::Adquisiciones.View.Properties.Resources.reportes;
            this.btnNuevo.Location = new System.Drawing.Point(318, 247);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(123, 95);
            this.btnNuevo.TabIndex = 108;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
            // 
            // FrmCatalogoFundamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(715, 465);
            this.Controls.Add(this.lblNumErrors);
            this.Controls.Add(this.listaError);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCatalogoFundamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo Fundamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFundamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtFraccion;
        private System.Windows.Forms.TextBox txtInciso;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumErrors;
        private System.Windows.Forms.ListBox listaError;
        private DevExpress.XtraEditors.SimpleButton btnConsultar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private System.Windows.Forms.BindingSource bsFundamento;

    }
}