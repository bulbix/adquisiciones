using System.Collections.Generic;
using Adquisiciones.Data.Auxiliares;
using Adquisiciones.Data.Entities;

namespace Adquisiciones.Data.Dao.ModAnexo
{
    public interface IAnexoDao : IGenericDao<Anexo, long>
    {
        Anexo ConsultaAnexo(string numAnexo, Almacen almacen);
        bool ExisteAnexo(string numAnexo, Almacen almacen);
        IList<Anexo> CargarAnexos(int anio, Almacen almacen);
        IList<Anexo> CargarAnexos(Almacen almacen);
        IList<Anexo> CargarAnexosWithCotizacion(int anio, Almacen almacen);
        IList<Anexo> CargarAnexosWithCotizacion(Almacen almacen);
        IList<Anexo> CargarAnexosWithFallo(Almacen almacen);
        IList<AnexoDetalle> CargarAnexoDetalle(Anexo anexo);
        bool ExisteAnexoCotizacion(Anexo anexo);
        bool ExisteAnexoPedido(Anexo anexo);
    
    }
}
