using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Business.ModAnexo;
using Adquisiciones.Business.ModCotizacion;
using Adquisiciones.Business.ModFallo;
using Adquisiciones.Business.ModPedido;
using Adquisiciones.Data.Dao.ModPedido;
using Adquisiciones.Data.Entities;
using Adquisiciones.View.DataSets;
using Adquisiciones.View.Reportes;
using Adquisiciones.View.Reportes.Clases;
using DevExpress.XtraEditors;
using Spring.Context.Support;
using Spring.Objects.Factory;
using Form = Spring.Windows.Forms.Form;

namespace Adquisiciones.View
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
                /*case "reportePedidoEntradaCompleto":
                    ReportePedidoEntradaCompleto(Entity as List<Pedido>);
                    break;*/
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
                filaDetalle["Articulo"] = detalle.Articulo.Id.CveArt;
                filaDetalle["Descripcion"] = detalle.Articulo.DesArticulo;
                filaDetalle["Unidad"] = detalle.Articulo.Unidad;
                filaDetalle["CantidadMinimo"] = detalle.CantidadMinimo;
                filaDetalle["CantidadMaximo"] = detalle.CantidadMaximo;
                anexoDs.Tables["AnexoDetalle"].Rows.Add(filaDetalle);
            }

            anexoDs.Tables["AnexoDetalle"].AcceptChanges();
            ReporteAnexo1.SetDataSource(anexoDs);
            crystalReportViewer.ReportSource = ReporteAnexo1;
            crystalReportViewer.Refresh();

            Text = @"ReporteAnexo::" + anexo;
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
                    filaDetalle["Articulo"] = detalle.Articulo.Id.CveArt;
                    filaDetalle["Descripcion"] = detalle.Articulo.DesArticulo;
                    filaDetalle["Unidad"] = detalle.Articulo.Unidad;
                    filaDetalle["Marca"] = detalle.Marca;
                    filaDetalle["Unidad"] = detalle.Articulo.Unidad;
                    filaDetalle["Cantidad"] = detalle.Cantidad;
                    filaDetalle["Precio"] = detalle.Precio;
                    filaDetalle["Importe"] = detalle.Cantidad*detalle.Precio;
                    filaDetalle["Observaciones"] = detalle.Observaciones;
                    cotizacionDs.Tables["CotizacionDetalle"].Rows.Add(filaDetalle);
                }
            }

            cotizacionDs.Tables["Cotizacion"].AcceptChanges();
            ReporteCotizacion1.SetDataSource(cotizacionDs);
            crystalReportViewer.ReportSource = ReporteCotizacion1;
            crystalReportViewer.Refresh();

            Text = @"ReporteCotizacion::" + cotizacion;
        }

        private void ReporteFallo(Fallo fallo)
        {

            var anexo = fallo.Anexo;
            anexo = FalloService.AnexoDao.
                     ConsultaAnexo(anexo.NumeroAnexo, anexo.Almacen);

            var falloDs = new FalloDS();

            foreach (var detalle in anexo.AnexoDetalle)
            {
                var filaDetalle = falloDs.Tables["AnexoDetalle"].NewRow();

                filaDetalle["Anexo"] = detalle.Anexo;
                filaDetalle["Fecha"] = String.Format("{0:dd/MM/yyyy}",fallo.FechaFallo);
                filaDetalle["ClaveArticulo"] = detalle.Articulo.Id.CveArt;

                var articulo = detalle.Articulo;
                //FalloService.ArticuloDao.Get(new ArticuloId(detalle.Articulo.Id.CveArt, anexo.Almacen));

                filaDetalle["Renglon"] = detalle.RenglonAnexo;
                filaDetalle["Descripcion"] = articulo.Id.CveArt + " / " + articulo.DesArticulo;
                filaDetalle["Unidad"] = articulo.Unidad;
                filaDetalle["Presentacion"] = articulo.Presentacion;
                filaDetalle["Cantidad"] = detalle.CantidadMinimo;
                falloDs.Tables["AnexoDetalle"].Rows.Add(filaDetalle);

                var cotizacionDetalles =
                    FalloService.CotizacionDao.CargarCotizacionDetalle(anexo, detalle.Articulo, anexo.Almacen);

                var count = 0;

                foreach (var subdetalle in cotizacionDetalles)
                {
                    string asterisk = count == 0 ? "* " : "";
                    var filaSubDetalle = falloDs.Tables["Proveedor"].NewRow();
                    filaSubDetalle["ClaveArticulo"] = subdetalle.Articulo.Id.CveArt;
                    filaSubDetalle["Descripcion"] = asterisk + subdetalle.Cotizacion.Proveedor.NombreFiscal;
                    filaSubDetalle["Precio"] = subdetalle.Precio;
                    filaSubDetalle["Total"] = subdetalle.Precio * detalle.CantidadMinimo;
                    filaSubDetalle["Marca"] = subdetalle.Marca;
                    filaSubDetalle["Porcentaje"] = DBNull.Value;
                    filaSubDetalle["Observaciones"] = subdetalle.Observaciones;
                    falloDs.Tables["Proveedor"].Rows.Add(filaSubDetalle);
                    ++count;
                }
            }

            falloDs.Tables["Proveedor"].AcceptChanges();
            falloDs.Tables["AnexoDetalle"].AcceptChanges();
            ReporteFallo1.SetDataSource(falloDs);
            crystalReportViewer.ReportSource = ReporteFallo1;
            crystalReportViewer.Refresh();
            Text = @"ReporteTabla::" + anexo;

        }

        private void ReportePedido(Pedido pedido)
        {
            pedido.PedidoDetalle = 
                PedidoService.PedidoDao.CargarPedidoDetalle(pedido);

            foreach (var pedidoDetalle in pedido.PedidoDetalle)
            {
                pedidoDetalle.PedidoEntrega = PedidoService.PedidoDao.CargarPedidoEntrega(pedidoDetalle);
            }

            var reporte = new ReportePedido(pedido);
            reporte.GenerarReporteCompleto();
            crystalReportViewer.ReportSource = null;
            crystalReportViewer.Refresh();Text = @"ReportePedido::" + pedido;
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
        
        private PedidoCompleto CargarPedidoCompleto(Pedido pedido, Entrada entrada = null)
        {
            var descripcionGasto = PedidoService.PedidoDao.PedidoOneDetalleDescripcion(pedido);

            var pedidoCompleto = new PedidoCompleto
            {
                Estado = pedido.EstadoPedido,
                Pedido = pedido.NumeroPedido.Value,
                FechaPedido = pedido.FechaPedido.Value,
                Factura = entrada != null?entrada.NumeroFactura:"",
                Entrada = entrada!=null?entrada.NumeroEntrada.Value.ToString():"",
                Almacen = pedido.AlmacenDestino,
                FechaEntrada = entrada!=null?String.Format("{0:dd/MM/yyyy}", entrada.FechaEntrada.Value):"",
                TotalFactura = entrada!=null?PedidoService.PedidoDao.ImporteEntrada(entrada):(decimal)0.0,
                Proveedor = pedido.Proveedor.NombreFiscal,
                RFCProveedor = pedido.Proveedor.Rfc,
                AreaSolicitada = pedido.CatArea.DesArea,
                Partida = pedido.PartidaString,
                DescripcionGasto = descripcionGasto,
                ImporteSinIVA = pedido.ImporteTotal.Value,
                Req = pedido.NumeroRequisicion,
                Elaboro = pedido.Usuario.Nombre,
                Licitacion = "",
                Procedimiento = pedido.TipoProcedimiento != null ? pedido.TipoProcedimiento.ToString() : "",
                FundamentoLegal = pedido.Fundamento != null ? pedido.Fundamento.DesFundamento : "",
                ImportePedido = pedido.Total,
                TipoPedido = pedido.CatTipopedido.DesTipoped
            };

            return pedidoCompleto;

        }
        
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
                                listaPedidoCompleto.Add(CargarPedidoCompleto(pedido,entrada));
                            }
                        }
                        else {
                            listaPedidoCompleto.Add(CargarPedidoCompleto(pedido));
                        }

                        break;

                    case EntradaPedido.ConEntrada:
                        if (entradas.Count > 0) {
                            foreach (var entrada in entradas) {
                                listaPedidoCompleto.Add(CargarPedidoCompleto(pedido, entrada));
                            }
                        }

                        break;

                    case EntradaPedido.SinEntrada:
                        if (entradas.Count == 0) {
                            listaPedidoCompleto.Add(CargarPedidoCompleto(pedido));
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

                        listaPedidoCompleto.Add(CargarPedidoCompleto(pedido, entrada));
                    }
                }
            }

            ReportePedidoCompleto1.SetDataSource(listaPedidoCompleto);
            crystalReportViewer.ReportSource = ReportePedidoCompleto1;
            crystalReportViewer.Refresh();

            Text = @"ReporteEntradaPedidoCompleto";
            
        }
    
    }
}
