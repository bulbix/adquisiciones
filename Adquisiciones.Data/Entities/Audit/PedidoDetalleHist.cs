/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;
using Adquisiciones.Data.Auxiliares;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// PedidoDetalleHis object for NHibernate mapped table 'pedido_detalle_his'.
	/// </summary>
	[Serializable]
	public class PedidoDetalleHist:IDetalle
	{
		#region Member Variables

	    private long _id;

        protected Pedido _pedido;
        protected short _renglonpedido;

	    protected Articulo _articulo;
		protected string _marca;
		protected decimal? _cantidad;
		protected decimal? _preciounitario;

        protected long _idexterno;
       
        private string _tipo;
        private long _idhist;

	    #endregion
		#region Constructors
			
		public PedidoDetalleHist() {}
		#endregion
		#region Public Properties
		
		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
		}
		public  virtual string Marca
		{
			get { return _marca; }
			set {_marca= value; }
		}
		public  virtual decimal? Cantidad
		{
			get { return _cantidad; }
			set {_cantidad= value; }
		}
		public  virtual decimal? PrecioUnitario
		{
			get { return _preciounitario; }
			set {_preciounitario= value; }
		}
	    public virtual long Id
	    {
	        get { return _id; }
	        set { _id = value; }
	    }

        public virtual long IdExterno
        {
            get { return _idexterno; }
            set { _idexterno = value; }
        }

       

        public virtual string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public virtual  Pedido Pedido
        {
            get { return _pedido; }
            set { _pedido = value; }
        }

        public virtual short RenglonPedido
        {
            get { return _renglonpedido; }
            set { _renglonpedido = value; }
        }

	    public virtual long IdHist
	    {
	        get { return _idhist; }
	        set { _idhist = value; }
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
			PedidoDetalleHist castObj = (PedidoDetalleHist)obj;
			return ( castObj != null ) &&
			this._id.Equals( castObj.Id);
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
