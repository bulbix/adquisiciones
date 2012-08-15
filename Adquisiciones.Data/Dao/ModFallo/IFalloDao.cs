
using System.Collections.Generic;
using Adquisiciones.Data.Entities;

namespace Adquisiciones.Data.Dao.ModFallo
{
    public interface IFalloDao: IGenericDao<Fallo,long>
    {
        long? MaximoId ();
        IList<Fallo> FallosByAnexo(Anexo anexo);
        IList<Fallo> FallosByAnexoEager(Anexo anexo);
        Fallo ExisteProvCotiz(Cotizacion cotizacion, Proveedor prov);
        IList<Fallo> ConsultarFalloCompleto(Anexo anexo);
        IList<Fallo> CargarFallos(int anio, Almacen almacen);
        IList<Fallo> CargarFallos(Almacen almacen);

        void BorrarFallos(Anexo anexo);

    }
}
