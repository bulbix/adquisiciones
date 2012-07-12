using System.Collections.Generic;
using Adquisiciones.Data.Entities;

namespace Adquisiciones.Data.Dao.ModCotizacion
{
    public interface ICotizacionDao:IGenericDao<Cotizacion,long>
    {
        Cotizacion CargarCotizacionEager(Proveedor prov, Anexo anexo, Almacen almacen);
        IList<CotizacionDetalle> CargarCotizacionDetalle(Anexo anexo, 
            Articulo articulo,
            Almacen almacen);
        IList<Cotizacion> CargarCotizaciones(int anio, Almacen almacen);
        IList<Cotizacion> CargarCotizaciones(Almacen almacen);
        bool ExisteAnexoFallo(Anexo anexo);
        long MaximoId(Almacen almacen);

    }
}
