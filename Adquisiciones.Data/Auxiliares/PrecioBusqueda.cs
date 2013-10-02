using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Entities;

namespace Adquisiciones.Data.Auxiliares
{
    public class PrecioBusqueda
    {
        public Articulo Articulo { get; set; }
        public DateTime FechaPedido { get; set; }
        public int NumeroPedido { get; set; }
        public CatTipopedido CatTipopedido { get; set; }
        public decimal Costo { get; set; }
        public string Marca { get; set; }
        public Proveedor Proveedor { get; set; }

        public PrecioBusqueda(Articulo articulo, DateTime fechaPedido,
            int numeroPedido,CatTipopedido catTipopedido,
            decimal costo, string marca, Proveedor proveedor)
        {
            Articulo = articulo;
            FechaPedido = fechaPedido;
            NumeroPedido = numeroPedido;
            CatTipopedido = catTipopedido;
            Costo = costo;
            Marca = marca;
            Proveedor = proveedor;
        }
    }
}
