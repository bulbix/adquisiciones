using Adquisiciones.Data.Dao.Audit;
using Adquisiciones.Data.Dao.ModAnexo;

namespace Adquisiciones.Business.Audit
{
    ///<summary>
    ///</summary>
    public interface IAuditService
    {
        ///<summary>
        ///</summary>
        IAnexoHistDao AnexoHistDao { get; set; }
        ///<summary>
        ///</summary>
        IAnexoDetalleHistDao AnexoDetalleHistDao { get; set; }
    }
}
