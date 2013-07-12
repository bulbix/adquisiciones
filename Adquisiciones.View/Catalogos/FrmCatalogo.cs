using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Data;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using log4net;

namespace Adquisiciones.View.Catalogos
{
    public partial class FrmCatalogo : XtraForm, IForma
    {
        protected static readonly ILog Log =
            LogManager.GetLogger(System.Reflection.MethodBase.
            GetCurrentMethod().DeclaringType);

        protected Type TypeEntity { get; set; }
        protected object EntityActual { get; set; }
        public Almacen AlmacenActual { get; set; }
        public IList<UsuarioModulo> ModulosUsuario { get; set; }
        


        public FrmCatalogo()
        {
            InitializeComponent();
        }

        protected void LimpiarCajas()
        {
            foreach (var control in Controls)
            {
                var type = control.GetType();
                if (type != typeof(TextBox) && type != typeof(MaskedTextBox)) continue;
                var caja = (TextBoxBase)control;
                caja.Text = "";
            }
        }

        protected void LimpiarValidacion()
        {
            listaError.Strings.Clear();
            lblNumErrors.Caption = @"0 Errores";
        }

        protected void ObtenerPerfil()
        {
            const string nombreModulo = "catalogo";

            foreach (var moduloUsuario in ModulosUsuario)
            {
                if (moduloUsuario.Estatus != "A")
                    continue;


                var desModulo = moduloUsuario.Id.Modulo.DesModulo.ToLower().Trim();

                if (desModulo.Contains(nombreModulo))
                {
                    if (desModulo.Contains("trabajar"))
                    {
                        cmdNuevo.Enabled = true;
                        cmdGuardar.Enabled = true;
                        listaError.Enabled = true;
                        lblNumErrors.Enabled = true;
                    }
                }
            }
        }

        public virtual void BindearCampos()
        {
            throw new NotImplementedException();
        }

        public virtual void InicializarCatalogos()
        {
            throw new NotImplementedException();
        }

        public virtual void Nuevo()
        {
            throw new NotImplementedException();
        }

        public virtual void Guardar()
        {
            throw new NotImplementedException();
        }

        public virtual void Consultar()
        {

            var usuarioModifico = (Usuario)TypeEntity.GetProperty("Usuario").GetValue(EntityActual, null);

            if (FrmModuloAcceso.UsuarioLog.IdUsuario != usuarioModifico.IdUsuario)
            {
                cmdGuardar.Enabled = false;
            }
           
        }

        private void CmdNuevoItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Nuevo();
        }

        private void cmdGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Guardar();
        }

        private void cmdReporte_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("No hay reporte asociado en los catalogos");
        }

        private void FrmCatalogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show(@"Esta seguro de cerrar la pestaña?", @"Adquisiciones",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}