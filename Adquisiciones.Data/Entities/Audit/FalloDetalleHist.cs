/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// FalloDetalleHist object for NHibernate mapped table 'fallo_detalle_hist'.
	/// </summary>
	[Serializable]
	public class FalloDetalleHist
	{
		#region Member Variables

	    private long _id;

        protected Fallo _fallo;
        protected short _renglonanexo;

	    protected decimal? _cantidadmax;
		protected decimal? _cantidadmin;
		protected decimal? _cantidadped;
		protected decimal? _preciofallo;
		protected Articulo _articulo;

        protected int _modificacion;
        protected string _tipo;
        protected long _idexterno;

	    #endregion
		#region Constructors
			
		public FalloDetalleHist() {}
		#endregion
		#region Public Properties
		
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

	    public virtual long Id
	    {
	        get { return _id; }
	        set { _id = value; }
	    }

        public virtual string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public virtual long IdExterno
        {
            get { return _idexterno; }
            set { _idexterno = value; }
        }

        public virtual int Modificacion
        {
            get { return _modificacion; }
            set { _modificacion = value; }
        }

        public virtual short RenglonAnexo
        {
            get { return _renglonanexo; }
            set { _renglonanexo = value; }
        }

        public virtual Fallo Fallo
        {
            get { return _fallo; }
            set { _fallo = value; }
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
			FalloDetalleHist castObj = (FalloDetalleHist)obj;
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
