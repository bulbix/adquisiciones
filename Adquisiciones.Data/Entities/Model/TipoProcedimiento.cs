using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adquisiciones.Data.Entities
{
    public class TipoProcedimiento : IComparable
    {
        public int Id { get; set; }
        public CatTipoprocedimiento Catalogo { get; set; }
        public string NumLicitacion { get; set; }
        public string Fraccion { get; set; }
        public string NumOrdinal { get; set; }


        public override string ToString()
        {
            return Catalogo.Bloque1;
        }

        public int CompareTo(object obj)
        {
            return Catalogo.Bloque1.CompareTo((obj as TipoProcedimiento).Catalogo.Bloque1);
        }

    }
}
