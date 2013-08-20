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
            string result = "";

            switch (Catalogo.Id) {
                case 1: case 3://Acaba en reglon desierto
                    result = string.Format("{0} {1}{2} {3}",
                    Catalogo.Bloque1, Catalogo.Bloque2, NumLicitacion, Catalogo.Bloque3);
                    break;
                case 2: case 4://Acaba en sesion del comite de adquisiciones
                    result = string.Format("{0} {1}{2} {3} {4} {5} {6} {7} {8} {9} {10}",
                    Catalogo.Bloque1, Catalogo.Bloque2, NumLicitacion, Catalogo.Bloque3,
                    Catalogo.Bloque4,Catalogo.Bloque5, Fraccion, Catalogo.Bloque6,
                    Catalogo.Bloque7,NumOrdinal,Catalogo.Bloque9);
                    break;
                case 5: case 6://el que acaba ene entrega 
                    result = string.Format("{0} {1}{2} {3} {4} {5}",
                    Catalogo.Bloque1, Catalogo.Bloque2, NumLicitacion, Catalogo.Bloque3,
                    NumOrdinal,Catalogo.Bloque5);
                    break;
                case 7:
                    result = string.Format("{0} {1} {2} {3} {4} {5} {6}",
                    Catalogo.Bloque1, Catalogo.Bloque2, Catalogo.Bloque3, Fraccion, Catalogo.Bloque4,
                    NumOrdinal,Catalogo.Bloque6);
                    break;
                case 8:
                    result = string.Format("{0} {1} {2}",
                    Catalogo.Bloque1, Catalogo.Bloque2, Catalogo.Bloque3);
                    break;
                case 9: case 10:
                    result = Catalogo.Bloque1;
                    break;
            }
           
            return result;
        }

        public int CompareTo(object obj)
        {
            return Catalogo.Bloque1.CompareTo((obj as TipoProcedimiento).Catalogo.Bloque1);
        }

    }
}
