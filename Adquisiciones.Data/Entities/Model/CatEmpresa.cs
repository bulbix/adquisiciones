using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adquisiciones.Data.Entities
{

    [Serializable]
    public class CatEmpresa: IComparable
    {
        public virtual int IdEmpresa { get; set; }
        public virtual string DesEmpresa { get; set; }
        public virtual string Estatus { get; set; }

        public override string ToString()
        {
            return DesEmpresa;
        }

        public int CompareTo(object obj)
        {
            return IdEmpresa.CompareTo((obj as CatEmpresa).IdEmpresa);
        }

    }
}
