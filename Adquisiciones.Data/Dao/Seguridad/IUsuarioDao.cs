using Adquisiciones.Data.Entities;

namespace Adquisiciones.Data.Dao.Seguridad
{
    public interface IUsuarioDao : IGenericDao<Usuario,int>
    {
        Usuario AccessAllow(string rfc, string password);
    }
}
