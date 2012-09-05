using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Data.Dao.Seguridad;
using DevExpress.XtraEditors;
using Spring.Context.Support;

namespace Adquisiciones.View
{
    public partial class FrmPerfil : DevExpress.XtraEditors.XtraForm
    {

        public IUsuarioDao UsuarioDao { private get; set; }


        public FrmPerfil()
        {
            InitializeComponent();

            var ctx = ContextRegistry.GetContext();
            UsuarioDao = ctx["usuarioDao"] as IUsuarioDao;
        }


        private void CargarPerfiles()
        {
            bsOrigen.DataSource = UsuarioDao.
                ModulosSinPerfil(FrmModuloAcceso.UsuarioLog, FrmModuloModulo.AlmacenSelec);
            bsDestino.DataSource = UsuarioDao.
                ModulosConPerfil(FrmModuloAcceso.UsuarioLog, FrmModuloModulo.AlmacenSelec);
            bsUsuario.DataSource = UsuarioDao.CargarUsuarios();
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            CargarPerfiles();
        }

        private void cmdOmitir_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmAdquisiciones().ShowDialog();
        }

        private void AsignarLista(ListBoxControl origen, ListBoxControl destino)
        {
           
        }

        private void cmdDerecha_Click(object sender, EventArgs e)
        {

        }
    }
}