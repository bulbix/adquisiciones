/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;
using Adquisiciones.Data.Auxiliares;
using NHibernate.Validator.Constraints;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// PedidoDetalle object for NHibernate mapped table 'pedido_detalle'.
	/// </summary>
	[Serializable]
	public class PedidoDetalle
	{
		#region Member Variables

        protected long _idpedidodetalle;
        protected Pedido _pedido;
        protected short _renglonpedido;

		protected Articulo _articulo;
		protected string _marca;
		protected decimal? _cantidad;
		protected decimal? _preciounitario;
		//protected PedidoEntrega _pedidoentrega;
        protected IList<PedidoEntrega> _pedidoentrega = new List<PedidoEntrega>();

		#endregion
		#region Constructors
			
		public PedidoDetalle()
		
        {

		}



		#endregion
		#region Public Properties

        public virtual long IdPedidoDetalle
        {
            get { return _idpedidodetalle; }
            set { _idpedidodetalle = value; }
        }

        public virtual Pedido Pedido
        {
            get { return _pedido; }
            set { _pedido = value; }
        }
        
        public virtual short RenglonPedido
        {
            get { return _renglonpedido; }
            set { _renglonpedido = value; }
        }
        
		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
		}

        [NotNullNotEmpty(Message = ("Marca Requerido"))]
		public  virtual string Marca
		{
			get { return _marca; }
			set {_marca= value; }
		}

        [NotNull(Message = ("Cantidad Requerida"))]
		public  virtual decimal? Cantidad
		{
			get { return _cantidad; }
			set {_cantidad= value; }
		}

        [NotNull(Message = ("Precio Unitario Requerido"))]
		public  virtual decimal? PrecioUnitario
		{
			get { return _preciounitario; }
			set {_preciounitario= value; }
		}

        [Valid]
        [NotEmpty(Message = "Se requiere al menos un pedido entrega")]
        public virtual IList<PedidoEntrega> PedidoEntrega
        {
            get { return _pedidoentrega; }
            set { _pedidoentrega = value; }
        }

        #endregion

        #region propiedades intermedias de bindeo

	    [NotNull(Message = ("Clave Requerido"))]
	    public int? CveArt { get; set; }

	    public string DescripcionArt { get; set; }

        private decimal? importe;

        public decimal? Importe { 
            
            get
            {
                importe = (decimal?) 0.0;
                if(Cantidad != null && PrecioUnitario != null)
                {
                    importe = Cantidad * PrecioUnitario;
                }

                return importe;

            }
            set { importe = value; }
            }

	    #endregion
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			PedidoDetalle castObj = (PedidoDetalle)obj;
			return ( castObj != null ) &&
			this._idpedidodetalle.Equals( castObj.IdPedidoDetalle);
		}
        
        /// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			//hash = 27 * hash * _id.GetHashCode();
			return hash;
		}

		#endregion
		
	}
}
