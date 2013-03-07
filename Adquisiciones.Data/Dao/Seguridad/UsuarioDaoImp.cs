using System;
using System.Collections.Generic;
using Adquisiciones.Data.Entities;
using NHibernate.Criterion;
using NHibernate.Transform;
using Spring.Transaction.Interceptor;
using System.Linq;

namespace Adquisiciones.Data.Dao.Seguridad
{
    public class UsuarioDaoImp:GenericDaoImp<Usuario,int>,IUsuarioDao{

        [Transaction(ReadOnly = true)]
        public Usuario ConsultarUsuario(string rfc, string password)
        {
            var query = CurrentSession.GetNamedQuery("Usuario.ConsultarUsuario");
            query.SetParameter("rfc", rfc);
            query.SetParameter("pwd", password);
            return query.UniqueResult<Usuario>();
        }

         [Transaction(ReadOnly = true)]
        public IList<Modulo> ModulosSinPerfil(Usuario usuario, Almacen almacen)
         {
            IList<Modulo> result = new List<Modulo>();

            if (usuario.IdUsuario != 0)
            {
                var query = CurrentSession.GetNamedQuery("Usuario.SinPerfiles");
                query.SetParameter("usuario", usuario);
                query.SetParameter("almacen", almacen);
                result = query.List<Modulo>();
            }

             return result;
         }

         [Transaction(ReadOnly = true)]
        public IList<UsuarioModulo> ModulosConPerfil(Usuario usuario, Almacen almacen)
        {
            IList<UsuarioModulo> result = new List<UsuarioModulo>();

            if (usuario.IdUsuario != 0)
            {
                var query = CurrentSession.GetNamedQuery("Usuario.ConPerfiles");
                query.SetParameter("usuario", usuario);
                query.SetParameter("almacen", almacen);
                result = query.List<UsuarioModulo>();
            }

            return result;
        }

         [Transaction(ReadOnly = true)]
        public IList<UsuarioModulo> ModulosAllSinPerfil(Usuario usuario, Almacen almacen)
        {
            IList<UsuarioModulo> result = new List<UsuarioModulo>();

            if (usuario.IdUsuario != 0)
            {
                var query = CurrentSession.GetNamedQuery("Usuario.AllSinPerfiles");
                query.SetParameter("usuario", usuario);
                query.SetParameter("almacen", almacen);
                result = query.List<UsuarioModulo>();
            }
            
             return result;
        }

        [Transaction(ReadOnly = true)]
         public IList<Usuario> CargarUsuarios()
         {
             var criteria = CurrentSession.CreateCriteria(typeof(Usuario));
             criteria.CreateAlias("UsuarioModulo", "um");
            criteria.Add(Restrictions.In("um.Id.Modulo.Id.Almacen.IdAlmacen",
                                         new string[] {"C2", "C5", "P2", "P5"}));
            criteria.SetResultTransformer(Transformers.DistinctRootEntity);

             return criteria.List<Usuario>();
        }

        [Transaction(ReadOnly = true)]
        public IList<UsuarioModulo> TraerModulos(Usuario usuario, Almacen almacen)
        {
            IList<UsuarioModulo> result = new List<UsuarioModulo>();

            if (usuario.IdUsuario != 0)
            {
                var query = CurrentSession.GetNamedQuery("Usuario.TraerModulos");
                query.SetParameter("usuario", usuario);
                query.SetParameter("almacen", almacen);
                result = query.List<UsuarioModulo>();
            }

            return result;
        }

        [Transaction(ReadOnly = true)]
        public IList<Modulo> TraerModulosByAlmacen(Almacen almacen)
        {
            var query = CurrentSession.GetNamedQuery("Modulo.TraerTodos");
            query.SetParameter("almacen", almacen);
            return query.List<Modulo>();
        }

        [Transaction(ReadOnly = true)]
        public int? SiguienteId()
        {
            int? result = 1;
            var query = CurrentSession.
                CreateQuery(@"select max(IdUsuario) from Usuario");

            if (query.UniqueResult() != null)
            {
                result = (int)query.UniqueResult() + 1;
            }

            return result;
        }
    }
}
