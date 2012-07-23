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
        ///<summary>
        ///</summary>
        public ICotizacionService CotizacionService { get; set; }
        ///<summary>
        ///</summary>
        public Cotizacion CotizacionActual;

        ///<summary>
        ///</summary>
        public Anexo AnexoActual;

        ///<summary>
        ///</summary>
        public Proveedor ProveedorActual;

        public FrmModuloCotizacion()
        {
            InitializeComponent();
            var ctx = ContextRegistry.GetContext();
            CotizacionService = ctx["cotizacionService"] as ICotizacionService;
            InicializarCatalogos();
            Nuevo();
        }

        public FrmModuloCotizacion(Cotizacion cotizacion)
            : this()
        {
            CotizacionActual = cotizacion;
            Consultar();
        }

        public override void BindearCampos()
        {
            CotizacionActual.FechaCotizacion = dtpFechacotizacion.DateTime;
            CotizacionActual.Usuario = FrmModuloAcceso.UsuarioLog;
            CotizacionActual.Almacen = FrmModuloModulo.AlmacenSelec;
            CotizacionActual.FechaModificacion = CotizacionService.AnexoDao.FechaServidor();
            CotizacionActual.IpTerminal = Util.IpTerminal();
        }

        public override void InicializarCatalogos()
        {
            var anexos = CotizacionService.AnexoDao.CargarAnexos(FrmModuloModulo.AlmacenSelec);
            bsAnexos.DataSource = anexos;
            var proveedores = CotizacionService.ProveedorDao.FindAll();
            bsProveedor.DataSource = proveedores;
        }

        public override void Nuevo()
        {
            CotizacionActual = new Cotizacion();

            //No capturen nuevamente anexo y proveedor
            CotizacionActual.Anexo = AnexoActual;
            CotizacionActual.Proveedor = ProveedorActual;
            dtpFechacotizacion.DateTime = DateTime.Now;
            BindearCampos();

            bsCotizacionDetalle.DataSource = new List<CotizacionDetalle>();
            listaError.Items.Clear();
            lblNumErrors.Text = string.Empty;

            gcDatosGenerales.Enabled = true;
            cmdGuardar.Enabled = false;
        }

        public override void Guardar()
        {
            try
            {
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

                XtraMessageBox.Show(@"Cotización Registrada o Actualizada Exitosamente",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en la insercion o actualizacion " + ee.Message,
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }
        }

        public override void Consultar()
        {
            try
            {
                if (Util.DatosValidos(CotizacionActual, lblNumErrors, listaError))
                {
                    CotizacionService.ConsultarCotizacion(ref CotizacionActual);
                    bsCotizacionDetalle.DataSource = CotizacionActual.CotizacionDetalle;

                    AnexoActual = CotizacionActual.Anexo;
                    lblInstituto.Text = MapeoInstituto(CotizacionActual.Anexo);
                    lblDesLicitacion.Text = CotizacionActual.Anexo.ToString();
                    ProveedorActual = CotizacionActual.Proveedor;
                    lblProveedor.Text = CotizacionActual.Proveedor.ToString();
                    dtpFechacotizacion.DateTime = CotizacionActual.FechaCotizacion.Value;

                    if (CotizacionService.CotizacionDao.ExisteAnexoFallo(CotizacionActual.Anexo))
                    {
                        XtraMessageBox.Show(@"El anexo tiene fallo",
                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmdGuardar.Enabled = false;
                    }
                    else
                    {
                        cmdGuardar.Enabled = true;
                    }

                    gcDatosGenerales.Enabled = false;
                    this.Text = lblDesLicitacion.Text + "@" + lblProveedor.Text;


                }
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Rellene los campos para la consulta");
                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }
        }

        private static string MapeoInstituto(Anexo anexo)
        {
            switch (anexo.Instituto)
            {
                case "O":
                    return "ORTOPEDIA";
                case "R":
                    return "REHABILITACION";
                case "C":
                    return "COMUNICACION";
            }

            return "";
        }

        private void SearchLookUpAnexoEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpAnexo.EditValue != null)
            {
                //Pinta el instituto y la descripcion del anexo
                var idAnexo = (long)searchLookUpAnexo.EditValue;
                AnexoActual = CotizacionService.AnexoDao.Get(idAnexo);
                CotizacionActual.Anexo = AnexoActual;
                lblInstituto.Text = MapeoInstituto(CotizacionActual.Anexo);
                lblDesLicitacion.Text = CotizacionActual.Anexo.ToString();
                searchLookUpProv.Focus();
            }
            else
            {
                AnexoActual = null;
                CotizacionActual.Anexo = AnexoActual;
                lblInstituto.Text = string.Empty;
                lblDesLicitacion.Text = string.Empty;
                searchLookUpProv.Focus();
            }
        }

        private void SearchLookUpProvEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpProv.EditValue != null)
            {
                var cveProv = (int)searchLookUpProv.EditValue;
                ProveedorActual = CotizacionService.ProveedorDao.Get(cveProv);
                CotizacionActual.Proveedor = ProveedorActual;
                lblProveedor.Text = CotizacionActual.Proveedor.ToString();
                gcCotizacionDetalle.Focus();
            }
            else
            {
                ProveedorActual = null;
                CotizacionActual.Proveedor = null;
                lblProveedor.Text = string.Empty;
                gcCotizacionDetalle.Focus();
            }
        }

        protected override void CmdConsultarClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Nuevo();
            Consultar();
        }

      


    }
}