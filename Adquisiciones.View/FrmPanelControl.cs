﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Business.Seguridad;
using Adquisiciones.Data.Dao.Seguridad;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using Spring.Context.Support;

namespace Adquisiciones.View
{
    public partial class FrmPanelControl : XtraForm
    {

        public IUsuarioService UsuarioService { private get; set; }
        private Usuario UsuarioActual;
        private Almacen AlmacenActual;

        public FrmPanelControl()
        {
            InitializeComponent();
            var ctx = ContextRegistry.GetContext();
            UsuarioService = ctx["usuarioService"] as IUsuarioService;
            Nuevo();

        }

        
        
        private void CargarPerfiles(Usuario usuario, Almacen almacen)
        {
            bsOrigen.DataSource = UsuarioService.UsuarioDao.
                ModulosSinPerfil(usuario, almacen);

            bsDestino.DataSource = UsuarioService.UsuarioDao.
                ModulosConPerfil(usuario,almacen);
        }


        private void CmdOmitirClick(object sender, EventArgs e)
        {
            Cerrar();
        }

        /// <summary> 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdDerechaClick(object sender, EventArgs e)
        {
            foreach(var item in lstOrigen.SelectedItems)
            {
                if (item == null)
                {
                    continue;
                }var perfil = item as Modulo;
                var usuarioModulo = new UsuarioModulo();
                usuarioModulo.Id = new UsuarioModuloId();
                usuarioModulo.Id.Modulo = perfil;
                (bsOrigen.DataSource as List<Modulo>).Remove(perfil);
                (bsDestino.DataSource as List<UsuarioModulo>).Add(usuarioModulo);
                lstOrigen.Refresh();
                lstDestino.Refresh();
            }
        }

        private void CmdIzquierdaClick(object sender, EventArgs e)
        {
            foreach (var item in lstDestino.SelectedItems)
            {
                if (item == null)
                {
                   continue; 
                }
                var perfil = item as UsuarioModulo;
                var modulo = new Modulo();
                modulo = perfil.Id.Modulo;
                (bsOrigen.DataSource as List<Modulo>).Add(modulo);
                (bsDestino.DataSource as List<UsuarioModulo>).Remove(perfil);
                lstOrigen.Refresh();
                lstDestino.Refresh();
            }
            
        }
        

        /// <summary>
        /// Carga los datos y los perfiles asociados con
        /// el almacen seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LstUsuarioEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpUsuario.EditValue != null)
            {
                var usuarioSelect = searchLookUpUsuarioView.GetFocusedRow() as Usuario;

                if (usuarioSelect != null)
                {
                    UsuarioActual = usuarioSelect;

                    txtCurrentPass.Text = string.Empty;
                    txtNewPass.Text = string.Empty;
                    txtConfirmPass.Text = string.Empty;

                    txtRfc.Text = UsuarioActual.Rfc;
                    txtNombre.Text = UsuarioActual.Nombre;
                    chkActivo.Enabled = UsuarioActual.Estatus == "A" ? true : false;

                    bsOrigen.DataSource = UsuarioService.UsuarioDao.
                    ModulosSinPerfil(UsuarioActual, AlmacenActual);

                    CargarPerfiles(UsuarioActual, AlmacenActual);
                }

            }
        }

        private void Nuevo()
        {
            bsOrigen.DataSource = new List<Modulo>();
            bsDestino.DataSource = new List<UsuarioModulo>();
            UsuarioActual = new Usuario();
            AlmacenActual = new Almacen();
            lstAlmacen.SelectedItem = "";
            searchLookUpUsuario.EditValue = null;
            txtRfc.Text = string.Empty;
            txtCurrentPass.Text = string.Empty;
            txtNewPass.Text = string.Empty;
            txtConfirmPass.Text = string.Empty;
            txtNombre.Text = string.Empty;
            chkActivo.Enabled = true;
            lblNumErrors.Text = string.Empty;
            listaError.Items.Clear();

            txtRfc.Focus();
            bsUsuarios.DataSource = UsuarioService.UsuarioDao.CargarUsuarios();

        }

        /// <summary>
        /// Blanquea campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdNuevoClick(object sender, EventArgs e)
        {
            Nuevo();
           

        }

        private void CmdGuardarUsuarioClick(object sender, EventArgs e)
        {

            bool updatePassword = false;

            try
            {
                AlmacenActual = new Almacen(lstAlmacen.SelectedItem.ToString());
                UsuarioActual.Rfc = txtRfc.Text.Trim();
                UsuarioActual.Nombre = txtNombre.Text.Trim();
                UsuarioActual.Estatus = chkActivo.Enabled ? "A" : "B";
                UsuarioActual.UsuarioModulo = bsDestino.DataSource as List<UsuarioModulo>;

                if (UsuarioActual.IdUsuario == 0)
                    UsuarioActual.Password = txtNewPass.Text;

                if (Util.DatosValidos(UsuarioActual, lblNumErrors, listaError))
                {
                    if (txtCurrentPass.Text != string.Empty && txtNewPass.Text !=
                        string.Empty && txtConfirmPass.Text != string.Empty)
                    {
                        updatePassword = true;

                        if (UsuarioActual.IdUsuario != 0 &&
                            UsuarioActual.Password != Util.GetSHA1(txtCurrentPass.Text))
                        {
                            XtraMessageBox.Show(@"El password actual es incorrecto",
                                                @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCurrentPass.Text = string.Empty;
                            txtCurrentPass.Focus();
                            return;
                        }

                        if (string.IsNullOrEmpty(txtNewPass.Text) || (txtNewPass.Text.Length < 4) ||
                            txtNewPass.Text.Length > 16 ||
                            txtNewPass.Text.Where(c => !char.IsLetterOrDigit(c)).Count() > 0)
                        {
                            XtraMessageBox.Show(@"La contrasena debe estar entre 4-16",
                                                @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNewPass.Text = string.Empty;
                            txtConfirmPass.Text = string.Empty;
                            txtNewPass.Focus();
                            return;}

                        if (txtNewPass.Text != txtConfirmPass.Text)
                        {
                            XtraMessageBox.Show(@"La confirmacion contrasena no coincide",
                                                @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtNewPass.Text = string.Empty;
                            txtConfirmPass.Text = string.Empty;
                            txtNewPass.Focus();
                            return;
                        }

                        UsuarioActual.Password = txtNewPass.Text;
                    }

                    
                    UsuarioService.GuardarUsuario(UsuarioActual, updatePassword);

                    XtraMessageBox.Show(@"Usuario Registrado o Actualizado",
                                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Nuevo();
                    
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(@"Ocurrio un error al guardar",
                                            @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Cerrar()
        {
            Hide();
            new FrmModuloModulo(false).ShowDialog();
        }

        private void FrmPanelControlFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();;
            
        }

        private void SimpleButton1Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show(@"Esta seguro de eliminar el usuario?", @"Adquisiciones",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    UsuarioService.Delete(UsuarioActual);
                    Nuevo();
                    XtraMessageBox.Show(@"Usuario borrado", @"Adquisiciones",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(@"El usuario tiene registros",
                           @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        public void TxtMayusculaKeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void LstAlmacenSelectedIndexChanged(object sender, EventArgs e)
        {
            bsDestino.DataSource = new List<UsuarioModulo>();
            AlmacenActual = new Almacen(lstAlmacen.SelectedItem.ToString());
            searchLookUpUsuario.EditValue = null;
            bsOrigen.DataSource = UsuarioService.UsuarioDao.
               ModulosSinPerfil(null, AlmacenActual);

        }

       

        
    }
}