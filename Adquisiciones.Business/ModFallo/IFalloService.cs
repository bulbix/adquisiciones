using System;
using System.Collections.Generic;
using Adquisiciones.Data.Dao.Catalogos;
using Adquisiciones.Data.Dao.ModAnexo;
using Adquisiciones.Data.Dao.ModCotizacion;
using Adquisiciones.Data.Dao.ModFallo;
using Adquisiciones.Data.Entities;

namespace Adquisiciones.Business.ModFallo
{
    ///<summary>
    ///</summary>
    public interface IFalloService
    {

        ///<summary>
        ///</summary>
        IArticuloDao ArticuloDao { get; set; }       

        ///<summary>
        ///</summary>
        IAnexoDao AnexoDao {get; set; }

        ///<summary>
        ///</summary>
        ICotizacionDao CotizacionDao { get; set; }

        ///<summary>
        ///</summary>
        IFalloDao FalloDao { get; set; }

        ///<summary>
        ///</summary>
        IFalloDetalleDao FalloDetalleDao { get; set; }

        ///<summary>
        ///</summary>
        event FalloEventHandler FalloProceso;

        ///<summary>
        ///</summary>
        ///<param name="anexo"></param>
        ///<param name="fechaFallo"></param>
        ///<returns></returns>
        List<Fallo> GuardarFallo(Anexo anexo, DateTime fechaFallo);

        ///<summary>
        /// 
        ///</summary>
        ///<param name="anexo"></param>
        ///<returns></returns>
        IList<Fallo> ConsultarFallo(Anexo anexo);

    }
}
