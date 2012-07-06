using System;
using Adquisiciones.Data.Entities;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Data.Dao.Seguridad
{
    public class UsuarioDaoImp:GenericDaoImp<Usuario,int>,IUsuarioDao{       

        protected string ReverseString(string s)
        {
            var arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        [Transaction(ReadOnly = true)]
        public Usuario AccessAllow(string rfc, string password)
        {
            return CurrentSession.CreateCriteria<Usuario>().
                Add(Restrictions.Eq("Rfc", rfc)).
                Add(Restrictions.Eq("Password", ReverseString(password))).
                UniqueResult<Usuario>();
        }

    }
}
