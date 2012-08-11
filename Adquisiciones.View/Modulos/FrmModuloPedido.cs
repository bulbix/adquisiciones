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
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Spring.Context.Support;
using System.Linq;

namespace Adquisiciones.View.Modulos
{
    public partial class FrmModuloPedido : FrmModulo
    {
        public IPedidoService PedidoService;

        /// <summary>
        /// </summary>
        public Pedido PedidoActual;

        public FrmModuloPedido()
        {
            InitializeComponent();
            base.TypeEntity = typeof(Pedido);
            base.NombreReporte = "reportePedido";
            base.NombreService = "pedidoService";
            base.GetServicio();
            PedidoService = base.Servicio as IPedidoService;
            base.ObtenerPerfil();
        }

        public FrmModuloPedido(int tipoPedido):this()
        {
            Nuevo();
            PedidoActual.CatTipopedido = new CatTipopedido(tipoPedido);

            //Si es distinto a pedido mayor deshabilita
            if (tipoPedido > 1)
                searchLookUpAnexo.Enabled = false;

            BindearCampos();
            InicializarCatalogos();
        }

         public FrmModuloPedido(Pedido pedido)
            : this(pedido.CatTipopedido.IdTipoped)
         {
            PedidoActual = pedido;
            Consultar();
            Text = @"Pedido::" + pedido;


            if (pedido.Requisicion != null)
                cmdGuardar.Enabled = false;
        }

        public override void BindearCampos()
        {
            bsPedidoDetalle.DataSource = new List<PedidoDetalle>();

            ////Bindeamos el padre
            deFechaPedido.DataBindings.Add(new Binding("DateTime", bsPedido, "FechaPedido", true));
            numPedido.DataBindings.Add(new Binding("Value", bsPedido, "NumeroPedido", true));
            txtRequisicion.DataBindings.Add(new Binding("Text", bsPedido, "NumeroRequisicion", true));
            txtDescuento.DataBindings.Add(new Binding("Text", bsPedido, "ImporteDescuento", true));
            txtReserva.DataBindings.Add(new Binding("Text", bsPedido, "IdReservaautoriza", false));
            cbxActividad.DataBindings.Add(new Binding("SelectedValue", bsPedido, "CatActividad", true));
            cbxIva.DataBindings.Add(new Binding("SelectedValue", bsPedido, "Iva", true));

            //txtReferencia.DataBindings.Add(new Binding("Text", bsPedido, "ImporteDescuento"));
            cbxCargo.DataBindings.Add(new Binding("SelectedValue", bsPedido, "CatPresupuesto", true));
            cbxInstituto.DataBindings.Add(new Binding("SelectedValue", bsPedido, "Instituto", true));
            txtObservaciones.DataBindings.Add(new Binding("Text", bsPedido, "Observaciones", false));
        }

        public override void InicializarCatalogos()
        {
            PedidoService.CatalogoActividad(cbxActividad);
            bsFundamento.DataSource = PedidoService.PedidoDao.CargarCatalogo<Fundamento>();
            PedidoService.AnexoService.IvasCombo(cbxIva);
            PedidoService.CatalogoPresupuestal(cbxCargo);
            PedidoService.AnexoService.InstitutosCombo(cbxInstituto);
            bsArea.DataSource = PedidoService.PedidoDao.CargarCatalogo<CatArea>("Estatus", 1);
            bsProveedor.DataSource = PedidoService.PedidoDao.CargarCatalogo<Proveedor>();
            bsAnexo.DataSource = PedidoService.AnexoDao.CargarAnexos(FrmModuloModulo.AlmacenSelec);
            repositoryItemSearchLookUpEdit2.DataSource = PedidoService.AnexoService.
                ArticuloDao.ArticulosByAlmacen(FrmModuloModulo.AlmacenSelec);
            repositoryItemSearchLookUpEdit2.DisplayMember = "CveArt";
            repositoryItemSearchLookUpEdit2.ValueMember = "CveArt";
        }

        public override void Nuevo()
        {
            PedidoActual = new Pedido();
            bsPedido.DataSource = PedidoActual;
            bsPedidoDetalle.DataSource = new List<PedidoDetalle>();

            //Cargamos el numero de pedido maximo
            PedidoActual.NumeroPedido = PedidoService.PedidoDao.MaximoNumeroPedido(FrmModuloModulo.AlmacenSelec);
            numPedido.Value = (decimal)PedidoActual.NumeroPedido;
            deFechaPedido.DateTime = PedidoService.PedidoDao.FechaServidor();
            PedidoActual.FechaPedido = deFechaPedido.DateTime;

            lblNumErrors.Caption = string.Empty;
            lblArea.Text = "";
            lblLicitacion.Text = "";
            lblProveedor.Text = "";
            lblFundamento.Text = "";
        }

        public override void Guardar()
        {
            listaError.Strings.Clear();
            lblNumErrors.Caption = "";

            //los parametros basicos
            PedidoActual.Almacen = FrmModuloModulo.AlmacenSelec;
            PedidoActual.Usuario = FrmModuloAcceso.UsuarioLog;

            //Validaciones 
            if (!Util.DatosValidos(PedidoActual, lblNumErrors, listaError))
            {
                return;
            }

            PedidoActual.PedidoDetalle = bsPedidoDetalle.DataSource as List<PedidoDetalle>;

            try
            {
                PedidoService.GuardarPedido(ref PedidoActual);
                base.EntityActual = PedidoActual;

                XtraMessageBox.Show(@"Pedido Registrado o Actualizado Exitosamente",
                                @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en el guardado",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }
        }

        public override void Consultar()
        {
            try
            {
                PedidoActual = PedidoService.ConsultarPedido(PedidoActual.NumeroPedido.Value,
                                                          FrmModuloModulo.AlmacenSelec);

                if (PedidoActual != null)
                {
                    bsPedido.DataSource = PedidoActual;
                    bsPedidoDetalle.DataSource = PedidoActual.PedidoDetalle;

                    lblFundamento.Text = PedidoActual.Fundamento.ToString();
                    lblArea.Text = PedidoActual.CatArea.ToString();
                    lblProveedor.Text = PedidoActual.Proveedor.ToString();

                    if (PedidoActual.Anexo != null)
                        lblLicitacion.Text = PedidoActual.Anexo.ToString();

                    listaError.Strings.Clear();
                    lblNumErrors.Caption = string.Empty;
                    SumTotal();

                    base.EntityActual = PedidoActual;

                }
                else
                {
                    XtraMessageBox.Show(@"Folio no existe", @"Adquisiciones",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ee)
            {
                XtraMessageBox.Show(@"Ocurrio un error en la consulta",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }
        }

        private void SearchLookUpFundamentoEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpFundamento.EditValue != null)
            {
                var funSeleccionado = searchLookUpEditFundamento.GetFocusedRow() as Fundamento;

                PedidoActual.Fundamento = funSeleccionado;

                if (funSeleccionado != null)
                    lblFundamento.Text = funSeleccionado.ToString();
            }

        }

        private void SearchLookUpAreaEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpArea.EditValue != null)
            {
                var areaSeleccionada = searchLookUpEditArea.GetFocusedRow() as CatArea;

                PedidoActual.CatArea = areaSeleccionada;


                if (areaSeleccionada != null)
                    lblArea.Text = areaSeleccionada.ToString();
            }
        }

        private void SearchLookUpProveedorEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpProveedor.EditValue != null)
            {
                var provSeleccionado = searchLookUpEditProveedor.GetFocusedRow() as Proveedor;

                PedidoActual.Proveedor = provSeleccionado;

                if (provSeleccionado != null)
                    lblProveedor.Text = provSeleccionado.ToString();
            }

        }

        /// <summary>
        /// Trae la licitacion en curso y su detalle para cargar el pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchLookUpAnexoEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpAnexo.EditValue != null)
            {
                var anexoSeleccionado = searchLookUpEditAnexo.GetFocusedRow() as Anexo;
                PedidoActual.Anexo = anexoSeleccionado;

                if (anexoSeleccionado != null)
                    lblLicitacion.Text = anexoSeleccionado.ToString();

                bsPedidoDetalle.DataSource = PedidoService.CargarPedidoDetalle(anexoSeleccionado);
                gvPedidoDetalle.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                gvPedidoDetalle.OptionsBehavior.AllowDeleteRows = DefaultBoolean.False;

                gridColumnArticulo.OptionsColumn.AllowEdit = false;
                gridColumnCantidad.OptionsColumn.AllowEdit = false;

            }
            else
            {
                PedidoActual.Anexo = null;
                lblLicitacion.Text = string.Empty;
                gvPedidoDetalle.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
                gvPedidoDetalle.OptionsBehavior.AllowDeleteRows = DefaultBoolean.True;
                bsPedidoDetalle.DataSource = new List<PedidoDetalle>();
                txtTotal.Text = @"$0.00";

                gridColumnArticulo.OptionsColumn.AllowEdit = true;
                gridColumnCantidad.OptionsColumn.AllowEdit = true;


            }

        }

        private void GvPedidoDetalleCellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var rowSelectValue = e.Value;

            //Para realizar las validaciones
            PedidoActual.PedidoDetalle = bsPedidoDetalle.DataSource as List<PedidoDetalle>;

            if (e.Column.AbsoluteIndex == 1)//posicionado en el articulo
            {
                if (TieneRepetidoArticulo((int?)(rowSelectValue)))
                {
                    XtraMessageBox.Show(@"Articulo repetido clave " + rowSelectValue,
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gvPedidoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", "");
                    //gvPedidoDetalle.SetRowCellValue(e.RowHandle, "PresentacionArt", "");
                    //gvAnexoDetalle.SetRowCellValue(e.RowHandle, "CveArt", "");
                    return;
                } try
                {
                    var cveArt = (int)rowSelectValue;

                    var almacen = FrmModuloModulo.AlmacenSelec;
                    var articuloid = new ArticuloId(cveArt, almacen);
                    var articuloSelect = PedidoService.AnexoService.ArticuloDao.Get(articuloid);
                    gvPedidoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", articuloSelect.DesArticulo);
                    //gvPedidoDetalle.SetRowCellValue(e.RowHandle, "PresentacionArt", articuloSelect.Presentacion);
                }
                catch (Exception ee)
                {
                    gvPedidoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", "");
                    //gvPedidoDetalle.SetRowCellValue(e.RowHandle, "PresentacionArt", "");

                }
            }

            //posicionado en precio
            if (e.Column.AbsoluteIndex == 7)
            {
                var precio = double.Parse(rowSelectValue.ToString());
                var cantidad = gvPedidoDetalle.GetRowCellValue(e.RowHandle, "Cantidad");

                if (cantidad == null)
                    precio = 0.0;
                var importe = double.Parse(cantidad + "") * precio;
                gvPedidoDetalle.SetRowCellValue(e.RowHandle, "Importe", importe);
            }

            SumTotal();
        }


        private void SumTotal()
        {
            if (bsPedidoDetalle.DataSource as IList<PedidoDetalle> != null)
            {
                var total =
               (from ad in bsPedidoDetalle.DataSource as IList<PedidoDetalle>
                select ad.Importe)
               .Sum();
                decimal dectotal = Convert.ToDecimal(total);
                txtTotal.Text = dectotal.ToString("$#,##0.00");
            }
        }

        private bool TieneRepetidoArticulo(int? articulo)
        {
            var numOcurrencia = PedidoActual.PedidoDetalle.Count
                (p => p.CveArt == articulo);

            return numOcurrencia > 1;
        }


        /// <summary>
        /// Display de la subventana PedidoEntregas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RepositoryItemButtonEdit1Click(object sender, EventArgs e)
        {
            var pedidoDetalleSelect = gvPedidoDetalle.GetFocusedRow() as PedidoDetalle;
            var forma = new FrmPedidoEntrega(pedidoDetalleSelect);
            forma.Show();
        }

        private void GcPedidoDetalleKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (PedidoActual.Anexo != null) // Solo si no tiene anexo
                {
                    gvPedidoDetalle.DeleteRow(gvPedidoDetalle.FocusedRowHandle);
                }
            }
        }
    }
}