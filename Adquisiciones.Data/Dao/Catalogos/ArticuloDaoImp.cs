using System;
using System.Collections.Generic;
using Adquisiciones.Data.Auxiliares;
using Adquisiciones.Data.Entities;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using Spring.Transaction.Interceptor;
namespace Adquisiciones.Data.Dao.Catalogos
{
    public class ArticuloDaoImp:GenericDaoImp<Articulo,ArticuloId>,IArticuloDao,IFormBusqueda
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

        [Transaction(ReadOnly = true)]
        public object ConsultarEntityAll(Almacen almacen)
        {
            return CargarCatalogoSinEstatus<Articulo>("Id.CveArt");
        }

        public void EliminarEntity(object entity, string nombreEntity)
        {
            throw new NotImplementedException();
        }

        public bool CancelarEntity(object entity)
        {
            throw new NotImplementedException();
        }

         [Transaction(ReadOnly = true)]
        public IList<ArticuloBusqueda> ArticulosByPartidaDescripcion(CatPartida partida = null,
            string aproxDescripcion = null)
         {
             string strQuery = "";

             if (partida != null && aproxDescripcion == null)
             {
                 strQuery = @"select 
                               new ArticuloBusqueda(a.Id.CveArt,a.DesArticulo,a.Unidad,
                               a.Presentacion,ap.Id.CatPartida.Partida,a.Id.Almacen.IdAlmacen) from Articulo a 
                               join a.ArticuloPartida ap 
                               where ap.Id.CatPartida = :partida order by a.Id.CveArt";

                 var query = CurrentSession.CreateQuery(strQuery);
                 query.SetParameter("partida", partida);
                 return query.List<ArticuloBusqueda>();
            }

             if (partida == null && aproxDescripcion != null)
             {
                 strQuery = @"select 
                               new ArticuloBusqueda(a.Id.CveArt,a.DesArticulo,a.Unidad,
                               a.Presentacion,ap.Id.CatPartida.Partida,a.Id.Almacen.IdAlmacen) from Articulo a 
                               join a.ArticuloPartida ap 
                               where a.DesArticulo like :aprox order by a.Id.CveArt";

                 var query = CurrentSession.CreateQuery(strQuery);
                 query.SetParameter("aprox", "%" + aproxDescripcion + "%");
                 return query.List<ArticuloBusqueda>();
             }

             if (partida != null && aproxDescripcion != null)
             {
                 strQuery = @"select 
                               new ArticuloBusqueda(a.Id.CveArt,a.DesArticulo,a.Unidad,
                               a.Presentacion,ap.Id.CatPartida.Partida,a.Id.Almacen.IdAlmacen) from Articulo a 
                               join a.ArticuloPartida ap 
                               where a.DesArticulo like :aprox and 
                               ap.Id.CatPartida = :partida order by a.Id.CveArt";

                 var query = CurrentSession.CreateQuery(strQuery);
                 query.SetParameter("partida", partida);
                 query.SetParameter("aprox", "%" + aproxDescripcion + "%");
                 return query.List<ArticuloBusqueda>();
             }


             return null;


         }
    }
}
