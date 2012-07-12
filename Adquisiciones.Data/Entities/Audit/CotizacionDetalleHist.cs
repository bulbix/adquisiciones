/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// CotizacionDetHis object for NHibernate mapped table 'cotizacion_det_his'.
	/// </summary>
	[Serializable]
	public class CotizacionDetalleHist
	{
		#region Member Variables

	    private long _id;
	    private long _idexterno;
        private Cotizacion _cotizacion;
        private short _renglonanexo;

		protected Articulo _articulo;
		protected string _marca;
		protected decimal? _precio;
		protected string _observaciones;
	    protected string _tipo;

		#endregion
		#region Constructors
			
		public CotizacionDetalleHist() {}
		
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
		public  virtual decimal? Precio
		{
			get { return _precio; }
			set {_precio= value; }
		}
		public  virtual string Observaciones
		{
			get { return _observaciones; }
			set {_observaciones= value; }
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

	    public virtual Cotizacion Cotizacion
	    {
	        get { return _cotizacion; }
	        set { _cotizacion = value; }
	    }

	    public virtual short RenglonAnexo
	    {
	        get { return _renglonanexo; }
	        set { _renglonanexo = value; }
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
			CotizacionDetalleHist castObj = (CotizacionDetalleHist)obj;
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
