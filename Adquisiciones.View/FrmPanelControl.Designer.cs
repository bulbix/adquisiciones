namespace Adquisiciones.View
{
    partial class FrmPanelControl
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
            this.lstUsuario = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bsUsuarios = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpUsuario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bsOrigen = new System.Windows.Forms.BindingSource(this.components);
            this.bsDestino = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkActivo = new DevExpress.XtraEditors.CheckButton();
            this.txtConfirmPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNewPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdGuardarPerfil = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmdIzquierda = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDerecha = new DevExpress.XtraEditors.SimpleButton();
            this.lstDestino = new DevExpress.XtraEditors.ListBoxControl();
            this.lstOrigen = new DevExpress.XtraEditors.ListBoxControl();
            this.cmdOmitir = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtRfc = new System.Windows.Forms.MaskedTextBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtCurrentPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmdGuardarPassword = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.bsUsuario = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lstUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstOrigen)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUsuario
            // 
            this.lstUsuario.Location = new System.Drawing.Point(60, 12);
            this.lstUsuario.Name = "lstUsuario";
            this.lstUsuario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lstUsuario.Properties.DataSource = this.bsUsuarios;
            this.lstUsuario.Properties.View = this.searchLookUpUsuario;
            this.lstUsuario.Size = new System.Drawing.Size(360, 20);
            this.lstUsuario.TabIndex = 0;
            this.lstUsuario.EditValueChanged += new System.EventHandler(this.lstUsuario_EditValueChanged);
            // 
            // searchLookUpUsuario
            // 
            this.searchLookUpUsuario.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpUsuario.Name = "searchLookUpUsuario";
            this.searchLookUpUsuario.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpUsuario.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Usuarios";
            // 
            // chkActivo
            // 
            this.chkActivo.Location = new System.Drawing.Point(450, 20);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(89, 23);
            this.chkActivo.TabIndex = 15;
            this.chkActivo.Text = "Usuario Activo";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(82, 149);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Properties.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(152, 20);
            this.txtConfirmPass.TabIndex = 14;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 155);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(51, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Confirmar:";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(82, 115);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Properties.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(152, 20);
            this.txtNewPass.TabIndex = 12;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 119);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Nueva:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdGuardarPerfil);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.cmdIzquierda);
            this.groupBox1.Controls.Add(this.cmdDerecha);
            this.groupBox1.Controls.Add(this.lstDestino);
            this.groupBox1.Controls.Add(this.lstOrigen);
            this.groupBox1.Location = new System.Drawing.Point(13, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 492);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perfiles";
            // 
            // cmdGuardarPerfil
            // 
            this.cmdGuardarPerfil.Location = new System.Drawing.Point(225, 258);
            this.cmdGuardarPerfil.Name = "cmdGuardarPerfil";
            this.cmdGuardarPerfil.Size = new System.Drawing.Size(106, 23);
            this.cmdGuardarPerfil.TabIndex = 17;
            this.cmdGuardarPerfil.Text = "Guardar Perfiles";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(354, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Perfiles asignados";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Perfiles sin asignar";
            // 
            // cmdIzquierda
            // 
            this.cmdIzquierda.Location = new System.Drawing.Point(245, 190);
            this.cmdIzquierda.Name = "cmdIzquierda";
            this.cmdIzquierda.Size = new System.Drawing.Size(75, 23);
            this.cmdIzquierda.TabIndex = 14;
            this.cmdIzquierda.Text = "<";
            // 
            // cmdDerecha
            // 
            this.cmdDerecha.Location = new System.Drawing.Point(245, 148);
            this.cmdDerecha.Name = "cmdDerecha";
            this.cmdDerecha.Size = new System.Drawing.Size(75, 23);
            this.cmdDerecha.TabIndex = 13;
            this.cmdDerecha.Text = ">";
            // 
            // lstDestino
            // 
            this.lstDestino.DataSource = this.bsDestino;
            this.lstDestino.Location = new System.Drawing.Point(354, 55);
            this.lstDestino.Name = "lstDestino";
            this.lstDestino.Size = new System.Drawing.Size(194, 402);
            this.lstDestino.TabIndex = 12;
            // 
            // lstOrigen
            // 
            this.lstOrigen.DataSource = this.bsOrigen;
            this.lstOrigen.Location = new System.Drawing.Point(17, 55);
            this.lstOrigen.Name = "lstOrigen";
            this.lstOrigen.Size = new System.Drawing.Size(186, 402);
            this.lstOrigen.TabIndex = 11;
            // 
            // cmdOmitir
            // 
            this.cmdOmitir.Location = new System.Drawing.Point(428, 11);
            this.cmdOmitir.Name = "cmdOmitir";
            this.cmdOmitir.Size = new System.Drawing.Size(75, 23);
            this.cmdOmitir.TabIndex = 18;
            this.cmdOmitir.Text = "Omitir";
            this.cmdOmitir.Click += new System.EventHandler(this.cmdOmitir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelControl9);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.labelControl8);
            this.groupBox2.Controls.Add(this.txtRfc);
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Controls.Add(this.txtCurrentPass);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Controls.Add(this.cmdGuardarPassword);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.txtNewPass);
            this.groupBox2.Controls.Add(this.chkActivo);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.txtConfirmPass);
            this.groupBox2.Location = new System.Drawing.Point(13, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 174);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contraseña";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(264, 21);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(63, 13);
            this.labelControl9.TabIndex = 25;
            this.labelControl9.Text = "labelControl9";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(152, 20);
            this.txtNombre.TabIndex = 24;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(15, 51);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(41, 13);
            this.labelControl8.TabIndex = 23;
            this.labelControl8.Text = "Nombre:";
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(82, 17);
            this.txtRfc.Mask = "LLLL000000LL0";
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(91, 21);
            this.txtRfc.TabIndex = 22;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(15, 20);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 13);
            this.labelControl7.TabIndex = 21;
            this.labelControl7.Text = "RFC:";
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Location = new System.Drawing.Point(82, 81);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Properties.PasswordChar = '*';
            this.txtCurrentPass.Size = new System.Drawing.Size(152, 20);
            this.txtCurrentPass.TabIndex = 20;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(17, 84);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 13);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Actual:";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // cmdGuardarPassword
            // 
            this.cmdGuardarPassword.Location = new System.Drawing.Point(429, 68);
            this.cmdGuardarPassword.Name = "cmdGuardarPassword";
            this.cmdGuardarPassword.Size = new System.Drawing.Size(129, 46);
            this.cmdGuardarPassword.TabIndex = 18;
            this.cmdGuardarPassword.Text = "Guardar Contraseña";
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Location = new System.Drawing.Point(506, 11);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(75, 23);
            this.cmdNuevo.TabIndex = 19;
            this.cmdNuevo.Text = "Nuevo";
            // 
            // FrmPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 705);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.cmdOmitir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lstUsuario);
            this.Name = "FrmPanelControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Control";
            this.Load += new System.EventHandler(this.FrmPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewPass.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstOrigen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit lstUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpUsuario;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bsOrigen;
        private System.Windows.Forms.BindingSource bsDestino;
        private System.Windows.Forms.BindingSource bsUsuarios;
        private DevExpress.XtraEditors.CheckButton chkActivo;
        private DevExpress.XtraEditors.TextEdit txtConfirmPass;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNewPass;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton cmdOmitir;
        private DevExpress.XtraEditors.SimpleButton cmdGuardarPerfil;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton cmdIzquierda;
        private DevExpress.XtraEditors.SimpleButton cmdDerecha;
        private DevExpress.XtraEditors.ListBoxControl lstDestino;
        private DevExpress.XtraEditors.ListBoxControl lstOrigen;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton cmdGuardarPassword;
        private DevExpress.XtraEditors.TextEdit txtCurrentPass;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton cmdNuevo;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.MaskedTextBox txtRfc;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.BindingSource bsUsuario;
    }
}