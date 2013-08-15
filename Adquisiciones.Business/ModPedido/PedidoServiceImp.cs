using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Adquisiciones.Business.Excepciones;
using Adquisiciones.Business.ModAnexo;
using Adquisiciones.Data;
using Adquisiciones.Data.Dao.ModAnexo;
using Adquisiciones.Data.Dao.ModFallo;
using Adquisiciones.Data.Dao.ModPedido;
using Adquisiciones.Data.Entities;
using Spring.Transaction.Interceptor;
using System.Linq;


namespace Adquisiciones.Business.ModPedido
{
    /// <summary>
    /// 
    /// </summary>
    public class PedidoServiceImp : IPedidoService,IFormBusqueda
    {
        public IRequisicionDao RequisicionDao { get; set; }

        public IAnexoDao AnexoDao { get; set; }

        public IFalloDao FalloDao { get; set; }

        public IFalloDetalleDao FalloDetalleDao { get; set; }

        public IAnexoService AnexoService { get; set;}

        public IPedidoDao PedidoDao { get; set; }

        public IPedidoDetalleDao PedidoDetalleDao { get; set; }

        public IPedidoEntregaDao PedidoEntregaDao { get; set; }


        [Transaction(ReadOnly = true)]
        public void CatalogoPresupuestal(ComboBox combo)
        {
            var listaPresupuesto = AnexoDao.CargarCatalogo<CatPresupuesto>("IdPresupuesto");
            var dicc = listaPresupuesto.ToDictionary(presupuesto => presupuesto, presupuesto => presupuesto.DesPresupuesto);
            Util.Dicc2Combo(dicc, combo);
        }

         [Transaction(ReadOnly = true)]
        public void CatalogoActividad(ComboBox combo)
        {
            var listaActividad = AnexoDao.CargarCatalogo<CatActividad>("IdActividad");
            var dicc = listaActividad.ToDictionary(actividad => actividad, actividad => actividad.DesActividad);
            Util.Dicc2Combo(dicc, combo);
        }

        public void CatalogoTipoProcedimiento(ComboBox combo, string bloque, string condicionColumn = null,
            string condicionValor = null)
        {
            try
            {
                var lista = PedidoDao.CatalogoTipoProcedimiento(bloque, condicionColumn, condicionValor);
                var dicc = lista.ToDictionary(proc => proc, proc => proc);
                Util.Dicc2Combo(dicc, combo);
            }
            catch (Exception e)
            {
            }
        }

        /// <summary>
        /// Calcula el importe total 
        /// </summary>
        /// <param name="requisicion"></param>
        /// <param name="falloDetalles"></param>
        /// <param name="iva"></param>
        [Transaction(ReadOnly = true)]
        private decimal? ImporteTotal(Requisicion requisicion, IList<FalloDetalle> falloDetalles)
        {
            decimal? importe = new decimal(0.0);

            foreach(var falloDetalle in falloDetalles)
            {
                var requisicionDetalle = RequisicionDao.
                    ObtenerRequisicionDetalleByArticulo(requisicion,falloDetalle.Articulo);

                if(requisicionDetalle != null)
                    importe += requisicionDetalle.Cantidad * falloDetalle.PrecioFallo;
            }

            //importe -= (importe * (iva/100));

            return importe;

        }

         [Transaction]
        public void GenerarPedidoAutomatico(Pedido pedidoCentinela, 
             Requisicion requisicion, DateTime fechaInicial, DateTime fechaFinal)
         {

             var fallos = FalloDao.FallosByAnexoEager(requisicion.Anexo);

             foreach (var fallo in fallos)
            {
                var pedido = new Pedido();
                pedido.Almacen = pedidoCentinela.Almacen;
                pedido.Usuario = pedidoCentinela.Usuario;
                pedido.IpTerminal = Util.IpTerminal();
                pedido.FechaCaptura = PedidoDao.FechaServidor();
                pedido.FechaModificacion = PedidoDao.FechaServidor();
                pedido.FechaPedido = pedidoCentinela.FechaPedido;
                pedido.Fundamento = pedidoCentinela.Fundamento;
                pedido.CatActividad = pedidoCentinela.CatActividad;
                pedido.Iva = pedidoCentinela.Iva;
                pedido.CatPresupuesto = pedidoCentinela.CatPresupuesto;
                pedido.Observaciones = pedidoCentinela.Observaciones;
                pedido.Modificacion = 1;
                pedido.Instituto = fallo.Anexo.Instituto;
                pedido.NumeroPedido = PedidoDao.SiguienteNumeroPedido(pedido.Almacen, 1);
                pedido.CatTipopedido = new CatTipopedido(1);//Pedido Mayor
                pedido.Proveedor = fallo.Cotizacion.Proveedor;
                pedido.Anexo = fallo.Anexo;
                pedido.CatArea = requisicion.CatArea;
                pedido.ImporteDescuento = new decimal(0.0);
                pedido.CatPresupuesto = pedido.CatPresupuesto;
                pedido.EstadoPedido = "P";
                pedido.ImporteTotal = ImporteTotal(requisicion, fallo.FalloDetalle);
                pedido.Requisicion = requisicion;
                
                pedido = PedidoDao.Merge(pedido);

                short renglonPedido = 1;
                //int entrega = 1;

                var requisicionesDetalle = RequisicionDao.CargarRequisicionDetalle(requisicion);

                foreach (var requisicionDetalle in requisicionesDetalle)
                {
                    foreach (var falloDetalle in fallo.FalloDetalle)
                    {
                        if(requisicionDetalle.Articulo == falloDetalle.Articulo)
                        {
                            //Actualizamos la cantidad pedida fallo
                            falloDetalle.CantidadPed += requisicionDetalle.Cantidad;
                            FalloDetalleDao.Merge(falloDetalle);

                            var pedidoDetalle = new PedidoDetalle();
                            pedidoDetalle.Pedido = pedido;
                            pedidoDetalle.RenglonPedido = renglonPedido;
                            pedidoDetalle.Articulo = falloDetalle.Articulo;
                            pedidoDetalle.Cantidad = requisicionDetalle.Cantidad;
                            pedidoDetalle.PrecioUnitario = falloDetalle.PrecioFallo;
                            //pedidoDetalle.Marca = falloDetalle.

                            var pedidoEntrega = new PedidoEntrega();
                            pedidoEntrega.Entrega = 1;
                            pedidoEntrega.FechaInicial = fechaInicial;
                            pedidoEntrega.FechaFinal = fechaFinal;
                            pedidoEntrega.Cantidad = requisicionDetalle.Cantidad;
                            pedidoEntrega.PedidoDetalle = pedidoDetalle;
                            //++entrega;

                            pedidoDetalle.PedidoEntrega.Add(pedidoEntrega);
                            PedidoDetalleDao.Merge(pedidoDetalle);
                            ++renglonPedido;

                        }
                    }
                }

                requisicion.Estatus = "P";
                RequisicionDao.Merge(requisicion);
             }

             

         }

        [Transaction(ReadOnly = true)]
        public bool TieneFalloRequisicion(Requisicion requisicion)
        {
            bool result = false;
            var fallos = FalloDao.FallosByAnexoEager(requisicion.Anexo);
            result = fallos.Count > 0;
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pedido"></param>
        /// <param name="importeTotal1"></param>
        /// <param name="pedidoDetalles"></param>
        [Transaction]
        public void GuardarPedido(ref Pedido pedido)
        {
            //Genere un id nuevo
            pedido.FechaModificacion = PedidoDao.FechaServidor();
            pedido.IpTerminal = Util.IpTerminal();
            ++pedido.Modificacion;

            if (pedido.IdPedido == 0)//Nuevo
            {
                pedido.FechaCaptura = PedidoDao.FechaServidor();
                pedido.EstadoPedido = "A";
                /*pedido.NumeroPedido = PedidoDao.SiguienteNumeroPedido(pedido.Almacen,
                pedido.CatTipopedido.IdTipoped);*/
            }

            //Le cargamos el Articulo y la llave compuesta)
            for (var index = 0; index < pedido.PedidoDetalle.Count; index++)
            {
                var pedidoDetalle = pedido.PedidoDetalle[index];
                pedidoDetalle.Pedido = pedido;

                //if (pedidoDetalle.RenglonPedido == 0)
                pedidoDetalle.RenglonPedido = (short)(index + 1);

                var entrega = 1;

                foreach (var pedidoEntrega in pedidoDetalle.PedidoEntrega)
                {
                    pedidoEntrega.PedidoDetalle = pedidoDetalle;
                    pedidoEntrega.Entrega = ++entrega;
                }
            }

            pedido.ImporteTotal = pedido.PedidoDetalle.Sum(detalle => detalle.Importe);

            PedidoDao.Merge(pedido);

        }

        [Transaction(ReadOnly = true)]
        public Pedido ConsultarPedido(int numPedido, Almacen almacen, int tipo)
        {
            var pedidoConsulta = PedidoDao.ConsultaPedido(numPedido, almacen, tipo);

            if (pedidoConsulta == null)
                return null;

            var pedidosDetalleConsulta = PedidoDao.CargarPedidoDetalle(pedidoConsulta);

            pedidoConsulta.PedidoDetalle = new List<PedidoDetalle>();

            //Seteamos las propiedas de la vista
            foreach (var pedidoDetalleConsulta in pedidosDetalleConsulta)
            {
                var pedidoDetalle = new PedidoDetalle
                {
                    IdPedidoDetalle = pedidoDetalleConsulta.IdPedidoDetalle,
                    Articulo = pedidoDetalleConsulta.Articulo,
                    RenglonPedido = pedidoDetalleConsulta.RenglonPedido,
                    CveArt = pedidoDetalleConsulta.Articulo.Id.CveArt,
                    DescripcionArt = pedidoDetalleConsulta.Articulo.DesArticulo,
                    UnidadArt = pedidoDetalleConsulta.Articulo.Unidad,
                    Cantidad = pedidoDetalleConsulta.Cantidad,
                    Marca = pedidoDetalleConsulta.Marca,
                    PrecioUnitario = pedidoDetalleConsulta.PrecioUnitario
                };

                pedidoDetalle.PedidoEntrega = PedidoDao.CargarPedidoEntrega(pedidoDetalle);
                pedidoConsulta.PedidoDetalle.Add(pedidoDetalle);
            }


            return pedidoConsulta;
        }

        public List<PedidoDetalle> CargarPedidoDetalle(Anexo anexo)
        {

            var anexosDetalle = AnexoService.AnexoDao.CargarAnexoDetalle(anexo);

            var pedidosDetalle = new List<PedidoDetalle>();

            foreach(var anexoDetalle in anexosDetalle)
            {
                var pedidoDetalle = new PedidoDetalle();

                pedidoDetalle.Articulo = anexoDetalle.Articulo;
                pedidoDetalle.RenglonPedido = anexoDetalle.RenglonAnexo;
                pedidoDetalle.CveArt = anexoDetalle.Articulo.Id.CveArt;
                pedidoDetalle.DescripcionArt = anexoDetalle.Articulo.DesArticulo;
                pedidoDetalle.UnidadArt = anexoDetalle.Articulo.Unidad;
                pedidoDetalle.Cantidad = 0;//anexoDetalle.CantidadMinimo;
                pedidosDetalle.Add(pedidoDetalle);
            }


            return pedidosDetalle;
        }

         [Transaction]
        public bool CancelarEntity(object entity)
         {
             if (PedidoDao.ExisteEntradaPedido(entity as Pedido))
             {
                 return false;
             }

             PedidoDao.CancelarPedido(entity as Pedido);
             return true;
         }

        [Transaction(ReadOnly = true)]
        public object ConsultarEntityAll(Almacen almacen)
         {
             //return PedidoDao.CargarPedidos(almacen);
            return null;
         }

        

         [Transaction]
        public void EliminarEntity(object entity, string nombreEntity)
        {
            PedidoDao.Delete(entity as Pedido);
        }
    }
}
