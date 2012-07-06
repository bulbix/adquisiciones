/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// Fallo object for NHibernate mapped table 'fallo'.
	/// </summary>
	[Serializable]
	public class Fallo
	{
		#region Member Variables
		protected long _idfallo;
		protected Cotizacion _cotizacion;
		protected Proveedor _proveedor;
		protected DateTime? _fechafallo;
		protected string _estado;
		protected Usuario _usuario;
		protected Almacen _almacen;
		protected DateTime? _fechamodificacion;
		protected string _ipterminal;
		protected int _modificacion;
		protected IList<FalloDetalle> _fallodetalle;
        protected Anexo _anexo;
		#endregion
		#region Constructors
			
		public Fallo() {}

		public Fallo(int idfallo)
		{
			this._idfallo= idfallo;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdFallo
		{
			get { return _idfallo; }
			set {_idfallo= value; }
		}
		public  virtual Cotizacion Cotizacion
		{
			get { return _cotizacion; }
			set {_cotizacion= value; }
		}
		public  virtual Proveedor Proveedor
		{
			get { return _proveedor; }
			set {_proveedor= value; }
		}

        [NotNull(Message = ("Fecha Fallo Requerido"))]
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
			set {_fechamodificacion = value; }
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
		public  virtual IList<FalloDetalle> FalloDetalle
		{
			get { return _fallodetalle; }
			set {_fallodetalle= value; }
		}

        [NotNull(Message = ("Anexo Requerido"))]
        public virtual Anexo Anexo
        {
            get { return _anexo; }
            set { _anexo = value; }
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
			Fallo castObj = (Fallo)obj;
			return ( castObj != null ) &&
			this._idfallo == castObj.IdFallo;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			//hash = 27 * hash * _idfallo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
