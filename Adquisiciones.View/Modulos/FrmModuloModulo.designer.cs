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
            this.SuspendLayout();
            // 
            // btnAdqconacyt5000
            // 
            this.btnAdqconacyt5000.Enabled = false;
            this.btnAdqconacyt5000.Image = global::Adquisiciones.View.Properties.Resources.conacyt;
            this.btnAdqconacyt5000.Location = new System.Drawing.Point(508, 42);
            this.btnAdqconacyt5000.Name = "btnAdqconacyt5000";
            this.btnAdqconacyt5000.Size = new System.Drawing.Size(129, 100);
            this.btnAdqconacyt5000.TabIndex = 17;
            this.btnAdqconacyt5000.Tag = "C5";
            this.btnAdqconacyt5000.Text = "5000";
            this.btnAdqconacyt5000.Click += new System.EventHandler(this.BtnAdqconacyt5000Click);
            // 
            // btnAdq5000
            // 
            this.btnAdq5000.Enabled = false;
            this.btnAdq5000.Image = global::Adquisiciones.View.Properties.Resources.conacyt;
            this.btnAdq5000.Location = new System.Drawing.Point(359, 42);
            this.btnAdq5000.Name = "btnAdq5000";
            this.btnAdq5000.Size = new System.Drawing.Size(129, 100);
            this.btnAdq5000.TabIndex = 16;
            this.btnAdq5000.Tag = "P5";
            this.btnAdq5000.Text = "5000";
            this.btnAdq5000.Click += new System.EventHandler(this.BtnAdq5000Click);
            // 
            // btnAdqconacyt2000
            // 
            this.btnAdqconacyt2000.Enabled = false;
            this.btnAdqconacyt2000.Image = global::Adquisiciones.View.Properties.Resources.conacyt;
            this.btnAdqconacyt2000.Location = new System.Drawing.Point(204, 42);
            this.btnAdqconacyt2000.Name = "btnAdqconacyt2000";
            this.btnAdqconacyt2000.Size = new System.Drawing.Size(129, 100);
            this.btnAdqconacyt2000.TabIndex = 15;
            this.btnAdqconacyt2000.Tag = "C2";
            this.btnAdqconacyt2000.Text = "2000";
            this.btnAdqconacyt2000.Click += new System.EventHandler(this.BtnAdqconacyt2000Click);
            // 
            // btnAdq2000
            // 
            this.btnAdq2000.Enabled = false;
            this.btnAdq2000.Image = global::Adquisiciones.View.Properties.Resources.conacyt;
            this.btnAdq2000.Location = new System.Drawing.Point(42, 42);
            this.btnAdq2000.Name = "btnAdq2000";
            this.btnAdq2000.Size = new System.Drawing.Size(129, 100);
            this.btnAdq2000.TabIndex = 14;
            this.btnAdq2000.Tag = "P2";
            this.btnAdq2000.Text = "2000";
            this.btnAdq2000.Click += new System.EventHandler(this.BtnAdq2000Click);
            // 
            // FrmModuloModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 196);
            this.Controls.Add(this.btnAdqconacyt5000);
            this.Controls.Add(this.btnAdq5000);
            this.Controls.Add(this.btnAdqconacyt2000);
            this.Controls.Add(this.btnAdq2000);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(712, 223);
            this.MinimumSize = new System.Drawing.Size(712, 223);
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


    }
}