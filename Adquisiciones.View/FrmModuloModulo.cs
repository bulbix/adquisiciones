using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Adquisiciones.Data.Dao.Catalogos;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using Spring.Context.Support;
using Form = Spring.Windows.Forms.Form;

namespace Adquisiciones.View
{
    ///<summary>
    ///</summary>
    public partial class FrmModuloModulo : Form
    {        
        ///<summary>
        ///</summary>
        public static  Almacen AlmacenSelec;

        public IAlmacenDao AlmacenDao { get; set; }
      
        ///<summary>
        ///</summary>
        public FrmModuloModulo()
        {
            InitializeComponent();

            var usuariosModulo = FrmModuloAcceso.UsuarioLog.UsuarioModulo;

            //leer lista de Usuarios Modulos
            foreach (var usuarioModulo in usuariosModulo)
            {
                foreach (var boton in from object control in Controls
                                      let type = control.GetType()
                                      where type == typeof (SimpleButton)
                                      select (SimpleButton)control
                                      into boton where boton.Tag.ToString().
                                      Equals(usuarioModulo.Id.Modulo.Almacen.IdAlmacen) select boton)
                {
                    boton.Enabled = true;
                }
            }
        }

        private void BtnAdq5000Click(object sender, EventArgs e)
        {
            AlmacenSelec = AlmacenDao.Get(btnAdq5000.Tag.ToString());
            this.Hide();
            new FrmAdquisiciones().ShowDialog();
        }

        private void BtnAdq2000Click(object sender, EventArgs e)
        {
            AlmacenSelec = AlmacenDao.Get(btnAdq2000.Tag.ToString());
            this.Hide();
            new FrmAdquisiciones().ShowDialog();
        }

        private void BtnAdqconacyt2000Click(object sender, EventArgs e)
        {
            AlmacenSelec = AlmacenDao.Get(btnAdqconacyt2000.Tag.ToString());
             this.Hide();
             new FrmAdquisiciones().ShowDialog();
        }

        private void BtnAdqconacyt5000Click(object sender, EventArgs e)
        {
            AlmacenSelec = AlmacenDao.Get(btnAdqconacyt5000.Tag.ToString());
             this.Hide();
             new FrmAdquisiciones().ShowDialog();
        }
    }
}
