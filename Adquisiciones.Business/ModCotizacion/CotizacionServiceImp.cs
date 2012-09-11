using System;
using System.Collections.Generic;
using System.Linq;
using Adquisiciones.Data;
using Adquisiciones.Data.Dao.ModAnexo;
using Adquisiciones.Data.Dao.Catalogos;
using System.Windows.Forms;
using Adquisiciones.Data.Entities;
using Spring.Transaction.Interceptor;
using Adquisiciones.Data.Dao.ModCotizacion;

namespace Adquisiciones.Business.ModCotizacion
{
    ///<summary>
    ///</summary>
    public class CotizacionServiceImp : ICotizacionService,IFormBusqueda
    {
        ///<summary>
        ///</summary>
        public ICotizacionDao CotizacionDao { get; set; }

        ///<summary>
        ///</summary>
        public IProveedorDao ProveedorDao { get; set; }

        ///<summary>
        ///</summary>
        public IAnexoDao AnexoDao { get; set; }

        ///<summary>
        ///</summary>
        public IArticuloDao ArticuloDao { get; set; }

        ///<summary>
        ///</summary>
        ///<param name="combo"></param>
        ///<param name="anio"></param>
        ///<param name="idAlmacen"></param>
        [Transaction(ReadOnly = true)]
        public void Anexos(ComboBox combo, int anio, Almacen almacen)
        {
            var listAnexo = AnexoDao.CargarAnexos(anio, almacen);

            var dicc = listAnexo.ToDictionary(anexo => anexo, anexo => anexo.NumeroAnexo);

            Util.Dicc2Combo<Anexo, string>(dicc, combo);
        }

        ///<summary>
        ///</summary>
        ///<param name="cotizacion"></param>
        [Transaction(ReadOnly = true)]
        public void ConsultarCotizacion(ref Cotizacion cotizacion)
        {
            var cargaCotizacion = CotizacionDao.CargarCotizacionEager
                (cotizacion.Proveedor, cotizacion.Anexo,
                cotizacion.Almacen);

            if (cargaCotizacion != null)
                cotizacion = cargaCotizacion;
            else
                cotizacion.IdCotizacion = CotizacionDao.MaximoId(cotizacion.Almacen);

            //Traemos los anexosdetalle 
            cotizacion.Anexo.AnexoDetalle = AnexoDao.CargarAnexoDetalle(cotizacion.Anexo);

            int indexCotizacion = 0;

            //Caragamos todos los anexos en la lista cotizacion detalle
            foreach (var anexoDetalle in cotizacion.Anexo.AnexoDetalle)
            {
                int existeCotizacionDetalle =
                    cotizacion.CotizacionDetalle.Count(p => p.RenglonAnexo ==
                        anexoDetalle.RenglonAnexo);

                CotizacionDetalle cotizacionDetalle;

                //No Existe la CotizacionDetalle en el AnexoDetalle
                if (existeCotizacionDetalle == 0)
                {
                    cotizacionDetalle = new CotizacionDetalle();
                    cotizacionDetalle.Cotizacion = cotizacion;
                    //cotizacionDetalle.RenglonAnexo = anexoDetalle.RenglonAnexo;
                    cotizacionDetalle.Articulo = anexoDetalle.Articulo;                    
                }
                else
                {
                    cotizacionDetalle = cotizacion.CotizacionDetalle[indexCotizacion++];
                }

                //Pintamos las propiedades de despliegue
                cotizacionDetalle.Cantidad = anexoDetalle.CantidadMinimo;
                cotizacionDetalle.RenglonAnexo = anexoDetalle.RenglonAnexo;
                cotizacionDetalle.CveArt = anexoDetalle.Articulo.Id.CveArt;
                cotizacionDetalle.DescripcionArt = anexoDetalle.Articulo.DesArticulo;
                cotizacionDetalle.PresentacionArt = anexoDetalle.Articulo.Presentacion;

                if (existeCotizacionDetalle == 0)
                    cotizacion.CotizacionDetalle.Add(cotizacionDetalle);
            }

            //Ordenamos la lista por renglon 
            cotizacion.CotizacionDetalle = 
                cotizacion.CotizacionDetalle.OrderBy(f => f.RenglonAnexo).ToList();
        }

        ///<summary>
        ///</summary>
        ///<param name="cotizacion"></param>
        ///<returns></returns>
        [Transaction]
        public void GuardarCotizacion(ref Cotizacion cotizacion)
        {
            cotizacion.FechaCaptura = CotizacionDao.FechaServidor();
            cotizacion.FechaModificacion = CotizacionDao.FechaServidor();
            cotizacion.IpTerminal = Util.IpTerminal();
            
            //Removemos de la cotizacion detalle las que no tengan precio centinela
            cotizacion.CotizacionDetalle = cotizacion.CotizacionDetalle.
                Where(cotizacionDetalle => cotizacionDetalle.Precio != null).ToList();
            ++cotizacion.Modificacion;
            cotizacion = CotizacionDao.Merge(cotizacion);
        }

        public bool ExisteCotizacionDetalle(IList<CotizacionDetalle> detalle)
        {
            var result = false;
            var numP= detalle.Count(p => p.Precio != null);
            //var numM = detalle.Count(p => p.Marca == null);
            //var numO = detalle.Count(p => p.Observaciones == null);

            if(numP !=0)result = true;

            return result;

        }

         [Transaction(ReadOnly = true)]
        public object ConsultarEntityAll(Almacen almacen)
         {
             return CotizacionDao.CargarCotizaciones(almacen);
         }

         [Transaction]
        public void EliminarEntity(object entity, string nombreEntity)
        {
            CotizacionDao.Delete(entity as Cotizacion);
        }
    }
}
