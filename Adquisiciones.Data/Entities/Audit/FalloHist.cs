/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections.Generic;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// FalloHist object for NHibernate mapped table 'fallo_hist'.
	/// </summary>
	[Serializable]
	public class FalloHist
	{
		#region Member Variables
        
        private long _id;

		protected Cotizacion _cotizacion;
		protected Anexo _anexo;
		protected Proveedor _proveedor;
		protected DateTime? _fechafallo;
		protected string _estado;
		protected Usuario _usuario;
		protected Almacen _almacen;
		protected DateTime? _fechamodificacion;
		protected string _ipterminal;
	    protected int _modificacion;
	    protected string _tipo;
        protected long _idexterno;

	    #endregion
		#region Constructors
			
		public FalloHist() {}
		
		
		#endregion
		#region Public Properties

        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }

		public  virtual Cotizacion Cotizacion
		{
			get { return _cotizacion; }
			set {_cotizacion= value; }
		}
		public  virtual Anexo Anexo
		{
			get { return _anexo; }
			set {_anexo= value; }
		}
		public  virtual Proveedor Proveedor
		{
			get { return _proveedor; }
			set {_proveedor= value; }
		}
		public  virtual DateTime? FechaFallo
		{
			get { return _fechafallo; }
			set {_fechafallo= value; }
		}
		public  virtual string Estado
		{
			get { return _estado; }
			set {_estado= value; }
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

	    

	    #endregion
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			FalloHist castObj = (FalloHist)obj;
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
