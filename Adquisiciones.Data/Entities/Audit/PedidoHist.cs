/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;
using Adquisiciones.Data.Auxiliares;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// PedidoHist object for NHibernate mapped table 'pedido_hist'.
	/// </summary>
	[Serializable]
	public class PedidoHist
	{
		#region Member Variables

	    private long _id;

		protected DateTime? _fechapedido;
		protected int? _numeropedido;
		protected CatTipopedido _cattipopedido;
		protected Proveedor _proveedor;
		protected Anexo _anexo;
		protected Requisicion _requisicion;
		protected Fundamento _fundamento;
		protected int? _idreservaautoriza;
		protected CatArea _catarea;
		protected decimal? _importedescuento;
		protected Iva _iva;
		protected CatActividad _catactividad;
		protected CatPresupuesto _catpresupuesto;
		protected string _estadopedido;
		protected decimal? _importetotal;
		protected string _observaciones;
		protected Usuario _usuario;
		protected Almacen _almacen;
		protected DateTime? _fechamodificacion;
        protected DateTime? _fechacaptura;
		protected string _ipterminal;
        protected string _numerorequisicion;
        protected string _instituto;
        protected long _idexterno;
        protected int _modificacion;
        private string _tipo;

	  

	    #endregion
		#region Constructors
			
		public PedidoHist() {}
		
		#endregion
		#region Public Properties
		
		public  virtual DateTime? FechaPedido
		{
			get { return _fechapedido; }
			set {_fechapedido= value; }
		}
		public  virtual int? NumeroPedido
		{
			get { return _numeropedido; }
			set {_numeropedido= value; }
		}
		public  virtual CatTipopedido CatTipopedido
		{
			get { return _cattipopedido; }
			set {_cattipopedido= value; }
		}
		public  virtual Proveedor Proveedor
		{
			get { return _proveedor; }
			set {_proveedor= value; }
		}
		public  virtual Anexo Anexo
		{
			get { return _anexo; }
			set {_anexo= value; }
		}
		public  virtual Requisicion Requisicion
		{
			get { return _requisicion; }
			set {_requisicion= value; }
		}
		public  virtual Fundamento Fundamento
		{
			get { return _fundamento; }
			set {_fundamento= value; }
		}
		public  virtual int? IdReservaautoriza
		{
			get { return _idreservaautoriza; }
			set {_idreservaautoriza= value; }
		}
		public  virtual CatArea CatArea
		{
			get { return _catarea; }
			set {_catarea= value; }
		}
		public  virtual decimal? ImporteDescuento
		{
			get { return _importedescuento; }
			set {_importedescuento= value; }
		}
		public  virtual Iva Iva
		{
			get { return _iva; }
			set {_iva= value; }
		}
		public  virtual CatActividad CatActividad
		{
			get { return _catactividad; }
			set {_catactividad= value; }
		}
		public  virtual CatPresupuesto CatPresupuesto
		{
			get { return _catpresupuesto; }
			set {_catpresupuesto= value; }
		}
		public  virtual string EstadoPedido
		{
			get { return _estadopedido; }
			set {_estadopedido= value; }
		}
		public  virtual decimal? ImporteTotal
		{
			get { return _importetotal; }
			set {_importetotal= value; }
		}
		public  virtual string Observaciones
		{
			get { return _observaciones; }
			set {_observaciones= value; }
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

        public virtual string Instituto
        {
            get { return _instituto; }
            set { _instituto = value; }
        }

        public virtual string NumeroRequisicion
        {
            get { return _numerorequisicion; }
            set { _numerorequisicion = value; }
        }

	    public virtual long Id
	    {
	        get { return _id; }
	        set { _id = value; }
	    }

        public virtual int Modificacion
        {
            get { return _modificacion; }
            set { _modificacion = value; }
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

        public virtual TipoProcedimiento TipoProcedimiento
        {
            get;
            set;
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
			PedidoHist castObj = (PedidoHist)obj;
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
