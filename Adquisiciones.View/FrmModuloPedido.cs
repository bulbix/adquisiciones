using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Adquisiciones.Business.ModPedido;
using Adquisiciones.Data.Entities;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using log4net;
using Spring.Context.Support;
using Adquisiciones.Business;
using System.Linq;

namespace Adquisiciones.View
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmModuloPedido : DevExpress.XtraEditors.XtraForm
    {

        ///<summary
        /// Servicio de Negocio
        ///</summary>
        public IPedidoService PedidoService;

        /// <summary>
        /// </summary>
        public Pedido PedidoActual;


           /// <summary>
        /// La bitacora
        /// </summary>
        private static readonly ILog Log =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        
        private void BindearCampos()
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

        /// <summary>
        /// 
        /// </summary>
        public FrmModuloPedido(int tipoPedido)
        {
            InitializeComponent();
            var ctx = ContextRegistry.GetContext();
            PedidoService = ctx["pedidoService"] as IPedidoService;
            NuevoPedido();
            PedidoActual.CatTipopedido = new CatTipopedido(tipoPedido);

            //Si es distinto a pedido mayor deshabilita
            if (tipoPedido > 1)
                searchLookUpAnexo.Enabled = false;

            BindearCampos();
            CargarCombos();
        }

        ///<summary>
        ///</summary>
        ///<param name="pedido"></param>
        public FrmModuloPedido(Pedido pedido)
            : this(pedido.CatTipopedido.IdTipoped)
        {
            ConsultarPedido(pedido.NumeroPedido.Value);
            Text = @"Pedido::" + pedido;

            if (pedido.Requisicion != null)
                btnGuardar.Enabled = false;
        }




        /// <summary>
        /// Combos asociados al pedido 
        /// </summary>
        public void CargarCombos()
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

        private void SearchLookUpProveedorEditValueChanged1(object sender, EventArgs e)
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
            else{PedidoActual.Anexo = null;
                lblLicitacion.Text = string.Empty;
                gvPedidoDetalle.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
                gvPedidoDetalle.OptionsBehavior.AllowDeleteRows = DefaultBoolean.True;
                bsPedidoDetalle.DataSource = new List<PedidoDetalle>();
                txtTotal.Text = @"$0.00";

                gridColumnArticulo.OptionsColumn.AllowEdit = true;
                gridColumnCantidad.OptionsColumn.AllowEdit = true;


            }

        }

       

        private void BtnGuardarClick(object sender, EventArgs e)
        {
            listaError1.Items.Clear();
            lblNumErrors1.Text = "";

            //los parametros basicos
            PedidoActual.Almacen = FrmModuloModulo.AlmacenSelec;
            PedidoActual.Usuario = FrmModuloAcceso.UsuarioLog;

            //Validaciones 
            if (!Util.DatosValidos(PedidoActual, lblNumErrors1, listaError1))
            {
                return;
            }

            PedidoActual.PedidoDetalle =  bsPedidoDetalle.DataSource as List<PedidoDetalle>;

            try
            {
                PedidoService.GuardarPedido(ref PedidoActual);
                MessageBox.Show(@"Pedido Registrado o Actualizado Exitosamente",
                                @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la persistencia Reportalo a Dep. Sistemas",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }

        }

        private void BtnRefrescarClick(object sender, EventArgs e)
        {
            ConsultarPedido((int)numPedido.Value);
        }

        private void BtnNuevoClick(object sender, EventArgs e)
        {
            NuevoPedido();

        }

        private void NuevoPedido()
        {
            PedidoActual = new Pedido();
            bsPedido.DataSource = PedidoActual;
            bsPedidoDetalle.DataSource = new List<PedidoDetalle>();

            //Cargamos el numero de pedido maximo
            PedidoActual.NumeroPedido = PedidoService.PedidoDao.MaximoNumeroPedido(FrmModuloModulo.AlmacenSelec);
            numPedido.Value = (decimal)PedidoActual.NumeroPedido;
            deFechaPedido.DateTime = PedidoService.PedidoDao.FechaServidor();
            PedidoActual.FechaPedido = deFechaPedido.DateTime;
            
            //txtnumlicitacion.Enabled = true;
            //dtpFechaanexo.Enabled = true;btnGuardar.Enabled = true;
            //txtnumlicitacion.Focus();listaError1.Items.Clear();
            lblNumErrors1.Text = string.Empty;

            lblArea.Text = "";
            lblLicitacion.Text = "";
            lblProveedor.Text = "";
            lblFundamento.Text = "";
        }
        private void ConsultarPedido(int numPedido)
        {
            try
            {
                PedidoActual = PedidoService.ConsultarPedido(numPedido,
                                                          FrmModuloModulo.AlmacenSelec);

                if (PedidoActual != null){
                    bsPedido.DataSource = PedidoActual;
                    bsPedidoDetalle.DataSource = PedidoActual.PedidoDetalle;
                   
                    lblFundamento.Text = PedidoActual.Fundamento.ToString();
                    lblArea.Text = PedidoActual.CatArea.ToString();
                    lblProveedor.Text = PedidoActual.Proveedor.ToString();

                    if(PedidoActual.Anexo != null)
                        lblLicitacion.Text = PedidoActual.Anexo.ToString();

                    listaError1.Items.Clear();
                    lblNumErrors1.Text = string.Empty;
                    SumTotal();
                }
                else
                {
                    MessageBox.Show(@"Folio no existe", @"Adquisiciones",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(@"Ocurrio un error en la consulta Reportalo a Dep. Sistemas",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Log.Error("Generado por:" + FrmModuloAcceso.UsuarioLog, ee);
            }
        }

        private void GvPedidoDetalleCellValueChanged (object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var rowSelectValue = e.Value;

            //Para realizar las validaciones
            PedidoActual.PedidoDetalle = bsPedidoDetalle.DataSource as List<PedidoDetalle>;

            ////Posicionado en renglon
            //if (e.Column.AbsoluteIndex == 0)
            //{
            //    if (TieneRepetidoRenglon((short?)(rowSelectValue)))
            //    {

            //        MessageBox.Show(@"Renglon repetido numero " + rowSelectValue,
            //                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        gvPedidoDetalle.SetRowCellValue(e.RowHandle, "Renglon", "");
            //        return;
            //    }
            //}

            if (e.Column.AbsoluteIndex == 1)//posicionado en el articulo
            {
                if (TieneRepetidoArticulo((int?)(rowSelectValue)))
                {
                    MessageBox.Show(@"Articulo repetido clave " + rowSelectValue,
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gvPedidoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", "");
                    //gvPedidoDetalle.SetRowCellValue(e.RowHandle, "PresentacionArt", "");
                    //gvAnexoDetalle.SetRowCellValue(e.RowHandle, "CveArt", "");
                    return;
                }try
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


        //private bool TieneRepetidoRenglon(short? renglon)
        //{
        //    var numOcurrencia = PedidoActual.PedidoDetalle.Count
        //        (p => p.Renglon == renglon);

        //    return numOcurrencia > 1;//}

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