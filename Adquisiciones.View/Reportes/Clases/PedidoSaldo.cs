using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adquisiciones.View.Reportes.Clases
{
    public class PedidoSaldo
    {
        public string Partida { get; set; }
        public int NumeroPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public string NumeroReq { get; set; }
        public string Proveedor { get; set; }
        public decimal ImporteTotalPedido { get; set; }
        public decimal ImporteTotalEntrada { get; set; }
        public string TipoPedido { get; set; }

    }
}
