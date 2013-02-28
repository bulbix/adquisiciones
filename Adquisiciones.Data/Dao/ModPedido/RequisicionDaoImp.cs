using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Dao.Catalogos;
using Adquisiciones.Data.Entities;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Data.Dao.ModPedido
{
    public class RequisicionDaoImp : GenericDaoImp<Requisicion, int>, IRequisicionDao
    {

        public IAlmacenDao AlmacenDao { get; set; }
        
        [Transaction(ReadOnly = true)]
        public IList<Requisicion> CargarRequisiciones(Almacen almacen)
        {
            var query = CurrentSession.GetNamedQuery("Requisicion.CargarRequisicionesActivasByAlmacen");
            var almacenes = AlmacenDao.getAlmacenes(almacen);
            query.SetParameterList("almacenes", almacenes.ToList());

            var fecha = FechaServidor().Year;
            query.SetParameter("anioActual", fecha);
            var requisiciones = query.List<Requisicion>();
            return requisiciones;

        }

        [Transaction(ReadOnly = true)]
        public RequisicionDetall ObtenerRequisicionDetalleByArticulo(Requisicion requisicion, Articulo articulo)
        {
            var criteria = CurrentSession.CreateCriteria<RequisicionDetall>();
            criteria.Add(Restrictions.Eq("Id.Requisicion", requisicion));
            criteria.Add(Restrictions.Eq("Articulo", articulo));
            return criteria.UniqueResult<RequisicionDetall>();
        }

        [Transaction(ReadOnly = true)]
        public IList<RequisicionDetall> CargarRequisicionDetalle(Requisicion requisicion)
        {
            var criteria = CurrentSession.CreateCriteria<RequisicionDetall>();
            criteria.Add(Restrictions.Eq("Id.Requisicion", requisicion));
            return criteria.List<RequisicionDetall>();
        }

        [Transaction]
        public void ActualizarEstatusRequisicion(Requisicion requisicion, string estatus)
        {
            requisicion.Estatus = estatus;
            Update(requisicion);
        }
    }
}
