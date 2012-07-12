using Adquisiciones.Data.Entities;

namespace Adquisiciones.Data.Dao.ModFallo
{
    public class FalloDetalleDaoImp:GenericDaoImp<FalloDetalle,long>, IFalloDetalleDao
    {
        public long? MaximoId()
        {
            long? result = 1;

            var query = CurrentSession.CreateQuery("select max(IdFalloDetalle) from FalloDetalle");

            if (query.UniqueResult() != null)
            {
                result = (long)query.UniqueResult() + 1;
            }

            return result;
        }
    }
}
