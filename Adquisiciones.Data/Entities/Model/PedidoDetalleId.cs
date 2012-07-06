/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// PedidoDetalleId object for NHibernate mapped table 'pedido_detalle'.
	/// </summary>
	[Serializable]
	public class PedidoDetalleId
	{
		#region Member Variables
		protected Pedido _pedido;
		protected short _renglonpedido;
		#endregion
		#region Constructors
			
		public PedidoDetalleId() {}
					
		public PedidoDetalleId(Pedido pedido, short renglonpedido) 
		{
			this._pedido= pedido;
			this._renglonpedido= renglonpedido;
		}

		#endregion
		#region Public Properties
		public  virtual Pedido Pedido
		{
			get { return _pedido; }
			set {_pedido= value; }
		}
		public  virtual short RenglonPedido
		{
			get { return _renglonpedido; }
			set {_renglonpedido= value; }
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
			PedidoDetalleId castObj = (PedidoDetalleId)obj;
			return ( castObj != null ) &&
			this._pedido.Equals( castObj.Pedido) &&
			this._renglonpedido == castObj.RenglonPedido;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _pedido.GetHashCode();
			hash = 27 * hash * _renglonpedido.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
