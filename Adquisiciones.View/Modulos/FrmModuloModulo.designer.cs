namespace Adquisiciones.View
{
    partial class FrmModuloModulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModuloModulo));
            this.btnAdqconacyt5000 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdq5000 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdqconacyt2000 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdq2000 = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdqconacyt5000
            // 
            this.btnAdqconacyt5000.Enabled = false;
            this.btnAdqconacyt5000.Image = global::Adquisiciones.View.Properties.Resources.conacyt;
            this.btnAdqconacyt5000.Location = new System.Drawing.Point(270, 84);
            this.btnAdqconacyt5000.Name = "btnAdqconacyt5000";
            this.btnAdqconacyt5000.Size = new System.Drawing.Size(250, 74);
            this.btnAdqconacyt5000.TabIndex = 17;
            this.btnAdqconacyt5000.Tag = "C5";
            this.btnAdqconacyt5000.Text = "ADQUISICIONES CONACYT 5000";
            this.btnAdqconacyt5000.Click += new System.EventHandler(this.BtnAdqconacyt5000Click);
            // 
            // btnAdq5000
            // 
            this.btnAdq5000.Enabled = false;
            this.btnAdq5000.Image = global::Adquisiciones.View.Properties.Resources.conacyt;
            this.btnAdq5000.Location = new System.Drawing.Point(270, 12);
            this.btnAdq5000.Name = "btnAdq5000";
            this.btnAdq5000.Size = new System.Drawing.Size(250, 69);
            this.btnAdq5000.TabIndex = 16;
            this.btnAdq5000.Tag = "P5";
            this.btnAdq5000.Text = "ADQUISICIONES 5000";
            this.btnAdq5000.Click += new System.EventHandler(this.BtnAdq5000Click);
            // 
            // btnAdqconacyt2000
            // 
            this.btnAdqconacyt2000.Enabled = false;
            this.btnAdqconacyt2000.Image = global::Adquisiciones.View.Properties.Resources.conacyt;
            this.btnAdqconacyt2000.Location = new System.Drawing.Point(12, 87);
            this.btnAdqconacyt2000.Name = "btnAdqconacyt2000";
            this.btnAdqconacyt2000.Size = new System.Drawing.Size(252, 71);
            this.btnAdqconacyt2000.TabIndex = 15;
            this.btnAdqconacyt2000.Tag = "C2";
            this.btnAdqconacyt2000.Text = "ADQUISICIONES CONACYT 2000";
            this.btnAdqconacyt2000.Click += new System.EventHandler(this.BtnAdqconacyt2000Click);
            // 
            // btnAdq2000
            // 
            this.btnAdq2000.Enabled = false;
            this.btnAdq2000.Image = global::Adquisiciones.View.Properties.Resources.conacyt;
            this.btnAdq2000.Location = new System.Drawing.Point(12, 12);
            this.btnAdq2000.Name = "btnAdq2000";
            this.btnAdq2000.Size = new System.Drawing.Size(252, 69);
            this.btnAdq2000.TabIndex = 14;
            this.btnAdq2000.Tag = "P2";
            this.btnAdq2000.Text = "ADQUISICIONES 2000";
            this.btnAdq2000.Click += new System.EventHandler(this.BtnAdq2000Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Enabled = false;
            this.cmdCancelar.Location = new System.Drawing.Point(567, 101);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(133, 57);
            this.cmdCancelar.TabIndex = 19;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.CmdCancelarClick);
            // 
            // FrmModuloModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 207);
            this.ControlBox = false;
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.btnAdqconacyt5000);
            this.Controls.Add(this.btnAdq5000);
            this.Controls.Add(this.btnAdqconacyt2000);
            this.Controls.Add(this.btnAdq2000);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(728, 245);
            this.MinimumSize = new System.Drawing.Size(720, 234);
            this.Name = "FrmModuloModulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Almacen";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnAdq2000;
        private DevExpress.XtraEditors.SimpleButton btnAdqconacyt2000;
        private DevExpress.XtraEditors.SimpleButton btnAdq5000;
        private DevExpress.XtraEditors.SimpleButton btnAdqconacyt5000;
        private System.Windows.Forms.Button cmdCancelar;


    }
}