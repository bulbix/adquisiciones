using System;
using System.Collections.Generic;
using System.Reflection;
using Adquisiciones.Data.Auxiliares;
using Adquisiciones.Data.Dao;
using Adquisiciones.Data.Dao.ModAnexo;
using NHibernate.Type;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Business.Audit
{
    ///<summary>
    ///</summary>
    public class AuditServiceImp : IAuditService
    {
        ///<summary>
        ///</summary>
        public IObjectDao ObjectDao { get; set; }

        public Dictionary<string,Historico> IdsDetalleHistorico { get; set; }

        public AuditServiceImp()
        {
            IdsDetalleHistorico = new Dictionary<string, Historico>();
        }

        /// <summary>
        /// COnstruye historico por reflexion
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="id"></param>
        /// <param name="propertyNames"></param>
        /// <param name="previousState"></param>
        /// <param name="types"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        [Transaction]
        public void ConstruirHistorico<T>(T entity, object id, string[] propertyNames, 
            object[] previousState,
            IType[] types, string tipo)
        {
            var nombreTabla = entity.GetType().Name; //AnexoDetalle

            if (nombreTabla.IndexOf("Hist") < 0)
            {
                var tableHist = "Adquisiciones.Data.Entities." + nombreTabla + "Hist";
                var a = Assembly.LoadWithPartialName("Adquisiciones.Data");
                var histType = a.GetType(tableHist); //Type AnexoDetalleHist
                var result = Activator.CreateInstance(histType); // new AnexoDetalleHist

                var index = 0;

                var idExterno = long.Parse(id.ToString());

                foreach (string propiedad in propertyNames)
                {
                    if (!types[index].IsCollectionType)
                    {histType.GetProperty(propiedad).SetValue(result, previousState[index], null);
                    }

                    ++index;
                }

                histType.GetProperty("IdExterno").SetValue(result, idExterno, null);
                histType.GetProperty("Tipo").SetValue(result, tipo, null);
               
                var idHist = ObjectDao.Insert(result);

                if(entity is IPadre)
                {
                    var nombreTablaHijaHist = nombreTabla + "DetalleHist";//AnexoDetalleHist

                    if(IdsDetalleHistorico.ContainsKey(nombreTablaHijaHist))
                    {
                        var historico = IdsDetalleHistorico[nombreTablaHijaHist];
                        historico.idPadre = idHist;
                        IdsDetalleHistorico[nombreTablaHijaHist] = historico;
                    }
                    else{ 
                        var historic = new Historico();
                        historic.idPadre = idHist;
                        IdsDetalleHistorico.Add(nombreTablaHijaHist, historic);
                    }
                 }


                if (entity is IDetalle)
                {
                    var tablaHist = nombreTabla + "Hist";
                    if (IdsDetalleHistorico.ContainsKey(tablaHist))
                    {
                       var historico = IdsDetalleHistorico[tablaHist];
                        historico.ids.Add(idHist);
                        IdsDetalleHistorico[tablaHist] = historico;
                    }
                    else
                    {var historic = new Historico();
                        historic.ids.Add(idHist);
                        IdsDetalleHistorico.Add(tablaHist, historic);
                    }
                }

                   


            }

        }
    }
}
