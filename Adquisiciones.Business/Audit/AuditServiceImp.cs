using System;
using Adquisiciones.Data.Dao;
using Adquisiciones.Data.Dao.ModAnexo;

namespace Adquisiciones.Business.Audit
{
    ///<summary>
    ///</summary>
    public class AuditServiceImp : IAuditService
    {
        ///<summary>
        ///</summary>
        public IObjectDao ObjectDao { get; set; }
    }
}
