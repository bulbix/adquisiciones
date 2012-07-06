/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;
using NHibernate.Type;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// AnexoHist object for NHibernate mapped table 'anexo_hist'.
	/// </summary>
	[Serializable]
	public class AnexoHist
	{
		#region Member Variables
		protected AnexoHistId _id;
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
		protected DateTime? _fechaalta;
		protected string _ipterminal;
	    private string _tipo;

		protected IList<CotizacionHist> _cotizacionhist;
		protected IList<AnexoDetalleHist> _anexodetallehist;


        /// <summary>
        /// Construye un objeto anexo opor reflexion
        /// </summary>
        /// <param name="propertyNames">Arreglo con las propiedades</param>
        /// <param name="previousState">Arreglo con los valores anteriores</param>
        /// <returns></returns>
        public static AnexoHist ConstruirHistorico(object id, string[] propertyNames, 
            object[] previousState, IType[] types, string tipo)
        {
            var result = new AnexoHist();
            int index = 0;
            var anexoHistType = typeof(AnexoHist);
            var idAnexoHist = new AnexoHistId();
            idAnexoHist.IdAnexo = (int) id;

            foreach (string propiedad in propertyNames)
            {
                switch (propiedad)
                {
                    case "Modificacion":
                        idAnexoHist.ModAnexo = (int)previousState[index];
                        break;
                    default:
                        if (!types[index].IsCollectionType)
                        {
                            anexoHistType.GetProperty(propiedad).
                                SetValue(result, previousState[index], null);
                        }
                        break;
                }

                ++index;
            }

            result.Id = idAnexoHist;
            result.Tipo = tipo;

            return result;
        }





		#endregion
		#region Constructors
			
		public AnexoHist() {}


		public AnexoHist(AnexoHistId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual AnexoHistId Id
		{
			get { return _id; }
			set {_id= value; }
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
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		public  virtual string IpTerminal
		{
			get { return _ipterminal; }
			set {_ipterminal= value; }
		}
		public  virtual IList<CotizacionHist> CotizacionHist
		{
			get { return _cotizacionhist; }
			set {_cotizacionhist= value; }
		}
		public  virtual IList<AnexoDetalleHist> AnexoDetalleHist
		{
			get { return _anexodetallehist; }
			set {_anexodetallehist= value; }
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
			return ( castObj != null ) &&
			this._id.Equals( castObj.Id);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _id.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
