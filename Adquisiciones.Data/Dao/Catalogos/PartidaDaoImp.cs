using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Entities;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Data.Dao.Catalogos
{
    public class PartidaDaoImp : GenericDaoImp<CatPartida, string>, IPartidaDao,IFormBusqueda{

        [Transaction(ReadOnly = true)]
        public object ConsultarEntityAll(Almacen almacen)
        {
            return CargarCatalogo<CatPartida>();
        }

        [Transaction]
        public void EliminarEntity(object entity, string nombreEntity)
        {
            Delete(entity as CatPartida);
        }

        public void CancelarEntity(object entity)
        {
        }
    }
}
