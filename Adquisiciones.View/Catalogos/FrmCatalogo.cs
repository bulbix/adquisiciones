using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Data;
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
            var modulosUsuario = FrmModuloAcceso.UsuarioLog.UsuarioModulo;
            const string nombreModulo = "catalogo";

            foreach (var moduloUsuario in modulosUsuario)
            {
                if (moduloUsuario.Estatus != "A")
                    continue;


                var desModulo = moduloUsuario.Id.Modulo.DesModulo.ToLower().Trim();

                if (desModulo.Contains(nombreModulo))
                {
                    //Por la ordenacion garantizamos siempre vendra la consulta
                    if (desModulo.Contains("consultar"))
                    {
                        cmdConsultar.Enabled = true;
                    }

                    if (desModulo.Contains("trabajar"))
                    {
                        cmdNuevo.Enabled = true;
                        cmdGuardar.Enabled = true;
                        listaError.Enabled = true;
                        lblNumErrors.Enabled = true;
                        cmdConsultar.Enabled = true;
                    }

                    if (desModulo.Contains("eliminar"))
                    {
                        cmdEliminar.Enabled = true;
                    }

                    if (desModulo.Contains("reportear"))
                    {
                        cmdReporte.Enabled = true;
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
            throw new NotImplementedException();
        }

        private void CmdNuevoItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Nuevo();
        }

        private void cmdGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Guardar();
        }

        private void cmdConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Consultar();
        }

        private void CmdEliminarItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            XtraMessageBox.Show("Borrelo desde la busqueda!!");

        }

        private void cmdReporte_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show("No hay reporte asociado en los catalogos");
        }
    }
}