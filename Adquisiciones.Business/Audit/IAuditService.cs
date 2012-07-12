using Adquisiciones.Data.Dao;
using Adquisiciones.Data.Dao.ModAnexo;

namespace Adquisiciones.Business.Audit
{
    ///<summary>
    ///</summary>
    public interface IAuditService
    {
        ///<summary>
        ///</summary>
        IObjectDao ObjectDao { get; set; }
        
    }
}
