/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// FalloDetalle object for NHibernate mapped table 'fallo_detalle'.
	/// </summary>
	[Serializable]
	public class FalloDetalle
	{
		#region Member Variables

	    protected long _idfallodetalle;
        protected Fallo _fallo;
        protected short _renglonanexo;

        protected decimal? _cantidadmax;
		protected decimal? _cantidadmin;
		protected decimal? _cantidadped;
		protected decimal? _preciofallo;
		protected Articulo _articulo;
		#endregion
		#region Constructors
			
		public FalloDetalle() {}

		#endregion
		#region Public Properties

        public virtual long IdFalloDetalle
        {
            get { return _idfallodetalle; }
            set { _idfallodetalle = value; }
        }

        public virtual Fallo Fallo
        {
            get { return _fallo; }
            set { _fallo = value; }
        }
        public virtual short RenglonAnexo
        {
            get { return _renglonanexo; }
            set { _renglonanexo = value; }
        }

		public  virtual decimal? CantidadMax
		{
			get { return _cantidadmax; }
			set {_cantidadmax= value; }
		}
		public  virtual decimal? CantidadMin
		{
			get { return _cantidadmin; }
			set {_cantidadmin= value; }
		}
		public  virtual decimal? CantidadPed
		{
			get { return _cantidadped; }
			set {_cantidadped= value; }
		}
		public  virtual decimal? PrecioFallo
		{
			get { return _preciofallo; }
			set {_preciofallo= value; }
		}
		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
		}


	    #endregion
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
            FalloDetalle derecha = obj as FalloDetalle;
            return (derecha.IdFalloDetalle == this.IdFalloDetalle);
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
