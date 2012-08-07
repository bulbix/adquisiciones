using System;
using System.Windows.Forms;
using Adquisiciones.Data.Entities;
using Adquisiciones.Data.Dao.Catalogos;
using DevExpress.XtraEditors;
using Spring.Context.Support;
using Adquisiciones.Business;

namespace Adquisiciones.View.Catalogos
{
    ///<summary>
    ///</summary>
    public partial class FrmCatalogoProveedor : XtraForm
    {
        #region Variables Miembro

        ///<summary>
        ///</summary>
        public IProveedorDao ProveedorDao { private get; set; }

        ///<summary>
        ///</summary>
        public Proveedor ProveedorActual { get; private set; }

        #endregion

        #region Contructores
        ///<summary>
        ///</summary>
        public FrmCatalogoProveedor()
        {
            InitializeComponent();
            //Acceder al contexto de spring
            var ctx = ContextRegistry.GetContext();
            ProveedorDao = ctx["proveedorDao"] as IProveedorDao;
            Nuevo();
            BindarCampos();
        }

        ///<summary>
        ///</summary>
        ///<param name="proveedor"></param>
        public FrmCatalogoProveedor(Proveedor proveedor):this()
        {
            Consultar(proveedor.CveProveedor.ToString());
            txtClave.Value = proveedor.CveProveedor;
        }



        #endregion

        #region Eventos


        private void Consultar(string cveProv)
        {
            try
            {
                LimpiarValidacion();
                ProveedorActual = ProveedorDao.Get(Int32.Parse(cveProv));

                if (ProveedorActual != null)
                {
                    btnGuardar.Enabled = true;
                    txtClave.Enabled = false;
                    bsProveedor.DataSource = ProveedorActual;
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
            }
        }

        private void BtnConsultarClick(object sender, EventArgs e)
        {
            Consultar(txtClave.Value.ToString());
            
        }

        private void BtnGuardarClick(object sender, EventArgs e)
        {
            try
            {
                var cveProv = Int32.Parse(txtClave.Value.ToString());
                ProveedorActual.CveProveedor = cveProv;

                if (Util.DatosValidos<Proveedor>(ProveedorActual, lblNumErrors, listaError))
                {
                    ProveedorDao.Update(ProveedorActual);
                    XtraMessageBox.Show(@"Proveedor Registrado o Actualizado Exitosamente",
                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarValidacion();
                }
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en la insercion o actualizacion",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
      

        private void BtnNuevoClick(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void Nuevo()
        {
            //Parametros por default
            ProveedorActual = new Proveedor(FrmModuloAcceso.UsuarioLog, Util.IpTerminal(),
                ProveedorDao.FechaServidor());
            bsProveedor.DataSource = ProveedorActual;
            LimpiarCajas();
            txtClave.Text = ProveedorDao.SiguienteCveProveedor().ToString();
            //btnGuardar.Enabled = false;
            txtClave.Enabled = true;
            txtClave.Focus();
            LimpiarValidacion();
        }

        private void TxtMayusculaKeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Limpia el listbox de las validaciones
        /// </summary>
        private void LimpiarValidacion()
        {            
            listaError.Items.Clear();
            lblNumErrors.Text = @"0 Errores";
        }

        /// <summary>
        /// Clear the boxes
        /// </summary>
        private void LimpiarCajas()
        {
            foreach (var control in Controls)
            {
                var type = control.GetType();
                if (type != typeof (TextBox) && type != typeof (MaskedTextBox)) continue;
                var caja = (TextBoxBase)control;
                caja.Text = "";
            }
        }
#endregion


        
    }
}
