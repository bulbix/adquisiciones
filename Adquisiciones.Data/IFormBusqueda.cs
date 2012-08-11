using Adquisiciones.Data.Entities;

namespace Adquisiciones.Data
{
    public interface IFormBusqueda
    {
        object ConsultarEntityAll(Almacen almacen);
        void EliminarEntity(object entity, string nombreEntity);
    }
}
