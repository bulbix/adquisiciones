using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using log4net;

namespace Adquisiciones.View.Modulos
{
    public partial class FrmModulo : XtraForm,IModulo
    {
        protected static readonly ILog Log =
            LogManager.GetLogger(System.Reflection.MethodBase.
            GetCurrentMethod().DeclaringType);

        protected Type TypeEntity { get; set; }

        public FrmModulo()
        {
            InitializeComponent();
        }

        protected void ObtenerPerfil()
        {
            var modulosUsuario = FrmModuloAcceso.UsuarioLog.UsuarioModulo;
            var nombreModulo = TypeEntity.Name.ToLower();
            foreach (var moduloUsuario in modulosUsuario)
            {
                if (moduloUsuario.Estatus != "A")
                    continue;var desModulo = moduloUsuario.Id.Modulo.DesModulo.ToLower().Trim();
                if (desModulo.Contains(nombreModulo))
                {
                    if (desModulo.Contains("consultar"))
                    {
                        cmdConsultar.Enabled = true;
                    }

                    if (desModulo.Contains("eliminar"))
                    {
                        cmdEliminar.Enabled = true;
                    }

                    if (desModulo.Contains("guardar"))
                    {
                        cmdNuevo.Enabled = true;
                        cmdGuardar.Enabled = true;
                        listaError.Enabled = true;
                        lblNumErrors.Enabled = true;
                    }

                    if (desModulo.Contains("reportear"))
                    {
                        cmdReporte.Enabled = true;
                    }

                    
                }
            }
        }


        private void HayErrores()
        {
            if (listaError.Strings.Count > 0)
                listaError.Appearance.ForeColor = Color.Red;
            else
                listaError.Appearance.ForeColor = Color.White;
        }

        protected virtual void CmdNuevoClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Nuevo();
        }

        protected virtual void CmdGuardarClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Guardar();
            HayErrores();
        }

        protected virtual void CmdConsultarClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Consultar();
            HayErrores();
        }

        public virtual void BindearCampos()
        {
        }

        public virtual void InicializarCatalogos()
        {
        }

        public virtual void Nuevo(){
        }

        public virtual void Guardar()
        {
        }

        public virtual void Consultar()
        {
        }
    }
}