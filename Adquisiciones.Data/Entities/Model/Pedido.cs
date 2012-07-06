/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;
using Adquisiciones.Data.Validators;
using NHibernate.Validator.Constraints;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// Pedido object for NHibernate mapped table 'pedido'.
	/// </summary>
	[Serializable]
	public class Pedido
	{
		#region Member Variables
		protected long _idpedido;
		protected DateTime? _fechapedido;
		protected int? _numeropedido;
		protected CatTipopedido _cattipopedido;
		protected Proveedor _proveedor;
        //Para los pedidos que sean distintos a los automaticos
        protected Requisicion _requisicion;

	    protected Anexo _anexo;
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
		protected string _ipterminal;
		protected int _modificacion;
		protected IList<Entrada> _entrada;
		protected IList<PedidoDetalle> _pedidodetalle = new List<PedidoDetalle>();
	    protected string numerorequisicion;
	    protected string _instituto;

	    #endregion
		#region Constructors
			
		public Pedido() {}


		public Pedido(int idpedido)
		{
			this._idpedido= idpedido;
		}
		
		#endregion

        #region Public Properties

        public virtual long IdPedido
        {
            get { return _idpedido; }
            set { _idpedido = value; }
        }

        [DateTimeNull(Message = ("Fecha Pedido Requerido"))]
        public virtual DateTime? FechaPedido
        {
            get { return _fechapedido; }
            set { _fechapedido = value; }
        }

        [NotNull(Message = ("Numero Pedido Requerido"))]
        public virtual int? NumeroPedido
        {
            get { return _numeropedido; }
            set { _numeropedido = value; }
        }

        public virtual Requisicion Requisicion
        {
            get { return _requisicion; }
            set { _requisicion = value; }
        }

        [NotNull(Message = ("Numero Requerido"))]
        public virtual string NumeroRequisicion
        {
            get { return numerorequisicion; }
            set { numerorequisicion = value; }
        }

        [NotNull(Message = ("Descuento Requerido"))]
        public virtual decimal? ImporteDescuento
        {
            get { return _importedescuento; }
            set { _importedescuento = value; }
        }
        
        public virtual int? IdReservaautoriza
        {
            get { return _idreservaautoriza; }
            set { _idreservaautoriza = value; }
        }


        [NotNull(Message = ("Actividad Requerido"))]
        public virtual CatActividad CatActividad
        {
            get { return _catactividad; }
            set { _catactividad = value; }
        }

        [NotNull(Message = ("Cargo Requerido"))]
        public virtual CatPresupuesto CatPresupuesto
        {
            get { return _catpresupuesto; }
            set { _catpresupuesto = value; }
        }

        [NotNull(Message = ("Iva Requerido"))]
        public virtual Iva Iva
        {
            get { return _iva; }
            set { _iva = value; }
        }

        [NotNullNotEmpty(Message = ("Instituto Requerido"))]
        public virtual string Instituto
        {
            get { return _instituto; }
            set { _instituto = value; }
        }

		public  virtual CatTipopedido CatTipopedido
		{
			get { return _cattipopedido; }
			set {_cattipopedido= value; }
		}

        [NotNull(Message = ("Proveedor Requerido"))]
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

        [NotNull(Message = ("Fundamento Requerido"))]
		public  virtual Fundamento Fundamento
		{
			get { return _fundamento; }
			set {_fundamento= value; }
		}

        [NotNull(Message = ("Area Requerida"))]
		public  virtual CatArea CatArea
		{
			get { return _catarea; } 
			set {_catarea= value; }
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

		public  virtual string IpTerminal
		{
			get { return _ipterminal; }
			set {_ipterminal= value; }
		}

		public  virtual int Modificacion
		{
			get { return _modificacion; }
			set {_modificacion= value; }
		}
		public  virtual IList<Entrada> Entrada
		{
			get { return _entrada; }
			set {_entrada= value; }
		}

        [NotEmpty(Message = "Se requiere al menos pedido detalle")]
        [Valid]
		public  virtual IList<PedidoDetalle> PedidoDetalle
		{
			get { return _pedidodetalle; }
			set {_pedidodetalle= value; }
		}
		#endregion


	    public override string ToString()
	    {
            return NumeroPedido + " - " + CatTipopedido;
	    }

	    public virtual bool Automatico { get; set;}

	    #region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			Pedido castObj = (Pedido)obj;
			return ( castObj != null ) &&
			this._idpedido == castObj.IdPedido;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idpedido.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
