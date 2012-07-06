using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Entities;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Data.Dao.Catalogos
{
    public class FundamentoDaoImp : GenericDaoImp<Fundamento, short>, IFundamentoDao
    {
        [Transaction(ReadOnly = true)]
        public short? SiguienteCveFundamento()
        {
            var query = CurrentSession.CreateQuery("select max(f.CveFundamento) from Fundamento f");
            short? result = query.UniqueResult<short>();
            return ++result;
        }
    }
}
