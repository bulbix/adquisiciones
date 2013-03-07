using System.Collections.Generic;
using Adquisiciones.Data.Entities;

namespace Adquisiciones.Data.Dao.Seguridad
{
    public interface IUsuarioDao : IGenericDao<Usuario,int>
    {
        Usuario ConsultarUsuario(string rfc, string password);
        IList<Modulo> ModulosSinPerfil(Usuario usuario, Almacen almacen);
        IList<UsuarioModulo> ModulosConPerfil(Usuario usuario, Almacen almacen);
        IList<UsuarioModulo> ModulosAllSinPerfil(Usuario usuario, Almacen almacen);
        IList<Usuario> CargarUsuarios();
        IList<UsuarioModulo> TraerModulos(Usuario usuario, Almacen almacen);
        IList<Modulo> TraerModulosByAlmacen(Almacen almacen);

        int? SiguienteId();
    }
}
