﻿using System;
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
            new ArticuloBusqueda(a.Id.CveArt,a.DesArticulo,a.Presentacion) 
            from Articulo a where Id.Almacen = :almacen");
            query.SetParameter("almacen", almacen);
            
            return query.List<ArticuloBusqueda>();
        }
    }
}
