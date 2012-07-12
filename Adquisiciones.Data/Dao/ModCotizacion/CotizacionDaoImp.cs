using System;
using System.Collections.Generic;
using Adquisiciones.Data.Entities;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Data.Dao.ModCotizacion
{
    public class CotizacionDaoImp : GenericDaoImp<Cotizacion, long>, ICotizacionDao
    {
        [Transaction(ReadOnly = true)]
        public Cotizacion CargarCotizacionEager(Proveedor prov, Anexo anexo, Almacen almacen)
        {
            var query = CurrentSession.GetNamedQuery("Cotizacion.CargaCotizacionByNumAnexoProvAlmacen");
            query.SetParameter("prov", prov);
            query.SetParameter("anexo", anexo);
            query.SetParameter("almacen", almacen);
            return query.UniqueResult<Cotizacion>();
        }

        [Transaction(ReadOnly = true)]
        public IList<CotizacionDetalle> CargarCotizacionDetalle(Anexo anexo, Articulo articulo,
            Almacen almacen)
        {

            var query = CurrentSession.GetNamedQuery("Cotizacion.CargaDetalleByIdAnexoArtAlmacen");
            query.SetParameter("anexo", anexo);
            query.SetParameter("almacen", almacen);
            query.SetParameter("articulo", articulo);
            return query.List<CotizacionDetalle>();
        }

        /// <summary>
        /// Cotizacion por anio en especifico
        /// </summary>
        /// <param name="anio"></param>
        /// <param name="almacen">almacen busqueda</param>
        /// <returns></returns>
        [Transaction(ReadOnly = true)]
        public IList<Cotizacion> CargarCotizaciones(int anio, Almacen almacen)
        {
            var query = CurrentSession.
                GetNamedQuery("Cotizacion.CargaCotizacion");
            query.SetParameter("anioActual", anio);
            query.SetParameter("almacen", almacen);
            return query.List<Cotizacion>();
        }

        /// <summary>
        /// Cotizaciones por anio
        /// </summary>
        /// <param name="almacen">almacen busqueda</param>
        /// <returns></returns>
        [Transaction(ReadOnly = true)]
        public IList<Cotizacion> CargarCotizaciones(Almacen almacen)
        {
            return CargarCotizaciones(FechaServidor().Year, almacen);
        }

        [Transaction(ReadOnly = true)]
        public bool ExisteAnexoFallo(Anexo anexo)
        {
            var criteria = CurrentSession.CreateCriteria(typeof(Fallo));
            criteria.Add(Restrictions.Eq("Anexo", anexo));

            if (anexo !=null && anexo.IdAnexo == 0) return false;
            var fallos = criteria.List<Fallo>();
            return fallos.Count != 0 ? true : false;
        }

        [Transaction(ReadOnly = true)]
        public long MaximoId(Almacen almacen)
        {
            long result = 1;

            result = CurrentSession.CreateCriteria(typeof(Cotizacion))
            .SetProjection(Projections.Max("IdCotizacion")).
            Add(Restrictions.Eq("Almacen", almacen)).UniqueResult<long>();

            if (result != null)++result;

            return result;
        }
    }
}
