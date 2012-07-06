using System;
using Adquisiciones.Data.Entities;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Data.Dao.Catalogos
{
   
    public class ProveedorDaoImp:GenericDaoImp<Proveedor,int>,IProveedorDao
    {

        [Transaction(ReadOnly = true)]
        public int? SiguienteCveProveedor()
        {
            var query = CurrentSession.CreateQuery("select max(p.CveProveedor) from Proveedor p");
            int? result = query.UniqueResult<Int32>();
            return ++result;
        }
    }
}
