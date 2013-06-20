using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Entities;

namespace Adquisiciones.View.Reportes.Clases
{
    public class PedidoConcentrado
    {

        public int NumeroPedido { get; set; }
        public string FechaPedido { get; set; }
        public string NumeroRequisicion { get; set; }
        public string Proveedor { get; set; }
        public string Elaboro { get; set; }
        public string Importe { get; set; }
        public string Descuento { get; set; }
        public string Iva { get; set; }
        public string Total { get; set; }

    }
}
