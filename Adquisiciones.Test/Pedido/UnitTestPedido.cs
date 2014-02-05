using System;
using System.Windows.Forms;
using Adquisiciones.Business;
using Adquisiciones.Business.ModPedido;
using Adquisiciones.Data.Dao.Catalogos;
using Adquisiciones.Data.Dao.ModPedido;
using Adquisiciones.Data.Entities;
using Adquisiciones.View.Reportes;
using NUnit.Framework;

namespace Adquisiciones.Test.Anexo
{
    [TestFixture]
    public class UnitTestPedido:AbstractDaoIntegrationTests
    {
        public IRequisicionDao RequisicionDao { private get; set; }
        public IPedidoDao PedidoDao { private get; set; }
        public IPedidoService PedidoService { private get; set; }
        public IPedidoEntregaDao PedidoEntregaDao { private get; set; }
        public IPedidoDetalleDao PedidoDetalleDao { private get; set; }
        public IArticuloDao ArticuloDao { private get; set; }

        [Test]
        public void TestMaximoNumeroPedido()
        {
            var result = PedidoDao.SiguienteNumeroPedido(new Almacen("P2"), 4);
            Assert.AreEqual(3,result);
        }

        [Test]
        public void ExisteNumeroPedido()
        {
            var result = PedidoDao.ExisteNumeroPedido(new Almacen("P2"),1,2);
            Assert.IsTrue(result);
        }

        [Test]
        public void TestConsultaRequisicion()
        {
            var almacen = new Almacen("C5");
            Assert.AreEqual(2, RequisicionDao.CargarRequisiciones(almacen).Count);
        }

        [Test]
        public void TestGenerarPedidoAutomatico()
        {
            var requisicion = RequisicionDao.Get(1);
            var pedido = new Pedido();
            pedido.CatArea = new CatArea(1);
            pedido.Proveedor = new Proveedor(1);
            pedido.NumeroRequisicion = "11";
            PedidoService.GenerarPedidoAutomatico(pedido,requisicion,new DateTime(),new DateTime() );
        }

        [Test]
        public void TestSumaCantidadEntrada()
        {
            var pedidoDetalle = PedidoDetalleDao.Get(1698);
            PedidoDao.SumaCantidadEntradaArticulo(pedidoDetalle);
            var pedido = new Pedido();
            pedido.NumeroPedido = PedidoService.PedidoDao.SiguienteNumeroPedido(new Almacen("C5"), 1);
            pedido.FechaPedido = PedidoService.PedidoDao.FechaServidor();
            pedido.Almacen = new Almacen("C5");
            pedido.Iva = new Iva(new IvaId(1, 16));
            //pedido.Anexo = new Anexo();
        }

        [Test]
        public void GuardarPedido()
        {
            var pedido = new Pedido();
            pedido.NumeroPedido = PedidoService.PedidoDao.SiguienteNumeroPedido(new Almacen("C5"), 1);
            pedido.FechaPedido = PedidoService.PedidoDao.FechaServidor();
            pedido.Almacen = new Almacen("C5");
            pedido.Iva = new Iva(new IvaId(1,16));
            //pedido.Anexo = new Anexo();
        }

        public void GenerarReportePedido(int numPedido, DateTime fechaPedido, int tipo, string almacen)
        {
            var pedido = PedidoService.ConsultarPedido(numPedido, fechaPedido, new Almacen(almacen), tipo);
            pedido.PedidoDetalle = PedidoService.PedidoDao.CargarPedidoDetalle(pedido);

            foreach (var pedidoDetalle in pedido.PedidoDetalle)
            {
                pedidoDetalle.PedidoEntrega = PedidoService.PedidoDao.
                    CargarPedidoEntrega(pedidoDetalle);
            }

            var reporte = new ReportePedido(pedido);
            reporte.GenerarReporteCompleto();
        }

        [Test]
        public void TestArticulo()
        {
            var articulo = 
                ArticuloDao.ArticuloPartida(2148, new Almacen("F"), new CatPartida("25901"));

            Assert.IsNotNull(articulo);

        }

        [Test]
        public void TestPartida()
        {
            var articulo = new Articulo(new ArticuloId(2148, new Almacen("F")));

            var partida = ArticuloDao.GetPartida( articulo);//, new CatPartida("25901"));
            Assert.AreEqual("25901", partida.Partida);
        }

        [Test]
        public  void GenerarReportePedidoMayor()
        {
            GenerarReportePedido(530,DateTime.Now, 1, "P2");
        }

        [Test]
        public void GenerarReportePedidoMenor()
        {
            GenerarReportePedido(317, DateTime.Now, 2, "P2");
        
        }

        [Test]
        public void GenerarReportePedidoDonacion()
        {
            GenerarReportePedido(3, DateTime.Now, 0, "P2");
        }

        [Test]
        public void GenerarReportePedidoExtraMuro()
        {
            GenerarReportePedido(4, DateTime.Now, 0, "P2");
        }
        
        [Test]
        public void TestCatalogoPresupuestal()
        {
            var combo = new ComboBox();
            PedidoService.CatalogoActividad(combo);
        }

        [Test]
        public void TestInsertarPedidoEntrega()
        {
            var pedido = new Pedido();

            pedido.FechaPedido = DateTime.Now;
            pedido.NumeroPedido = 215;
            pedido.CatTipopedido = new CatTipopedido(1);
            pedido.Proveedor = new Proveedor(97);
            pedido.Anexo = new Data.Entities.Anexo(1);
            pedido.Requisicion = new Requisicion(1);
            pedido.Fundamento = new Fundamento(1);
            pedido.IdReservaautoriza = null;
            pedido.CatArea = new CatArea(1100);
            pedido.ImporteDescuento = 100;
            pedido.Iva = new Iva(new IvaId(1,16));
            pedido.CatActividad = new CatActividad(1);
            pedido.CatPresupuesto = new CatPresupuesto(1);
            pedido.EstadoPedido = "A";
            pedido.ImporteTotal = 100;
            pedido.Observaciones = "aaaa";
            pedido.Usuario = new Usuario(4192);
            pedido.Almacen = new Almacen("C5");
            pedido.FechaModificacion = DateTime.Now;
            pedido.IpTerminal = "aaa";
            pedido.Modificacion = 1;
            pedido.Instituto = "eee";
            pedido.NumeroRequisicion = "zzzz";
            
            var pedidoDetalle = new PedidoDetalle();
            pedidoDetalle.Pedido = pedido;
            pedidoDetalle.RenglonPedido = 3;
            pedidoDetalle.Articulo = new Articulo(new ArticuloId(2,new Almacen("F")));
            pedidoDetalle.Marca = "dionisio";
            pedidoDetalle.Cantidad = 1562;
            pedidoDetalle.PrecioUnitario = 1;
            pedido.PedidoDetalle.Add(pedidoDetalle);

            var pedidoEntrega = new PedidoEntrega();
            pedidoEntrega.PedidoDetalle = pedidoDetalle;
            pedidoEntrega.Entrega = 15;
            pedidoEntrega.FechaInicial = DateTime.Now;
            pedidoEntrega.FechaFinal = DateTime.Now;
            pedidoEntrega.Cantidad = 15;
            pedidoDetalle.PedidoEntrega.Add(pedidoEntrega);

            PedidoDao.Merge(pedido);
        }

        [Test]
        public void TestConsultarPedido()
        {
            var pedido  = PedidoService.ConsultarPedido(1,DateTime.Now, new Almacen("C5"), 0);
            Assert.NotNull(pedido);
        }

        [Test]
        public void TestNumalet()
        {
            var result = Numalet.ToCardinal(1001.12);
            Assert.AreEqual(result, "");
        }

        [SetUp]
        public void SetUp()
        {
            //base.SetComplete();
        }

        [TearDown]
        public void TearDown()
        {  
        }
    }
}
