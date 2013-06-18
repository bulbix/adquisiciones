using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business.Seguridad;
using Adquisiciones.Data.Dao.Seguridad;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using Spring.Context;
using Spring.Context.Support;
using Spring.Windows.Forms;


namespace Adquisiciones.View
{
    ///<summary>
    ///</summary>
    public partial class FrmModuloAcceso : XtraForm
    {

        public static Usuario UsuarioLog;
        public IUsuarioService UsuarioService { private get; set; }
        private CaptchaImage captcha;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.txtRfc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.picCaptcha = new DevExpress.XtraEditors.PictureEdit();
            this.txtCaptcha = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRfc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptcha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaptcha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Adquisiciones.View.Properties.Resources.torrecnr;
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Image = global::Adquisiciones.View.Properties.Resources.accept;
            this.cmdAceptar.Location = new System.Drawing.Point(278, 253);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(122, 63);
            this.cmdAceptar.TabIndex = 3;
            this.cmdAceptar.Text = "Iniciar Sesion";
            this.cmdAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancelar.Image = global::Adquisiciones.View.Properties.Resources.cancelar;
            this.cmdCancelar.Location = new System.Drawing.Point(406, 251);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(122, 63);
            this.cmdCancelar.TabIndex = 4;
            this.cmdCancelar.Text = "Salir";
            this.cmdCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtRfc
            // 
            this.txtRfc.EditValue = "";
            this.txtRfc.Location = new System.Drawing.Point(278, 63);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(242, 20);
            this.txtRfc.TabIndex = 0;
            this.txtRfc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMayusculaKeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(278, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "RFC:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(278, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(278, 113);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(242, 21);
            this.txtPassword.TabIndex = 1;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Black";
            // 
            // picCaptcha
            // 
            this.picCaptcha.Location = new System.Drawing.Point(278, 144);
            this.picCaptcha.Name = "picCaptcha";
            this.picCaptcha.Size = new System.Drawing.Size(242, 58);
            this.picCaptcha.TabIndex = 8;
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.EditValue = "";
            this.txtCaptcha.Location = new System.Drawing.Point(278, 225);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.Size = new System.Drawing.Size(242, 20);
            this.txtCaptcha.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(278, 208);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(119, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Teclee codigo seguridad:";
            // 
            // FrmModuloAcceso
            // 
            this.AcceptButton = this.cmdAceptar;
            this.CancelButton = this.cmdCancelar;
            this.ClientSize = new System.Drawing.Size(558, 351);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtCaptcha);
            this.Controls.Add(this.picCaptcha);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtRfc);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(574, 389);
            this.MinimumSize = new System.Drawing.Size(566, 378);
            this.Name = "FrmModuloAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adquisiciones V 1.0 @ Instituto Nacional Rehabilitación";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmModuloAcceso_FormClosed);
            this.Load += new System.EventHandler(this.FrmModuloAcceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRfc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptcha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaptcha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public FrmModuloAcceso()
        {
            InitializeComponent();
            var ctx = ContextRegistry.GetContext();
            UsuarioService = ctx["usuarioService"] as IUsuarioService;
           

        }

        #region Metodos
        private void GenerarCaptcha()
        {
            captcha = new CaptchaImage(CaptchaImage.GenerateRandomCode(),
                picCaptcha.Width, picCaptcha.Height);
            picCaptcha.Image = captcha.Image;
        }

        private void LanzarPantallaInicio()
        {
            Hide();

            if (UsuarioLog.PanelControl)
                new FrmPanelControl().Show();
            else
                new FrmModuloModulo(false).Show();

        }

        #endregion

        #region Eventos
        private void BtnAceptarClick(object sender, EventArgs e)
        {
            UsuarioLog = UsuarioService.AccessAllow(txtRfc.Text, txtPassword.Text);

            if(txtCaptcha.Text.Trim() != captcha.Text)
            {
                XtraMessageBox.Show(@"Codigo de seguridad incorrecto",
                 @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GenerarCaptcha();
                txtCaptcha.Text = "";
                txtCaptcha.Focus();
                return;
            }
            
            if (UsuarioLog == null)
            {
                //Credenciales No Validas
                XtraMessageBox.Show(@"Verifique credenciales",
                                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GenerarCaptcha();
                txtCaptcha.Text = "";
                txtPassword.Text = "";
                txtRfc.Focus();
            }
            else //Redireccionamos
            {
                if(UsuarioLog.Estatus != "A")
                {
                    XtraMessageBox.Show(@"Usuario dado de baja, pregunte a su administrador",
                                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LanzarPantallaInicio();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmModuloAcceso_FormClosed(object sender, FormClosedEventArgs e)
        {Application.Exit();
        }

        public void TxtMayusculaKeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void FrmModuloAcceso_Load(object sender, EventArgs e)
        {
            GenerarCaptcha();
            //txtCaptcha.Text = captcha.Text;
        }
#endregion

    }
}