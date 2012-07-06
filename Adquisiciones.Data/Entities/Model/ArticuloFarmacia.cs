/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// ArticuloFarmacia object for NHibernate mapped table 'articulo_farmacia'.
	/// </summary>
	[Serializable]
	public class ArticuloFarmacia
	{
		#region Member Variables
        protected ArticuloFarmaciaId _id;
		protected string _grupo;
		protected string _dosis;
		protected string _gramaje;
		#endregion
		#region Constructors
			
		public ArticuloFarmacia() {}
					
		public ArticuloFarmacia(ArticuloFarmaciaId id, string grupo, string dosis, string gramaje) 
		{
            this._id = id;
			this._grupo= grupo;
			this._dosis= dosis;
			this._gramaje= gramaje;
		}

        public ArticuloFarmacia(ArticuloFarmaciaId id)
        {
            this._id= id;
        }
		
		#endregion
		#region Public Properties
        public virtual ArticuloFarmaciaId Id
        {
            get { return _id; }
            set { _id = value; }
        }
		public  virtual string Grupo
		{
			get { return _grupo; }
			set {_grupo= value; }
		}
		public  virtual string Dosis
		{
			get { return _dosis; }
			set {_dosis= value; }
		}
		public  virtual string Gramaje
		{
			get { return _gramaje; }
			set {_gramaje= value; }
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
			ArticuloFarmacia castObj = (ArticuloFarmacia)obj;
            return (castObj != null) &&
            this._id.Equals(castObj.Id);
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
