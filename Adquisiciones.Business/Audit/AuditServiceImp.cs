using Adquisiciones.Data.Dao.Audit;
using Adquisiciones.Data.Dao.ModAnexo;

namespace Adquisiciones.Business.Audit
{
    ///<summary>
    ///</summary>
    public class AuditServiceImp : IAuditService
    {
        ///<summary>
        ///</summary>
        public IAnexoHistDao AnexoHistDao { get; set; }
        public IAnexoDetalleHistDao AnexoDetalleHistDao { get; set; }
    }
}
