/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;
using NHibernate.Type;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// AnexoDetalleHist object for NHibernate mapped table 'anexo_detalle_hist'.
	/// </summary>
	[Serializable]
	public class AnexoDetalleHist
	{
		#region Member Variables

	    private long _id;
	    private long _idexterno;

	    private Anexo _anexo;
	    private short _renglonanexo;
        private Articulo _articulo;
        private string _presentacion;
        private decimal? _cantidad;
	    private string _tipo;
       

		#endregion

		#region Constructors

		public AnexoDetalleHist() {}
		
		#endregion

		#region Public Properties

        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual long IdExterno
        {
            get { return _idexterno; }
            set { _idexterno = value; }
        }

		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
		}
		public  virtual string Presentacion
		{
			get { return _presentacion; }
			set {_presentacion= value; }
		}
		public  virtual decimal? Cantidad
		{
			get { return _cantidad; }
			set {_cantidad= value; }
		}

	    public virtual Anexo Anexo
	    {
	        get { return _anexo; }
	        set { _anexo = value; }
	    }

	    public virtual string Tipo
	    {
	        get { return _tipo; }
	        set { _tipo = value; }
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
		    return true;
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
