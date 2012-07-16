using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Spring.Aop;
using Spring.Context.Support;

namespace Adquisiciones.Business.Audit
{
    public class UpdateAfterHistorico : IAfterReturningAdvice
    {   

        ///<summary>
        ///</summary>
        ///<param name="returnValue"></param>
        ///<param name="method"></param>
        ///<param name="args"></param>
        ///<param name="target"></param>
        public void AfterReturning(object returnValue, MethodInfo method, object[] args, object target)
        {
            var ctx = ContextRegistry.GetContext();
            var auditService = ctx["auditService"] as IAuditService;
            var nameService = method.Name;
            var nameHistorico = nameService.Substring(7) + "DetalleHist";

            if (auditService.IdsDetalleHistorico.ContainsKey(nameHistorico))
            {
                var historico = auditService.IdsDetalleHistorico[nameHistorico];
                auditService.ObjectDao.UpdateHistoticaHija(nameHistorico, historico.ids, historico.idPadre);
            }
        }
        
    }
}
