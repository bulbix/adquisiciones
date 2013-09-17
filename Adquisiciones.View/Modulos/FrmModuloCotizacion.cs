using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Business.ModCotizacion;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using Spring.Context.Support;

namespace Adquisiciones.View.Modulos
{
    public partial class FrmModuloCotizacion : FrmModulo
    {

        #region Variables
        public ICotizacionService CotizacionService { get; set; }
        public Cotizacion CotizacionActual;
        public Anexo AnexoActual;
        public Proveedor ProveedorActual;
        #endregion

        #region Contructores
        public FrmModuloCotizacion(FrmAdquisiciones padre)
        {
            InitializeComponent();
            
            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;

            base.TypeEntity = typeof(Cotizacion);
            base.NombreReporte = "reporteCotizacion";
            base.NombreService = "cotizacionService";
            base.GetServicio();
            CotizacionService = base.Servicio as ICotizacionService;
            InicializarCatalogos();
            Nuevo();
            base.ObtenerPerfil();
        }

        public FrmModuloCotizacion(Cotizacion cotizacion, FrmAdquisiciones padre): this(padre)
        {
            CotizacionActual = cotizacion;
            AnexoActual = cotizacion.Anexo;
            ProveedorActual = cotizacion.Proveedor;
            Consultar();
        }
        #endregion

        #region Metodos
        public override void BindearCampos()
        {
            CotizacionActual.Usuario = FrmModuloAcceso.UsuarioLog;
            CotizacionActual.Almacen = AlmacenActual;
        }

        public override void InicializarCatalogos()
        {
            var anexos = CotizacionService.AnexoDao.CargarAnexos(AlmacenActual);
            bsAnexos.DataSource = anexos;
            var proveedores = CotizacionService.ProveedorDao.CargarCatalogo<Proveedor>("CveProveedor");
            bsProveedor.DataSource = proveedores;
        }

        public override void Nuevo()
        {
            CotizacionActual = new Cotizacion();

            //No capturen nuevamente anexo y proveedor
            CotizacionActual.Anexo = AnexoActual;
            CotizacionActual.Proveedor = ProveedorActual;
            CotizacionActual.FechaCotizacion = CotizacionService.CotizacionDao.FechaServidor();
            lblFecha.Text = String.Format("{0:dd/MM/yyyy}", CotizacionActual.FechaCotizacion);

            Text = "Cotizacion::" + CotizacionActual;

            BindearCampos();

            bsCotizacionDetalle.DataSource = new List<CotizacionDetalle>();
            LimpiarErrores();
            gcDatosGenerales.Enabled = true;
            cmdGuardar.Enabled = true;
        }

        public override void Guardar()
        {
            try
            {
                txtCentinela.Focus();//Para rebindeeen los campos
                if (!Util.DatosValidos(CotizacionActual, lblNumErrors, listaError))
                {
                    return;
                }

                if (!CotizacionService.
                        ExisteCotizacionDetalle(CotizacionActual.CotizacionDetalle))
                {
                    XtraMessageBox.Show(@"Cotización requiere al menos un registro",
                   @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                BindearCampos();
                CotizacionService.GuardarCotizacion(ref CotizacionActual);
                CotizacionService.ConsultarCotizacion(ref CotizacionActual);
                bsCotizacionDetalle.DataSource = CotizacionActual.CotizacionDetalle;

                base.EntityActual = CotizacionActual;

                XtraMessageBox.Show(@"Cotización Registrada o Actualizada Exitosamente",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en la insercion o actualizacion ",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }
        }

        public override void Consultar()
        {
            try
            {
                Nuevo();

                if (Util.DatosValidos(CotizacionActual, lblNumErrors, listaError))
                {
                    CotizacionService.ConsultarCotizacion(ref CotizacionActual);
                    bsCotizacionDetalle.DataSource = CotizacionActual.CotizacionDetalle;

                    if (searchLookUpAnexo.Handle != IntPtr.Zero)
                        searchLookUpAnexo.EditValue = CotizacionActual.Anexo.IdAnexo;

                    AnexoActual = CotizacionActual.Anexo;

                    if (searchLookUpProv.Handle != IntPtr.Zero)
                        searchLookUpProv.EditValue = CotizacionActual.Proveedor.CveProveedor;

                    ProveedorActual = CotizacionActual.Proveedor;

                    lblFecha.Text = String.Format("{0:dd/MM/yyyy}", CotizacionActual.FechaCotizacion);

                    base.EntityActual = CotizacionActual;
                    base.Consultar();

                    if (CotizacionService.CotizacionDao.ExisteAnexoFallo(CotizacionActual.Anexo))
                    {
                        XtraMessageBox.Show(@"El anexo tiene fallo",
                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmdGuardar.Enabled = false;
                    }

                    gcDatosGenerales.Enabled = false;
                    this.Text = AnexoActual + "@" + ProveedorActual;
                }
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Rellene los campos para la consulta");
                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }
        }
        #endregion

        #region Eventos
        private void SearchLookUpAnexoEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpAnexo.EditValue != null)
            {
                var anexoSeleccionado = searchLookUpEditAnexo.GetFocusedRow() as Anexo;

                if (anexoSeleccionado != null)
                {
                    AnexoActual = anexoSeleccionado;
                    CotizacionActual.Anexo = AnexoActual;
                }
            }
            else
            {
                AnexoActual = null;
                CotizacionActual.Anexo = AnexoActual;
            }
        }

        private void SearchLookUpProvEditValueChanged(object sender, EventArgs e)
        {

            if (searchLookUpProv.EditValue != null)
            {
                var provSeleccionado = searchLookUpEditProv.GetFocusedRow() as Proveedor;

                if (provSeleccionado != null)
                {
                    ProveedorActual = provSeleccionado;
                    CotizacionActual.Proveedor = ProveedorActual;
                }  
            }
            else
            {
                ProveedorActual = null;
                CotizacionActual.Proveedor = null;
            }
        }

        private void GvAnexoDetalleKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                gvCotizacionDetalle.DeleteRow(gvCotizacionDetalle.FocusedRowHandle);
            }
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        #endregion

    }
}