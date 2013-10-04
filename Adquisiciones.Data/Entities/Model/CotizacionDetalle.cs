/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using Adquisiciones.Data.Auxiliares;
using Adquisiciones.Data.Validators;

namespace Adquisiciones.Data.Entities
{
    /// <summary>
    /// CotizacionDetalle object for NHibernate mapped table 'cotizacion_detalle'.
    /// </summary>
    [Serializable]
    public class CotizacionDetalle:IDetalle
    {
        #region Member Variables
        protected long _idcotizaciondetalle;
        private Cotizacion _cotizacion;
        private short _renglonanexo;

        protected Articulo _articulo;
        protected string _marca;
        protected decimal? _precio;
        protected string _observaciones;
       

        #endregion
        #region Constructors

        public CotizacionDetalle() { }

        #endregion
        #region Public Properties

        public virtual long IdCotizacionDetalle
        {
            get { return _idcotizaciondetalle; }
            set { _idcotizaciondetalle = value; }
        }

        public virtual Cotizacion Cotizacion
        {
            get { return _cotizacion; }
            set { _cotizacion = value; }
        }

        public virtual short RenglonAnexo
        {
            get { return _renglonanexo; }
            set { _renglonanexo = value; }
        }

        public virtual Articulo Articulo
        {
            get { return _articulo; }
            set { _articulo = value; }
        }
        
        public virtual string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public virtual decimal? Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
      
        public virtual string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }

        #endregion

        #region propiedades intermedias de bindeo

        public int CveArt
        {
            get; set;
        }

        public string DescripcionArt
        {
            get; set;
        }

        public string PresentacionArt
        {
            get;set;
        }

        public decimal? CantidadMinimo
        {
            get; set;
        }

        public decimal? CantidadMaximo
        {
            get; set;
        }

        public string UnidadArt
        {
            get; set;
        }
        
        #endregion


        #region  propiedades tabla comparativa

        public bool Ganador { get; set;}
        public decimal Porcentaje { get; set; }


        #endregion

        #region Equals And HashCode Overrides
        /// <summary>
        /// local implementation of Equals based on unique value members
        /// </summary>
        public override bool Equals(object obj)
        {
            CotizacionDetalle derecha = obj as CotizacionDetalle;
            return (derecha.IdCotizacionDetalle == this.IdCotizacionDetalle);
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
