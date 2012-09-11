/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections.Generic;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// AnexoHist object for NHibernate mapped table 'anexo_hist'.
	/// </summary>
	[Serializable]
	public class AnexoHist
	{
		#region Member Variables

	    private long _id;
        protected long _idexterno;
        protected int _modificacion;
		protected string _numeroanexo;
		protected DateTime? _fechaanexo;
		protected string _instituto;
		protected string _desanexo;
		protected TipoLicitacion _tipolicitacion;
		protected decimal? _techopresupuestal;
		protected decimal? _importeiva;
		protected Iva _iva;
		protected Usuario _usuario;
		protected Almacen _almacen;
		protected DateTime? _fechamodificacion;
        protected DateTime? _fechacaptura;
		protected string _ipterminal;
	    private string _tipo;
     
		#endregion
		#region Constructors
			
		public AnexoHist() {}
		
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
        public virtual int Modificacion
        {
            get { return _modificacion; }
            set { _modificacion = value; }
        }

		public  virtual string NumeroAnexo
		{
			get { return _numeroanexo; }
			set {_numeroanexo= value; }
		}
		public  virtual DateTime? FechaAnexo
		{
			get { return _fechaanexo; }
			set {_fechaanexo= value; }
		}
		public  virtual string Instituto
		{
			get { return _instituto; }
			set {_instituto= value; }
		}
		public  virtual string DesAnexo
		{
			get { return _desanexo; }
			set {_desanexo= value; }
		}
		public  virtual TipoLicitacion TipoLicitacion
		{
			get { return _tipolicitacion; }
			set {_tipolicitacion= value; }
		}
		public  virtual decimal? TechoPresupuestal
		{
			get { return _techopresupuestal; }
			set {_techopresupuestal= value; }
		}
		public  virtual decimal? ImporteIva
		{
			get { return _importeiva; }
			set {_importeiva= value; }
		}
		public  virtual Iva Iva
		{
			get { return _iva; }
			set {_iva= value; }
		}
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
		}
		public  virtual Almacen Almacen
		{
			get { return _almacen; }
			set {_almacen= value; }
		}
		public  virtual DateTime? FechaModificacion
		{
			get { return _fechamodificacion; }
			set {_fechamodificacion= value; }
		}

        public virtual DateTime? FechaCaptura
        {
            get { return _fechacaptura; }
            set { _fechacaptura = value; }
        }

		public  virtual string IpTerminal
		{
			get { return _ipterminal; }
			set {_ipterminal= value; }
		}

	    public virtual string Tipo
	    {
	        get { return _tipo; }
	        set { _tipo = value; }
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
			AnexoHist castObj = (AnexoHist)obj;
			return this._id.Equals( castObj.Id);
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
