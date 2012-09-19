using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Dao.Seguridad;
using Adquisiciones.Data.Entities;

namespace Adquisiciones.Business.Seguridad
{
    public interface IUsuarioService
    {
        IUsuarioDao UsuarioDao { get; set; }
        Usuario AccessAllow(string rfc, string password);
        void GuardarUsuario(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(Usuario usuario);
    }
}
