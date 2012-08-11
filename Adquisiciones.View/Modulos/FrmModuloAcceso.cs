using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
        ///<summary>
        ///</summary>
        public static Usuario UsuarioLog;

        /// <summary>
        /// </summary>
        public IUsuarioDao UsuarioDao { private get; set; }


        /// <summary>
        ///  </summary>
        public FrmModuloAcceso()
        {
            InitializeComponent();
            var ctx = ContextRegistry.GetContext();
            UsuarioDao = ctx["usuarioDao"] as IUsuarioDao;
        }

        private void BtnAceptarClick(object sender, EventArgs e)
        {
            UsuarioLog = UsuarioDao.AccessAllow(txtId.Text, txtPassword.Text);
            if (UsuarioLog == null)
            {  //Credenciales No Validas
                XtraMessageBox.Show(@"No tiene Acceso al Sistema, Verifique credenciales",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Redireccionamos
            {
                this.Hide();
                new FrmModuloModulo().ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Adquisiciones.View.Properties.Resources.torrecnr;
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmdAceptar
            // 
            this.cmdAceptar.Image = global::Adquisiciones.View.Properties.Resources.accept;
            this.cmdAceptar.Location = new System.Drawing.Point(278, 185);
            this.cmdAceptar.Name = "cmdAceptar";
            this.cmdAceptar.Size = new System.Drawing.Size(122, 63);
            this.cmdAceptar.TabIndex = 1;
            this.cmdAceptar.Text = "Iniciar Sesion";
            this.cmdAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Image = global::Adquisiciones.View.Properties.Resources.cancelar;
            this.cmdCancelar.Location = new System.Drawing.Point(418, 185);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(122, 63);
            this.cmdCancelar.TabIndex = 2;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtId
            // 
            this.txtId.EditValue = "BULBIX";
            this.txtId.Location = new System.Drawing.Point(278, 80);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(242, 20);
            this.txtId.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(278, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Usuario:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(278, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(278, 130);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(242, 21);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "adios";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Black";
            // 
            // FrmModuloAcceso
            // 
            this.ClientSize = new System.Drawing.Size(558, 351);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdAceptar);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(574, 389);
            this.MinimumSize = new System.Drawing.Size(566, 378);
            this.Name = "FrmModuloAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adquisiciones V 1.0 @ Instituto Nacional Rehabilitación";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmModuloAcceso_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FrmModuloAcceso_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}