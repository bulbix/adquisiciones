/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// RequisicionDetall object for NHibernate mapped table 'requisicion_detall'.
	/// </summary>
	[Serializable]
	public class RequisicionDetall
	{
		#region Member Variables
		protected RequisicionDetallId _id;
		protected Articulo _articulo;
		protected decimal? _cantidad;
		protected Requisicion _requisicion;
		#endregion
		#region Constructors
			
		public RequisicionDetall() {}
					
		public RequisicionDetall(RequisicionDetallId id, decimal? cantidad, Requisicion requisicion) 
		{
			this._id= id;
			this._cantidad= cantidad;
			this._requisicion= requisicion;
		}

		public RequisicionDetall(RequisicionDetallId id, Requisicion requisicion)
		{
			this._id= id;
			this._requisicion= requisicion;
		}
		
		#endregion
		#region Public Properties
		public  virtual RequisicionDetallId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
		}
		public  virtual decimal? Cantidad
		{
			get { return _cantidad; }
			set {_cantidad= value; }
		}
		public  virtual Requisicion Requisicion
		{
			get { return _requisicion; }
			set {_requisicion= value; }
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
			RequisicionDetall castObj = (RequisicionDetall)obj;
			return ( castObj != null ) &&
			this._id.Equals( castObj.Id);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _id.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
