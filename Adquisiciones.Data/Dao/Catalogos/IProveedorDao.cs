using Adquisiciones.Data.Entities;

namespace Adquisiciones.Data.Dao.Catalogos
{
    public interface IProveedorDao : IGenericDao<Proveedor, int>
    {
        int? SiguienteCveProveedor();
    }
}
