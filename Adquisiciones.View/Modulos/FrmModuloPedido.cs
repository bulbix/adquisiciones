using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Business.ModPedido;
using Adquisiciones.Data.Entities;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;

namespace Adquisiciones.View.Modulos
{
    public partial class FrmModuloPedido : FrmModulo
    {
        #region Variables
        public IPedidoService PedidoService;
        public Pedido PedidoActual;
        public Almacen AlmacenArticulo;
        private int tipoPedido = 0;
        private decimal importeTotal = (decimal)0.0;
        #endregion

        #region Constructores
        public FrmModuloPedido(FrmAdquisiciones padre)
        {
            InitializeComponent();

            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;
            AlmacenesCombo(cbxAlmacen, AlmacenActual);

            base.TypeEntity = typeof(Pedido);
            base.NombreReporte = "reportePedido";
            base.NombreService = "pedidoService";
            base.GetServicio();
            PedidoService = base.Servicio as IPedidoService;
            base.ObtenerPerfil();
        }

        public FrmModuloPedido(int tipoPedido,FrmAdquisiciones padre):this(padre)
        {
            this.tipoPedido = tipoPedido;
            Nuevo();
            
            PedidoActual.CatTipopedido = new CatTipopedido(tipoPedido);

            if (tipoPedido > 1)
                searchLookUpAnexo.Enabled = false;

            if(tipoPedido > 2)
                gridColumnFecha.Visible = false;

           
            InicializarCatalogos();
            BindearCampos();

        }

         public FrmModuloPedido(Pedido pedido,FrmAdquisiciones padre):this(pedido.CatTipopedido.IdTipoped,padre)
         {
            PedidoActual = pedido;
            Consultar();
            Text = @"Pedido::" + pedido;

            if (pedido.Requisicion != null)
                cmdGuardar.Enabled = false;
            
         }
        #endregion

        #region Metodos
         public override void BindearCampos()
        {
            bsPedidoDetalle.DataSource = new List<PedidoDetalle>();
           
            txtRequisicion.DataBindings.Add(new Binding("Text", bsPedido, "NumeroRequisicion", true));
            txtDescuento.DataBindings.Add(new Binding("Text", bsPedido, "ImporteDescuento", true));
            txtReserva.DataBindings.Add(new Binding("Text", bsPedido, "IdReservaautoriza", true));
            //cbxActividad.DataBindings.Add(new Binding("SelectedValue", bsPedido, "CatActividad", false));
            //cbxIva.DataBindings.Add(new Binding("SelectedValue", bsPedido, "Iva", false));
            //cbxCargo.DataBindings.Add(new Binding("SelectedValue", bsPedido, "CatPresupuesto", false));
            txtObservaciones.DataBindings.Add(new Binding("Text", bsPedido, "Observaciones", false));

        }

        public override void InicializarCatalogos()
        {
            PedidoService.CatalogoActividad(cbxActividad);
            PedidoService.AnexoService.IvasCombo(cbxIva);
            PedidoService.CatalogoPresupuestal(cbxCargo);
            bsFundamento.DataSource = PedidoService.PedidoDao.CargarCatalogo<Fundamento>();
            bsArea.DataSource = PedidoService.PedidoDao.CargarCatalogo<CatArea>("Estatus", 1);
            bsProveedor.DataSource = PedidoService.PedidoDao.CargarCatalogo<Proveedor>();
            bsAnexo.DataSource = PedidoService.AnexoDao.CargarAnexos(AlmacenActual);
            bsPartida.DataSource = PedidoService.PedidoDao.CargarCatalogo<CatPartida>();
        }

        public override void Nuevo()
        {
            PedidoActual = new Pedido();
            PedidoActual.CatTipopedido = new CatTipopedido(this.tipoPedido);

            bsPedido.DataSource = PedidoActual;
            bsPedidoDetalle.DataSource = new List<PedidoDetalle>();

            //Cargamos el numero de pedido maximo
            PedidoActual.NumeroPedido = PedidoService.PedidoDao.
                SiguienteNumeroPedido(AlmacenActual, this.tipoPedido);
            lblNumero.Text = PedidoActual.NumeroPedido.ToString();
            PedidoActual.FechaPedido = PedidoService.PedidoDao.FechaServidor();
            lblFecha.Text = String.Format("{0:dd/MM/yyyy}", PedidoActual.FechaPedido);
            
            cmdGuardar.Enabled = true;
            cbxAlmacen.Enabled = true;
            searchLookUpFundamento.EditValue = null;
            searchLookUpArea.EditValue = null;
            searchLookUpProveedor.EditValue = null;
            searchLookUpAnexo.EditValue = null;
            searchLookUpAnexo.Enabled = true;
            searchLookUpPartida.Enabled = true;
            searchLookUpPartida.EditValue = null;
            LimpiarErrores();
            LimpiarComboAnexo();
            splitContainerControl1.Panel1.Enabled = true;
            txtRequisicion.Focus();
        }

        public override void Guardar()
        {
            SumTotal();
            LimpiarErrores();

            //los parametros basicos
            PedidoActual.Almacen = AlmacenActual;
            PedidoActual.Usuario = FrmModuloAcceso.UsuarioLog;
           
            //Cmbos
            PedidoActual.CatActividad = cbxActividad.SelectedValue as CatActividad;
            PedidoActual.CatPresupuesto = cbxCargo.SelectedValue as CatPresupuesto;
            PedidoActual.Iva = cbxIva.SelectedValue as Iva;

            if (!Util.DatosValidos(PedidoActual, lblNumErrors, listaError))
                return;

            PedidoActual.PedidoDetalle = bsPedidoDetalle.DataSource as List<PedidoDetalle>;

            try
            {
                PedidoService.GuardarPedido(ref PedidoActual, importeTotal);

                Consultar();

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
                                                          AlmacenActual, this.tipoPedido);
                if (PedidoActual != null)
                {
                    lblNumero.Text = PedidoActual.NumeroPedido.ToString();
                    lblFecha.Text = String.Format("{0:dd/MM/yyyy}", PedidoActual.FechaPedido);

                    bsPedido.DataSource = PedidoActual;
                    bsPedidoDetalle.DataSource = PedidoActual.PedidoDetalle;

                    //Combos que no vincula
                    if(PedidoActual.CatActividad != null)
                        cbxActividad.SelectedIndex = cbxActividad.FindStringExact(PedidoActual.CatActividad.DesActividad);
                    
                    if(PedidoActual.CatPresupuesto != null)
                        cbxCargo.SelectedIndex = cbxCargo.FindStringExact(PedidoActual.CatPresupuesto.DesPresupuesto);

                    if(PedidoActual.Iva != null)
                        cbxIva.SelectedIndex = cbxIva.FindStringExact(PedidoActual.Iva.Id.Porcentaje.ToString());

                    if (searchLookUpFundamento.Handle != IntPtr.Zero)
                        searchLookUpFundamento.EditValue = PedidoActual.Fundamento.CveFundamento;

                    if (searchLookUpArea.Handle != IntPtr.Zero)
                        searchLookUpArea.EditValue = PedidoActual.CatArea.CveArea;

                    if (searchLookUpProveedor.Handle != IntPtr.Zero)
                        searchLookUpProveedor.EditValue = PedidoActual.Proveedor.CveProveedor;

                    if (PedidoActual.Anexo != null)
                    {
                        if (searchLookUpAnexo.Handle != IntPtr.Zero)
                        searchLookUpAnexo.EditValue = PedidoActual.Anexo.NumeroAnexo;

                        SeleccionoAnexo();
                       
                    }

                    var oneDetalle = PedidoActual.PedidoDetalle[0];

                    //Centinela
                    if (searchLookUpPartida.Handle != IntPtr.Zero)
                        searchLookUpPartida.EditValue =
                            PedidoService.AnexoService.ArticuloDao.GetPartida(oneDetalle.Articulo).Partida;


                    LimpiarErrores();
                   

                    if(PedidoService.PedidoDao.ExisteEntradaPedido(PedidoActual))
                    {
                        XtraMessageBox.Show(@"Ya Existe entrada asociada al pedido",
                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmdGuardar.Enabled = false;
                    }

                    searchLookUpPartida.Enabled = false;
                    searchLookUpAnexo.Enabled = false;
                    cbxAlmacen.Enabled = false;


                    base.EntityActual = PedidoActual;
                    base.Consultar();

                    

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

        private void SeleccionoAnexo()
        {
            gvPedidoDetalle.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            gvPedidoDetalle.OptionsBehavior.AllowDeleteRows = DefaultBoolean.False;
            gridColumnArticulo.OptionsColumn.AllowEdit = false;
        }

        private void LimpiarComboAnexo()
        {
            PedidoActual.Anexo = null;
            gvPedidoDetalle.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            gvPedidoDetalle.OptionsBehavior.AllowDeleteRows = DefaultBoolean.True;
            bsPedidoDetalle.DataSource = new List<PedidoDetalle>();
            lblSubTotal.Text = @"$0.00";
            gridColumnArticulo.OptionsColumn.AllowEdit = true;
        }

        private void SumTotal()
        {
            try
            {
                if (bsPedidoDetalle.DataSource as IList<PedidoDetalle> != null)
                {
                    var subTotal = (from ad in bsPedidoDetalle.DataSource as IList<PedidoDetalle>
                                    select ad.Importe).Sum();
                    var dectotal = Convert.ToDecimal(subTotal);
                    lblSubTotal.Text = dectotal.ToString("$#,##0.00");

                    decimal descuento = (decimal)0.0;


                    if (rbCantidad.Checked)
                    {
                        descuento = decimal.Parse(txtDescuento.Text);
                        lblDescuento.Text = descuento.ToString("$#,##0.00");

                    }
                    else if (rbPorcentaje.Checked)
                    {
                        descuento = decimal.Parse(txtDescuento.Text) / 100;
                        lblDescuento.Text = descuento.ToString("$#,##0.00");
                    }

                    decimal importeDesc = subTotal.Value - descuento;

                    lblSubDesc.Text = importeDesc.ToString("$#,##0.00");

                    var iva = (cbxIva.SelectedValue as Iva).Id.Porcentaje;

                    decimal cantidadIva = importeDesc * iva / 100;

                    lblIva.Text = cantidadIva.ToString("$#,##0.00");

                    this.importeTotal = importeDesc + cantidadIva;
                    lblTotal.Text = importeTotal.ToString("$#,##0.00");

                }
            }
            catch (Exception e)
            {
                lblSubTotal.Text = "$0.00";
                lblDescuento.Text = "$0.00";
                lblSubDesc.Text = "$0.00";
                lblIva.Text = "$0.00";
                lblTotal.Text = "$0.00";

            }
        }

        private bool TieneRepetidoArticulo(int? articulo)
        {
            var numOcurrencia = PedidoActual.PedidoDetalle.Count(p => p.CveArt == articulo);
            return numOcurrencia > 1;
        }

        #endregion

        #region Eventos
        private void SearchLookUpFundamentoEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpFundamento.EditValue != null)
            {
                var funSeleccionado = searchLookUpEditFundamento.GetFocusedRow() as Fundamento;

                if(funSeleccionado != null)
                    PedidoActual.Fundamento = funSeleccionado;
            }

        }

        private void SearchLookUpAreaEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpArea.EditValue != null)
            {
                var areaSeleccionada = searchLookUpEditArea.GetFocusedRow() as CatArea;
                
                if(areaSeleccionada != null)
                    PedidoActual.CatArea = areaSeleccionada;
            }
        }

        private void SearchLookUpProveedorEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpProveedor.EditValue != null)
            {
                var provSeleccionado = searchLookUpEditProveedor.GetFocusedRow() as Proveedor;

                if(provSeleccionado != null)
                    PedidoActual.Proveedor = provSeleccionado;
            }

        }

        private void SearchLookUpAnexoEditValueChanged(object sender, EventArgs e)
        {
            if (searchLookUpAnexo.EditValue != null)
            {
                var anexoSeleccionado = searchLookUpEditAnexo.GetFocusedRow() as Anexo;

                //Solo pedidos nuevos
                if (anexoSeleccionado != null && PedidoActual.IdPedido == 0)
                {
                    if (PedidoService.PedidoDao.ExisteAnexoPedido(anexoSeleccionado))
                    {
                        XtraMessageBox.Show(@"El anexo ya esta asociado a un pedido",
                                            @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarComboAnexo();
                        return;
                    }
                    PedidoActual.Anexo = anexoSeleccionado;
                    var pedidosDetalle = PedidoService.CargarPedidoDetalle(anexoSeleccionado);
                    bsPedidoDetalle.DataSource = pedidosDetalle;
                    SeleccionoAnexo();
                }
            }
            else
            {
                LimpiarComboAnexo();
            }

        }

        private void GvPedidoDetalleCellValueChanged(object sender, CellValueChangedEventArgs e)
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
                    gvPedidoDetalle.SetRowCellValue(e.RowHandle, "UnidadArt", "");
                    return;
                } 
                
                try
                {
                    var cveArt = (int)rowSelectValue;
                    var almacen = cbxAlmacen.SelectedValue as Almacen;
                    var partida = searchLookUpEditPartida.GetFocusedRow() as CatPartida;

                    if(partida == null)
                    {
                        XtraMessageBox.Show(@"No ha seleccionado partida",
                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var articuloSelect = PedidoService.AnexoService.
                        ArticuloDao.ArticuloPartida(cveArt, almacen, partida);

                    if(articuloSelect == null)
                    {
                        XtraMessageBox.Show(@"No existe la clave", @"Adquisiciones",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                        gvPedidoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", "");
                        gvPedidoDetalle.SetRowCellValue(e.RowHandle, "UnidadArt", "");

                        return;
                    }

                    gvPedidoDetalle.SetRowCellValue(e.RowHandle, "Articulo", articuloSelect);
                    gvPedidoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", articuloSelect.DesArticulo);
                    gvPedidoDetalle.SetRowCellValue(e.RowHandle, "UnidadArt", articuloSelect.CatUnidad.Unidad);
                    gvPedidoDetalle.SetRowCellValue(e.RowHandle, "Cantidad", 0);
                    gvPedidoDetalle.SetRowCellValue(e.RowHandle, "PrecioUnitario", 0.0);
                    
                }
                catch (Exception ee)
                {
                    gvPedidoDetalle.SetRowCellValue(e.RowHandle, "DescripcionArt", "");
                    gvPedidoDetalle.SetRowCellValue(e.RowHandle, "UnidadArt", "");

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
                if (PedidoActual.Anexo == null) // Solo si no tiene anexo
                {
                    gvPedidoDetalle.DeleteRow(gvPedidoDetalle.FocusedRowHandle);
                }
            }
        }

        private void TxtDescuentoLeave(object sender, EventArgs e)
        {
            SumTotal();
        }

        private void CbxIvaSelectedValueChanged(object sender, EventArgs e)
        {
            SumTotal();
        }

        private void SearchLookUpPartidaEditValueChanged(object sender, EventArgs e)
        {
            if (PedidoActual.IdPedido == 0)//Nuevo
                bsPedidoDetalle.DataSource = new List<PedidoDetalle>();
        }

        private void CbxAlmacenSelectedIndexChanged(object sender, EventArgs e)
        {
            if(PedidoActual == null || PedidoActual.IdPedido == 0)//Nuevo
                bsPedidoDetalle.DataSource = new List<PedidoDetalle>();
        }

        private void FrmModuloPedidoLoad(object sender, EventArgs e)
        {
            SumTotal();
        }

        #endregion
    }
}