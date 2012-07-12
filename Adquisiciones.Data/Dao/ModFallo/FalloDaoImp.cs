﻿using System;
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
        public IList<Fallo> FallosByAnexoEager(Anexo anexo)
        {
            var query = CurrentSession.GetNamedQuery("Fallo.CargarByAnexoEager");
            query.SetParameter("anexo", anexo);
            return query.List<Fallo>();
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
        public IList<Fallo> ConsultarFalloCompleto(Anexo anexo)
        {
            var query = CurrentSession.GetNamedQuery("Fallo.CargarByAnexoCompleto");
            query.SetParameter("anexo", anexo);
            return query.List<Fallo>();
        }

        [Transaction(ReadOnly = true)]
        public IList<Fallo> CargarFallos(int anio, Almacen almacen)
        {
            var query = CurrentSession.
              GetNamedQuery("Fallo.CargaFallos");
            query.SetParameter("anioActual", anio);
            query.SetParameter("almacen", almacen);

            var lista = query.List<Fallo>();
            return lista.GroupBy(x => x.Anexo.NumeroAnexo).Select(y => y.First()).ToList();}
        [Transaction(ReadOnly = true)]
        public IList<Fallo> CargarFallos(Almacen almacen)
        {
            return CargarFallos(FechaServidor().Year, almacen);
        }
    }
}
