using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Entities;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Data.Dao.Catalogos
{
    public class FundamentoDaoImp : GenericDaoImp<Fundamento, short>, IFundamentoDao, IFormBusqueda
    {
        [Transaction(ReadOnly = true)]
        public short? SiguienteCveFundamento()
        {
            var query = CurrentSession.CreateQuery("select max(f.CveFundamento) from Fundamento f");
            short? result = query.UniqueResult<short>();
            return ++result;
        }

        [Transaction(ReadOnly = true)]
        public object ConsultarEntityAll(Almacen almacen)
        {
            return CargarCatalogo<Fundamento>();
        }
        [Transaction]
        public void EliminarEntity(object entity, string nombreEntity)
        {
            Delete(entity as Fundamento);
        }

        public void CancelarEntity(object entity)
        {
        }
    }
}