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
using Adquisiciones.View.Busquedas;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Spring.Context.Support;

namespace Adquisiciones.View.Modulos
{
    public partial class FrmModuloLicitaPedido : FrmModulo
    {
        #region Variables
        public IPedidoService PedidoService { get; set; }
        public Pedido PedidoActual;
        public Requisicion RequisicionActual;
        #endregion

        #region Constructores
        public FrmModuloLicitaPedido(FrmAdquisiciones padre)
        {
            InitializeComponent();

            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;
            this.MdiParent = padre;
            base.TypeEntity = typeof(Pedido);
            base.NombreModulo = "Pedido";
            var ctx = ContextRegistry.GetContext();
            PedidoService = ctx["pedidoService"] as IPedidoService;
            InicializarCatalogos();
            Nuevo();
            BindearCampos();
            base.ObtenerPerfil();
        }
        #endregion

        #region Metodos
        public override void InicializarCatalogos()
        {
            bsRequisicion.DataSource = PedidoService.RequisicionDao.CargarRequisiciones(AlmacenActual);
            bsFundamento.DataSource = PedidoService.RequisicionDao.CargarCatalogo<Fundamento>("CveFundamento");
            PedidoService.CatalogoActividad(cbxActividad);
            PedidoService.AnexoService.IvasCombo(cbxIva);
            PedidoService.CatalogoPresupuestal(cbxCargo);
        }

        public override void BindearCampos()
        {
            cbxIva.DataBindings.Add(new Binding("SelectedValue", bsPedido, "Iva", true));
            cbxActividad.DataBindings.Add(new Binding("SelectedValue", bsPedido, "CatActividad", true));
            cbxCargo.DataBindings.Add(new Binding("SelectedValue", bsPedido, "CatPresupuesto", true));
        }

        public override void Nuevo()
        {
            PedidoActual = new Pedido();
            bsPedido.DataSource = PedidoActual;

            PedidoActual.FechaPedido = PedidoService.PedidoDao.FechaServidor();
            lblFecha.Text = String.Format("{0:dd/MM/yyyy}", PedidoActual.FechaPedido);

            LimpiarRequisicion();
            LimpiarErrores();
        }

        public override void Guardar()
        {
            LimpiarErrores();
            //PedidoActual.FechaPedido = deFechaPedido.DateTime;

            //Validaciones 
            if (!DatosValidosPedido(PedidoActual, listaError))
                return;

            //los parametros basicos
            PedidoActual.Observaciones = txtObservaciones.Text;
            PedidoActual.Almacen = AlmacenActual;
            PedidoActual.Usuario = FrmModuloAcceso.UsuarioLog;

            try
            {
                PedidoService.GenerarPedidoAutomatico(PedidoActual, RequisicionActual,
                    deFechaInicial.DateTime, deFechaFinal.DateTime);
                
                XtraMessageBox.Show(@"Pedido Automatico realizado Exitosamente Requisicion #" + PedidoActual.Requisicion.NumeroRequisicion,
                @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en el guardado",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }

        }

        public bool DatosValidosPedido(Pedido pedido, BarListItem lista)
        {
            bool result = true;

            if (pedido.Requisicion == null)
            {
                result = false;
                lista.Strings.Add("Requisicion requerida");
            }

            if (!Util.FechaValida(pedido.FechaPedido))
            {
                result = false;
                lista.Strings.Add("Fecha Pedido requerida");
            }

            if (!Util.FechaValida(deFechaInicial.DateTime))
            {
                result = false;
                lista.Strings.Add("Fecha Inicial requerida");
            }

            if (!Util.FechaValida(deFechaFinal.DateTime))
            {
                result = false;
                lista.Strings.Add("Fecha Final requerida");
            }

            if (deFechaInicial.DateTime.CompareTo(deFechaFinal.DateTime) > 0)
            {
                result = false;
                lista.Strings.Add("Fecha inicial debe ser mayor fecha final");
            }

            if (pedido.Fundamento == null)
            {
                result = false;
                lista.Strings.Add("Fundamento requerido");
            }

            if (pedido.CatActividad == null)
            {
                result = false;
                lista.Strings.Add("Actividad requerida");
            }

            if (pedido.Iva == null)
            {
                result = false;
                lista.Strings.Add("Iva requerido");
            }

            if (pedido.CatPresupuesto == null)
            {
                result = false;
                lista.Strings.Add("Cargo a requerido");
            }

            lblNumErrors.Caption = lista.Strings.Count + " Errores";

            return result;
        }

        private void LimpiarRequisicion()
        {
            lblArea.Text = "";
            lblLicitacion.Text = "";
            PedidoActual.Requisicion = null;
        }
        #endregion

        #region Eventos
        private void SearchLookUpRequisicionEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpRequisicion.EditValue != null)
            {
                var reqSeleccionada = searchLookUpEditRequisicion.GetFocusedRow() as Requisicion;

                if (PedidoService.PedidoDao.ExisteRequisicionPedido(reqSeleccionada))
                {
                    XtraMessageBox.Show(@"La requisicion ya tiene pedido automatico",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarRequisicion();
                    return;
                }

                if (!PedidoService.TieneFalloRequisicion(reqSeleccionada))
                {
                    XtraMessageBox.Show(@"El anexo de la requisicion no tiene fallo",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarRequisicion();
                    return;
                }

                RequisicionActual = reqSeleccionada;
                PedidoActual.Requisicion = RequisicionActual;

                if (reqSeleccionada != null)
                {
                    lblArea.Text = reqSeleccionada.CatArea.ToString();
                    lblLicitacion.Text = reqSeleccionada.Anexo.ToString();
                }
            }

        }

        private void SearchLookUpFundamentoEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpFundamento.EditValue != null)
            {
                var fundamentoSeleccionado = searchLookUpEditFundamento.GetFocusedRow() as Fundamento;
                PedidoActual.Fundamento = fundamentoSeleccionado;
            }
        }
        #endregion

    }
}