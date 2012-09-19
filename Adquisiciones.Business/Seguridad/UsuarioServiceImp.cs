using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Dao.Seguridad;
using Adquisiciones.Data.Entities;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Business.Seguridad
{
    public class UsuarioServiceImp:IUsuarioService
    {
        public IUsuarioDao UsuarioDao { get; set; }


        [Transaction(ReadOnly = true)]
        public Usuario AccessAllow(string rfc, string password)
        {
            var usr = UsuarioDao.AccessAllow(rfc, Util.GetSHA1(password));
            return usr;
        }


        [Transaction]
        public void GuardarUsuario(Usuario usuario)
        {
            usuario.Password = Util.GetSHA1(usuario.Password);
            usuario.FechaAlta = UsuarioDao.FechaServidor();
            usuario.FechaBaja = null;

            foreach (var usuarioModulo in usuario.UsuarioModulo)
            {
                //Nuevo perfil
                if(usuarioModulo.Id.Usuario ==null)
                {
                    usuarioModulo.Id.Usuario = usuario;
                    usuarioModulo.Estatus = "A";
                    usuarioModulo.FechaAlta = UsuarioDao.FechaServidor();
                    usuarioModulo.FechaBaja = null;
                }
            }

            UsuarioDao.Merge(usuario);

        }

        [Transaction]
        public void Update(Usuario usuario)
        {
            UsuarioDao.Update(usuario);
        }


        [Transaction]
        public void Delete(Usuario usuario)
        {
            UsuarioDao.Delete(usuario);
        }
    }
}
