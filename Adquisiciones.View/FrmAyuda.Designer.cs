namespace Adquisiciones.View
{
    partial class FrmAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAyuda));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.windowsMedia = new AxWMPLib.AxWindowsMediaPlayer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmdPlay = new DevExpress.XtraEditors.SimpleButton();
            this.lstModulo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(151, 406);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Reproducir";
            // 
            // windowsMedia
            // 
            this.windowsMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowsMedia.Enabled = true;
            this.windowsMedia.Location = new System.Drawing.Point(0, 0);
            this.windowsMedia.Name = "windowsMedia";
            this.windowsMedia.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMedia.OcxState")));
            this.windowsMedia.Size = new System.Drawing.Size(605, 441);
            this.windowsMedia.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmdPlay);
            this.splitContainer1.Panel1.Controls.Add(this.lstModulo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.windowsMedia);
            this.splitContainer1.Size = new System.Drawing.Size(605, 491);
            this.splitContainer1.SplitterDistance = 46;
            this.splitContainer1.TabIndex = 3;
            // 
            // cmdPlay
            // 
            this.cmdPlay.Location = new System.Drawing.Point(210, 12);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(90, 23);
            this.cmdPlay.TabIndex = 4;
            this.cmdPlay.Text = "Reproducir";
            this.cmdPlay.Click += new System.EventHandler(this.SimpleButton2Click);
            // 
            // lstModulo
            // 
            this.lstModulo.FormattingEnabled = true;
            this.lstModulo.Items.AddRange(new object[] {
            "Anexo",
            "Cotizacion",
            "Fallo",
            "Pedido"});
            this.lstModulo.Location = new System.Drawing.Point(21, 15);
            this.lstModulo.Name = "lstModulo";
            this.lstModulo.Size = new System.Drawing.Size(172, 21);
            this.lstModulo.TabIndex = 3;
            // 
            // FrmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 491);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.simpleButton1);
            this.Name = "FrmAyuda";
            this.Text = "Ayuda Adquisiciones";
            ((System.ComponentModel.ISupportInitialize)(this.windowsMedia)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private AxWMPLib.AxWindowsMediaPlayer windowsMedia;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox lstModulo;
        private DevExpress.XtraEditors.SimpleButton cmdPlay;
    }
}