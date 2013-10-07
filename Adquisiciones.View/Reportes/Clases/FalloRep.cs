using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adquisiciones.View.Reportes.Clases
{
    public class FalloRep
    {
        public DateTime FechaFallo { get; set; }
        public string TipoLicitacion { get; set; }
        public string Anexo { get; set; }
        public string Proveedor { get; set; }
        public string Renglones { get; set; }
        public decimal TotalAdjudicado { get; set; }

    }
}
