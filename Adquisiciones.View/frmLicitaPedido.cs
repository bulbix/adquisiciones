using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NHibernate;
using Adquisiciones.Data.Entities;

namespace Adquisiciones.View
{
    ///<summary>
    ///</summary>
    public partial class FrmLicitaPedido : Form
    {
        ISession sesion;// = SessionFactory.Instance;
        Pedido pedidoActual = new Pedido();
        // Requisicion requisicionActual = new Requisicion();
        
        //Anexo anexoActual = new Anexo();
        //Proveedor proveedorActual = new Proveedor();

        public FrmLicitaPedido()
        {
            InitializeComponent();
           
        }

        private void deshabilita_campos()
        {


            cbxRequisicion.Enabled = false;
            txtFecha.Enabled = false;
            txtArea.Enabled = false;
            txtDesarea.Enabled = false;
            txtLicitacion.Enabled = false;
            txtDeslicitacion.Enabled = false;
            btnAceptar.Enabled = false;
       
        }

        private void activa_campos()
        {

            cbxRequisicion.Enabled = true;
            txtFecha.Enabled = true;
            txtArea.Enabled = true;
            txtDesarea.Enabled = true;
            txtLicitacion.Enabled = true;
            txtDeslicitacion.Enabled = true;
            btnAceptar.Enabled = true;
            
        }
        private void limpia_objetos()
        {
            cbxRequisicion.Items.Clear();
            txtFecha.Text = "";
            txtArea.Text = "";
            txtDesarea.Text = "";
            txtLicitacion.Text = "";
            txtDeslicitacion.Text = "";
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            sesion.Close();
        }

        private void txtCarga_Click(object sender, EventArgs e)
        {
            //limpia_objetos();
            cbxRequisicion.Enabled = true;
            IQuery query = sesion.GetNamedQuery("Requisicion.Cargadatosrequisicion");
            query.SetParameter("idAlmacen", FrmModuloModulo.AlmacenSelec.IdAlmacen);
            //IList<Requisicion> datosreq = query.List<Requisicion>();

            //foreach (Requisicion listarequisicion in datosreq)
           // {
            //    cbxRequisicion.Items.Add(listarequisicion.NumeroRequisicon.ToString());

           // }
        }

        private void cbxRequisicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFecha.Enabled = true;
            txtArea.Enabled = true;
            txtDesarea.Enabled = true;
            txtLicitacion.Enabled = true;
            txtDeslicitacion.Enabled = true;

            IQuery query = sesion.GetNamedQuery("Anexo.NumeroRequisicion");
            query.SetParameter("numReq", cbxRequisicion.Text);
            query.SetParameter("idAlmacen", FrmModuloModulo.AlmacenSelec.IdAlmacen);
            //requisicionActual = query.UniqueResult<Requisicion>();

            //txtFecha.Text = requisicionActual.FechaRequisicion.ToString();
            //txtArea.Text = requisicionActual.CatArea.CveArea.ToString();
            //txtDesarea.Text = requisicionActual.CatArea.DesArea;
            //txtLicitacion.Text = requisicionActual.Anexo.NumeroAnexo;
            //txtDeslicitacion.Text = requisicionActual.Anexo.DesAnexo;
                       
                     
            
        }  

        private void txtFundamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                short cveFundamento = short.Parse(txtFundamento.Text);
                Fundamento fundamento = sesion.Get<Fundamento>(cveFundamento);
                txtDesfundamento.Text = fundamento.DesFundamento;
            }
        }

        private void txtFundamento_TextChanged(object sender, EventArgs e)
        {

        }


        private void inicializarActividadCargoIva()
        { 
            IQuery query = sesion.CreateQuery("from CatActividad");
            IList<CatActividad> actividades = query.List<CatActividad>();

            /*se mapea el entiti cat actividad a un diccionario para utilizar el metodo en la clase util*/
            Dictionary<string, string> listaActividades = new Dictionary<string, string>();
            foreach (CatActividad actividad in actividades)
            {
                listaActividades.Add(actividad.IdActividad.ToString(), 
                    actividad.DesActividad);
            }

            //cbxActividad.DataSource = Util.lista2Dataset(listaActividades).Tables["lista"];
            cbxActividad.DisplayMember = "label";
            cbxActividad.ValueMember = "value";

            Dictionary<String, String> cargos = new Dictionary<string, string>();
            cargos.Add("C", "CUOTAS DE RECUPERACION");
            cargos.Add("P", "PRESUPUESTO FEDERAL");
            cargos.Add("O", "OTROS");
            //cbxCargo.DataSource = Util.lista2Dataset(cargos).Tables["lista"];
            cbxCargo.DisplayMember = "label";
            cbxCargo.ValueMember = "value";

            query = sesion.CreateQuery("from Iva");
            IList<Iva> ivas = query.List<Iva>();

            Dictionary<string, string> listaIva = new Dictionary<string, string>();
            foreach (Iva iva in ivas)
            {
                listaIva.Add(iva.Id.IdIva.ToString(),
                    iva.Id.Porcentaje.ToString());
            }

            //cbxIva.DataSource = Util.lista2Dataset(listaIva).Tables["lista"];
            cbxIva.DisplayMember = "label";
            cbxIva.ValueMember = "value";
                   

        }

        private void frmLicitaPedido_Load(object sender, EventArgs e)
        {
                        inicializarActividadCargoIva();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
                                                                                        
      }
}
