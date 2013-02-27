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
using DevExpress.XtraEditors;
using log4net;
using Spring.Context.Support;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Adquisiciones.View.Modulos
{
    public partial class FrmModulo : XtraForm,IForma
    {
        protected static readonly ILog Log =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected Type TypeEntity { get; set; }
        protected IFormBusqueda Servicio { get; set; }
        protected string NombreReporte { get; set; }
        protected string NombreService { get; set; }
        protected object EntityActual { get; set; }
        public Almacen AlmacenActual { get; set; }
        public IList<UsuarioModulo> ModulosUsuario { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public FrmModulo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Habilita o Deshabilita hasta encontrar un control SearchLookUpEdit
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="habilitar"></param>
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
        /// Limpia combos
        /// </summary>
        protected void LimpiarErrores()
        {
            listaError.Strings.Clear();
            lblNumErrors.Caption = string.Empty;
        }

        /// <summary>
        /// Rellena un combo con los almacenes de acuerdo al almacen en curso
        /// </summary>
        /// <param name="combo">Combo con los almacenes </param>
        /// <param name="almacenAdq">Almacen adquisiciones</param>
        protected void AlmacenesCombo(ComboBox combo, Almacen almacenAdq)
        {

            var ctx = ContextRegistry.GetContext();
            var almacenDao = ctx["almacenDao"] as IAlmacenDao;

            var almacenes = new List<Almacen>();
            switch(almacenAdq.IdAlmacen)
            {
                case "C2":
                    almacenes.Add(almacenDao.Get("PC"));
                    almacenes.Add(almacenDao.Get("GC"));
                    almacenes.Add(almacenDao.Get("FC"));
                    break;
                case "C5":
                    almacenes.Add(almacenDao.Get("AC"));
                    break;
                case "P2":
                    almacenes.Add(almacenDao.Get("F"));
                    almacenes.Add(almacenDao.Get("G"));
                    almacenes.Add(almacenDao.Get("P"));
                    break;
                case "P5":
                    almacenes.Add(almacenDao.Get("A"));
                    break;
            }

            var dicc = almacenes.ToDictionary(almacen => almacen, 
                almacen => almacen.ToString());

            Util.Dicc2Combo(dicc, combo);
        }

        /// <summary>
        /// Perfiles con su copia cada uno
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

        protected void HayErrores()
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
            var usuarioModifico = (Usuario)TypeEntity.GetProperty("Usuario").GetValue(EntityActual, null);

            if (FrmModuloAcceso.UsuarioLog.IdUsuario != usuarioModifico.IdUsuario)
            {
                cmdGuardar.Enabled = false;
                splitContainerControl1.Panel1.Enabled = false;
            }
        }

        protected void GetServicio()
        {
            var ctx = ContextRegistry.GetContext();
            Servicio = ctx[NombreService] as IFormBusqueda;
        }

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
    }
}