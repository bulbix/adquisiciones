using System;
using System.Collections.Generic;
using Adquisiciones.Data.Auxiliares;
using Adquisiciones.Data.Entities;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using Spring.Transaction.Interceptor;
namespace Adquisiciones.Data.Dao.Catalogos
{
    public class ArticuloDaoImp:GenericDaoImp<Articulo,ArticuloId>,IArticuloDao
    {
        [Transaction(ReadOnly = true) ]
        public IList<ArticuloBusqueda> ArticulosByAlmacen(Almacen almacen)
        {
            var query = CurrentSession.CreateQuery(@"select 
            new ArticuloBusqueda(a.Id.CveArt,a.DesArticulo,a.CatUnidad.Unidad) 
            from Articulo a where Id.Almacen = :almacen order by a.Id.CveArt");
            query.SetParameter("almacen", almacen);
            
            return query.List<ArticuloBusqueda>();
        }
        
        [Transaction(ReadOnly = true)]
        public Articulo ArticuloPartida(int cveArt,Almacen almacen, CatPartida partida)
        {
            var query = CurrentSession.
                CreateQuery(@"  select a from Articulo a 
                                join fetch a.ArticuloPartida ap 
                                where ap.Id.CatPartida = :partida and 
                                a.Id.Almacen = :almacen and 
                                a.Id.CveArt = :clave");
            
            query.SetParameter("partida", partida);
            query.SetParameter("almacen", almacen);
            query.SetParameter("clave", cveArt);
            return query.UniqueResult<Articulo>();

        }

        [Transaction(ReadOnly = true)]
        public CatPartida GetPartida(Articulo articulo)
        {
            var query = CurrentSession.
                CreateQuery(@"  select ap.Id.CatPartida from ArticuloPartida  ap  
                                join ap.Id.Articulo a 
                                where a = :articulo");

            query.SetParameter("articulo", articulo);
            return query.UniqueResult<CatPartida>();
        }
    }
}
