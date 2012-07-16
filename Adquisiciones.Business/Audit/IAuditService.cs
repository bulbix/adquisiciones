using System.Collections.Generic;
using Adquisiciones.Data.Dao;
using Adquisiciones.Data.Dao.ModAnexo;
using NHibernate.Type;

namespace Adquisiciones.Business.Audit
{
    ///<summary>
    ///</summary>
    public interface IAuditService
    {
        ///<summary>
        ///</summary>
        IObjectDao ObjectDao { get; set; }

        Dictionary<string,Historico> IdsDetalleHistorico { get; set; }

        ///<summary>
        ///</summary>
        ///<param name="entity"></param>
        ///<param name="id"></param>
        ///<param name="propertyNames"></param>
        ///<param name="previousState"></param>
        ///<param name="types"></param>
        ///<param name="tipo"></param>
        ///<typeparam name="T"></typeparam>
        ///<returns></returns>
        void ConstruirHistorico<T>(T entity, object id, string[] propertyNames,
                                     object[] previousState, IType[] types, string tipo);

    }
}
