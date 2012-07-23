using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Business.ModPedido;
using Adquisiciones.Data.Entities;
using DevExpress.XtraEditors;
using Spring.Context.Support;

namespace Adquisiciones.View.Modulos
{
    public partial class FrmModuloLicitaPedido : FrmModulo
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

        public FrmModuloLicitaPedido()
        {
            InitializeComponent();
            var ctx = ContextRegistry.GetContext();
            PedidoService = ctx["pedidoService"] as IPedidoService;
            InicializarCatalogos();
            Nuevo();
            BindearCampos();
        }

        public override void InicializarCatalogos()
        {
            bsRequisicion.DataSource = PedidoService.RequisicionDao.CargarRequisiciones(FrmModuloModulo.AlmacenSelec);
            bsFundamento.DataSource = PedidoService.RequisicionDao.CargarCatalogo<Fundamento>();
            PedidoService.CatalogoActividad(cbxActividad);
            PedidoService.AnexoService.IvasCombo(cbxIva);
            PedidoService.CatalogoPresupuestal(cbxCargo);
        }

        public override void BindearCampos()
        {
            //deFechaPedido.DataBindings.Add(new Binding("DateTime", bsPedido, "FechaPedido", true));
            txtObservaciones.DataBindings.Add(new Binding("Text", bsPedido, "Observaciones", true));
            cbxIva.DataBindings.Add(new Binding("SelectedValue", bsPedido, "Iva", true));
            cbxActividad.DataBindings.Add(new Binding("SelectedValue", bsPedido, "CatActividad", true));
            cbxCargo.DataBindings.Add(new Binding("SelectedValue", bsPedido, "CatPresupuesto", true));
        }

        public override void Nuevo()
        {
            PedidoActual = new Pedido();
            bsPedido.DataSource = PedidoActual;
            lblFechaRequisicion.Text = "";
            lblArea.Text = "";
            lblLicitacion.Text = "";
            lblFundamento.Text = "";
        }

        public override void Guardar()
        {
            listaError.Items.Clear();
            lblNumErrors.Text = "";

            PedidoActual.FechaPedido = deFechaPedido.DateTime;

            //Validaciones 
            if (!DatosValidosPedido(PedidoActual, listaError))
            {
                return;
            }

            if (PedidoService.PedidoDao.ExisteRequisicionPedido(RequisicionActual))
            {
                XtraMessageBox.Show(@"La requisicion ya tiene pedido automatico",
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


                if (tieneFalloAnexo)
                {
                    XtraMessageBox.Show(@"Pedido Automatico realizado Exitosamente Requisicion #" + PedidoActual.Requisicion.NumeroRequisicion,
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show(@"El anexo de la requisicion no tiene fallo: " + RequisicionActual.Anexo,
                   @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en la persistencia Reportalo a Dep. Sistemas",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }

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
        public bool DatosValidosPedido(Pedido pedido, ListBox lista)
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
    }
}