using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Business.ModPedido;
using Adquisiciones.Data.Entities;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace Adquisiciones.View.Modulos
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FrmModuloPedido : FrmModulo
    {
        #region Variables
        public IPedidoService PedidoService;
        public Pedido PedidoActual;
        private int tipoPedido = 0;
        
        
        #endregion

        #region Constructores

        /// <summary>
        /// Modulo Pedido creado a partir de la forma padre principal
        /// que dara los permisos y el almacen elegido
        /// </summary>
        /// <param name="padre"></param>
        public FrmModuloPedido(FrmAdquisiciones padre)
        {
            InitializeComponent();

            ModulosUsuario = padre.ModulosUsuario;
            AlmacenActual = padre.AlmacenSelect;
            AlmacenesCombo(cbxAlmacen, AlmacenActual);

            base.TypeEntity = typeof(Pedido);
            base.NombreModulo = "Pedido";
            base.NombreReporte = "reportePedido";
            base.NombreService = "pedidoService";
            base.GetServicio();
            PedidoService = base.Servicio as IPedidoService;
            base.ObtenerPerfil();
        }

        /// <summary>
        /// Constructor que crea el modulo a partir del contenedor principal 
        /// heredado del principal constructor
        /// </summary>
        /// <param name="tipoPedido">El tipo a ser creado</param>
        /// <param name="padre">Forma padre principal</param>
        public FrmModuloPedido(int tipoPedido,FrmAdquisiciones padre):this(padre)
        {
            this.tipoPedido = tipoPedido;
            Nuevo();
            
            PedidoActual.CatTipopedido = new CatTipopedido(tipoPedido);
            plProcedimiento.TipoPedido = PedidoActual.CatTipopedido;

            if (tipoPedido > 1)
            {
                searchLookUpAnexo.Enabled = false;
                panelFechaEntrega.Visible = false;
                gridColumnFecha.Visible = false;
            }

            if (tipoPedido > 2)
            {
                cmdMostrarProc.Visible = false;
            }


            InicializarCatalogos();
            BindearCampos();

        }

        /// <summary>
        /// Constructor creado a partir del segundo constructor 
        /// es creado a partir de una consulta de pedido
        /// </summary>
        /// <param name="pedido">Pedido consultado</param>
        /// <param name="padre">Forma Padre Principal</param>
        public FrmModuloPedido(Pedido pedido,FrmAdquisiciones padre):
            this(pedido.CatTipopedido.IdTipoped,padre)
         {
            PedidoActual = pedido;
            plProcedimiento.TipoPedido = PedidoActual.CatTipopedido;
            Consultar();

            Text = @"Pedido::" + PedidoActual;

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
            txtObservaciones.DataBindings.Add(new Binding("Text", bsPedido, "Observaciones", false));
            
            //deFecha.DataBindings.Add(new Binding("DateTime", bsPedido, "FechaPedido", true));
            //txtNumero.DataBindings.Add(new Binding("Value", bsPedido, "NumeroPedido", true));

        }

        public override void InicializarCatalogos()
        {
            PedidoService.CatalogoActividad(cbxActividad);
            PedidoService.AnexoService.IvasCombo(cbxIva);
            PedidoService.CatalogoPresupuestal(cbxCargo);
            bsFundamento.DataSource = PedidoService.PedidoDao.CargarCatalogo<Fundamento>("CveFundamento");
            bsArea.DataSource = PedidoService.PedidoDao.CargarCatalogo<CatArea>("CveArea","Estatus", 1);
            bsProveedor.DataSource = PedidoService.PedidoDao.CargarCatalogo<Proveedor>("CveProveedor");
            bsAnexo.DataSource = PedidoService.AnexoDao.CargarAnexos(AlmacenActual);
            bsPartida.DataSource = PedidoService.PedidoDao.CargarCatalogo<CatPartida>("Partida");
        }

        public override void Nuevo()
        {
            PedidoActual = new Pedido();
            PedidoActual.CatTipopedido = new CatTipopedido(this.tipoPedido);

            bsPedido.DataSource = PedidoActual;
            bsPedidoDetalle.DataSource = new List<PedidoDetalle>();

            //Esto es un cambio para la ultima version
            PedidoActual.NumeroPedido = PedidoService.PedidoDao.SiguienteNumeroPedido(AlmacenActual, this.tipoPedido);
            lblNumero.Text = PedidoActual.NumeroPedido.ToString();
            PedidoActual.FechaPedido = PedidoService.PedidoDao.FechaServidor();
            lblFecha.Text = String.Format("{0:dd/MM/yyyy}", PedidoActual.FechaPedido);

            /*PedidoActual.FechaPedido = PedidoService.PedidoDao.FechaServidor();
            PedidoActual.NumeroPedido = PedidoService.PedidoDao.SiguienteNumeroPedido(AlmacenActual, this.tipoPedido).Value;
            deFecha.DateTime = PedidoActual.FechaPedido.Value;
            txtNumero.Value = PedidoActual.NumeroPedido.Value;
            */
             
            txtDescuento.Text = "0.00";
            Text = @"Pedido::" + PedidoActual;

            cmdGuardar.Enabled = true;
            cbxAlmacen.Enabled = true;

            searchLookUpFundamento.Visible = false;
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
            txtCentinela.Focus(); //Para rebindeeen los campos
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

            if ((tipoPedido == 1 || tipoPedido == 2 ) &&  plProcedimiento.Tipoprocedimiento.Catalogo == null)
            {
                XtraMessageBox.Show(@"Procedimiento es requerido",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tipoPedido == 1 && !ExisteFechaEntrega())
            {
                XtraMessageBox.Show(@"No ha capturado fechas de entrega para todas las claves",
                    @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (plProcedimiento.Tipoprocedimiento != null && 
                plProcedimiento.Tipoprocedimiento.Catalogo == null)
                PedidoActual.TipoProcedimiento = null;
            else
                PedidoActual.TipoProcedimiento = plProcedimiento.Tipoprocedimiento;
            

            //Nuevo
            /*if (PedidoActual.IdPedido == 0 && PedidoService.PedidoDao.ExisteNumeroPedido(AlmacenActual, tipoPedido,
                PedidoActual.NumeroPedido.Value)){

                    XtraMessageBox.Show(@"El Folio ya existe",
                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }*/

            PedidoActual.PedidoDetalle = bsPedidoDetalle.DataSource as List<PedidoDetalle>;

            try
            {
                PedidoService.GuardarPedido(ref PedidoActual);

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

                    if (PedidoActual.Fundamento != null)
                    {
                        cmdMostrarProc.Visible = false;
                        searchLookUpFundamento.Visible = true;
                        if (searchLookUpFundamento.Handle != IntPtr.Zero)
                            searchLookUpFundamento.EditValue = PedidoActual.Fundamento.CveFundamento;
                    }

                    plProcedimiento.Tipoprocedimiento = PedidoActual.TipoProcedimiento;

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
                    PedidoActual.Partida = PedidoService.AnexoService.ArticuloDao.GetPartida(oneDetalle.Articulo);
                    cbxAlmacen.SelectedIndex = cbxAlmacen.FindStringExact(oneDetalle.Articulo.Id.Almacen.ToString());

                    //Centinela
                    if (searchLookUpPartida.Handle != IntPtr.Zero)
                        searchLookUpPartida.EditValue = PedidoActual.Partida.Partida;


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

                    cmdMostrarProc.Enabled = true;

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
                        descuento = (decimal.Parse(txtDescuento.Text) / 100) * subTotal.Value;
                        lblDescuento.Text = descuento.ToString("$#,##0.00");
                    }

                    decimal importeDesc = subTotal.Value - descuento;

                    lblSubDesc.Text = importeDesc.ToString("$#,##0.00");

                    var iva = (cbxIva.SelectedValue as Iva).Id.Porcentaje;

                    decimal cantidadIva = importeDesc * iva / 100;

                    lblIva.Text = cantidadIva.ToString("$#,##0.00");

                    var importeTotal = importeDesc + cantidadIva;
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

        /// <summary>
        /// Verifica si existe al menos una fecha de entrega para todos los pedidos detalle
        /// </summary>
        /// <returns></returns>
        private bool ExisteFechaEntrega()
        {
            var pedidoDetalle = bsPedidoDetalle.DataSource as List<PedidoDetalle>;
            var result = false;
            var index = pedidoDetalle.Count(detalle => detalle.PedidoEntrega.Count >= 1);

            if (pedidoDetalle.Count == index)
                result = true;

            return result;

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
                    //var partida = searchLookUpEditPartida.GetFocusedRow() as CatPartida;

                    if(PedidoActual.Partida == null)
                    {
                        XtraMessageBox.Show(@"No ha seleccionado partida",
                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var articuloSelect = PedidoService.AnexoService.
                        ArticuloDao.ArticuloPartida(cveArt, almacen, PedidoActual.Partida);

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
                    gvPedidoDetalle.SetRowCellValue(e.RowHandle, "UnidadArt", articuloSelect.Unidad);
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

            //posicionado en cantidad
            if(e.Column.AbsoluteIndex == 4)
            {
                var cantidad = decimal.Parse(rowSelectValue.ToString());

                if(cantidad != (decimal)0.0)
                {
                    if (deFechaInicial.DateTime.CompareTo(deFechaFinal.DateTime) > 0)
                    {
                        XtraMessageBox.Show(@"Fecha inicial debe ser menor o igual fecha final",
                                        @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    //Agregar un pedido entrega default
                    var pedidoDetalleSelect = gvPedidoDetalle.GetFocusedRow() as PedidoDetalle;
                    pedidoDetalleSelect.PedidoEntrega.Clear();

                    if (deFechaInicial.EditValue != null && deFechaFinal.EditValue != null)
                    {
                        var pedidoEntrega = new PedidoEntrega(deFechaInicial.DateTime,
                                                    deFechaFinal.DateTime, cantidad);
                        pedidoDetalleSelect.PedidoEntrega.Add(pedidoEntrega);
                    }
                }
                //var articulo = gvPedidoDetalle.GetRowCellValue(e.RowHandle, "Articulo");
                //decimal? sumaPedidoEntrega = PedidoActual.PedidoDetalle.
                //First(detalle=>detalle.Articulo == articulo).
                //PedidoEntrega.Sum(entrega => entrega.Cantidad);
                //if (sumaPedidoEntrega > cantidad)
                //{
                //    XtraMessageBox.Show(@"La suma de los renglones del pedido entrega debe coincidir con " + cantidad,
                //             @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }

            SumTotal();
        }

        private void RepositoryItemButtonEdit1Click(object sender, EventArgs e)
        {
            var pedidoDetalleSelect = gvPedidoDetalle.GetFocusedRow() as PedidoDetalle;
            var forma = new FrmPedidoEntrega(pedidoDetalleSelect);
            forma.ShowDialog();
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

            if (searchLookUpPartida.EditValue != null)
            {
                var parSeleccionado = searchLookUpEditPartida.GetFocusedRow() as CatPartida;

                if (parSeleccionado != null)
                    PedidoActual.Partida = parSeleccionado;
            }
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

        private void CmdRefrescarTotalClick(object sender, EventArgs e)
        {
            SumTotal();
        }

        private void CmdUpdateFechaEntregaClick(object sender, EventArgs e)
        {

            if (deFechaInicial.DateTime.CompareTo(deFechaFinal.DateTime) > 0)
            {
                XtraMessageBox.Show(@"Fecha inicial debe ser menor o igual fecha final",
                                @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach(var pedidoDetalle in PedidoActual.PedidoDetalle)
            {
                pedidoDetalle.PedidoEntrega.Clear();

                if(deFechaInicial.EditValue != null && deFechaFinal.EditValue != null)
                {
                    var pedidoEntrega = new PedidoEntrega(deFechaInicial.DateTime,
                                                deFechaFinal.DateTime, pedidoDetalle.Cantidad);
                    pedidoDetalle.PedidoEntrega.Add(pedidoEntrega);
                }
            }

            XtraMessageBox.Show(@"Fechas de Entrega Actualizadas todas las claves",
                   @"Adquisiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void cmdMostrarProc_Click(object sender, EventArgs e)
        {
            plProcedimiento.Visible = true;
        }
       
    }
}