using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Data;
using Adquisiciones.Data.Auxiliares;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Spring.Context.Support;

namespace Adquisiciones.View.Busquedas
{
    public partial class FrmBusqueda : XtraForm
    {

        #region Variables
        protected Type TypeEntity { get; set; }
        protected string NombreService { get; set; }
        protected string NombreReporte { get; set; }
        protected Type TypeForma { get; set; }
        protected IFormBusqueda Servicio { get; set; }
        protected GridView GvGeneral { get; set; }
        public Almacen AlmacenActual { get; set; }
        public IList<UsuarioModulo> ModulosUsuario { get; set; }
        #endregion

        #region Constructores
        public FrmBusqueda()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos
        protected void ObtenerPerfil(){
           
            var nombreModulo = TypeEntity.Name.ToLower();

            if (TypeEntity.GetInterface("ICatalogo") != null)
                nombreModulo = "catalogo";

            foreach (var moduloUsuario in ModulosUsuario)
            {
                if (moduloUsuario.Estatus != "A" 
                    || !moduloUsuario.Id.Modulo.Id.Almacen.Equals(AlmacenActual))
                    continue;

                var desModulo = moduloUsuario.Id.Modulo.DesModulo.ToLower().Trim();
                if (desModulo.Contains(nombreModulo))
                {
                    if (desModulo.Contains("consultar"))
                    {
                        cmdBuscar.Enabled = true;
                        cmdConsultar.Enabled = true;
                    }
                    if (desModulo.Contains("eliminar"))
                    {
                        cmdEliminar.Enabled = true;
                    }

                    if (desModulo.Contains("reportear"))
                    {
                        cmdImprimir.Enabled = true;
                        cmdReporte.Enabled = true;
                    }
                }
            }
        }

        protected virtual void Buscar()
        {
            GetServicio();
            var source = Servicio.ConsultarEntityAll(AlmacenActual);
            bsSource.DataSource = source;
        }

        protected virtual void Eliminar()
        {
            try
            {
                var usuarioModifico = (Usuario)TypeEntity.
                GetProperty("Usuario").GetValue(GvGeneral.GetFocusedRow(), null);


                if (FrmModuloAcceso.UsuarioLog.IdUsuario != usuarioModifico.IdUsuario)
                {
                    XtraMessageBox.Show(@"No es dueño del registro", @"Adquisiciones",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (XtraMessageBox.Show(@"Esta seguro de eliminar el elemento seleccionado?", @"Adquisiciones",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    GetServicio();
                    Servicio.EliminarEntity(GvGeneral.GetFocusedRow(), TypeEntity.Name);
                    XtraMessageBox.Show(@"Elemento seleccionado borrado", @"Adquisiciones",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Buscar();
                }
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Elemento seleccionado asociado otro modulo", @"Adquisiciones",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected void GetServicio()
        {
            var ctx = ContextRegistry.GetContext();
            Servicio = ctx[NombreService] as IFormBusqueda;
        }
        #endregion

        #region Eventos
        private void CmdBuscarItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Buscar();

        }

        protected virtual void CmdConsultarItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var select = Convert.
                    ChangeType(GvGeneral.GetFocusedRow(), TypeEntity);
                var forma = (Form)TypeForma.GetConstructor(new[] { TypeEntity,typeof(FrmAdquisiciones) }).
                    Invoke(new[] { select,this.MdiParent as FrmAdquisiciones });

                forma.MdiParent = this.MdiParent;
                forma.Show();
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"No hay registro seleccionado", @"Adquisiciones",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CmdImprimirItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GvGeneral.ShowPrintPreview();
        }

        protected virtual void CmdReporteItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                var select = Convert.
                    ChangeType(GvGeneral.GetFocusedRow(), TypeEntity);

                var forma = new FrmModuloReportes(NombreReporte, select);
                forma.MdiParent = this.MdiParent;
                forma.Show();
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"No hay registro seleccionado", @"Adquisiciones",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CmdEliminarItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           Eliminar();
        }
        #endregion

    }
}