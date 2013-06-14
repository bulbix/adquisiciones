/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;
using Adquisiciones.Data.Auxiliares;
using Adquisiciones.Data.Validators;
using NHibernate.Validator.Constraints;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// PedidoEntrega object for NHibernate mapped table 'pedido_entrega'.
	/// </summary>
	[Serializable]
	public class PedidoEntrega:IDetalle
	{
		#region Member Variables
        protected long _idpedidoentrega;
        protected PedidoDetalle _pedidodetalle;
        protected int _entrega;

		protected DateTime? _fechainicial;
		protected DateTime? _fechafinal;
		protected decimal? _cantidad;

		#endregion
		#region Constructors
			
		public PedidoEntrega() {}
					
		public PedidoEntrega( DateTime? fechainicial, DateTime? fechafinal, decimal? cantidad) 
		{	
			this._fechainicial= fechainicial;
			this._fechafinal= fechafinal;
			this._cantidad= cantidad;
		}

		#endregion
		#region Public Properties

        public virtual long IdPedidoEntrega
        {
            get { return _idpedidoentrega; }
            set { _idpedidoentrega = value; }
        }

        public virtual PedidoDetalle PedidoDetalle
        {
            get { return _pedidodetalle; }
            set { _pedidodetalle = value; }
        }

        [DateTimeNull(Message = ("Fecha Inicial Requerido"))]
		public  virtual DateTime? FechaInicial
		{
			get { return _fechainicial; }
			set {_fechainicial= value; }
		}

        [DateTimeNull(Message = ("Fecha Final Requerido"))]
        public  virtual DateTime? FechaFinal
		{
			get { return _fechafinal; }
			set {_fechafinal= value; }
		}

		public  virtual decimal? Cantidad
		{
			get { return _cantidad; }
			set {_cantidad= value; }
		}

        public virtual int Entrega
        {
            get { return _entrega; }
            set { _entrega = value; }
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
			PedidoEntrega castObj = (PedidoEntrega)obj;
			return ( castObj != null ) &&
			this._idpedidoentrega.Equals( castObj._idpedidoentrega);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode(){
			int hash = 57;
			//hash = 27 * hash * _id.GetHashCode();
			return hash;
		}

		#endregion
		
	}
}
