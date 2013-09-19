using System.Collections.Generic;
using Adquisiciones.Data.Entities;
using Adquisiciones.Data.Auxiliares;

namespace Adquisiciones.Data.Dao.Catalogos
{
    public interface IArticuloDao:IGenericDao<Articulo,ArticuloId>
    {

        IList<ArticuloBusqueda> ArticulosByAlmacen(Almacen almacen);
        Articulo ArticuloPartida(int cveArt, Almacen almacen, CatPartida partida);
        CatPartida GetPartida(Articulo articulo);

        IList<ArticuloBusqueda> ArticulosByPartidaDescripcion(CatPartida partida = null,
            string aproxDescripcion = null);

    }
}
