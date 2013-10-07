using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Adquisiciones.Business.ModAnexo;
using Adquisiciones.Business.ModCotizacion;
using Adquisiciones.Business.ModFallo;
using Adquisiciones.Business.ModPedido;
using Adquisiciones.Data.Dao.ModPedido;
using Adquisiciones.Data.Entities;
using Adquisiciones.View.DataSets;
using Adquisiciones.View.Reportes.Clases;
using DevExpress.XtraEditors;
using Spring.Context.Support;

namespace Adquisiciones.View.Reportes
{
    ///<summary>
    ///</summary>
    public partial class FrmModuloReportes : XtraForm
    {
        private readonly string NombreReporte;

        private readonly object Entity;

        public IAnexoService AnexoService { get; set; }
        public ICotizacionService CotizacionService { get; set; }
        public IFalloService FalloService { get; set; }
        public IPedidoService PedidoService { get; set; }

        ///<summary></summary>
        ///<param name="nombreReporte"></param>
        ///<param name="entity"></param>
        public FrmModuloReportes(string nombreReporte, object entity)
        {
            InitializeComponent();
            NombreReporte = nombreReporte;
            Entity = entity;
            IniciarServicios();
            GenerarReporte();
        }
        
        public FrmModuloReportes()
        {
            InitializeComponent();
            IniciarServicios();
        }
        
        private void IniciarServicios()
        {
            var ctx = ContextRegistry.GetContext();
            AnexoService = ctx["anexoService"] as IAnexoService;
            CotizacionService = ctx["cotizacionService"] as ICotizacionService;
            FalloService = ctx["falloService"] as IFalloService;
            PedidoService = ctx["pedidoService"] as IPedidoService;
        }

        private void GenerarReporte()
        {
            Cursor.Current = Cursors.WaitCursor; 
            switch (NombreReporte)
            {
                case "reporteAnexo":
                    ReporteAnexo(Entity as Anexo);
                    break;
                case "reporteCotizacion":
                    ReporteCotizacion(Entity as Cotizacion);
                    break;
                case "reporteTabla":
                    ReporteTabla(Entity as Anexo);
                    break;
                case "reporteFallo":
                    ReporteFallo(Entity as Fallo);
                    break;
                case "reportePedido":
                    ReportePedido(Entity as Pedido);
                    break;
                case "reportePedidoConcentrado":
                    ReportePedidoConcentrado(Entity as List<Pedido>);
                    break;
                case "reportePedidoDetallado":
                    ReportePedidoDetallado(Entity as List<Pedido>);
                    break;
                case "reportePedidoEntrada":
                    ReportePedidoEntrada(Entity as List<Pedido>);
                    break;
                case "reporteProveedor":
                    ReporteProveedor(Entity as List<Proveedor>);
                    break;
                case "reporteFundamento":
                    ReporteFundamento(Entity as List<Fundamento>);
                    break;
                case "reporteListaPedido":
                    ReporteListadoPedido(Entity as List<Pedido>);
                    break;
                case "reportePedidoSaldo":
                    ReportePedidoSaldo(Entity as List<Pedido>);
                    break;


            }

            Cursor.Current = Cursors.Default;
        }
       
        private void ReporteAnexo(Anexo anexo){
           
            var anexoDs = new AnexoDS();

            anexo = AnexoService.ConsultarAnexo(anexo.NumeroAnexo, anexo.Almacen);

            DataRow filaMain = anexoDs.Tables["Anexo"].NewRow();
            filaMain["Id"] = anexo.IdAnexo;
            filaMain["Numero"] = anexo.NumeroAnexo;
            filaMain["Descripcion"] = anexo.DesAnexo;
            filaMain["Fecha"] = String.Format("{0:dd/MM/yyyy}", anexo.FechaAnexo);
            filaMain["Presupuesto"] = anexo.TechoPresupuestal.Value.ToString("C");
            anexoDs.Tables["Anexo"].Rows.Add(filaMain);
            anexoDs.Tables["Anexo"].AcceptChanges();

           
            foreach (AnexoDetalle detalle in anexo.AnexoDetalle)
            {
                DataRow filaDetalle = anexoDs.Tables["AnexoDetalle"].NewRow();
                filaDetalle["Id"] = anexo.IdAnexo;
                filaDetalle["Renglon"] = detalle.RenglonAnexo;
                filaDetalle["Articulo"] = detalle.Articulo.Id.CveArt;
                filaDetalle["Descripcion"] = detalle.Articulo.DesArticulo;
                filaDetalle["Unidad"] = detalle.Articulo.Unidad;
                filaDetalle["CantidadMinimo"] = detalle.CantidadMinimo??0;
                filaDetalle["CantidadMaximo"] = detalle.CantidadMaximo;
                anexoDs.Tables["AnexoDetalle"].Rows.Add(filaDetalle);
            }

            anexoDs.Tables["AnexoDetalle"].AcceptChanges();

            if (anexo.TipoContrato == Contrato.ABIERTO)
            {
                ReporteAnexoAbierto1.SetDataSource(anexoDs);
                crystalReportViewer.ReportSource = ReporteAnexoAbierto1;
            }
            else if (anexo.TipoContrato == Contrato.CERRADO)
            {
                ReporteAnexoCerrado1.SetDataSource(anexoDs);
                crystalReportViewer.ReportSource = ReporteAnexoCerrado1;
            }

            
            crystalReportViewer.Refresh();

            Text = @"ReporteAnexo";
        }
        
        private void ReporteCotizacion(Cotizacion cotizacion)
        {
           
            CotizacionService.ConsultarCotizacion(ref cotizacion);

            var cotizacionDs = new CotizacionDS();

            DataRow filaMain = cotizacionDs.Tables["Cotizacion"].NewRow();
            filaMain["Id"] = cotizacion.IdCotizacion;
            filaMain["Fecha"] = String.Format("{0:dd/MM/yyyy}", cotizacion.FechaCotizacion);
            filaMain["Anexo"] = cotizacion.Anexo;
            filaMain["Proveedor"] = cotizacion.Proveedor;
            cotizacionDs.Tables["Cotizacion"].Rows.Add(filaMain);
            cotizacionDs.Tables["Cotizacion"].AcceptChanges();
            
            foreach (CotizacionDetalle detalle in cotizacion.CotizacionDetalle)
            {
                if (detalle.Precio != null)
                {
                    DataRow filaDetalle = cotizacionDs.Tables["CotizacionDetalle"].NewRow();
                    filaDetalle["Id"] = cotizacion.IdCotizacion;
                    filaDetalle["Renglon"] = detalle.RenglonAnexo;
                    filaDetalle["Articulo"] = detalle.Articulo.Id.CveArt;
                    filaDetalle["Descripcion"] = detalle.Articulo.DesArticulo;
                    filaDetalle["Unidad"] = detalle.Articulo.Unidad;
                    filaDetalle["Marca"] = detalle.Marca;
                    filaDetalle["Unidad"] = detalle.Articulo.Unidad;
                    filaDetalle["CantidadMinimo"] = detalle.CantidadMinimo??0;
                    filaDetalle["CantidadMaximo"] = detalle.CantidadMaximo;
                    filaDetalle["Precio"] = detalle.Precio;
                    filaDetalle["Observaciones"] = detalle.Observaciones;
                    cotizacionDs.Tables["CotizacionDetalle"].Rows.Add(filaDetalle);
                }
            }

            cotizacionDs.Tables["Cotizacion"].AcceptChanges();

            if (cotizacion.Anexo.TipoContrato == Contrato.ABIERTO)
            {
                ReporteCotizacionAbierto1.SetDataSource(cotizacionDs);
                crystalReportViewer.ReportSource = ReporteCotizacionAbierto1;
            }
            else if (cotizacion.Anexo.TipoContrato == Contrato.CERRADO)
            {
                ReporteCotizacionCerrado1.SetDataSource(cotizacionDs);
                crystalReportViewer.ReportSource = ReporteCotizacionCerrado1;
            }
            
            crystalReportViewer.Refresh();

            Text = @"ReporteCotizacion";
        }
        
        private void AsignarProveedores(IList<CotizacionDetalle> cotizacionesDetalle)
        {

            var cuantos = 0;
            var count = 0;
            var precioGanador = cotizacionesDetalle[0].Precio;//Ganador Centinela

            foreach (var detalle in cotizacionesDetalle)
            {
                var precio = detalle.Precio;

                if (count == 0)
                {
                    detalle.Ganador = true;
                    ++cuantos;
                }
                else
                {
                    if (precioGanador == precio) {
                        detalle.Ganador = true;
                        ++cuantos;
                    }
                    else
                    {
                        detalle.Ganador = false;
                    }
                }

                ++count;
            }


            foreach (var detalle in cotizacionesDetalle)
            {
                if (detalle.Ganador){
                    detalle.Porcentaje = (decimal)(100/cuantos);
                }
            }

        }
        
        private void ReporteTabla(Anexo anexo)
        {
            anexo = AnexoService.AnexoDao.
                     ConsultaAnexo(anexo.NumeroAnexo, anexo.Almacen);

            var anexoDs = new AnexoDS();

            decimal? totalAsignadoMin = 0, totalAsignadoMax = 0;
            int renglonesDesiertos = 0;

            foreach (var detalle in anexo.AnexoDetalle)
            {
                var filaDetalle = anexoDs.Tables["AnexoDetalleTabla"].NewRow();

                filaDetalle["Anexo"] = detalle.Anexo;
                filaDetalle["Presupuesto"] = detalle.Anexo.TechoPresupuestal;
                filaDetalle["AsignadoConIvaEtiquetaMin"] = "ASIGNADO MIN CON " 
                    + detalle.Anexo.Iva.Id.Porcentaje + " % DE IVA:";

                if (anexo.TipoContrato == Contrato.ABIERTO){
                    filaDetalle["AsignadoConIvaEtiquetaMax"] = "ASIGNADO MAX CON "
                    + detalle.Anexo.Iva.Id.Porcentaje + " % DE IVA:";
                }
                else if (anexo.TipoContrato == Contrato.CERRADO) {
                    filaDetalle["AsignadoConIvaEtiquetaMax"] = "ASIGNADO CON "
                    + detalle.Anexo.Iva.Id.Porcentaje + " % DE IVA:";
                }

                var renglonesLicitados = anexo.AnexoDetalle.Max(d => d.RenglonAnexo);
                filaDetalle["RenglonesLicitados"] = renglonesLicitados;


                filaDetalle["ClaveArticulo"] = detalle.Articulo.Id.CveArt;

                var articulo = detalle.Articulo;
                filaDetalle["Renglon"] = detalle.RenglonAnexo;
                filaDetalle["Descripcion"] = articulo.Id.CveArt + " / " + articulo.DesArticulo;
                filaDetalle["Unidad"] = articulo.Unidad;
                filaDetalle["Presentacion"] = articulo.Presentacion;

                filaDetalle["CantidadMaximo"] = detalle.CantidadMaximo;
                filaDetalle["CantidadMinimo"] = detalle.CantidadMinimo??0;

                var cotizacionDetalles = CotizacionService.CotizacionDao.
                    CargarCotizacionDetalle(anexo, detalle.Articulo, anexo.Almacen);

                if (cotizacionDetalles.Count > 0)
                {
                    AsignarProveedores(cotizacionDetalles);

                    var count = 0;

                    foreach (var subdetalle in cotizacionDetalles)
                    {
                        if (count == 0)
                        {
                            totalAsignadoMin += subdetalle.Precio*detalle.CantidadMinimo??0;
                            totalAsignadoMax += subdetalle.Precio * detalle.CantidadMaximo;
                        }

                        var asterisco = subdetalle.Ganador ? "* " : "";
                        var filaSubDetalle = anexoDs.Tables["Proveedor"].NewRow();
                        filaSubDetalle["ClaveArticulo"] = subdetalle.Articulo.Id.CveArt;
                        filaSubDetalle["Descripcion"] = asterisco + subdetalle.Cotizacion.Proveedor.NombreFiscal;
                        filaSubDetalle["Precio"] = subdetalle.Precio;
                        filaSubDetalle["TotalMax"] = subdetalle.Precio*detalle.CantidadMaximo;
                        filaSubDetalle["TotalMin"] = subdetalle.Precio*detalle.CantidadMinimo??0;
                        filaSubDetalle["Marca"] = subdetalle.Marca;
                        filaSubDetalle["Porcentaje"] = subdetalle.Porcentaje;
                        filaSubDetalle["Observaciones"] = subdetalle.Observaciones;
                        anexoDs.Tables["Proveedor"].Rows.Add(filaSubDetalle);

                        ++count;
                    }
                }
                else
                {
                    var filaSubDetalle = anexoDs.Tables["Proveedor"].NewRow();
                    filaSubDetalle["ClaveArticulo"] = detalle.Articulo.Id.CveArt;
                    filaSubDetalle["Descripcion"] = "<<<<< D E S I E R T O >>>>>";
                    anexoDs.Tables["Proveedor"].Rows.Add(filaSubDetalle);
                    ++renglonesDesiertos;
                }


                filaDetalle["RenglonesDesiertos"] = renglonesDesiertos;
                var renglonesAdjudicados = renglonesLicitados - renglonesDesiertos;
                filaDetalle["RenglonesAdjudicados"] = renglonesAdjudicados;

                var asignadoConIvaMin = (totalAsignadoMin * detalle.Anexo.Iva.Id.Porcentaje/100) 
                            + totalAsignadoMin;
                var asignadoConIvaMax = (totalAsignadoMax * detalle.Anexo.Iva.Id.Porcentaje / 100)
                            + totalAsignadoMax;

                filaDetalle["AsignadoConIvaMin"] = asignadoConIvaMin;
                filaDetalle["AsignadoConIvaMax"] = asignadoConIvaMax;

                var diferenciaMin = detalle.Anexo.TechoPresupuestal - asignadoConIvaMin;
                var diferenciaMax = detalle.Anexo.TechoPresupuestal - asignadoConIvaMax;

                filaDetalle["DiferenciaMin"] = diferenciaMin;
                filaDetalle["DiferenciaMax"] = diferenciaMax;

                anexoDs.Tables["AnexoDetalleTabla"].Rows.Add(filaDetalle);
            }


            anexoDs.Tables["Proveedor"].AcceptChanges();
            anexoDs.Tables["AnexoDetalle"].AcceptChanges();

            if (anexo.TipoContrato == Contrato.ABIERTO){
                ReporteTablaAbierto1.SetDataSource(anexoDs);
                crystalReportViewer.ReportSource = ReporteTablaAbierto1;
            }
            else if (anexo.TipoContrato == Contrato.CERRADO){
                ReporteTablaCerrado1.SetDataSource(anexoDs);
                crystalReportViewer.ReportSource = ReporteTablaCerrado1;
            }

            crystalReportViewer.Refresh();
            Text = @"ReporteTablaComparativa";

        }

        /// <summary>
        /// Reporte Final de la adjudicacion por proveedor
        /// </summary>
        /// <param name="fallo"></param>
        private void ReporteFallo(Fallo fallo)
        {
            var listaFalloRep = new List<FalloRep>();
            
            var fallosConsulta  = FalloService.ConsultarFallo(fallo.Anexo);

            foreach (var falloConsulta in fallosConsulta) {
                
                var falloRep = new FalloRep{
                    FechaFallo = falloConsulta.FechaFallo.Value,
                    TipoLicitacion = "LICITACION PUBLICA " + fallo.Anexo.TipoLicitacion + " O INVITACION RESTRINGIDA",
                    Anexo = fallo.Anexo.ToString(),
                    Proveedor = falloConsulta.Proveedor.NombreFiscal
                };

                falloConsulta.FalloDetalle = FalloService.FalloDao.
                    ConsultarFalloDetalle(falloConsulta);

                foreach (var falloDetalleConsulta in falloConsulta.FalloDetalle) {
                    falloRep.Renglones += falloDetalleConsulta.RenglonAnexo + ",";
                    falloRep.TotalAdjudicado += falloDetalleConsulta.CantidadMin.Value
                        *falloDetalleConsulta.PrecioFallo.Value;
                }

                //Quitar la utima coma
                falloRep.Renglones = falloRep.Renglones.Substring(0, falloRep.Renglones.Length - 1);
                listaFalloRep.Add(falloRep);
            }

            ReporteFallo1.SetDataSource(listaFalloRep);
            crystalReportViewer.ReportSource = ReporteFallo1;
            crystalReportViewer.Refresh();

            Text = @"ReporteFallo";
        }
        
        private void ReportePedido(Pedido pedido)
        {

            pedido = PedidoService.
            ConsultarPedido(pedido.NumeroPedido.Value, pedido.FechaPedido.Value,
            pedido.Almacen, pedido.CatTipopedido.IdTipoped);

            var reporte = new ReportePedido(pedido);
            reporte.GenerarReporteCompleto();
            crystalReportViewer.ReportSource = null;
            crystalReportViewer.Refresh();Text = @"ReportePedido";
        }

        private void ReportePedidoConcentrado(List<Pedido> pedidos)
        {
            var listaPedidoConcentrado = new List<PedidoConcentrado>();

            foreach (var pedido in pedidos) {
                
                //decimal iva = pedido.ImporteTotal.Value *(pedido.Iva.Id.Porcentaje/(decimal)100.0);
                //decimal total = pedido.ImporteTotal.Value- pedido.ImporteDescuento.Value + iva; 

                var pedidoConcentrado = new PedidoConcentrado {
                    NumeroPedido = pedido.NumeroPedido.Value,
                    FechaPedido = String.Format("{0:dd/MM/yyyy}", pedido.FechaPedido),
                    NumeroRequisicion = pedido.NumeroRequisicion,
                    PartidaArticulo = pedido.PartidaString,
                    Proveedor = pedido.Proveedor.NombreFiscal,
                    Elaboro = pedido.Usuario.Nombre,
                    Importe = pedido.ImporteTotal.Value,
                    Descuento = pedido.ImporteDescuento.Value,
                    Iva = pedido.IvaCantidad,
                    Total = pedido.Total,
                    TipoPedido = pedido.CatTipopedido.DesTipoped
                };

                listaPedidoConcentrado.Add(pedidoConcentrado);
            }

            ReportePedidoConcentrado1.SetDataSource(listaPedidoConcentrado);
            crystalReportViewer.ReportSource = ReportePedidoConcentrado1;
            crystalReportViewer.Refresh();

            Text = @"ReportePedidoConcentrado";

        }

        private void ReportePedidoDetallado(List<Pedido> pedidos)
        {
            var listaPedidoDetallado = new List<PedidoDetallado>();

            foreach (var pedido in pedidos) {
                pedido.PedidoDetalle = PedidoService.PedidoDao.CargarPedidoDetalle(pedido);

                var index = 0;
                foreach (var pedidoDetalle in pedido.PedidoDetalle)
                {
                    var importe = pedidoDetalle.Cantidad.Value*pedidoDetalle.PrecioUnitario.Value;

                    var pedidoDetallado= new PedidoDetallado
                    {
                        NumeroPedido = pedido.NumeroPedido.Value,
                        FechaPedido = String.Format("{0:dd/MM/yyyy}", pedido.FechaPedido),
                        NumeroRequisicion = pedido.NumeroRequisicion,
                        Proveedor = pedido.Proveedor.NombreFiscal,
                        DescripcionArticulo = pedidoDetalle.Articulo.ToString(),
                        UnidadArticulo  = pedidoDetalle.Articulo.Unidad,
                        PartidaArticulo = pedido.PartidaString,
                        Cantidad = pedidoDetalle.Cantidad.Value,
                        PrecioUnitario = pedidoDetalle.PrecioUnitario.Value,
                        Importe = importe,
                        Descuento = pedido.ImporteDescuento.Value ,
                        Iva = (decimal)(pedido.Iva.Id.Porcentaje/100.0),
                        TipoPedido = pedido.CatTipopedido.DesTipoped
                    };

                    listaPedidoDetallado.Add(pedidoDetallado);
                    index++;
                }
            }

            ReportePedidoDetallado1.SetDataSource(listaPedidoDetallado);
            crystalReportViewer.ReportSource = ReportePedidoDetallado1;
            crystalReportViewer.Refresh();

            Text = @"ReportePedidoDetallado";
            
        }
        
        private void ReportePedidoEntrada(List<Pedido> pedidos)
        {
             var listaPedidoEntrada = new List<PedidoEntrada>();

             foreach (var pedido in pedidos)
             {
                var entradas = PedidoService.PedidoDao.CargarEntradas(pedido);

                decimal total = pedido.Total;

                if (entradas.Count > 0)
                {

                    foreach (var entrada in entradas)
                    {
                        var pedidoEntrada = new PedidoEntrada
                        {
                            NumeroPedido = pedido.NumeroPedido.Value,
                            FechaPedido = String.Format("{0:dd/MM/yyyy}", pedido.FechaPedido),
                            Proveedor = pedido.Proveedor.NombreFiscal,
                            Total = total,
                            NumeroEntrada = entrada.NumeroEntrada.Value,
                            Factura = entrada.NumeroFactura,
                            FechaEntrada = String.Format("{0:dd/MM/yyyy}", entrada.FechaEntrada),
                            ImporteEntrada =PedidoService.PedidoDao.ImporteEntrada(entrada),
                            TipoPedido = pedido.CatTipopedido.DesTipoped
                        };

                        listaPedidoEntrada.Add(pedidoEntrada);
                    }
                }
                else
                {
                    var pedidoEntrada = new PedidoEntrada
                    {
                        NumeroPedido = pedido.NumeroPedido.Value,
                        FechaPedido = String.Format("{0:dd/MM/yyyy}", pedido.FechaPedido),
                        Proveedor = pedido.Proveedor.NombreFiscal,
                        Total = total,
                        NumeroEntrada = 0,
                        Factura = "",
                        FechaEntrada = "",
                        ImporteEntrada =  (decimal)0.00,
                        TipoPedido = pedido.CatTipopedido.DesTipoped
                    };

                    listaPedidoEntrada.Add(pedidoEntrada);
                    
                }

             }

             ReportePedidoEntrada1.SetDataSource(listaPedidoEntrada);
             crystalReportViewer.ReportSource = ReportePedidoEntrada1;
             crystalReportViewer.Refresh();

             Text = @"ReportePedidoEntrada";

        }
       
        public void ReporteEntradaPedido(DateTime fechaInicial, DateTime fechaFinal,
            CatTipopedido tipopedido, Ordenado ordenado)
        {
            var listaPedidoEntrada = new List<PedidoEntrada>();

            var entradas = PedidoService.PedidoDao.CargarEntradas(fechaInicial, fechaFinal);

            foreach(var entrada in entradas)
            {
                var pedidos = PedidoService.PedidoDao.CargarPedidos(entrada,tipopedido,ordenado);

                if (pedidos.Count > 0)
                {
                    foreach (var pedido in pedidos)
                    {
                        decimal total = pedido.Total;

                        var pedidoEntrada = new PedidoEntrada
                        {
                            NumeroPedido = pedido.NumeroPedido.Value,
                            FechaPedido = String.Format("{0:dd/MM/yyyy}", pedido.FechaPedido),
                            Proveedor = pedido.Proveedor.NombreFiscal,
                            Total = total,
                            NumeroEntrada = entrada.NumeroEntrada.Value,
                            Factura = entrada.NumeroFactura,
                            FechaEntrada = String.Format("{0:dd/MM/yyyy}", entrada.FechaEntrada),
                            ImporteEntrada =PedidoService.PedidoDao.ImporteEntrada(entrada),
                            TipoPedido = pedido.CatTipopedido.DesTipoped
                        };

                        listaPedidoEntrada.Add(pedidoEntrada);

                    }
                    
                }
            }

            ReportePedidoEntrada1.SetDataSource(listaPedidoEntrada);
            crystalReportViewer.ReportSource = ReportePedidoEntrada1;
            crystalReportViewer.Refresh();

            Text = @"ReporteEntradaPedido";


        }
    
        public void ReporteProveedor(List<Proveedor> provs)
        {
            ReporteProveedor1.SetDataSource(provs);
            crystalReportViewer.ReportSource = ReporteProveedor1;
            crystalReportViewer.Refresh();

            Text = @"ReporteProveedor";
            
        }

        public void ReporteFundamento(List<Fundamento> funds)
        {
            ReporteFundamento1.SetDataSource(funds);
            crystalReportViewer.ReportSource = ReporteFundamento1;
            crystalReportViewer.Refresh();

            Text = @"ReporteFundamento";

        }
        
        private void CargarPedidoCompleto(Pedido pedido, 
            ref List<PedidoCompleto> lista, Entrada entrada = null)
        {
            var descripcionGasto = PedidoService.PedidoDao.PedidoOneDetalleDescripcion(pedido);

            var importePedido = pedido.Total;
            var importeSinIva = pedido.ImporteTotal.Value;

            var pedidoFound = lista.Find(p => p.Pedido == pedido.NumeroPedido);

            if (pedidoFound != null){
                importePedido = (decimal) 0.0;
                importeSinIva = (decimal) 0.0;
            }

            
            var totalFactura = entrada != null ? PedidoService.PedidoDao.ImporteEntrada(entrada) : (decimal) 0.0;
            var importeSinIVAEntrada = entrada != null ? PedidoService.PedidoDao.ImporteEntradaSinIva(entrada) : (decimal)0.0;

            var fundamentoProcedimiento = "";

            if (pedido.Fundamento != null)
                fundamentoProcedimiento = pedido.Fundamento.DesFundamento;

            if (pedido.TipoProcedimiento != null)
                fundamentoProcedimiento = pedido.TipoProcedimiento.ToString();

            var pedidoCompleto = new PedidoCompleto
            {
                Estado = pedido.EstadoPedido,
                Pedido = pedido.NumeroPedido.Value,
                FechaPedido = pedido.FechaPedido.Value,
                Factura = entrada != null?entrada.NumeroFactura:"",
                Entrada = entrada!=null?entrada.NumeroEntrada.Value.ToString():"",
                Almacen = pedido.AlmacenDestino,
                FechaEntrada = entrada!=null?String.Format("{0:dd/MM/yyyy}", entrada.FechaEntrada.Value):"",
                TotalFactura = totalFactura,
                ImporteSinIVAEntrada = importeSinIVAEntrada,
                Proveedor = pedido.Proveedor.NombreFiscal,
                RFCProveedor = pedido.Proveedor.Rfc,
                AreaSolicitada = pedido.CatArea.DesArea,
                Partida = pedido.PartidaString,
                DescripcionGasto = descripcionGasto,
                ImporteSinIVA = importeSinIva,
                Req = pedido.NumeroRequisicion,
                Elaboro = pedido.Usuario.Nombre,
                Licitacion = "",
                Procedimiento = fundamentoProcedimiento,
                ImportePedido = importePedido,
                TipoPedido = pedido.CatTipopedido.DesTipoped
            };

            lista.Add(pedidoCompleto);

        }
        
        /// <summary>
        /// Reporte genrado con los pedidos de la busqueda de pedidos 
        /// falta poner el rango de fecha puesto en la ventana display
        /// </summary>
        /// <param name="pedidos"></param>
        /// <param name="entradaPedido"></param>
        public void ReportePedidoEntradaCompleto(List<Pedido> pedidos, EntradaPedido entradaPedido)
        {
            var listaPedidoCompleto = new List<PedidoCompleto>();

            foreach (var pedido in pedidos)
            {
                var entradas = PedidoService.PedidoDao.CargarEntradas(pedido);
                switch (entradaPedido) {
                    case EntradaPedido.Ambos:
                        if (entradas.Count > 0) {
                            foreach (var entrada in entradas) {
                                CargarPedidoCompleto(pedido, ref listaPedidoCompleto, entrada: entrada);
                            }
                        }
                        else {
                            CargarPedidoCompleto(pedido, ref listaPedidoCompleto, null);
                        }

                        break;

                    case EntradaPedido.ConEntrada:
                        if (entradas.Count > 0) {
                            foreach (var entrada in entradas) {
                                CargarPedidoCompleto(pedido, ref listaPedidoCompleto, entrada: entrada);
                            }
                        }

                        break;

                    case EntradaPedido.SinEntrada:
                        if (entradas.Count == 0) {
                            CargarPedidoCompleto(pedido, ref listaPedidoCompleto, null);
                        }
                        break;
                }
            }

            ReportePedidoCompleto1.SetDataSource(listaPedidoCompleto);
            crystalReportViewer.ReportSource = ReportePedidoCompleto1;
            crystalReportViewer.Refresh();

            Text = @"ReportePedidoEntradaCompleto";
            
        }

        public void ReporteEntradaPedidoCompleto(DateTime fechaInicial, DateTime fechaFinal,
            CatTipopedido tipopedido, Ordenado ordenado)
        {
            var listaPedidoCompleto = new List<PedidoCompleto>();

            var entradas = PedidoService.PedidoDao.CargarEntradas(fechaInicial, fechaFinal);

            foreach (var entrada in entradas)
            {
                var pedidos = PedidoService.PedidoDao.CargarPedidos(entrada, tipopedido, ordenado);

                if (pedidos.Count > 0) {
                    foreach (var pedido in pedidos)
                    {
                        try{
                            var partidaAlmacen = PedidoService.PedidoDao.CargarPartidaAlmacen(pedido);
                            pedido.AlmacenDestino = partidaAlmacen[0];
                            pedido.PartidaString = partidaAlmacen[1];
                        }
                        catch (Exception ex){}

                        CargarPedidoCompleto(pedido, ref listaPedidoCompleto, entrada: entrada);
                    }
                }
            }

            ReportePedidoCompleto1.SetDataSource(listaPedidoCompleto);
            crystalReportViewer.ReportSource = ReportePedidoCompleto1;
            crystalReportViewer.Refresh();

            Text = @"ReporteEntradaPedidoCompleto";
            
        }
        
        private void ReporteListadoPedido(List<Pedido> pedidos)
        {
            var listaPedidoConcentrado = new List<PedidoConcentrado>();

            foreach (var pedido in pedidos){

                var pedidoConcentrado = new PedidoConcentrado {
                    NumeroPedido = pedido.NumeroPedido.Value,
                    FechaPedido = String.Format("{0:dd/MM/yyyy}", pedido.FechaPedido),
                    CveProveedor = pedido.Proveedor.CveProveedor,
                    Proveedor = pedido.Proveedor.NombreFiscal,
                    Estado = pedido.EstadoPedido,
                    Elaboro = pedido.Usuario.Nombre,
                    TipoPedido = pedido.CatTipopedido.DesTipoped
                };

                listaPedidoConcentrado.Add(pedidoConcentrado);
            }

            ReporteListaPedido1.SetDataSource(listaPedidoConcentrado);
            crystalReportViewer.ReportSource =ReporteListaPedido1;
            crystalReportViewer.Refresh();

            Text = @"ReporteListaPedido";
            
        }

        private void ReportePedidoSaldo(List<Pedido> pedidos)
        {
             var listaPedidoSaldo = new List<PedidoSaldo>();

            foreach (var pedido in pedidos) {
                var pedidoSaldo = new PedidoSaldo{
                    Partida = pedido.PartidaString,
                    NumeroPedido = pedido.NumeroPedido.Value,
                    FechaPedido = pedido.FechaPedido.Value,
                    NumeroReq = pedido.NumeroRequisicion,
                    Proveedor = pedido.Proveedor.NombreFiscal,
                    ImporteTotalPedido = pedido.Total,
                    ImporteTotalEntrada = PedidoService.PedidoDao.ImporteEntradas(pedido),
                    TipoPedido = pedido.CatTipopedido.ToString()
                };

                listaPedidoSaldo.Add(pedidoSaldo);
            }

            ReportePedidoSaldo1.SetDataSource(listaPedidoSaldo);
            crystalReportViewer.ReportSource = ReportePedidoSaldo1;
            crystalReportViewer.Refresh();

            Text = @"ReportePedidoSaldo";



        }


    }
}
