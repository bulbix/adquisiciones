using System.Collections.Generic;
using Adquisiciones.Data.Dao.ModAnexo;
using Adquisiciones.Data.Dao.Catalogos;
using System.Windows.Forms;
using Adquisiciones.Data.Entities;
using Adquisiciones.Data.Dao.ModCotizacion;

namespace Adquisiciones.Business.ModCotizacion
{
    ///<summary>
    ///</summary>
    public interface ICotizacionService
    {

        ///<summary>
        ///</summary>
        ICotizacionDao CotizacionDao { get; set; }

        ///<summary>
        ///</summary>
        IAnexoDao AnexoDao{ get; set; }
        
        ///<summary>
        ///</summary>
        IArticuloDao ArticuloDao { get; set; }

        ///<summary>
        ///</summary>
        IProveedorDao ProveedorDao { get; set; }       

        ///<summary>
        ///</summary>
        ///<param name="combo"></param>
        ///<param name="anio"></param>
        ///<param name="idAlmacen"></param>
        void Anexos(ComboBox combo, int anio, Almacen almacen);


        ///<summary>
        ///</summary>
        ///<param name="cotizacion"></param>
        void ConsultaCotizacion(ref Cotizacion cotizacion);

        ///<summary>
        ///</summary>
        ///<param name="cotizacion"></param><returns></returns>
        void GuardaCotizacion(ref Cotizacion cotizacion);

        bool ExisteCotizacionDetalle(IList<CotizacionDetalle> detalle);

    }
}
