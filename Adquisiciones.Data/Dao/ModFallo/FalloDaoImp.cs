using System;
using System.Collections.Generic;
using Adquisiciones.Data.Entities;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using System.Linq;

namespace Adquisiciones.Data.Dao.ModFallo
{
    public class FalloDaoImp:GenericDaoImp<Fallo,long>,IFalloDao
    {
        public long? MaximoId()
        {
            long? result = 1;

            var query = CurrentSession.CreateQuery("select max(IdFallo) from Fallo");
           
            if (query.UniqueResult() != null)
            {
                result = (long)query.UniqueResult() + 1;
            }

            return result;
        }

        [Transaction(ReadOnly = true)]
        public IList<Fallo> FallosByAnexo(Anexo anexo)
        {
            var criteria = CurrentSession.CreateCriteria(typeof(Fallo));
            criteria.Add(Restrictions.Eq("Anexo", anexo));
            return criteria.List<Fallo>();
        }

        [Transaction(ReadOnly = true)]
        public Fallo ExisteProvCotiz(Cotizacion cotizacion, Proveedor prov)
        {
            var query = CurrentSession.GetNamedQuery("Fallo.ExisteProvCotiz");
            query.SetParameter("cotizacion", cotizacion);
            query.SetParameter("proveedor", prov);
            return query.UniqueResult<Fallo>();
        }

        [Transaction(ReadOnly = true)]
        public IList<Fallo> ConsultarFalloByAnexo(Anexo anexo)
        {
            var query = CurrentSession.GetNamedQuery("Fallo.CargarByAnexo");
            query.SetParameter("anexo", anexo);
            return query.List<Fallo>();
        }

        [Transaction(ReadOnly = true)]
        public IList<FalloDetalle> ConsultarFalloDetalle(Fallo fallo)
        {
            var query = CurrentSession.GetNamedQuery("Fallo.CargaDetalle");
            query.SetParameter("fallo", fallo);
            return query.List<FalloDetalle>();
        }

        [Transaction(ReadOnly = true)]
        public IList<Fallo> CargarFallos(int anio, Almacen almacen)
        {
            var query = CurrentSession.
              GetNamedQuery("Fallo.CargaFallos");
            query.SetParameter("anioActual", anio);
            query.SetParameter("almacen", almacen);

            var lista = query.List<Fallo>();
            return lista.GroupBy(x => x.Anexo.NumeroAnexo).Select(y => y.First()).ToList();
        }
        
        [Transaction(ReadOnly = true)]
        public IList<Fallo> CargarFallos(Almacen almacen)
        {
            return CargarFallos(FechaServidor().Year, almacen);
        }

        [Transaction]
        public void BorrarFallos(Anexo anexo)
        {
            var fallos = FallosByAnexo(anexo);
            foreach (var fallo in fallos)
                Delete(fallo);
        }

         [Transaction(ReadOnly = true)]
        public bool ExisteFalloRequisicion(Anexo anexo)
         {
             bool result = false;
            var criteria = CurrentSession.CreateCriteria(typeof(Fallo));
            criteria.Add(Restrictions.Eq("Anexo", anexo));

            if (anexo != null && anexo.IdAnexo == 0) return false;
            var fallos = criteria.List<Fallo>();
             foreach (var fallo in fallos)
             {
                 if(fallo.Estado == "R")
                 {
                     result = true;
                     break;
                 }
             }

             return result;
         }
    }
}
