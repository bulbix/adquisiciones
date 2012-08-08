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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.cbxClase = new System.Windows.Forms.ComboBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClase = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtDescripcion);
            this.groupControl1.Controls.Add(this.cbxClase);
            this.groupControl1.Controls.Add(this.txtClave);
            this.groupControl1.Controls.Add(this.lblClase);
            this.groupControl1.Controls.Add(this.lblDescripcion);
            this.groupControl1.Controls.Add(this.lblClave);
            this.groupControl1.Location = new System.Drawing.Point(33, 130);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(656, 210);
            this.groupControl1.TabIndex = 106;
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
            this.txtClave.Size = new System.Drawing.Size(95, 21);
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
            this.lblDescripcion.Size = new System.Drawing.Size(61, 13);
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
            // FrmCatalogoPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 470);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmCatalogoPartida";
            this.Text = "Catálogo Partida";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bsSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbxClase;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblClave;
    }
}