using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Entities;

namespace Adquisiciones.Data.Dao.Catalogos
{
    public interface IAlmacenDao:IGenericDao<Almacen,string>
    {

        IList<Almacen> getAlmacenes(Almacen almacenAdq);
    }
}
