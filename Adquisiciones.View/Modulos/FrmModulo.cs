using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Data;
using Adquisiciones.Data.Dao.Catalogos;
using Adquisiciones.Data.Entities;
using Adquisiciones.View.Reportes;
using DevExpress.XtraEditors;
using log4net;
using Spring.Context.Support;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Adquisiciones.View.Modulos
{
    public partial class FrmModulo : XtraForm,IForma
    {
        protected static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected Type TypeEntity { get; set; }
        protected IFormBusqueda Servicio { get; set; }
        protected string NombreReporte { get; set; }
        protected string NombreService { get; set; }
        protected object EntityActual { get; set; }
        public Almacen AlmacenActual { get; set; }
        public IList<UsuarioModulo> ModulosUsuario { get; set; }
       
        public FrmModulo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Habilita los controlres del tipo SearchLookUpEdit
        /// </summary>
        /// <param name="controls">Todos los controles de la forma</param>
        /// <param name="habilitar">Bandera para habilitar</param>
        private static void HabilitarBuscadores(Control controls, bool habilitar)
        {
            foreach (var control  in controls.Controls)
            {
                if (control is SearchLookUpEdit)
                    (control as SearchLookUpEdit).Enabled = habilitar;
                else
                    HabilitarBuscadores((control as Control),habilitar);
            }
        }

        /// <summary>
        /// Blanquea los errores de la lista
        /// </summary>
        protected void LimpiarErrores()
        {
            listaError.Strings.Clear();
            lblNumErrors.Caption = string.Empty;
        }

        /// <summary>
        /// Carga los tipos de almacenes disponibles para la carga
        /// de acuerdo al almacenAdq
        /// </summary>
        /// <param name="combo">Donde se cargaran los objetos</param>
        /// <param name="almacenAdq">El tipo de almacen inicial</param>
        protected void AlmacenesCombo(ComboBox combo, Almacen almacenAdq)
        {

            var ctx = ContextRegistry.GetContext();
            var almacenDao = ctx["almacenDao"] as IAlmacenDao;

            var almacenes = almacenDao.getAlmacenes(almacenAdq);

            var dicc = almacenes.ToDictionary(almacen => almacen, 
                almacen => almacen.ToString());

            Util.Dicc2Combo(dicc, combo);
        }

        /// <summary>
        /// Habilita los permisos de manera generica
        /// </summary>
        protected void ObtenerPerfil()
        {
            var nombreModulo = TypeEntity.Name.ToLower();

            foreach (var moduloUsuario in ModulosUsuario)
            {
                if (moduloUsuario.Estatus != "A" 
                    || !moduloUsuario.Id.Modulo.Id.Almacen.Equals(AlmacenActual))
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
                        HabilitarBuscadores(this,true);
                    }

                    if (desModulo.Contains("reportear"))
                    {
                        cmdReporte.Enabled = true;
                    }
                    
                }
            }
        }

        /// <summary>
        /// Colorea la lista si hay errores
        /// </summary>
        protected void HayErrores()
        {
            if (listaError.Strings.Count > 0)
                listaError.Appearance.ForeColor = Color.Red;
            else
                listaError.Appearance.ForeColor = Color.White;
        }

        /// <summary>
        /// Boton Nuevo generico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void CmdNuevoClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Nuevo();
        }

        /// <summary>
        /// Boton guardar generico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void CmdGuardarClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Guardar();
            HayErrores();
        }

        /// <summary>
        /// Boton Consultar Generico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void CmdConsultarClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Consultar();
            HayErrores();
        }

        /// <summary>
        /// Enlaza los controles de la forma
        /// </summary>
        public virtual void BindearCampos()
        {
        }

        /// <summary>
        /// Carga los catalogos de la forma
        /// </summary>
        public virtual void InicializarCatalogos()
        {
        }

        /// <summary>
        /// Nuevo
        /// </summary>
        public virtual void Nuevo(){
        }

        /// <summary>
        /// Guardar
        /// </summary>
        public virtual void Guardar()
        {
        }

        /// <summary>
        /// Se realiza la consulta con previa verificacion de usuario
        /// </summary>
        public virtual void Consultar()
        {
            var usuarioModifico = (Usuario)TypeEntity.GetProperty("Usuario").GetValue(EntityActual, null);

            if (FrmModuloAcceso.UsuarioLog.IdUsuario != usuarioModifico.IdUsuario)
            {
                cmdGuardar.Enabled = false;
            }

            if(EntityActual is Pedido)
            {
                if((EntityActual as Pedido).EstadoPedido == "C")
                {
                    cmdGuardar.Enabled = false;
                }
            }


        }

        /// <summary>
        /// Obtiene el servicio asociado almodulo
        /// </summary>
        protected void GetServicio()
        {
            var ctx = ContextRegistry.GetContext();
            Servicio = ctx[NombreService] as IFormBusqueda;
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual void Eliminar()
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

        protected virtual void CmdEliminarItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Eliminar();
        }

        /// <summary>
        /// Reporte asociado al modulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                XtraMessageBox.Show(@"Ocurrio un error al generar el reporte", @"Adquisiciones",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmModuloFormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show(@"Esta seguro de cerrar la pestaña?", @"Adquisiciones",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


    }
}