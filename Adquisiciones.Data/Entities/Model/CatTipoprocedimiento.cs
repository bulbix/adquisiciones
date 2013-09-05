using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adquisiciones.Data.Entities
{
    public class CatTipoprocedimiento
    {

        public short Id { get; set; }
        public string Bloque1 { get; set; }
        public string Bloque2 { get; set; }
        public string Bloque3 { get; set; }
        public string Bloque4 { get; set; }
        public string Bloque5 { get; set; }
        public string Bloque6 { get; set; }
        public string Bloque7 { get; set; }
        public string Bloque8 { get; set; }
        public string Bloque9 { get; set; }

        public bool Menor { get; set;}
        public bool Mayor { get; set; }

    }
}
