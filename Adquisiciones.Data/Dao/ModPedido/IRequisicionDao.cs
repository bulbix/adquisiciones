using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Dao.Catalogos;
using Adquisiciones.Data.Entities;

namespace Adquisiciones.Data.Dao.ModPedido
{
    public interface IRequisicionDao : IGenericDao<Requisicion, int>
    {


        IAlmacenDao AlmacenDao { get; set; }


        /// <summary>
        /// Obtiene las requsiciones activas por almacen
        /// </summary>
        /// <param name="almacen">El almacen seleccionado</param>
        /// <returns>Lista de requisiciones</returns>
        IList<Requisicion> CargarRequisiciones(Almacen almacen);
        RequisicionDetall ObtenerRequisicionDetalleByArticulo(Requisicion requisicion, Articulo articulo);
        IList<RequisicionDetall> CargarRequisicionDetalle(Requisicion requisicion);

        void ActualizarEstatusRequisicion(Requisicion requisicion, String estatus);

    }
}
