using System.Collections.Generic;
using Adquisiciones.Data.Entities;
using Adquisiciones.Data.Auxiliares;

namespace Adquisiciones.Data.Dao.Catalogos
{
    public interface IArticuloDao:IGenericDao<Articulo,ArticuloId>
    {

        IList<ArticuloBusqueda> ArticulosByAlmacen(Almacen almacen);
        ArticuloPartida ArticuloPartida(Articulo articulo);

    }
}
