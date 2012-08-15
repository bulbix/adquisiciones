using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Adquisiciones.Data;
using Adquisiciones.Data.Auxiliares;
using Adquisiciones.Data.Dao.Catalogos;
using Adquisiciones.Data.Dao.ModAnexo;
using Adquisiciones.Data.Dao.ModCotizacion;
using Adquisiciones.Data.Dao.ModFallo;
using Adquisiciones.Data.Entities;
using log4net;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Business.ModFallo
{
    public class FalloServiceImp : IFalloService,IFormBusqueda
    {public event FalloEventHandler FalloProceso;

        public IArticuloDao ArticuloDao { get; set; }

        public IAnexoDao AnexoDao { get; set; }

        public IFalloDao FalloDao { get; set; }

        public IFalloDetalleDao FalloDetalleDao { get; set; }

        public ICotizacionDao CotizacionDao { get; set; }

        /// <summary>
        /// Solo se ejecuta una vez con el precio mas bajo
        /// La persistencia se hace por separado entre padres y hijos 
        /// ya que pueden haber mas de dos renglones en el fallo 
        /// con sus respectivos hijos
        /// </summary>
        /// <param name="anexo"></param>
        /// <param name="fechaFallo"></param>
        /// <returns></returns>
        [Transaction]
        public List<Fallo> GuardarFallo(Anexo anexo, DateTime fechaFallo)
        {
            var result = new List<Fallo>();

            var anexosDetalle = AnexoDao.CargarAnexoDetalle(anexo);

            //Borramos en cascada padre con sus hijos
            //var fallos = FalloDao.FallosByAnexo(anexo);
            //foreach (var fallo in fallos)
            //    FalloDao.Delete(fallo);

            double index = 1.0;

            foreach (var anexoDetalle in anexosDetalle)
            {
                //Evento
                var porcentaje = (int)((index++ / anexosDetalle.Count) * 100.0);
                OnFalloProceso(new FalloProcesoEvento(porcentaje));

                var cotizacionesDetalle =
                    CotizacionDao.CargarCotizacionDetalle(anexo,
                    anexoDetalle.Articulo,
                    anexo.Almacen);


                if (cotizacionesDetalle.Count == 0)
                    continue;

                var cotizacionDetalle = cotizacionesDetalle[0];


                var falloFound =
                    FalloDao.ExisteProvCotiz(cotizacionDetalle.Cotizacion,
                    cotizacionDetalle.Cotizacion.Proveedor);

                var fechaActual = FalloDao.FechaServidor();

                Fallo falloActual = null;

                if (falloFound == null)
                {
                    falloActual = new Fallo
                                      {
                        IdFallo = FalloDao.MaximoId().Value,
                        Anexo = anexo,
                        Cotizacion = cotizacionDetalle.Cotizacion,
                        Proveedor = cotizacionDetalle.Cotizacion.Proveedor,
                        Estado = "A",
                        Usuario = anexo.Usuario,
                        Almacen = anexo.Almacen,
                        FechaFallo = fechaFallo,
                        FechaModificacion = fechaActual,
                        IpTerminal = Util.IpTerminal(),
                        Modificacion = 0
                    };

                    FalloDao.Insert(falloActual);

                }
                else
                    falloActual = falloFound;

                falloActual.FalloDetalle = new List<FalloDetalle>();
                result.Add(falloActual);

                var minCantidad =
                    double.Parse(anexoDetalle.Cantidad.ToString()) * 0.40;

                //var id = new FalloDetalleId(falloActual, cotizacionDetalle.Id.RenglonAnexo);

                var falloDetalle = new FalloDetalle()
                {
                    IdFalloDetalle = FalloDetalleDao.MaximoId().Value,Fallo = falloActual,
                    RenglonAnexo = cotizacionDetalle.RenglonAnexo,
                    CantidadMax = anexoDetalle.Cantidad,
                    CantidadMin = decimal.Parse(minCantidad.ToString()),
                    CantidadPed = 0,
                    PrecioFallo = cotizacionDetalle.Precio,
                    Articulo = cotizacionDetalle.Articulo
                };

                FalloDetalleDao.Insert(falloDetalle);

                falloActual.FalloDetalle.Add(falloDetalle);

            }

            return result;
        }

        /// <summary>
        /// Delegamos la consulta del fallo </summary>
        /// <param name="anexo"></param>
        /// <returns></returns>
        [Transaction(ReadOnly = true)]
        public IList<Fallo> ConsultarFallo(Anexo anexo)
        {
            return FalloDao.ConsultarFalloCompleto(anexo);
        }

        /// <summary> Para delegar el porcentaje en la vista
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnFalloProceso(FalloProcesoEvento e)
        {
            if (FalloProceso != null)
            {
                FalloProceso(this, e);

            }
        }

         [Transaction(ReadOnly = true)]
        public object ConsultarEntityAll(Almacen almacen)
         {
             return FalloDao.CargarFallos(almacen);}

         [Transaction]
        public void EliminarEntity(object entity, string nombreEntity)
        {
            FalloDao.BorrarFallos((entity as Fallo).Anexo);
        }
    }
}
