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
	/// AnexoDetalle object for NHibernate mapped table 'anexo_detalle'.
	/// </summary>
	public class AnexoDetalle:IDetalle
	{
		#region Member Variables
        protected long  _idanexodetalle;
        protected Anexo _anexo = new Anexo();
        protected short _renglonanexo;
		protected Articulo _articulo;
		protected string _presentacion;
		protected decimal? _cantidadminimo;
        protected decimal? _cantidadmaximo;
	   


        //protected Anexo _anexo;
		#endregion
		#region Constructors
			
		public AnexoDetalle() {
        
        }
		
		#endregion
		#region Public Properties
		public  virtual long IdAnexoDetalle
		{
			get { return _idanexodetalle; }
			set {_idanexodetalle= value; }
		}

        public virtual Anexo Anexo
        {
            get { return _anexo; }
            set { _anexo = value; }
        }

        public virtual short RenglonAnexo
        {
            get { return _renglonanexo; }
            set { _renglonanexo = value; }
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
       
        [NotNull(Message = ("Campo Requerido"))]
		public  virtual decimal? CantidadMinimo
		{
			get { return _cantidadminimo; }
			set {_cantidadminimo= value; }
		}

        [NotNull(Message = ("Campo Requerido"))]
        public virtual decimal? CantidadMaximo
        {
            get { return _cantidadmaximo; }
            set { _cantidadmaximo = value; }
        }

		#endregion
        
        #region propiedades intermedias de bindeo
        private int? cveArt;

       
        [NotNull(Message = ("Campo Requerido"))]
        public int? CveArt
        {
            get { return cveArt; }
            set { cveArt = value; }
        }

        private string descripcionArt;

        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public string DescripcionArt
        {
            get { return descripcionArt; }
            set { descripcionArt = value; }
        }
        private string presentacionArt;
        public string PresentacionArt
        {
            get { return presentacionArt; }
            set { presentacionArt = value; }
        }

	   

	    #endregion
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
            AnexoDetalle castObj = (AnexoDetalle)obj;
            return ( castObj != null ) && this._idanexodetalle.Equals( castObj.IdAnexoDetalle);
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
