using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using log4net;
using Spring.Context.Support;

namespace Adquisiciones.View.Modulos
{
    public partial class FrmModulo : XtraForm,IModulo
    {
        protected static readonly ILog Log =
            LogManager.GetLogger(System.Reflection.MethodBase.
            GetCurrentMethod().DeclaringType);

        protected Type TypeEntity { get; set; }
        protected IFormBusqueda Servicio { get; set; }
        protected string NombreReporte { get; set; }
        protected string NombreService { get; set; }
        protected object EntityActual { get; set; }

        public FrmModulo()
        {
            InitializeComponent();
        }

        private void HabilitarBuscadores(bool habilitar)
        {
            foreach (var boton in from object control in Controls
                                  let type = control.GetType()
                                  where type == typeof(SearchLookUpEdit)
                                  select (SearchLookUpEdit)control
                                      into boton

                                      select boton)
            {
                boton.Enabled = habilitar;
            }
            
        }

        protected void ObtenerPerfil()
        {
            var modulosUsuario = FrmModuloAcceso.UsuarioLog.UsuarioModulo;
            var nombreModulo = TypeEntity.Name.ToLower();
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
                        HabilitarBuscadores(false);
                    }

                    if (desModulo.Contains("trabajar"))
                    {
                        cmdNuevo.Enabled = true;
                        cmdGuardar.Enabled = true;
                        listaError.Enabled = true;
                        lblNumErrors.Enabled = true;
                        cmdConsultar.Enabled = true;
                        HabilitarBuscadores(true);
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

        protected void GetServicio()
        {
            var ctx = ContextRegistry.GetContext();
            Servicio = ctx[NombreService] as IFormBusqueda;
        }

        protected virtual void CmdEliminarItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show(@"Esta seguro de eliminar el elemento?", @"Adquisiciones",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    GetServicio();
                    Servicio.EliminarEntity(EntityActual, TypeEntity.Name);
                    XtraMessageBox.Show(@"Elemento borrado", @"Adquisiciones",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Elemento asociado otro modulo", @"Adquisiciones",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        protected virtual void CmdReporteItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {   
                var forma = new FrmModuloReportes(NombreReporte, EntityActual);
                forma.MdiParent = this.MdiParent;
                forma.Show();
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"No hay entity actual", @"Adquisiciones",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}