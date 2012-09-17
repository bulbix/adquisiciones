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
using Spring.Context.Support;

namespace Adquisiciones.View
{
    public partial class FrmPanelControl : DevExpress.XtraEditors.XtraForm
    {

        public IUsuarioDao UsuarioDao { private get; set; }

        private Usuario UsuarioActual;

        public FrmPanelControl()
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
            bsUsuarios.DataSource = UsuarioDao.CargarUsuarios();
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

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        public  void BindearCampos()
        {
            bsUsuario.DataSource = new Usuario();
            txtRfc.DataBindings.Add(new Binding("Text", bsUsuario, "Rfc", true));
            txtNombre.DataBindings.Add(new Binding("Text", bsUsuario, "Nombre", true));
            bsUsuario.DataSource = UsuarioActual ;

        }

        private void lstUsuario_EditValueChanged(object sender, EventArgs e)
        {
            if (lstUsuario.EditValue != null)
            {
                var usuarioSelect = searchLookUpUsuario.GetFocusedRow() as Usuario;

                if (usuarioSelect != null)
                    UsuarioActual = usuarioSelect;
            }
        }}
}