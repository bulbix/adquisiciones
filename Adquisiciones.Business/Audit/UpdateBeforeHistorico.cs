using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Spring.Aop;
using Spring.Context.Support;

namespace Adquisiciones.Business.Audit
{
    public class UpdateBeforeHistorico : IMethodBeforeAdvice
    {
        public void Before(MethodInfo method, object[] args, object target)
        {
            var ctx = ContextRegistry.GetContext();
            var auditService = ctx["auditService"] as IAuditService;
            var nameService = method.Name;
            var nameHistorico = nameService.Substring(7) + "DetalleHist";

            if (auditService.IdsDetalleHistorico.ContainsKey(nameHistorico))
                auditService.IdsDetalleHistorico[nameHistorico] = new Historico();
            else
                auditService.IdsDetalleHistorico.Add(nameHistorico,new Historico());
        }
    }
}
