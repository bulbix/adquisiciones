﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Entities;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Data.Dao.ModPedido
{
    public class PedidoDaoImp : GenericDaoImp<Pedido, long>, IPedidoDao
    {
        [Transaction(ReadOnly = true)]
        public int? MaximoNumeroPedido(Almacen almacen)
        {
            int? result = 1;

            var query = CurrentSession.GetNamedQuery("Pedido.MaximoNumeroPedido");
            var anio = FechaServidor().Year;
            query.SetParameter("anioActual", anio);
            query.SetParameter("almacen", almacen);

            if(query.UniqueResult() != null)
            {
                result = (int)query.UniqueResult() + 1;
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
        public Pedido ConsultaPedido(int numPedido, Almacen almacen)
        {
            var query = CurrentSession.GetNamedQuery("Pedido.CargaPedido");
            query.SetParameter("numero", numPedido);
            var fecha = FechaServidor().Year;
            query.SetParameter("anioActual", fecha);
            query.SetParameter("almacen", almacen);
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
    }
}
