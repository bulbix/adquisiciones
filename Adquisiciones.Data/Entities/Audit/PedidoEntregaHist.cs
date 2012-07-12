/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// PedidoEntregaHis object for NHibernate mapped table 'pedido_entrega_his'.
	/// </summary>
	[Serializable]
	public class PedidoEntregaHist
	{
		#region Member Variables

	    private long _id;

	    private int _entrega;

	    private PedidoDetalle _pedidodetalle;

		protected DateTime? _fechainicial;
		protected DateTime? _fechafinal;
		protected decimal? _cantidad;


        protected long _idexterno;
       
        private string _tipo;

	    #endregion
		#region Constructors
			
		public PedidoEntregaHist() {}
		
		#endregion
		#region Public Properties
		public  virtual DateTime? FechaInicial
		{
			get { return _fechainicial; }
			set {_fechainicial= value; }
		}
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

	    public virtual int Entrega
	    {
	        get { return _entrega; }
	        set { _entrega = value; }
	    }

	    public virtual PedidoDetalle PedidoDetalle
	    {
	        get { return _pedidodetalle; }
	        set { _pedidodetalle = value; }
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
			PedidoEntregaHist castObj = (PedidoEntregaHist)obj;
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
