using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adquisiciones.View.Reportes.Clases
{
    public class PedidoEntrada : PedidoConcentrado
    {
        public int NumeroEntrada { get; set; }
        public string Factura { get; set; }
        public string FechaEntrada { get; set; }
        public string ImporteEntrada { get; set; }
    }
}