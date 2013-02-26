using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Business.ModAnexo;
using Adquisiciones.Data.Dao.Catalogos;
using Adquisiciones.Data.Dao.ModAnexo;
using Adquisiciones.Data.Dao.ModFallo;
using Adquisiciones.Data.Dao.ModPedido;
using Adquisiciones.Data.Dao.Seguridad;
using System.Windows.Forms;
using Adquisiciones.Data.Entities;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Business.ModPedido
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPedidoService
    {

        ///<summary>
        ///</summary>
        IRequisicionDao RequisicionDao { get; set; }

        /// <summary>
        /// </summary>
        IAnexoDao AnexoDao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IFalloDao FalloDao { get; set; }

        
        ///<summary>
        ///</summary>
        IPedidoDetalleDao PedidoDetalleDao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IPedidoDao PedidoDao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IPedidoEntregaDao PedidoEntregaDao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IFalloDetalleDao FalloDetalleDao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        IAnexoService AnexoService { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="combo"></param>
        void CatalogoPresupuestal(ComboBox combo);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="combo"></param>
        void CatalogoActividad(ComboBox combo);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pedido"></param>
        /// <param name="requisicion"></param>
        /// <param name="fechaInicial"></param>
        /// <param name="fechaFinal"></param>
        /// Regresa true si encontro fallo
        void GenerarPedidoAutomatico(Pedido pedido, 
            Requisicion requisicion, DateTime fechaInicial, DateTime fechaFinal);


        bool TieneFalloRequisicion(Requisicion requisicion);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pedido"></param>
        /// <param name="importeTotal"></param>
        void GuardarPedido(ref Pedido pedido, decimal importeTotal);


        /// <summary>
        /// Consulta el pedido en base el id solicitado
        /// </summary>
        Pedido ConsultarPedido(int numPedido, Almacen almacen);

        /// <summary>
        /// Carga un pedidodetalle apartir del anexodetalle
        /// </summary>
        /// <param name="anexo"></param>
        /// <returns></returns>
        List<PedidoDetalle> CargarPedidoDetalle(Anexo anexo);

    }
}
