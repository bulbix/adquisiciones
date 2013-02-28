using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adquisiciones.Data.Entities
{

    [Serializable]
    public class CatEmpresa
    {
        public virtual int IdEmpresa { get; set; }
        public virtual string DesEmpresa { get; set; }
        public virtual string Estatus { get; set; }

    }
}
