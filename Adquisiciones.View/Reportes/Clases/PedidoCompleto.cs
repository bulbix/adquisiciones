using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adquisiciones.View.Reportes.Clases
{
    public class PedidoCompleto
    {
        public string Estado { get; set; }
        public int Pedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public string Factura { get; set; }
        public string Entrada { get; set; }
        public string Almacen { get; set; }
        public string FechaEntrada { get; set; }
        public decimal ImporteSinIVAEntrada { get; set; }
        public decimal TotalFactura { get; set; }
        public string Proveedor { get; set; }
        public string RFCProveedor { get; set; }
        public string AreaSolicitada { get; set; }
        public string Partida { get; set; }
        public string DescripcionGasto { get; set; }
        public decimal ImporteSinIVA { get; set; }
        public string Req { get; set; }
        public string Elaboro { get; set; }
        public string Licitacion { get; set; }
        public string Procedimiento { get; set; }
        public string FundamentoLegal { get; set; }
        public decimal ImportePedido { get; set; }
        public string TipoPedido { get; set; }
    }
}
