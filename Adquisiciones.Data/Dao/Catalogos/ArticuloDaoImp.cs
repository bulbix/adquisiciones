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
            List<Almacen> almacenes = new List<Almacen>();

            switch(almacen.IdAlmacen)
            {
                case "C5":
                    almacenes.Add(new Almacen("AC")); 
                    break;
                case "C2":
                    almacenes.Add(new Almacen("PC")); 
                    almacenes.Add(new Almacen("GC")); 
                    almacenes.Add(new Almacen("FC")); 
                    break;
                case "P2":
                    almacenes.Add(new Almacen("F")); 
                    almacenes.Add(new Almacen("G")); 
                    almacenes.Add(new Almacen("P"));
                    break;
                case "P5":
                    almacenes.Add(new Almacen("A")); 
                    break;
                default:
                    break;
            }

            var query = CurrentSession.CreateQuery(@"select 
            new ArticuloBusqueda(a.Id.CveArt,a.DesArticulo,a.Presentacion) 
            from Articulo a where Id.Almacen in (:almacen)");
            query.SetParameterList("almacen", almacenes);
            
            return query.List<ArticuloBusqueda>();
        }
        [Transaction(ReadOnly = true)]
        public ArticuloPartida ArticuloPartida(Articulo articulo)
        {
            var query = CurrentSession.
                CreateQuery(@"select ap from ArticuloPartida ap where ap.Id.Articulo = :articulo");
            query.SetParameter("articulo", articulo);

            return query.UniqueResult<ArticuloPartida>();
        }
    }
}
