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
                case "reporteEntradaPedido":
                    break;
            }
        }


        private void FrmReportesLoad(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
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
                    Proveedor = pedido.Proveedor.NombreFiscal,
                    Elaboro = pedido.Usuario.Nombre,
                    Importe = pedido.ImporteTotal.Value,
                    Descuento = pedido.ImporteDescuento.Value,
                    Iva = pedido.IvaCantidad,
                    Total = pedido.Total
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
                    var partida = new CatPartida();

                    if (index == 0)
                    {
                        var oneDetalle = pedido.PedidoDetalle[0];
                        partida = PedidoService.AnexoService.ArticuloDao.GetPartida(oneDetalle.Articulo);
                    }

                    var pedidoDetallado= new PedidoDetallado
                    {
                        NumeroPedido = pedido.NumeroPedido.Value,
                        FechaPedido = String.Format("{0:dd/MM/yyyy}", pedido.FechaPedido),
                        NumeroRequisicion = pedido.NumeroRequisicion,
                        Proveedor = pedido.Proveedor.NombreFiscal,
                        DescripcionArticulo = pedidoDetalle.Articulo.DesArticulo,
                        UnidadArticulo  = pedidoDetalle.Articulo.Unidad,
                        PartidaArticulo = partida.ToString(),
                        Cantidad = pedidoDetalle.Cantidad.Value,
                        PrecioUnitario = pedidoDetalle.PrecioUnitario.Value,
                        Importe = importe,
                        Descuento = pedido.ImporteDescuento.Value ,
                        Iva = (decimal)(pedido.Iva.Id.Porcentaje/100.0)
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
                            ImporteEntrada =
                                PedidoService.PedidoDao.ImporteEntrada(entrada)
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
                        ImporteEntrada =  (decimal)0.00
                    };

                    listaPedidoEntrada.Add(pedidoEntrada);
                    
                }

             }

             ReportePedidoEntrada1.SetDataSource(listaPedidoEntrada);
             crystalReportViewer.ReportSource = ReportePedidoEntrada1;
             crystalReportViewer.Refresh();

             Text = @"ReportePedidoEntrada";

        }
       

        public void ReporteEntradaPedido(DateTime fechaInicial, DateTime fechaFinal,CatTipopedido tipopedido, Ordenado ordenado)
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
                            ImporteEntrada =PedidoService.PedidoDao.ImporteEntrada(entrada)
                        };

                        listaPedidoEntrada.Add(pedidoEntrada);

                    }
                    
                }
                else
                {
                    var pedidoEntrada = new PedidoEntrada
                    {
                        NumeroPedido = 0,
                        FechaPedido = "",
                        Proveedor = "",
                        Total = (decimal)0.0,
                        NumeroEntrada = entrada.NumeroEntrada.Value,
                        Factura = entrada.NumeroFactura,
                        FechaEntrada = String.Format("{0:dd/MM/yyyy}", entrada.FechaEntrada),
                        ImporteEntrada = (decimal)0.00
                    };

                    listaPedidoEntrada.Add(pedidoEntrada);
                    
                }

            }

            ReportePedidoEntrada1.SetDataSource(listaPedidoEntrada);
            crystalReportViewer.ReportSource = ReportePedidoEntrada1;
            crystalReportViewer.Refresh();

            Text = @"ReporteEntradaPedido";


        }
    }
}
