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
using Adquisiciones.Data.Entities;
using Adquisiciones.View.DataSets;
using Adquisiciones.View.Reportes;
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
            }
        }


        private void FrmReportesLoad(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        private void ReporteAnexo(Anexo anexo)
        {
           
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
                filaDetalle["Unidad"] = detalle.Articulo.CatUnidad.Unidad;
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
                    filaDetalle["Unidad"] = detalle.Articulo.CatUnidad.Unidad;
                    filaDetalle["Marca"] = detalle.Marca;
                    filaDetalle["Unidad"] = detalle.Articulo.CatUnidad.Unidad;
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
                filaDetalle["Unidad"] = articulo.CatUnidad.Unidad;
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

       
    }
}
