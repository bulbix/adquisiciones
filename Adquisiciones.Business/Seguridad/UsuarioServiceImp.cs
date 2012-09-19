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
            var hash = Util.GetSHA1(password);
            var usr = UsuarioDao.AccessAllow(rfc, hash );
            return usr;
        }


        [Transaction]
        public void GuardarUsuario(Usuario usuario, bool updatePassword)
        {
            if(updatePassword)
                usuario.Password = Util.GetSHA1(usuario.Password);

            usuario.FechaAlta = UsuarioDao.FechaServidor();
            usuario.FechaBaja = null;

            Almacen almacen = null;

            foreach (var usuarioModulo in usuario.UsuarioModulo)
            {
                almacen = usuarioModulo.Id.Modulo.Id.Almacen;
                //Nuevo perfil
                if(usuarioModulo.Id.Usuario ==null)
                {
                    usuarioModulo.Id.Usuario = usuario;
                    usuarioModulo.Estatus = "A";
                    usuarioModulo.FechaAlta = UsuarioDao.FechaServidor();
                    usuarioModulo.FechaBaja = null;
                }
            }

            //Agrega los otros perfiles no los borre
            if(almacen!=null)
            {
                var otrosPerfiles = UsuarioDao.ModulosAllSinPerfil(usuario, almacen);
                foreach (var otroPerfil in otrosPerfiles)
                {
                    if(!usuario.UsuarioModulo.Contains(otroPerfil))
                    {
                        usuario.UsuarioModulo.Add(otroPerfil);
                    }
                }}

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
