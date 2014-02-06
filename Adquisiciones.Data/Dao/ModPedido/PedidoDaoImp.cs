using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Auxiliares;
using Adquisiciones.Data.Entities;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Mapping;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Data.Dao.ModPedido
{
    public class PedidoDaoImp : GenericDaoImp<Pedido, long>, IPedidoDao
    {
        [Transaction(ReadOnly = true)]
        public int? SiguienteNumeroPedido(Almacen almacen, int tipo)
        {
            int? result = 1;

            var query = CurrentSession.GetNamedQuery("Pedido.MaximoNumeroPedido");
            var anio = FechaServidor().Year;
            query.SetParameter("anioActual", anio);
            query.SetParameter("almacen", almacen);
            query.SetParameter("tipoPedido", tipo);

            if (query.UniqueResult() != null)
            {
                result = (int)query.UniqueResult() + 1;
            }

            return result;

        }

        [Transaction(ReadOnly = true)]
        public bool ExisteNumeroPedido(Almacen almacen, int tipo, int numPedido)
        {
            var result = false;

            var query = CurrentSession.GetNamedQuery("Pedido.ExisteNumeroPedido");
            var anio = FechaServidor().Year;
            query.SetParameter("anioActual", anio);
            query.SetParameter("almacen", almacen);
            query.SetParameter("tipoPedido", tipo);
            query.SetParameter("numPedido", numPedido);

            if (query.List().Count > 0)
            {
                result = true;
            }

            return result;

        }

        /// <summary>
        /// Revisa que los pedidos automaticos no tenga una requisicion ya asiganada
        /// </summary>
        /// <param name="requisicion"></param>
        /// <returns></returns>
        [Transaction(ReadOnly = true)]
        public bool ExisteRequisicionPedido(Requisicion requisicion)
        {
            var query = CurrentSession.GetNamedQuery("Pedido.ExisteRequisicionPedido");
            query.SetParameter("requisicion", requisicion);
            if (requisicion.IdRequisicion == 0) return false;
            var pedidos = query.List<Pedido>();
            return pedidos.Count != 0 ? true : false;
        }

        [Transaction(ReadOnly = true)]
        public bool ExisteAnexoPedido(Anexo anexo)
        {
            var query = CurrentSession.GetNamedQuery("Pedido.ExisteAnexoPedido");
            query.SetParameter("anexo", anexo);
            if (anexo.IdAnexo == 0) return false;
            var pedidos = query.List<Pedido>();
            return pedidos.Count != 0 ? true : false;
        }

        [Transaction(ReadOnly = true)]
        public bool ExisteEntradaPedido(Pedido pedido)
        {
            var query = CurrentSession.GetNamedQuery("Pedido.ExisteEntradaPedido");
            query.SetParameter("pedido", pedido);
            if (pedido.IdPedido == 0) return false;
            var entradas = query.List<Entrada>();
            return entradas.Count != 0 ? true : false;
        }

        [Transaction(ReadOnly = true)]
        public Pedido ConsultaPedido(int numPedido, DateTime fechaPedido, Almacen almacen, int tipo)
        {
            var query = CurrentSession.GetNamedQuery("Pedido.CargaPedido");
            query.SetParameter("numero", numPedido);
            var anio = fechaPedido.Year;
            query.SetParameter("anioActual", anio);
            query.SetParameter("almacen", almacen);
            query.SetParameter("tipoPedido", tipo);

            return query.UniqueResult<Pedido>();
        }

        [Transaction(ReadOnly = true)]
        public IList<PedidoDetalle> CargarPedidoDetalle(Pedido pedido)
        {
            var query = CurrentSession.
              GetNamedQuery("Pedido.CargaPedidoDetalle");
            query.SetParameter("pedido", pedido);
            return query.List<PedidoDetalle>();

        }

        [Transaction(ReadOnly = true)]
        public IList<PedidoEntrega> CargarPedidoEntrega(PedidoDetalle pedidoDetalle)
        {
            var query = CurrentSession.
              GetNamedQuery("Pedido.CargaPedidoEntrega");
            query.SetParameter("pedidoDetalle", pedidoDetalle);
            return query.List<PedidoEntrega>();

        }

        [Transaction(ReadOnly = true)]
        public IList<Pedido> CargarPedidos(Almacen almacen, object fechaInicial,
            object fechaFinal, int numeroInicial, int numeroFinal, int[] tipos, Proveedor proveedor = null)
        {

            var strquery =
                @"from Pedido p
                          left join fetch p.Fundamento
                          left join fetch p.TipoProcedimiento
                          left join fetch p.CatArea
                          left join fetch p.CatPresupuesto 
                          left join fetch p.CatActividad       
                          left join fetch p.CatTipopedido 
                          left join fetch p.Proveedor 
                          left join fetch p.Anexo 
                          left join fetch p.Requisicion 
                          left join fetch p.Usuario 
                          where p.Almacen = :almacen  
                          {0}
                          {1} 
                          {2}
                          {3}
                          order by p.NumeroPedido desc, p.FechaPedido desc";

            string rangoFecha = "", rangoNumero = "", rangoTipo = "", proveedorCondition = "";

            if (fechaInicial != null && fechaFinal != null)
                rangoFecha = " and p.FechaPedido between :fInicial and :fFinal ";

            if (numeroInicial != 0 && numeroFinal != 0)
                rangoNumero = string.Format(" and p.NumeroPedido between {0} and {1} ", numeroInicial, numeroFinal);

            if (tipos.Length > 0)
                rangoTipo = string.Format(" and p.CatTipopedido.IdTipoped in ({0}) ", String.Join(",", tipos));

            if (proveedor != null)
                proveedorCondition = " and p.Proveedor = :proveedor ";

            strquery = string.Format(strquery, rangoFecha, rangoNumero, rangoTipo, proveedorCondition);

            var query = CurrentSession.CreateQuery(strquery);

            query.SetParameter("almacen", almacen);

            if (fechaInicial != null && fechaFinal != null)
            {
                query.SetParameter("fInicial", fechaInicial);
                query.SetParameter("fFinal", fechaFinal);
            }

            if (proveedor != null)
            {
                query.SetParameter("proveedor", proveedor);
            }


            return query.List<Pedido>();
        }

        [Transaction(ReadOnly = true)]
        public IList<Entrada> CargarEntradas(Pedido pedido)
        {
            var criteria = CurrentSession.CreateCriteria(typeof(Entrada));
            criteria.Add(Restrictions.Eq("Pedido", pedido));
            criteria.Add(Restrictions.Not(Restrictions.Eq("EstadoEntrada", "C")));
            criteria.SetFetchMode("EntradaDetalle", FetchMode.Lazy);
            return criteria.List<Entrada>();
        }

        [Transaction(ReadOnly = true)]
        public String[] CargarPartidaAlmacen(Pedido pedido)
        {
            var result = new String[] { "", "" };

            const string queryNativo = @"SELECT FIRST 1 cve_art,id_almacen FROM pedido_detalle WHERE id_pedido = :idpedido";
            var query = CurrentSession.CreateSQLQuery(queryNativo);
            query.SetParameter("idpedido", pedido.IdPedido);
            var claveAlmacen = query.UniqueResult<Object[]>();


            switch (claveAlmacen[1].ToString().Trim()[0])//Tomamos el primer caracter
            {
                case 'F':
                    result[0] = "FARMACIA";
                    break;
                case 'G':
                    result[0] = "GENERAL";
                    break;
                case 'P':
                    result[0] = "PROTESIS";
                    break;
            }

            const string strQuery = "SELECT partida FROM articulo_partida WHERE cve_art = :articulo and id_almacen = :almacen";
            var criteria = CurrentSession.CreateSQLQuery(strQuery);
            criteria.SetParameter("articulo", (int)claveAlmacen[0]);
            criteria.SetParameter("almacen", claveAlmacen[1].ToString());
            var partida = criteria.UniqueResult<string>();

            result[1] = partida;

            return result;
        }

        [Transaction(ReadOnly = true)]
        public decimal ImporteEntrada(Entrada entrada)
        {
            var strQuery = @"select sum(ed.PrecioEntrada * ed.Cantidad) 
            from EntradaDetalle ed where ed.Entrada = :entrada and ed.Entrada.EstadoEntrada <> 'C'";

            var query = CurrentSession.CreateQuery(strQuery);
            query.SetParameter("entrada", entrada);

            var suma = (decimal)query.UniqueResult();
            return suma;
        }

        [Transaction(ReadOnly = true)]
        public decimal ImporteEntradaSinIva(Entrada entrada)
        {
            var strQuery = @"select ed from EntradaDetalle ed 
            join fetch ed.Entrada e 
            join fetch e.Pedido p 
            where ed.Entrada = :entrada 
            and ed.Entrada.EstadoEntrada <> 'C'";
            var query = CurrentSession.CreateQuery(strQuery);
            query.SetParameter("entrada", entrada);
            var entradaDetalle = (List<EntradaDetalle>)query.List<EntradaDetalle>();
            var suma = (decimal)0.0;

            foreach (var detalle in entradaDetalle)
            {
                var criteria = CurrentSession.CreateCriteria(typeof(PedidoDetalle));
                criteria.Add(Restrictions.Eq("Pedido", detalle.Entrada.Pedido));
                criteria.Add(Restrictions.Eq("Articulo", detalle.Articulo));
                var pedidoDetalle = criteria.UniqueResult<PedidoDetalle>();
                suma += detalle.Cantidad.Value * pedidoDetalle.PrecioUnitario.Value;
            }

            return suma;
        }

        [Transaction(ReadOnly = true)]
        public decimal ImporteEntradas(Pedido pedido)
        {
            decimal total = 0;
            var criteria = CurrentSession.CreateCriteria(typeof(Entrada));
            criteria.Add(Restrictions.Eq("Pedido", pedido));
            criteria.SetFetchMode("EntradaDetalle", FetchMode.Lazy);
            criteria.Add(Restrictions.Not(Restrictions.Eq("EstadoEntrada", "C")));
            var entradas = criteria.List<Entrada>();

            foreach (var entrada in entradas)
            {
                total += ImporteEntrada(entrada);
            }

            return total;
        }

        [Transaction]
        public void CancelarPedido(Pedido pedido)
        {
            pedido.EstadoPedido = "C";
            CurrentSession.Update(pedido);
        }

        [Transaction(ReadOnly = true)]
        public IList<Entrada> CargarEntradas(DateTime fechaInicial, DateTime fechaFinal)
        {
            var criteria = CurrentSession.CreateCriteria(typeof(Entrada));
            criteria.Add(Restrictions.Between("FechaEntrada", fechaInicial, fechaFinal));
            criteria.SetFetchMode("EntradaDetalle", FetchMode.Lazy);
            criteria.Add(Restrictions.Not(Restrictions.Eq("EstadoEntrada", "C")));
            return criteria.List<Entrada>();

        }

        [Transaction(ReadOnly = true)]
        public IList<Pedido> CargarPedidos(Entrada entrada, CatTipopedido tipopedido, Ordenado ordenado)
        {
            var strquery =
            @" select p from Pedido p 
                join p.Entradas e 
                join fetch p.Proveedor 
                join fetch p.Usuario 
                join fetch p.CatArea 
                join fetch p.Fundamento
                join fetch p.CatTipopedido  
                where e.IdEntrada = :idEntrada 
                and p.CatTipopedido = :tipoPedido 
                and p.EstadoPedido <> 'C'";

            switch (ordenado)
            {
                case Ordenado.Proveedor:
                    strquery += " order by p.Proveedor";
                    break;
                case Ordenado.Pedido:
                    strquery += " order by p.IdPedido";
                    break;
            }

            var query = CurrentSession.CreateQuery(strquery);
            query.SetParameter("idEntrada", entrada.IdEntrada);
            query.SetParameter("tipoPedido", tipopedido);
            var pedidos = query.List<Pedido>();
            return pedidos;
        }

        [Transaction(ReadOnly = true)]
        public IList<string> CatalogoTipoProcedimiento(string bloque, CatTipopedido tipoPedido, string condicionColumn = null, string condicionValor = null)
        {
            var criteria = CurrentSession.CreateCriteria(typeof(CatTipoprocedimiento));
            criteria.SetProjection(Projections.Distinct(Projections.Property(bloque)));

            if (condicionColumn != null && condicionValor != null)
            {
                criteria.Add(Restrictions.Eq(condicionColumn, condicionValor));
            }

            if (tipoPedido.IdTipoped == 1)
            { //Pedido Mayor
                criteria.Add(Restrictions.Eq("Mayor", true));
            }
            else if (tipoPedido.IdTipoped == 2)
            { //Pedido Menor
                criteria.Add(Restrictions.Eq("Menor", true));
            }


            //criteria.AddOrder(Order.Asc("Id"));

            return criteria.List<string>();
        }

        [Transaction(ReadOnly = true)]
        public CatTipoprocedimiento CatTipoprocedimientoByBloques(string[] bloquesNombre, object[] bloquesValor)
        {
            CatTipoprocedimiento result = null;

            var criteria = CurrentSession.CreateCriteria(typeof(CatTipoprocedimiento));

            for (var index = 0; index < bloquesNombre.Length; index++)
            {
                if (bloquesValor[index] != null)
                    criteria.Add(Restrictions.Eq(bloquesNombre[index], bloquesValor[index]));
                else
                    criteria.Add(Restrictions.IsNull(bloquesNombre[index]));
            }

            if (criteria.UniqueResult() != null)
            {
                result = criteria.UniqueResult<CatTipoprocedimiento>();
            }

            return result;

        }

        [Transaction(ReadOnly = true)]
        public string PedidoOneDetalleDescripcion(Pedido pedido)
        {
            const string queryNativo = @"SELECT a.des_articulo[1,50] 
            FROM pedido_detalle pd, articulo a 
            WHERE a.cve_art = pd.cve_art AND a.id_almacen = pd.id_almacen AND id_pedido = :idpedido 
            AND pd.renglon_pedido = 1";

            var query = CurrentSession.CreateSQLQuery(queryNativo);
            query.SetParameter("idpedido", pedido.IdPedido);
            var descripcion = query.UniqueResult<string>();
            return descripcion;
        }

        [Transaction(ReadOnly = true)]
        public IList<PrecioBusqueda> CargarPrecios(int clave, Almacen almacen)
        {
            var query = CurrentSession.CreateQuery(@"
            select new PrecioBusqueda(pd.Articulo,p.FechaPedido,p.NumeroPedido,p.CatTipopedido,
            pd.PrecioUnitario,pd.Marca,p.Proveedor) 
            from PedidoDetalle pd 
            join pd.Pedido p             
            join pd.Articulo a              
            where a.Id.CveArt = :clave 
            and p.Almacen = :almacen 
            order by p.FechaPedido desc");
            query.SetParameter("clave", clave);
            query.SetParameter("almacen", almacen);

            return query.List<PrecioBusqueda>();


        }
    }
}
