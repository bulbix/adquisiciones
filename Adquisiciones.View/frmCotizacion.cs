using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Adquisiciones.Data.Entities;
using Adquisiciones.Business;
using Adquisiciones.Business.ModCotizacion;
using Spring.Context.Support;

namespace Adquisiciones.View
{
    ///<summary>
    ///</summary>
    public partial class FrmCotizacion : Form
    {
        #region Variables Miembro

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

        #endregion

        #region Constructores
        ///<summary>
        ///</summary>
        public FrmCotizacion()
        {
            InitializeComponent();
            var ctx = ContextRegistry.GetContext();
            CotizacionService = ctx["cotizacionService"] as ICotizacionService;
            this.BindearDetalle();
            this.Nuevo();
        }
        #endregion

        #region Eventos
        private void CbxLicitacionSelectedIndexChanged(object sender, EventArgs e)
        {
            //Pinta el instituto y la descripcion del anexo
            AnexoActual = cbxLicitacion.SelectedValue as Anexo;
            if (AnexoActual == null) return;
            txtInstituto.Text = MapeoInstituto(AnexoActual);
            txtDeslicitacion.Text = AnexoActual.DesAnexo;
            txtProveedor.Focus();
        }

        private void BtnCargalicitacionClick(object sender, EventArgs e)
        {

            CotizacionService.Anexos(cbxLicitacion, (int)nudFecha.Value, FrmModulo.AlmacenSelec.IdAlmacen);
        }
        
        private void TxtProveedorKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ProveedorActual = CotizacionService.ProveedorDao.Get(int.Parse(txtProveedor.Text));
                txtDesproveedor.Text = ProveedorActual.NombreFiscal;
            }
        }

        private void BtnNuevoClick(object sender, EventArgs e)
        {
            this.Nuevo();
        }

        private void BtnGuardarClick(object sender, EventArgs e)
        {
            GuardarCotizacion();
           
        }

        private void BtnConsultarClick(object sender, EventArgs e)
        {
            try
            {
                CotizacionActual = new Cotizacion();
                this.BindearPadre();
                CotizacionService.ConsultaCotizacion(ref CotizacionActual);
                bsCotizacionDetalle.DataSource = CotizacionActual.CotizacionDetalle;
                gpbDatosCotizacion.Enabled = false;
                btnGuardar.Enabled = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Rellene los campos para la consulta");
            }
        }

        private void BtnCerrarClick(object sender, EventArgs e)
        {
            this.Close();
            ;

        }

        #endregion

        #region Metodos

        private void Nuevo()
        {
            nudFecha.Value = CotizacionService.CotizacionDao.FechaServidor().Year;
            CotizacionActual = new Cotizacion();
            AnexoActual = new Anexo();
            ProveedorActual = new Proveedor();

            cbxLicitacion.DataSource = null;
            bsCotizacionDetalle.DataSource = new List<CotizacionDetalle>();
            listaError.Items.Clear();
            lblNumErrors.Text = string.Empty;

            txtInstituto.Text = string.Empty;
            txtDeslicitacion.Text = string.Empty;
            txtProveedor.Text = string.Empty;
            txtDesproveedor.Text = string.Empty;
            txtDeslicitacion.Text = string.Empty;
            dtpFechacotizacion.Value = DateTime.Now;

            gpbDatosCotizacion.Enabled = true;          
            btnGuardar.Enabled = false;

        }

        private void GuardarCotizacion()
        {
            try
            {
                if (Util.DatosValidos<Cotizacion>(CotizacionActual,lblNumErrors,listaError))
                {

                    this.BindearPadre();
                    CotizacionService.GuardaCotizacion(ref CotizacionActual);
                    CotizacionService.ConsultaCotizacion(ref CotizacionActual);
                    bsCotizacionDetalle.DataSource = CotizacionActual.CotizacionDetalle;

                    MessageBox.Show(@"Cotización Registrada o Actualizada Exitosamente",
                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la insercion o actualizacion " + ee.Message,
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindearDetalle()
        {

            // Initialize the DataGridView.
            bsCotizacionDetalle.DataSource = new List<CotizacionDetalle>();
            dgvCotizacion.AutoGenerateColumns = false;
            dgvCotizacion.AllowUserToAddRows = false;
            dgvCotizacion.AutoSize = true;
            dgvCotizacion.DataSource = bsCotizacionDetalle;

            // Initialize and add a text box column.
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Renglon";
            column.Name = "Renglon";
            column.ReadOnly = true;
            dgvCotizacion.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "CveArt";
            column.Name = "Articulo";
            column.ReadOnly = true;
            dgvCotizacion.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "DescripcionArt";
            column.Width = 150;
            column.Name = "Descripcion";
            column.ReadOnly = true;
            dgvCotizacion.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PresentacionArt";
            column.Name = "Presentacion";
            column.ReadOnly = true;
            dgvCotizacion.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Cantidad";
            column.Name = "Cantidad";
            column.ReadOnly = true;
            dgvCotizacion.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Precio";
            column.Name = "Precio Unitario";
            column.Width = 75;
            column.ReadOnly = false;
            dgvCotizacion.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Marca";
            column.Name = "Marca";
            column.ReadOnly = false;
            dgvCotizacion.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Observaciones";
            column.Name = "Observaciones";
            column.ReadOnly = false;
            dgvCotizacion.Columns.Add(column);
        }

        private void BindearPadre()
        {
            CotizacionActual.Anexo = AnexoActual;
            CotizacionActual.Proveedor = ProveedorActual;
            CotizacionActual.FechaCotizacion = dtpFechacotizacion.Value;
            CotizacionActual.Usuario = FrmAcceso.UsuarioLog;
            CotizacionActual.Almacen = FrmModulo.AlmacenSelec;
            CotizacionActual.FechaModificacion = CotizacionService.AnexoDao.FechaServidor();
            CotizacionActual.IpTerminal = Util.IpTerminal();
            CotizacionActual.Modificacion = 0;
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

        #endregion

        
        
    }
}
