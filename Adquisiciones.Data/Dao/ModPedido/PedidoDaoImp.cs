using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Entities;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Data.Dao.ModPedido
{
    public class PedidoDaoImp : GenericDaoImp<Pedido, long>, IPedidoDao
    {
        [Transaction(ReadOnly = true)]
        public int? SiguienteNumeroPedido(Almacen almacen, int tipo)
        {
            int? result = 1;

            var query = CurrentSession.GetNamedQuery("Pedido.MaximoNumeroPedido");
            var anio = FechaServidor().Year;
            query.SetParameter("anioActual", anio);
            query.SetParameter("almacen", almacen);
            query.SetParameter("tipoPedido", tipo);

            if(query.UniqueResult() != null)
            {
                result = (int)query.UniqueResult() + 1;
            }

            return result;

        }

        [Transaction(ReadOnly = true)]
        public bool ExisteNumeroPedido(Almacen almacen, int tipo, int numPedido)
        {
            var result = false;

            var query = CurrentSession.GetNamedQuery("Pedido.ExisteNumeroPedido");
            var anio = FechaServidor().Year;
            query.SetParameter("anioActual", anio);
            query.SetParameter("almacen", almacen);
            query.SetParameter("tipoPedido", tipo);
            query.SetParameter("numPedido", numPedido);

            if (query.List().Count > 0)
            {
                result = true;
            }

            return result;

        }

        /// <summary>
        /// Revisa que los pedidos automaticos no tenga una requisicion ya asiganada
        /// </summary>
        /// <param name="requisicion"></param>
        /// <returns></returns>
        [Transaction(ReadOnly = true)]
        public bool ExisteRequisicionPedido(Requisicion requisicion)
        {
            var query = CurrentSession.GetNamedQuery("Pedido.ExisteRequisicionPedido");
            query.SetParameter("requisicion", requisicion);
            if (requisicion.IdRequisicion == 0) return false;
            var pedidos = query.List<Pedido>();
            return pedidos.Count != 0 ? true : false;
        }

        [Transaction(ReadOnly = true)]
        public bool ExisteAnexoPedido(Anexo anexo)
        {
            var query = CurrentSession.GetNamedQuery("Pedido.ExisteAnexoPedido");
            query.SetParameter("anexo", anexo);
            if (anexo.IdAnexo == 0) return false;
            var pedidos = query.List<Pedido>();
            return pedidos.Count != 0 ? true : false;
        }

         [Transaction(ReadOnly = true)]
        public bool ExisteEntradaPedido(Pedido pedido)
        {
            var query = CurrentSession.GetNamedQuery("Pedido.ExisteEntradaPedido");
            query.SetParameter("pedido", pedido);
            if (pedido.IdPedido == 0) return false;
            var entradas = query.List<Entrada>();
            return entradas.Count != 0 ? true : false;
        }

        [Transaction(ReadOnly = true)]
        public Pedido ConsultaPedido(int numPedido, Almacen almacen, int tipo)
        {
            var query = CurrentSession.GetNamedQuery("Pedido.CargaPedido");
            query.SetParameter("numero", numPedido);
            var fecha = FechaServidor().Year;
            query.SetParameter("anioActual", fecha);
            query.SetParameter("almacen", almacen);
            query.SetParameter("tipoPedido", tipo);

            return query.UniqueResult<Pedido>();
        }

        [Transaction(ReadOnly = true)]
        public IList<PedidoDetalle> CargarPedidoDetalle(Pedido pedido)
        {
            var query = CurrentSession.
              GetNamedQuery("Pedido.CargaPedidoDetalle");
            query.SetParameter("pedido", pedido);
            return query.List<PedidoDetalle>();
          
        }

        [Transaction(ReadOnly = true)]
        public IList<PedidoEntrega> CargarPedidoEntrega(PedidoDetalle pedidoDetalle)
        {
            var query = CurrentSession.
              GetNamedQuery("Pedido.CargaPedidoEntrega");
            query.SetParameter("pedidoDetalle", pedidoDetalle);
            return query.List<PedidoEntrega>();

        }

        [Transaction(ReadOnly = true)]
        public IList<Pedido> CargarPedidos(int anio, Almacen almacen)
        {
            var query = CurrentSession.
              GetNamedQuery("Pedido.CargaPedidos");
            query.SetParameter("anioActual", anio);
            query.SetParameter("almacen", almacen);
            return query.List<Pedido>();
        }

        [Transaction(ReadOnly = true)]
        public IList<Pedido> CargarPedidos(Almacen almacen)
        {
            return CargarPedidos(FechaServidor().Year, almacen);
        }

         [Transaction(ReadOnly = true)]
        public IList<Entrada> CargarEntradas(Pedido pedido)
        {
            var criteria = CurrentSession.CreateCriteria(typeof(Entrada));
            criteria.Add(Restrictions.Eq("Pedido", pedido));
            criteria.SetFetchMode("EntradaDetalle", FetchMode.Lazy);
            return criteria.List<Entrada>();
        }

         [Transaction(ReadOnly = true)]
        public String[] CargarPartidaAlmacen(Pedido pedido)
         {
             var result = new String[] {"", ""};

             const string queryNativo = @"SELECT FIRST 1 cve_art,id_almacen FROM pedido_detalle WHERE id_pedido = :idpedido";
             var query = CurrentSession.CreateSQLQuery(queryNativo);
             query.SetParameter("idpedido", pedido.IdPedido);
             var claveAlmacen =query.UniqueResult<Object[]>();

             //result[0] = claveAlmacen[1].ToString();
             switch(claveAlmacen[1].ToString().Trim())
             {
                 case "F":
                     result[0] = "FARMACIA";
                     break;
                 case "G":
                     result[0] = "GENERAL";
                     break;
                 case "P":
                     result[0] = "PROTESIS";
                     break;
             } 

             const string strQuery = "SELECT partida FROM articulo_partida WHERE cve_art = :articulo and id_almacen = :almacen";
             var criteria = CurrentSession.CreateSQLQuery(strQuery);
             criteria.SetParameter("articulo", (int)claveAlmacen[0]);
             criteria.SetParameter("almacen", claveAlmacen[1].ToString());
             var partida  = criteria.UniqueResult<string>();

             result[1] = partida;

             return result;
         }

        [Transaction(ReadOnly = true)]
        public decimal ImporteEntrada(Entrada entrada)
        {
            var strQuery = @"select sum(ed.PrecioEntrada * ed.Cantidad) 
            from EntradaDetalle ed where ed.Entrada = :entrada ";

            var query = CurrentSession.CreateQuery(strQuery);
            query.SetParameter("entrada", entrada);

            var suma = (decimal)query.UniqueResult();
            return suma;
        }

        [Transaction]
        public void CancelarPedido(Pedido pedido)
        {
            pedido.EstadoPedido = "C";
            CurrentSession.Update(pedido);
        }

        [Transaction(ReadOnly = true)]
        public IList<Entrada> CargarEntradas(DateTime fechaInicial, DateTime fechaFinal)
        {
            var criteria = CurrentSession.CreateCriteria(typeof(Entrada));
            criteria.Add(Restrictions.Between("FechaEntrada", fechaInicial,fechaFinal));
            criteria.SetFetchMode("EntradaDetalle", FetchMode.Lazy);
            return criteria.List<Entrada>();

        }

         [Transaction(ReadOnly = true)]
        public IList<Pedido> CargarPedidos(Entrada entrada, CatTipopedido tipopedido, Ordenado ordenado)
         {
             var strquery =
             @"select p from Pedido p join p.Entradas e join fetch p.Proveedor 
            where e.IdEntrada = :idEntrada and p.CatTipopedido = :tipoPedido ";

            switch (ordenado){
                case Ordenado.Proveedor:
                    strquery += " order by p.Proveedor";
                    break;
                case Ordenado.Pedido:
                    strquery += " order by p.IdPedido";
                    break;
            }

             var query = CurrentSession.CreateQuery(strquery);
             query.SetParameter("idEntrada", entrada.IdEntrada);
             query.SetParameter("tipoPedido", tipopedido);
             var pedidos = query.List<Pedido>();
             return pedidos;
        }
    }
}
