/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// CatActividad object for NHibernate mapped table 'cat_actividad'.
	/// </summary>
	[Serializable]
    public class CatActividad : IComparable
	{
		#region Member Variables
		protected int _idactividad;
		protected string _desactividad;
		protected DateTime? _fechaalta;
		protected DateTime? _fechabaja;
		protected string _estatus;
		#endregion
		#region Constructors
			
		public CatActividad() {}
					
		public CatActividad(int idactividad, string desactividad, DateTime? fechaalta, DateTime? fechabaja, string estatus) 
		{
			this._idactividad= idactividad;
			this._desactividad= desactividad;
			this._fechaalta= fechaalta;
			this._fechabaja= fechabaja;
			this._estatus= estatus;
		}

		public CatActividad(int idactividad)
		{
			this._idactividad= idactividad;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdActividad
		{
			get { return _idactividad; }
			set {_idactividad= value; }
		}
		public  virtual string DesActividad
		{
			get { return _desactividad; }
			set {_desactividad= value; }
		}
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		public  virtual DateTime? FechaBaja
		{
			get { return _fechabaja; }
			set {_fechabaja= value; }
		}
		public  virtual string Estatus
		{
			get { return _estatus; }
			set {_estatus= value; }
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
			CatActividad castObj = (CatActividad)obj;
			return ( castObj != null ) &&
			this._idactividad == castObj.IdActividad;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			//hash = 27 * hash * _idactividad.GetHashCode();
			return hash;
		}

        public override string ToString()
        {
            return DesActividad;
        }

        public int CompareTo(object obj)
        {
            return IdActividad.CompareTo((obj as CatActividad).IdActividad);
        }



		#endregion
		
	}
}
