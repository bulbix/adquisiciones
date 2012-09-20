﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Adquisiciones.Business.Seguridad;
using Adquisiciones.Data.Dao.Catalogos;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using Spring.Context.Support;


namespace Adquisiciones.View
{
    ///<summary>
    ///</summary>
    public partial class FrmModuloModulo : XtraForm
    {        
        ///<summary>
        ///</summary>
        public static  Almacen AlmacenSelec;

        public IAlmacenDao AlmacenDao { get; set; }

        public IUsuarioService UsuarioService { get; set; }

        ///<summary>
        ///</summary>
        public FrmModuloModulo()
        {
            InitializeComponent();

            var ctx = ContextRegistry.GetContext();
            AlmacenDao = ctx["almacenDao"] as IAlmacenDao;

            UsuarioService = ctx["usuarioService"] as IUsuarioService;

            var usuariosModulo = FrmModuloAcceso.UsuarioLog.UsuarioModulo;

            //leer lista de Usuarios Modulos
            foreach (var usuarioModulo in usuariosModulo)
            {
                foreach (var boton in from object control in Controls
                                      let type = control.GetType()
                                      where type == typeof (SimpleButton)
                                      select (SimpleButton)control
                                      into boton where boton.Tag.ToString().
                                      Equals(usuarioModulo.Id.Modulo.Id.Almacen.IdAlmacen) select boton)
                {
                    boton.Enabled = true;
                }
            }
        }
        private void MostrarMain()
        {
            //Quitar permisos que no son del almacen seleccionado
            FrmModuloAcceso.UsuarioLog.UsuarioModulo = UsuarioService.UsuarioDao.TraerModulos(
                FrmModuloAcceso.UsuarioLog, AlmacenSelec);
            Hide();
            new FrmAdquisiciones().Show();
           
        }

        private void BtnAdq5000Click(object sender, EventArgs e)
        {
            AlmacenSelec = AlmacenDao.Get(btnAdq5000.Tag.ToString());
            MostrarMain();
        }

        private void BtnAdq2000Click(object sender, EventArgs e)
        {
            AlmacenSelec = AlmacenDao.Get(btnAdq2000.Tag.ToString());
            MostrarMain();
        }

        private void BtnAdqconacyt2000Click(object sender, EventArgs e)
        {
            AlmacenSelec = AlmacenDao.Get(btnAdqconacyt2000.Tag.ToString());
            MostrarMain();

        }

        private void BtnAdqconacyt5000Click(object sender, EventArgs e)
        {
            AlmacenSelec = AlmacenDao.Get(btnAdqconacyt5000.Tag.ToString());
            MostrarMain();
        }

        private void FrmModuloModulo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
        }
    }
}
