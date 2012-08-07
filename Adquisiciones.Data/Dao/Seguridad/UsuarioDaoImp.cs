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
            var query = CurrentSession.GetNamedQuery("Usuario.VerificaUsuario");
            query.SetParameter("rfc", rfc);
            query.SetParameter("pwd", ReverseString(password));
            return query.UniqueResult<Usuario>();
        }

    }
}
