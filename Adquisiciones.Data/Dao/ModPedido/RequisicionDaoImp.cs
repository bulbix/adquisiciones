using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Entities;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Data.Dao.ModPedido
{
    public class RequisicionDaoImp : GenericDaoImp<Requisicion, int>, IRequisicionDao
    {


        [Transaction(ReadOnly = true)]
        public IList<Requisicion> CargarRequisiciones(Almacen almacen)
        {
            var query = CurrentSession.GetNamedQuery("Requisicion.CargarRequisicionesActivasByAlmacen");
            query.SetParameter("almacen", almacen);
            return query.List<Requisicion>();

        }

        [Transaction(ReadOnly = true)]
        public RequisicionDetall ObtenerRequisicionDetalleByArticulo(Requisicion requisicion, Articulo articulo)
        {
            var criteria = CurrentSession.CreateCriteria<RequisicionDetall>();
            criteria.Add(Restrictions.Eq("Id.Requisicion", requisicion));
            criteria.Add(Restrictions.Eq("Articulo", articulo));
            return criteria.UniqueResult<RequisicionDetall>();
        }
    }
}
