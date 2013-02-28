/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// Almacen object for NHibernate mapped table 'almacen'.
	/// </summary>
	[Serializable]
	public class Almacen
	{
		#region Member Variables
		protected string _idalmacen;
		protected string _desalmacen;
		protected DateTime? _fechaalta;
		#endregion
		#region Constructors
			
		public Almacen() {}
					
		public Almacen(string idalmacen, string desalmacen, DateTime? fechaalta) 
		{
			this._idalmacen= idalmacen;
			this._desalmacen= desalmacen;
			this._fechaalta= fechaalta;
		}

		public Almacen(string idalmacen)
		{
			this._idalmacen= idalmacen;
		}
		
		#endregion
		#region Public Properties
		public  virtual string IdAlmacen
		{
			get { return _idalmacen; }
			set {_idalmacen= value; }
		}
		public  virtual string DesAlmacen
		{
			get { return _desalmacen; }
			set {_desalmacen= value; }
		}
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		
		#endregion
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{	
			var derecha = obj as Almacen;
            if (derecha == null) return false;
			return (this._idalmacen == derecha.IdAlmacen);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			//hash = 27 * hash * _idalmacen.GetHashCode();
			return hash;
		}
		#endregion

       



	    public override string ToString()
        {
            return string.Format("{0}-{1}", IdAlmacen, DesAlmacen);
        }
		
	}
}
