using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Entities;

namespace Adquisiciones.Business
{
    public interface IFormBusqueda
    {
        object ConsultarEntityAll(Almacen almacen, string nombreEntity);
        void EliminarEntity(object entity, string nombreEntity);
    }
}
