/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;
using Adquisiciones.Data.Auxiliares;
using NHibernate.Validator.Constraints;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// Cotizacion object for NHibernate mapped table 'cotizacion'.
	/// </summary>
	[Serializable]
	public class Cotizacion:IPadre
	{
		#region Member Variables
		protected long _idcotizacion;
		protected Proveedor _proveedor;
		protected DateTime? _fechacotizacion;
		protected Usuario _usuario;
		protected Almacen _almacen;
		protected DateTime? _fechamodificacion;
		protected string _ipterminal;
		protected int _modificacion;
		protected IList<CotizacionDetalle> _cotizaciondetalle = new List<CotizacionDetalle>();
		protected IList<Fallo> _fallo;
		protected Anexo _anexo;
		#endregion
		#region Constructors
			
		public Cotizacion() {}
				
		
		public Cotizacion(int idCotizacion)
		{
			this._idcotizacion = idCotizacion;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdCotizacion
		{
			get { return _idcotizacion; }
			set {_idcotizacion= value; }
		}

        [NotNull(Message = ("Campo Requerido"))]
		public  virtual Proveedor Proveedor
		{
			get { return _proveedor; }
			set {_proveedor= value; }
		}

         [NotNull(Message = ("Fecha Cotizacion Requerido"))]
		public  virtual DateTime? FechaCotizacion
		{
			get { return _fechacotizacion; }
			set {_fechacotizacion= value; }
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
            set { _fechamodificacion = value; }
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

        [Valid]
		public  virtual IList<CotizacionDetalle> CotizacionDetalle
		{
			get { return _cotizaciondetalle; }
			set {_cotizaciondetalle= value; }
		}
		public  virtual IList<Fallo> Fallo
		{
			get { return _fallo; }
			set {_fallo= value; }
		}
        
        [NotNull(Message = ("Campo Requerido"))]
		public  virtual Anexo Anexo
		{
			get { return _anexo; }
			set {_anexo= value; }
		}
		#endregion

        public virtual bool TieneFallo { get; set; }
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
            Cotizacion derecha = obj as Cotizacion;

            return this.IdCotizacion == derecha.IdCotizacion;
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


        public override string ToString()
        {
            return Anexo + "//" + Proveedor;
        }



		#endregion
		
	}
}
