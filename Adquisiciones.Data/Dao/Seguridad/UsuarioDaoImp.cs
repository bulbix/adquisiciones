using System;
using System.Collections.Generic;
using Adquisiciones.Data.Entities;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Data.Dao.Seguridad
{
    public class UsuarioDaoImp:GenericDaoImp<Usuario,int>,IUsuarioDao{

        [Transaction(ReadOnly = true)]
        public Usuario AccessAllow(string rfc, string password)
        {
            var query = CurrentSession.GetNamedQuery("Usuario.VerificaUsuario");
            query.SetParameter("rfc", rfc);
            query.SetParameter("pwd", password);
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
        public IList<UsuarioModulo> ModulosConPerfil(Usuario usuario, Almacen almacen)
        {
            var query = CurrentSession.GetNamedQuery("Usuario.ConPerfiles");
            query.SetParameter("usuario", usuario);
            query.SetParameter("almacen", almacen);
            return query.List<UsuarioModulo>();
        }

         [Transaction(ReadOnly = true)]
        public IList<UsuarioModulo> ModulosAllSinPerfil(Usuario usuario, Almacen almacen)
        {
            var query = CurrentSession.GetNamedQuery("Usuario.AllSinPerfiles");
            query.SetParameter("usuario", usuario);
            query.SetParameter("almacen", almacen);
            return query.List<UsuarioModulo>();
        }

        [Transaction(ReadOnly = true)]
         public IList<Usuario> CargarUsuarios()
         {
             var criteria = CurrentSession.CreateCriteria(typeof(Usuario));
             return criteria.List<Usuario>();
         }
    }
}
