/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// RequisicionDetallId object for NHibernate mapped table 'requisicion_detall'.
	/// </summary>
	[Serializable]
	public class RequisicionDetallId
	{
		#region Member Variables
		protected Requisicion _requisicion;
		protected short _renglon;
		#endregion
		#region Constructors
			
		public RequisicionDetallId() {}
					
		public RequisicionDetallId(Requisicion requisicion, short renglon) 
		{
			this._requisicion= requisicion;
			this._renglon= renglon;
		}

		#endregion
		#region Public Properties
		public  virtual Requisicion Requisicion
		{
			get { return _requisicion; }
			set {_requisicion= value; }
		}
		public  virtual short Renglon
		{
			get { return _renglon; }
			set {_renglon= value; }
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
			RequisicionDetallId castObj = (RequisicionDetallId)obj;
			return ( castObj != null ) &&
			this._requisicion.Equals( castObj.Requisicion) &&
			this._renglon == castObj.Renglon;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _requisicion.GetHashCode();
			hash = 27 * hash * _renglon.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
