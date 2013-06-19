/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Adquisiciones.Data.Entities
{
	/// <summary>
	/// Articulo object for NHibernate mapped table 'articulo'.
	/// </summary>
	[Serializable]
	public class Articulo
	{
		#region Member Variables
		protected ArticuloId _id;
		protected string _desarticulo;
        protected string _unidad;        
		protected string _presentacion;
		protected short? _presentacioncant;
		protected string _presentacionunid;
		
		protected decimal? _maximo;
		protected decimal? _minimo;
		protected decimal? _puntoreorden;
		protected decimal? _consumopromedio;
		protected decimal? _movimientoprom;
		protected string _tipomovimiento;
		protected string _arealocaliza;
		protected string _anaquellocaliza;
		protected string _nivellocaliza;

		protected Usuario  _usuario;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
        //3 rows
        protected string _imagen;
        protected IList<ArticuloFarmacia> _articulofarmacia;
        protected IList<ArticuloPartida> _articulopartida;
        
        
		#endregion
		#region Constructors
			
		public Articulo() {}
        //string gramaje, string dosis, int? idgrupo,, Almacen almacen
		public Articulo(ArticuloId id, string desarticulo, string presentacion, short? presentacioncant, string presentacionunid, decimal? maximo, decimal? minimo, decimal? puntoreorden, decimal? consumopromedio, decimal? movimientoprom, string tipomovimiento, string arealocaliza, string anaquellocaliza, string nivellocaliza,  DateTime? fechaalta, string ipterminal, string imagen) 
		{
			this._id= id;
			this._desarticulo= desarticulo;
			this._presentacion= presentacion;
			this._presentacioncant= presentacioncant;
			this._presentacionunid= presentacionunid;
			this._maximo= maximo;
			this._minimo= minimo;
			this._puntoreorden= puntoreorden;
			this._consumopromedio= consumopromedio;
			this._movimientoprom= movimientoprom;
			this._tipomovimiento= tipomovimiento;
			this._arealocaliza= arealocaliza;
			this._anaquellocaliza= anaquellocaliza;
			this._nivellocaliza= nivellocaliza;
            //this._gramaje= gramaje;
            //this._dosis= dosis;
            //this._idgrupo= idgrupo;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
            this._imagen = imagen;
            
		}

		public Articulo(ArticuloId id)
		{
			this._id= id;
			
		}
		
		#endregion
		#region Public Properties
		public  virtual ArticuloId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual string DesArticulo
		{
			get { return _desarticulo; }
			set {_desarticulo= value; }
		}
		public  virtual string Unidad
		{
			get { return _unidad; }
			set {_unidad= value; }
		}
		public  virtual string Presentacion
		{
			get { return _presentacion; }
			set {_presentacion= value; }
		}
		public  virtual short? PresentacionCant
		{
			get { return _presentacioncant; }
			set {_presentacioncant= value; }
		}
		public  virtual string PresentacionUnid
		{
			get { return _presentacionunid; }
			set {_presentacionunid= value; }
		}
        //public  virtual CatPartida CatPartida
        //{
        //    get { return _catpartida; }
        //    set {_catpartida= value; }
        //}
		public  virtual decimal? Maximo
		{
			get { return _maximo; }
			set {_maximo= value; }
		}
		public  virtual decimal? Minimo
		{
			get { return _minimo; }
			set {_minimo= value; }
		}
		public  virtual decimal? PuntoReorden
		{
			get { return _puntoreorden; }
			set {_puntoreorden= value; }
		}
		public  virtual decimal? ConsumoPromedio
		{
			get { return _consumopromedio; }
			set {_consumopromedio= value; }
		}
		public  virtual decimal? MovimientoProm
		{
			get { return _movimientoprom; }
			set {_movimientoprom= value; }
		}
		public  virtual string TipoMovimiento
		{
			get { return _tipomovimiento; }
			set {_tipomovimiento= value; }
		}
		public  virtual string AreaLocaliza
		{
			get { return _arealocaliza; }
			set {_arealocaliza= value; }
		}
		public  virtual string AnaquelLocaliza
		{
			get { return _anaquellocaliza; }
			set {_anaquellocaliza= value; }
		}
		public  virtual string NivelLocaliza
		{
			get { return _nivellocaliza; }
			set {_nivellocaliza= value; }
		}
      
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
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
        //protected string _imagen;   
        public virtual string Imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }
        //protected ArticuloFarmacia _articulofarmacia;
        public virtual IList<ArticuloFarmacia> ArticuloFarmacia
        {
            get { return _articulofarmacia; }
            set { _articulofarmacia = value; }
        }
        //protected IList<ArticuloPartida> _articulopartida;
        public virtual IList<ArticuloPartida> ArticuloPartida
        {
            get { return _articulopartida; }
            set { _articulopartida = value; }
        }
       
        #endregion


		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			Articulo castObj = (Articulo)obj;
			return this._id.Equals( castObj.Id);
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
