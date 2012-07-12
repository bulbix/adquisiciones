using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Entities;

namespace Adquisiciones.Data.Dao.ModFallo
{
    public interface IFalloDetalleDao: IGenericDao<FalloDetalle,long>
    {
        long? MaximoId();
    }
}
