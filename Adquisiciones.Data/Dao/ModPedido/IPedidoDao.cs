using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Entities;

namespace Adquisiciones.Data.Dao.ModPedido
{
    public interface IPedidoDao : IGenericDao<Pedido, long >
    {
        int? SiguienteNumeroPedido(Almacen almacen, int tipo);
        bool ExisteNumeroPedido(Almacen almacen, int tipo, int numPedido);

        bool ExisteRequisicionPedido(Requisicion requisicion);
        bool ExisteAnexoPedido(Anexo anexo);


        Pedido ConsultaPedido(int numPedido, Almacen almacen);
        IList<PedidoDetalle> CargarPedidoDetalle(Pedido pedido);
        IList<PedidoEntrega> CargarPedidoEntrega(PedidoDetalle pedidoDetalle);
        IList<Pedido> CargarPedidos(int anio, Almacen almacen);
        IList<Pedido> CargarPedidos(Almacen almacen);

    }
}
