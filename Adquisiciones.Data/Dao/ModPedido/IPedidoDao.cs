using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Entities;

namespace Adquisiciones.Data.Dao.ModPedido
{
    public enum Ordenado  {Proveedor, Pedido}

    public interface IPedidoDao : IGenericDao<Pedido, long >
    {
        int? SiguienteNumeroPedido(Almacen almacen, int tipo);
        bool ExisteNumeroPedido(Almacen almacen, int tipo, int numPedido);
        bool ExisteRequisicionPedido(Requisicion requisicion);
        bool ExisteAnexoPedido(Anexo anexo);
        bool ExisteEntradaPedido(Pedido pedido);

        Pedido ConsultaPedido(int numPedido, Almacen almacen, int tipo);
        IList<PedidoDetalle> CargarPedidoDetalle(Pedido pedido);
        IList<PedidoEntrega> CargarPedidoEntrega(PedidoDetalle pedidoDetalle);
        IList<Pedido> CargarPedidos(int anio, Almacen almacen);
        IList<Pedido> CargarPedidos(Almacen almacen);
        IList<Entrada> CargarEntradas(Pedido pedido);
        CatPartida CargarCatalogoPartida(Pedido pedido);
        decimal ImporteEntrada(Entrada entrada);
        void CancelarPedido(Pedido pedido);

        IList<Entrada> CargarEntradas(DateTime fechaInicial, DateTime fechaFinal);
        IList<Pedido> CargarPedidos(Entrada entrada,CatTipopedido tipopedido, Ordenado ordenado);

    }
}
