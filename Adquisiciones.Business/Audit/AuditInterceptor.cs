using System;
using Adquisiciones.Data.Audit;
using Adquisiciones.Data.Entities;
using NHibernate;
using NHibernate.Type;
using Spring.Collections;
using Spring.Context.Support;
using Spring.Transaction.Interceptor;
using System.Linq;


namespace Adquisiciones.Business.Audit
{
    ///<summary>
    ///</summary>
    public class AuditInterceptor : EmptyInterceptor
    {
        private static IAuditService auditService;


        public override void OnDelete(object entity, object id, object[] state,
            string[] propertyNames, IType[] types)
        {
            auditService =
       ContextRegistry.GetContext()["auditService"] as IAuditService;

            if (entity.GetType().
            GetCustomAttributes(typeof(AuditableAttribute), false).Length > 0)
            {
                if (entity is Anexo)
                {
                    var anexoHist = Util.ConstruirHistorico<AnexoHist>(id, propertyNames, state, types, "delete");
                    auditService.AnexoHistDao.Insert(anexoHist);}
               
            }
        }


        public override bool OnFlushDirty(object entity, object id,
                            object[] currentState, object[] previousState,
                            string[] propertyNames, IType[] types)
        {
            auditService =
        ContextRegistry.GetContext()["auditService"] as IAuditService;

            if (entity.GetType().
            GetCustomAttributes(typeof(AuditableAttribute), false).Length > 0)
            {
                if (entity is Anexo)
                {
                    var anexoHist = Util.ConstruirHistorico<AnexoHist>(
                        id, propertyNames, previousState, types, "update");
                    auditService.AnexoHistDao.Insert(anexoHist);

                }}


            return base.OnFlushDirty(entity, id, currentState, previousState, propertyNames, types);
        }

    }
}
