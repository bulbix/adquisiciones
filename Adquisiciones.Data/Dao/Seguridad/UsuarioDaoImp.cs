using System;
using System.Collections.Generic;
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

         [Transaction(ReadOnly = true)]
        public IList<Modulo> ModulosSinPerfil(Usuario usuario, Almacen almacen)
        {
            var query = CurrentSession.GetNamedQuery("Usuario.SinPerfiles");
            query.SetParameter("usuario", usuario);
            query.SetParameter("almacen", almacen);
            return query.List<Modulo>();
        }

         [Transaction(ReadOnly = true)]
        public IList<Modulo> ModulosConPerfil(Usuario usuario, Almacen almacen)
        {
            var query = CurrentSession.GetNamedQuery("Usuario.ConPerfiles");
            query.SetParameter("usuario", usuario);
            query.SetParameter("almacen", almacen);
            return query.List<Modulo>();
        }
         [Transaction(ReadOnly = true)]public IList<Usuario> CargarUsuarios()
        {
            var query = CurrentSession.GetNamedQuery("Usuario.CargaCombo");
            return query.List<Usuario>();
        }
    }
}
