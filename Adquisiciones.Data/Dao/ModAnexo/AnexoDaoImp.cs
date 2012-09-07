using System;
using System.Collections.Generic;
using Adquisiciones.Data.Auxiliares;
using Adquisiciones.Data.Entities;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Data.Dao.ModAnexo
{
    public class AnexoDaoImp : GenericDaoImp<Anexo, long>, IAnexoDao
    {
        /// <summary>
        /// Regresa un anexo en modo ansioso
        /// </summary>
        /// <param name="numAnexo" />
        /// <param name="almacen"></param>
        /// <returns></returns>
        [Transaction(ReadOnly = true)]
        public Anexo ConsultaAnexo(string numAnexo, Almacen almacen)
        {
            var query = CurrentSession.GetNamedQuery("Anexo.CargaAnexo");
            query.SetParameter("numero", numAnexo);
            var fecha = FechaServidor().Year;
            query.SetParameter("anioActual", fecha);
            query.SetParameter("almacen", almacen);
            return query.UniqueResult<Anexo>();
        }

        [Transaction(ReadOnly = true)]
        public bool ExisteAnexo(string numAnexo, Almacen almacen)
        {
            var query = CurrentSession.GetNamedQuery("Anexo.ExisteAnexo");
            query.SetParameter("numero", numAnexo);
            query.SetParameter("anioActual", FechaServidor().Year);
            query.SetParameter("almacen", almacen);
            var anexo = query.UniqueResult<Anexo>();
            return anexo == null ? false : true;
        }

        [Transaction(ReadOnly = true)]
        public IList<Anexo> CargarAnexos(int anio, Almacen almacen)
        {
            var query = CurrentSession.
               GetNamedQuery("Anexo.CargaAnexos");
            query.SetParameter("anioActual", anio);
            query.SetParameter("almacen", almacen);
            return query.List<Anexo>();
        }

         [Transaction(ReadOnly = true)]
        public IList<Anexo> CargarAnexos(Almacen almacen)
        {
             return CargarAnexos(FechaServidor().Year, almacen);
        }

        [Transaction(ReadOnly = true)]
        public IList<Anexo> CargarAnexosWithCotizacion(int anio, Almacen almacen)
        {
            var query = CurrentSession.
              GetNamedQuery("Anexo.CargaAnexosWithCotizacion");
            query.SetParameter("anioActual", anio);
            query.SetParameter("almacen", almacen);
            return query.List<Anexo>();
        }

        [Transaction(ReadOnly = true)]
        public IList<Anexo> CargarAnexosWithCotizacion(Almacen almacen)
        {
            return CargarAnexosWithCotizacion(FechaServidor().Year, almacen);
        }


        [Transaction(ReadOnly = true)]
        public IList<Anexo> CargarAnexosWithFallo(Almacen almacen)
        {
            var query = CurrentSession.
              GetNamedQuery("Anexo.CargaAnexosWithFallo");
            query.SetParameter("anioActual", FechaServidor().Year);
            query.SetParameter("almacen", almacen);
            return query.List<Anexo>();
        }

        [Transaction(ReadOnly = true)]
        public IList<AnexoDetalle> CargarAnexoDetalle(Anexo anexo)
        {
            var query = CurrentSession.
                GetNamedQuery("Anexo.CargaDetalle");
            query.SetParameter("anexo", anexo);
            return query.List<AnexoDetalle>();
        }

        [Transaction(ReadOnly = true)]
        public bool ExisteAnexoCotizacion(Anexo anexo)
        {
            var criteria = CurrentSession.CreateCriteria(typeof(Cotizacion));
            criteria.Add(Restrictions.Eq("Anexo", anexo));

            if (anexo != null && anexo.IdAnexo == 0) return false;
            var cotizaciones = criteria.List<Cotizacion>();
            return cotizaciones.Count != 0 ? true : false;

        }

        [Transaction(ReadOnly = true)]
        public bool ExisteAnexoPedido(Anexo anexo)
        {
            var criteria = CurrentSession.CreateCriteria(typeof(Pedido));
            criteria.Add(Restrictions.Eq("Anexo", anexo));

            if (anexo != null && anexo.IdAnexo == 0) return false;
            var pedidos = criteria.List<Pedido>();
            return pedidos.Count != 0 ? true : false;
        }
    }
}