using System;
using System.Windows.Forms;
using Adquisiciones.Business.ModPedido;
using Adquisiciones.Data.Entities;
using log4net;
using Spring.Context.Support;
using Adquisiciones.Business;
using Spring.Objects.Factory;
using Form = Spring.Windows.Forms.Form;

namespace Adquisiciones.View
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmModuloLicitaPedido : Form, IInitializingObject
    {
        ///<summary
        /// Servicio de Negocio
        ///</summary>
        public IPedidoService PedidoService { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Pedido PedidoActual;

        /// <summary>
        /// 
        /// </summary>
        public Requisicion RequisicionActual;


        /// <summary>
        /// La bitacora
        /// </summary>
        private static readonly ILog Log =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// 
        /// </summary>
        public void NuevoPedido()
        {
            PedidoActual = new Pedido();
            bsPedido.DataSource = PedidoActual;
            lblFechaRequisicion.Text = "";
            lblArea.Text = "";
            lblLicitacion.Text = "";
            lblFundamento.Text = "";
        }

        private void BindearCampos()
        {   
            //deFechaPedido.DataBindings.Add(new Binding("DateTime", bsPedido, "FechaPedido", true));
            txtObservaciones.DataBindings.Add(new Binding("Text", bsPedido, "Observaciones", true));
            cbxIva.DataBindings.Add(new Binding("SelectedValue", bsPedido, "Iva", true));
            cbxActividad.DataBindings.Add(new Binding("SelectedValue", bsPedido, "CatActividad", true));
            cbxCargo.DataBindings.Add(new Binding("SelectedValue", bsPedido, "CatPresupuesto", true));
        }


        /// <summary>
        /// 
        /// </summary>
        public FrmModuloLicitaPedido(){
            InitializeComponent();
        }

        /// <summary>
        /// Combos asociados al pedido 
        /// </summary>
        public void InicializarCatalogos()
        {
            bsRequisicion.DataSource = PedidoService.RequisicionDao.CargarRequisiciones(FrmModuloModulo.AlmacenSelec);
            bsFundamento.DataSource = PedidoService.RequisicionDao.CargarCatalogo<Fundamento>();
            PedidoService.CatalogoActividad(cbxActividad);
            PedidoService.AnexoService.IvasCombo(cbxIva);
            PedidoService.CatalogoPresupuestal(cbxCargo);

        }


        private void SearchLookUpRequisicionEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpRequisicion.EditValue != null)
            {
                var reqSeleccionada = searchLookUpEditRequisicion.GetFocusedRow() as Requisicion;
                RequisicionActual = reqSeleccionada;
                PedidoActual.Requisicion = RequisicionActual;

                if (reqSeleccionada != null)
                {
                    lblFechaRequisicion.Text = String.Format("{0:dd/MM/yyyy}", reqSeleccionada.FechaRequisicion);
                    lblArea.Text = reqSeleccionada.CatArea.ToString();
                    lblLicitacion.Text = reqSeleccionada.Anexo.ToString();
                }
            }

        }

        private void SearchLookUpFundamentoEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpFundamento.EditValue != null)
            {
                var fundamentoSelecciondao = searchLookUpEditFundamento.GetFocusedRow() as Fundamento;
                PedidoActual.Fundamento = fundamentoSelecciondao;
                if (fundamentoSelecciondao != null) 
                    lblFundamento.Text = fundamentoSelecciondao.ToString();
            }
        }

        /// <summary>
        /// Esta validacion solo sera
        /// </summary>
        /// <param name="pedido"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public bool DatosValidosPedido(Pedido  pedido,  ListBox lista)
        {
            bool result = true;

            if (pedido.Requisicion == null)
            {
                result = false;
                lista.Items.Add("Requisicion requerida");
            }

            if (!Util.FechaValida(pedido.FechaPedido))
            {
                result = false;
                lista.Items.Add("Fecha Pedido requerida");
            }

            if (!Util.FechaValida(deFechaInicial.DateTime))
            {
                result = false;
                lista.Items.Add("Fecha Inicial requerida");
            }

            if (!Util.FechaValida(deFechaFinal.DateTime))
            {
                result = false;
                lista.Items.Add("Fecha Final requerida");
            }

            if (pedido.Fundamento == null)
            {
                result = false;
                lista.Items.Add("Fundamento requerido");
            }

            if (pedido.CatActividad == null)
            {
                result = false;
                lista.Items.Add("Actividad requerida");
            }

            if (pedido.Iva == null)
            {
                result = false;
                lista.Items.Add("Iva requerido");
            }

            if (pedido.CatPresupuesto == null)
            {
                result = false;
                lista.Items.Add("Cargo a requerido");
            }

            return result;
        }


        private void CmdGenerarPedidoClick(object sender, EventArgs e)
        {
            listaError2.Items.Clear();
            lblNumErrors2.Text = "";
         
            PedidoActual.FechaPedido = deFechaPedido.DateTime;
            
            //Validaciones 
            if (!DatosValidosPedido(PedidoActual,  listaError2))
            {
                return;
            }

            if (PedidoService.PedidoDao.ExisteRequisicionPedido(RequisicionActual))
            {
                MessageBox.Show(@"La requisicion ya tiene pedido automatico",
                @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //los parametros basicos
            PedidoActual.FechaModificacion = PedidoService.PedidoDao.FechaServidor();
            PedidoActual.IpTerminal = Util.IpTerminal();
            PedidoActual.Almacen = FrmModuloModulo.AlmacenSelec;
            PedidoActual.Usuario = FrmModuloAcceso.UsuarioLog;
            PedidoActual.EstadoPedido = "A";
            PedidoActual.Modificacion = 0;

             try
            {

            bool tieneFalloAnexo = PedidoService.GenerarPedidoAutomatico(PedidoActual, RequisicionActual,
                deFechaInicial.DateTime, deFechaFinal.DateTime);


            if(tieneFalloAnexo)
            {
                MessageBox.Show(@"Pedido Automatico realizado Exitosamente Requisicion #" + PedidoActual.Requisicion.NumeroRequisicion,
                @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"El anexo de la requisicion no tiene fallo: " + RequisicionActual.Anexo ,
               @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            }
             catch (Exception ee)
             {
                 MessageBox.Show(@"Ocurrio un error en la persistencia Reportalo a Dep. Sistemas",
                     @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                 Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
             }


        }

        public void AfterPropertiesSet()
        {
            InicializarCatalogos();
            NuevoPedido();
            BindearCampos();
        }
    }
}