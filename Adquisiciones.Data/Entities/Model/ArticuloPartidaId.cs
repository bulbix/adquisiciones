/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// ArticuloPartidaId object for NHibernate mapped table 'articulo_partida'.
	/// </summary>
	[Serializable]
	public class ArticuloPartidaId
	{
		#region Member Variables
		protected CatPartida _catpartida;
        protected Articulo _articulo;
		protected String _estatus;
		#endregion
		#region Constructors
			
		public ArticuloPartidaId() {}

        public ArticuloPartidaId(CatPartida catpartida, Articulo articulo, String estatus) 
		{
			this._catpartida= catpartida;
            this._articulo = articulo;
			this._estatus= estatus;
		}

		#endregion
		#region Public Properties
        public virtual CatPartida CatPartida
        {
            get { return _catpartida; }
            set { _catpartida = value; }
        }
        public virtual Articulo Articulo
        {
            get { return _articulo; }
            set { _articulo = value; }
        }
        public virtual String Estatus
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
			ArticuloPartidaId castObj = (ArticuloPartidaId)obj;
			return ( castObj != null ) &&
			this._catpartida.Equals( castObj.CatPartida) &&
            this._articulo.Equals( castObj.Articulo) &&
			this._estatus == castObj.Estatus;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _catpartida.GetHashCode();
            hash = 27 * hash * _articulo.GetHashCode();
			hash = 27 * hash * _estatus.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
