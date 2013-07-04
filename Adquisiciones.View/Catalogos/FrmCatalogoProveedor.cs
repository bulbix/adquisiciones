using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Data.Dao.Catalogos;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using Spring.Context.Support;
using System.Linq;

namespace Adquisiciones.View.Catalogos
{
    public partial class FrmCatalogoProveedor : FrmCatalogo
    {
        #region Variables
        public IProveedorDao ProveedorDao { private get; set; }
        public Proveedor ProveedorActual { get; private set; }
        #endregion

        #region Constructores
        public FrmCatalogoProveedor(FrmAdquisiciones padre)
        {
            InitializeComponent();

            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;
            var ctx = ContextRegistry.GetContext();
            ProveedorDao = ctx["proveedorDao"] as IProveedorDao;
            BindearCampos();
            InicializarCatalogos();
            Nuevo();
            base.ObtenerPerfil();
        }

        public FrmCatalogoProveedor(Proveedor proveedor,FrmAdquisiciones padre):this(padre)
        {
            ProveedorActual = proveedor;
            txtClave.Value = proveedor.CveProveedor;
            Consultar();
        }
        #endregion

        #region Metodos
        public override void InicializarCatalogos()
        {
            var listEmpresas = ProveedorDao.CargarCatalogo<CatEmpresa>();
            var dicc = listEmpresas.ToDictionary(empresa => empresa, empresa => empresa.DesEmpresa);
            Util.Dicc2Combo(dicc,cbxEmpresa);

            cbxEmpresa.SelectedIndex = cbxEmpresa.FindStringExact("");
            
        }
        
        public override void BindearCampos()
        {
            //txtClave.DataBindings.Add(new Binding("Value", bsSource, "CveProveedor",false));
            txtPaterno.DataBindings.Add(new Binding("Text", bsSource, "Paterno", true));
            txtMaterno.DataBindings.Add(new Binding("Text", bsSource, "Materno", true));
            txtNombre.DataBindings.Add(new Binding("Text", bsSource, "Nombre", true));
            txtNombreFiscal.DataBindings.Add(new Binding("Text", bsSource, "NombreFiscal", true));
            txtNombreComercial.DataBindings.Add(new Binding("Text", bsSource, "NombreComercial", true));
            txtCalle.DataBindings.Add(new Binding("Text", bsSource, "Calle", true));
            txtColonia.DataBindings.Add(new Binding("Text", bsSource, "Colonia", true));
            txtDelegacion.DataBindings.Add(new Binding("Text", bsSource, "Delegacion", true));
            txtEstado.DataBindings.Add(new Binding("Text", bsSource, "Estado", true));
            txtPais.DataBindings.Add(new Binding("Text", bsSource, "Pais", true));
            txtCodigoP.DataBindings.Add(new Binding("Text", bsSource, "CodigoP", true));
            txtRfc.DataBindings.Add(new Binding("Text", bsSource, "Rfc", true));
            txtTel.DataBindings.Add(new Binding("Text", bsSource, "Tel", true));
            txtTel2.DataBindings.Add(new Binding("Text", bsSource, "Tel2", true));
            txtTel3.DataBindings.Add(new Binding("Text", bsSource, "Tel3", true));
            txtFax.DataBindings.Add(new Binding("Text", bsSource, "Fax", true));
            txtCorreo.DataBindings.Add(new Binding("Text", bsSource, "Correo", true));
            txtRnombre.DataBindings.Add(new Binding("Text", bsSource, "RNombre", true));
            txtRpaterno.DataBindings.Add(new Binding("Text", bsSource, "RPaterno", true));
            txtRmaterno.DataBindings.Add(new Binding("Text", bsSource, "RMaterno", true));
            txtGiro.DataBindings.Add(new Binding("Text", bsSource, "Giro", true));
            txtObservaciones.DataBindings.Add(new Binding("Text", bsSource, "Observacion", true));

            bsSource.DataSource = ProveedorActual;
        }
        
        public override void Nuevo()
        {   
            ProveedorActual = new Proveedor(FrmModuloAcceso.UsuarioLog,
                                            Util.IpTerminal(),
                                            ProveedorDao.FechaServidor());
            bsSource.DataSource = ProveedorActual;
            LimpiarCajas();
            txtClave.Value = ProveedorDao.SiguienteCveProveedor().Value;
            txtClave.Enabled = true;
            txtClave.Focus();
            LimpiarValidacion();
            ProveedorActual.Pais = "MEXICO";
        }

        private bool validarPersona()
        {
            bool result = true;
            if(txtPaterno.Text.Length == 0 && txtMaterno.Text.Length == 0 
                && txtNombre.Text.Length == 0)//Persona Fisica
            {
                //Persona Moral
                if(txtNombreFiscal.Text.Length == 0 && txtNombreComercial.Text.Length == 0)
                {
                    XtraMessageBox.Show(@"No ha capturado ninguna Persona Fisica o Moral",
                       @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
            }

            if (txtNombreFiscal.Text.Length != 0 && txtNombreComercial.Text.Length != 0)
            {
                if (txtRnombre.Text.Length == 0 && txtRmaterno.Text.Length == 0
                    && txtRpaterno.Text.Length == 0)
                {
                    XtraMessageBox.Show(@"Si capturo Persona Moral, debe capturar al representate legal",
                                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
            }

            return result;
        }

        public override void Guardar(){
            try
            {
                txtCentinela.Focus();
                var cveProv = Int32.Parse(txtClave.Value.ToString());
                ProveedorActual.CveProveedor = cveProv;
                ProveedorActual.CatEmpresa = cbxEmpresa.SelectedValue as CatEmpresa;
                ProveedorActual.Estatus = "A";

                if (Util.DatosValidos(ProveedorActual, lblNumErrors, listaError))
                {
                    if (validarPersona())
                    {
                        ProveedorDao.Update(ProveedorActual);
                        XtraMessageBox.Show(@"Proveedor Registrado o Actualizado Exitosamente",
                                            @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarValidacion();
                    }
                }
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en la insercion o actualizacion",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }
        }

        public override void Consultar()
        {
            try
            {
                LimpiarValidacion();
                ProveedorActual = ProveedorDao.Get(Int32.Parse(txtClave.Value.ToString()));

                if (ProveedorActual != null)
                {
                    cmdGuardar.Enabled = true;
                    txtClave.Enabled = false;
                    bsSource.DataSource = ProveedorActual;

                    if(ProveedorActual.CatEmpresa!= null)
                        cbxEmpresa.SelectedIndex = cbxEmpresa.FindStringExact(ProveedorActual.CatEmpresa.DesEmpresa);

                    Text = @"Proveedor::" + ProveedorActual;

                }
                else
                {
                    XtraMessageBox.Show(@"Clave proveedor no existe", @"Adquisiciones",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en la consulta ", @"Adquisiciones",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }
        }
        #endregion

        #region Eventos
        public void TxtMayusculaKeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
        #endregion

        private void txtRpaterno_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreFiscal_Leave(object sender, EventArgs e)
        {
            txtNombreComercial.Text = txtNombreFiscal.Text;
            txtNombreComercial.ResetBindings();
        }
    }
}