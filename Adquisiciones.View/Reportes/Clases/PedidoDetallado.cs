using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adquisiciones.View.Reportes.Clases
{
    class PedidoDetallado:PedidoConcentrado
    {
        public string DescripcionArticulo { get; set; }
        public string UnidadArticulo { get; set; }
        public string PartidaArticulo { get; set; }
        public decimal Cantidad { get; set; }
        public string PrecioUnitario { get; set; }
        public string Importe { get; set; }
    }
}
