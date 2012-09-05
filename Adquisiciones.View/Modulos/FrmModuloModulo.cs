using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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

        private bool PermisoAsignarPerfil = false;
      
        ///<summary>
        ///</summary>
        public FrmModuloModulo()
        {
            InitializeComponent();

            var ctx = ContextRegistry.GetContext();
            AlmacenDao = ctx["almacenDao"] as IAlmacenDao;

            var usuariosModulo = FrmModuloAcceso.UsuarioLog.UsuarioModulo;

            //leer lista de Usuarios Modulos
            foreach (var usuarioModulo in usuariosModulo)
            {
                if (usuarioModulo.Id.Modulo.DesModulo.Trim().Equals("ASIGNAR PERFIL"))
                    PermisoAsignarPerfil = true;

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

        private void LanzarPantallaInicio()
        {
            this.Hide();
            if (PermisoAsignarPerfil)
                new FrmPerfil().ShowDialog();
            else
                new FrmAdquisiciones().ShowDialog();
            
        }

        private void BtnAdq5000Click(object sender, EventArgs e)
        {
            AlmacenSelec = AlmacenDao.Get(btnAdq5000.Tag.ToString());
            LanzarPantallaInicio();

        }

        private void BtnAdq2000Click(object sender, EventArgs e)
        {
            AlmacenSelec = AlmacenDao.Get(btnAdq2000.Tag.ToString());
            LanzarPantallaInicio();
        }

        private void BtnAdqconacyt2000Click(object sender, EventArgs e)
        {
            AlmacenSelec = AlmacenDao.Get(btnAdqconacyt2000.Tag.ToString());
            LanzarPantallaInicio();

        }

        private void BtnAdqconacyt5000Click(object sender, EventArgs e)
        {
            AlmacenSelec = AlmacenDao.Get(btnAdqconacyt5000.Tag.ToString());
            LanzarPantallaInicio();

        }
    }
}
