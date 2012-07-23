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

        public FrmModulo()
        {
            InitializeComponent();
        }

        protected virtual void CmdNuevoClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Nuevo();
        }

        protected virtual void CmdGuardarClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Guardar();
        }

        protected virtual void CmdConsultarClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Consultar();
        }

        public virtual void BindearCampos()
        {
        }

        public virtual void InicializarCatalogos()
        {
        }

        public virtual void Nuevo()
        {
        }

        public virtual void Guardar()
        {
        }

        public virtual void Consultar()
        {
        }
    }
}