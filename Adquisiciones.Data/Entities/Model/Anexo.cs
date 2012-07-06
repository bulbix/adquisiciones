using System;
using System.Collections.Generic;
using System.ComponentModel;
using Adquisiciones.Data.Audit;
using NHibernate.Validator.Constraints;

namespace Adquisiciones.Data.Entities
{
    /// <summary>
    /// Anexo object for NHibernate mapped table 'anexo'.
    /// </summary>
    [Auditable]
    public class Anexo : INotifyPropertyChanged
    {
        #region Member Variables
        protected long _idanexo;
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
        protected DateTime? _fechamodificacion;
        protected string _ipterminal;
        protected int _modificacion;
        protected IList<Cotizacion> _cotizacion;
        protected IList<AnexoDetalle> _anexodetalle = new List<AnexoDetalle>();
        #endregion
        #region Constructors

        public Anexo() { }

        public Anexo(DateTime? fechaModificacion, string ipterminal, Almacen almacen, Usuario usuario)
        {                  
            this._fechamodificacion = fechaModificacion;
            this._ipterminal = ipterminal;
            this.Almacen = almacen;
            this.Usuario = usuario;
            //this.FechaAnexo = DateTime.Now;
            this.Modificacion = 0;
        }

        public Anexo(long idanexo)
        {
            this._idanexo = idanexo;
        }

        #endregion
        #region Public Properties
        public virtual long IdAnexo
        {
            get { return _idanexo; }
            set { _idanexo = value; }
        }

        [NotNullNotEmpty(Message=("Campo Requerido"))]
        public virtual string NumeroAnexo
        {
            get { return _numeroanexo; }
            set
            {
                if (_numeroanexo != value)
                {
                    _numeroanexo = value;
                    OnPropertyChanged("NumeroAnexo");
                }
            }
        }
       
        public virtual DateTime? FechaAnexo
        {
            get { return _fechaanexo; }
            set
            {
                if (_fechaanexo != value)
                {
                    _fechaanexo = value;
                    OnPropertyChanged("FechaAnexo");
                }
            }
        }

        [NotNull(Message = ("Campo Requerido"))]
        public virtual string Instituto
        {
            get { return _instituto; }
            set
            {
                if (_instituto != value)
                {
                    _instituto = value;
                    OnPropertyChanged("Instituto");
                }
            }
        }

        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string DesAnexo
        {
            get { return _desanexo; }
            set
            {
                if (_desanexo != value)
                {
                    _desanexo = value;
                    OnPropertyChanged("DesAnexo");
                }
            }
        }

        [NotNull(Message = ("Campo Requerido"))]
        public virtual TipoLicitacion TipoLicitacion
        {
            get { return _tipolicitacion; }
            set
            {
                if (_tipolicitacion != value)
                {
                    _tipolicitacion = value;
                    OnPropertyChanged("TipoLicitacion");
                }
            }
        }

        
        [NotNull(Message = ("Campo Requerido"))]
        public virtual decimal? TechoPresupuestal
        {
            get { return _techopresupuestal; }
            set
            {
                if (_techopresupuestal != value)
                {
                    _techopresupuestal = value;
                    OnPropertyChanged("TechoPresupuestal");
                }
            }
        }
        public virtual decimal? ImporteIva
        {
            get {
                try{
                //Calcula el importe del IVA
                decimal porcentajeIva = 0;
                porcentajeIva = TechoPresupuestal.Value * (decimal)(Iva.Id.Porcentaje / 100.0);                
                return porcentajeIva;
                }
                catch(Exception e)
                {
                    return 0;
                }
            }
            set {
                _importeiva = value;
            }
           
        }

        [NotNull(Message = ("Campo Requerido"))]
        public virtual Iva Iva
        {
            get { return _iva; }
            set
            {
                if (_iva != value)
                {
                    _iva = value;
                    OnPropertyChanged("Iva");
                }
            }
        }
        public virtual Usuario Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public virtual Almacen Almacen
        {
            get { return _almacen; }
            set { _almacen = value; }
        }
        public virtual DateTime? FechaModificacion
        {
            get { return _fechamodificacion; }
            set { _fechamodificacion = value; }
        }
        public virtual string IpTerminal
        {
            get { return _ipterminal; }
            set { _ipterminal = value; }
        }
        public virtual int Modificacion
        {
            get { return _modificacion; }
            set { _modificacion = value; }
        }
        public virtual IList<Cotizacion> Cotizacion
        {
            get { return _cotizacion; }
            set { _cotizacion = value; }
        }

        [NotEmpty (Message="Se requiere al menos un registro")]
        [Valid]
        public virtual IList<AnexoDetalle> AnexoDetalle
        {
            get { return _anexodetalle; }
            set { _anexodetalle = value; }
        }
        #endregion


        public virtual bool TieneCotizacion { get; set; }


        public override string ToString()
        {
            return NumeroAnexo + " - " + DesAnexo;
        }

        #region Equals And HashCode Overrides
        /// <summary>
        /// local implementation of Equals based on unique value members
        /// </summary>
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if ((obj == null) || (obj.GetType() != this.GetType())) return false;
            Anexo castObj = (Anexo)obj;
            return (castObj != null) &&
            this._idanexo == castObj.IdAnexo;
        }
        /// <summary>
        /// local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {
            int hash = 57;
            //hash = 27 * hash * _idanexo.GetHashCode();
            return hash;
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        #region business logic

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
