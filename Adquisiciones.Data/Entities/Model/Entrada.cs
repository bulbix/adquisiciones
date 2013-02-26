/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// Entrada object for NHibernate mapped table 'entrada'.
	/// </summary>
	[Serializable]
	public class Entrada
	{
		#region Member Variables
		protected int _identrada;
		protected int? _numeroentrada;
		protected DateTime? _fechaentrada;
		protected string _numerofactura;
		protected Pedido _pedido;
		protected int? _recibio;
		protected int? _supervisor;
		protected string _estadoentrada;
		protected Almacen _almacen;
		protected CatActividad _catactividad;
		protected CatPresupuesto _catpresupuesto;
		protected Usuario _usuario;
		protected DateTime? _fechamodificacion;
		protected string _ipterminal;
		protected int? _modificacion;
		
		#endregion
		#region Constructors
			
		public Entrada() {}

		public Entrada(int identrada)
		{
			this._identrada= identrada;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdEntrada
		{
			get { return _identrada; }
			set {_identrada= value; }
		}
		public  virtual int? NumeroEntrada
		{
			get { return _numeroentrada; }
			set {_numeroentrada= value; }
		}
		public  virtual DateTime? FechaEntrada
		{
			get { return _fechaentrada; }
			set {_fechaentrada= value; }
		}
		public  virtual string NumeroFactura
		{
			get { return _numerofactura; }
			set {_numerofactura= value; }
		}
		public  virtual Pedido Pedido
		{
			get { return _pedido; }
			set {_pedido= value; }
		}
		public  virtual int? Recibio
		{
			get { return _recibio; }
			set {_recibio= value; }
		}
		public  virtual int? Supervisor
		{
			get { return _supervisor; }
			set {_supervisor= value; }
		}
		public  virtual string EstadoEntrada
		{
			get { return _estadoentrada; }
			set {_estadoentrada= value; }
		}
		public  virtual Almacen Almacen
		{
			get { return _almacen; }
			set {_almacen= value; }
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
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
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
		public  virtual int? Modificacion
		{
			get { return _modificacion; }
			set {_modificacion= value; }
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
			Entrada castObj = (Entrada)obj;
			return ( castObj != null ) &&
			this._identrada == castObj.IdEntrada;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _identrada.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
