﻿using System;
using Adquisiciones.Data.Entities;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Data.Dao.Catalogos
{
   
    public class ProveedorDaoImp:GenericDaoImp<Proveedor,int>,IProveedorDao,IFormBusqueda
    {

        [Transaction(ReadOnly = true)]
        public int? SiguienteCveProveedor()
        {
            var query = CurrentSession.CreateQuery("select max(p.CveProveedor) from Proveedor p");
            int? result = query.UniqueResult<Int32>();
            return ++result;
        }

        [Transaction(ReadOnly = true)]
        public object ConsultarEntityAll(Almacen almacen)
        {
            //return this.CargarCatalogo<Proveedor>();
            var criteria = CurrentSession.CreateCriteria(typeof(Proveedor));
            criteria.SetFetchMode("Usuario", FetchMode.Eager);
            criteria.AddOrder(Order.Desc("CveProveedor"));
            return criteria.List<Proveedor>();

        }

        [Transaction]
        public void EliminarEntity(object entity, string nombreEntity)
        {
           Delete(entity as Proveedor);
        }

        public bool CancelarEntity(object entity)
        {
            return true;
        }
    }
}
