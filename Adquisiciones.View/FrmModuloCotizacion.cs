using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Business.ModCotizacion;
using Adquisiciones.Data.Entities;
using log4net;
using Spring.Context.Support;

namespace Adquisiciones.View
{
    ///<summary>
    ///</summary>
    public partial class FrmModuloCotizacion : DevExpress.XtraEditors.XtraForm
    {
        ///<summary>
        ///</summary>
        public ICotizacionService CotizacionService;


        ///<summary>
        ///</summary>
        public Cotizacion CotizacionActual;

        ///<summary>
        ///</summary>
        public Anexo AnexoActual;

        ///<summary>
        ///</summary>
        public Proveedor ProveedorActual;

        /// <summary>
        /// La bitacora
        /// </summary>
        private static readonly ILog Log =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cotizacion"></param>
        public FrmModuloCotizacion(Cotizacion cotizacion)
            : this()
        {
            CotizacionActual = cotizacion;
            ConsultarCotizacion();
        }


        /// <summary>
        /// 
        /// </summary>
        public FrmModuloCotizacion()
        {
            InitializeComponent();
            var ctx = ContextRegistry.GetContext();
            CotizacionService = ctx["cotizacionService"] as ICotizacionService;
            Nuevo();
            CargarCombos();
        }


        public void CargarCombos()
        {
            var anexos = CotizacionService.AnexoDao.CargarAnexos(FrmModuloModulo.AlmacenSelec);
            bsAnexos.DataSource = anexos;
            var proveedores = CotizacionService.ProveedorDao.FindAll();
            bsProveedor.DataSource = proveedores;
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



        private void BtnNuevoClick(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void BtnGuardarClick(object sender, EventArgs e)
        {
            GuardarCotizacion();

        }

        private void BtnConsultarClick(object sender, EventArgs e)
        {
            Nuevo();
            ConsultarCotizacion();
        }

        ///<summary>
        ///</summary>
        ///<param name="cotizacion"></param>
        public void ConsultarCotizacion()
        {

            try
            {
                if (Util.DatosValidos(CotizacionActual, lblNumErrors, listaError))
                {
                    CotizacionService.ConsultaCotizacion(ref CotizacionActual);
                    bsCotizacionDetalle.DataSource = CotizacionActual.CotizacionDetalle;

                    AnexoActual = CotizacionActual.Anexo;
                    lblInstituto.Text = MapeoInstituto(CotizacionActual.Anexo);
                    lblDesLicitacion.Text = CotizacionActual.Anexo.ToString();
                    ProveedorActual = CotizacionActual.Proveedor;
                    lblProveedor.Text = CotizacionActual.Proveedor.ToString();
                    dtpFechacotizacion.DateTime = CotizacionActual.FechaCotizacion.Value;

                    if (CotizacionService.CotizacionDao.ExisteAnexoFallo(CotizacionActual.Anexo))
                    {
                        MessageBox.Show(@"El anexo tiene fallo",
                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnGuardar.Enabled = false;
                    }
                    else
                    {   
                        btnGuardar.Enabled = true;
                    }

                    gcDatosGenerales.Enabled = false;
                    this.Text = lblDesLicitacion.Text+ "@" + lblProveedor.Text;


                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Rellene los campos para la consulta");
                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }

        }



        private void gvCotizacionDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                gvCotizacionDetalle.DeleteRow(gvCotizacionDetalle.FocusedRowHandle);
            }
        }


        private void Nuevo()
        {
            CotizacionActual = new Cotizacion();

            //No capturen nuevamente anexo y proveedor
            CotizacionActual.Anexo = AnexoActual;
            CotizacionActual.Proveedor = ProveedorActual;
            dtpFechacotizacion.DateTime = DateTime.Now;
            BindearPadre();
            
            bsCotizacionDetalle.DataSource = new List<CotizacionDetalle>();
            listaError.Items.Clear();
            lblNumErrors.Text = string.Empty;

            gcDatosGenerales.Enabled = true;
            btnGuardar.Enabled = false;

        }

        private void GuardarCotizacion()
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
                        MessageBox.Show(@"Cotización requiere al menos un registro",
                       @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    BindearPadre();
                    CotizacionService.GuardaCotizacion(ref CotizacionActual);
                    CotizacionService.ConsultaCotizacion(ref CotizacionActual);
                    bsCotizacionDetalle.DataSource = CotizacionActual.CotizacionDetalle;

                    MessageBox.Show(@"Cotización Registrada o Actualizada Exitosamente",
                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                


            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion " + ee.Message,
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }
        }



        private void BindearPadre()
        {
            CotizacionActual.FechaCotizacion = dtpFechacotizacion.DateTime;
            CotizacionActual.Usuario = FrmModuloAcceso.UsuarioLog;
            CotizacionActual.Almacen = FrmModuloModulo.AlmacenSelec;
            CotizacionActual.FechaModificacion = CotizacionService.AnexoDao.FechaServidor();
            CotizacionActual.IpTerminal = Util.IpTerminal();
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




    }
}