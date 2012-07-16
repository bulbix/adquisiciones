using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adquisiciones.Data.Dao
{
    public interface IObjectDao : IGenericDao<object,long>
    {

        long GetIdHistorico(String nombreTablaPadreHist, long idPadre);
        void UpdateHistoticaHija(string nombreTablaHijaHist, List<long> listaids, long idHist);

    }
}
