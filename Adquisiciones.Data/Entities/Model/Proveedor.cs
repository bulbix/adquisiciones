/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

using System.ComponentModel;
using Adquisiciones.Data.Auxiliares;
using Adquisiciones.Data.Validators;
using NHibernate.Validator.Constraints;

namespace Adquisiciones.Data.Entities
{
    /// <summary>
    /// Proveedor object for NHibernate mapped table 'proveedor'.
    /// </summary>
    [Serializable]
    public class Proveedor : INotifyPropertyChanged,ICatalogo,IComparable
    {

        // property change events
        public virtual event PropertyChangedEventHandler PropertyChanged;

        #region Member Variables
        protected int? _cveproveedor;
        protected string _nombrefiscal;
        protected string _nombrecomercial;
        protected string _paterno;
        protected string _materno;
        protected string _nombre;
        protected string _calle;
        protected string _colonia;
        protected string _delegacion;
        protected string _estado;
        protected string _pais;
        protected string _codigop;
        protected string _rfc;
        protected string _tel;
        protected string _tel2;
        protected string _tel3;
        protected string _fax;
        protected string _correo;
        protected string _rpaterno;
        protected string _rmaterno;
        protected string _rnombre;
        protected string _giro;
        protected string _observacion;
        protected string _ipterminal;
        protected DateTime? _fechaalta;
        protected Usuario _usuario;
        protected IList<Cotizacion> _cotizacion;
        protected IList<CotizacionHist> _cotizacionhist;
        protected IList<Fallo> _fallo;
        protected IList<FalloHist> _fallohist;
        protected IList<Pedido> _pedido;
        protected IList<PedidoHist> _pedidohist;

        protected string _estatus;

        #endregion
        #region Constructors

        public Proveedor() { }

        public Proveedor(Usuario usuario, string ipterminal, DateTime? fechaalta)
        {
            this._usuario = usuario;
            this._ipterminal = ipterminal;
            this._fechaalta = fechaalta;
        }

        public Proveedor(int cveproveedor)
        {
            this._cveproveedor = cveproveedor;
        }

        #endregion
        #region Public Properties

        [NotNull(Message = ("Campo Requerido"))]
        public virtual int? CveProveedor
        {
            get
            { return _cveproveedor; }
            set
            {
                if (_cveproveedor != value)
                {
                    _cveproveedor = value;
                    OnPropertyChanged("CveProveedor");
                }
            }

        }

        [StringOptional]
        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string NombreFiscal
        {
            get { return _nombrefiscal!=null?_nombrefiscal.Trim():""; }

            set
            {
                if (_nombrefiscal != value)
                {
                    _nombrefiscal = value;
                    OnPropertyChanged("NombreFiscal");
                }
            }

        }

        //[StringOptional]
        //[NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string NombreComercial
        {
            get { return _nombrecomercial!=null?_nombrecomercial.Trim():""; }

            set
            {
                if (_nombrecomercial != value)
                {
                    _nombrecomercial = value;
                    OnPropertyChanged("NombreComercial");
                }
            }
        }

        [StringOptional]
        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string Paterno
        {
            get { return _paterno!= null?_paterno.Trim():""; }
            set
            {
                if (_paterno != value)
                {
                    _paterno = value;
                    OnPropertyChanged("Paterno");
                }
            }
        }

        [StringOptional]
        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string Materno
        {
            get { return _materno!=null?_materno.Trim():""; }
            set
            {
                if (_materno != value)
                {
                    _materno = value;
                    OnPropertyChanged("Materno");
                }
            }

        }

        [StringOptional]
        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string Nombre
        {
            get { return _nombre!=null?_nombre.Trim():""; }
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    OnPropertyChanged("Nombre");
                }
            }
        }

        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string Calle
        {
            get { return _calle!=null?_calle.Trim():""; }

            set
            {
                if (_calle != value)
                {
                    _calle = value;
                    OnPropertyChanged("Calle");
                }
            }
        }

        [StringOptional]
        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string Colonia
        {
            get { return _colonia!=null?_colonia.Trim():""; }

            set
            {
                if (_colonia != value)
                {
                    _colonia = value;
                    OnPropertyChanged("Colonia");
                }
            }
        }

        [StringOptional]
        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string Delegacion
        {
            get { return _delegacion!=null?_delegacion.Trim():""; }

            set
            {
                if (_delegacion != value)
                {
                    _delegacion = value;
                    OnPropertyChanged("Delegacion");
                }
            }
        }

        [StringOptional]
        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string Estado
        {
            get { return _estado!=null?_estado.Trim():""; }

            set
            {
                if (_estado != value)
                {
                    _estado = value;
                    OnPropertyChanged("Estado");
                }
            }
        }

        [StringOptional]
        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string Pais
        {
            get { return _pais!=null?_pais.Trim():""; }
            set
            {
                if (_pais != value)
                {
                    _pais = value;
                    OnPropertyChanged("Pais");
                }
            }
        }

        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string CodigoP
        {
            get { return _codigop!=null?_codigop.Trim():""; }
            set
            {
                if (_codigop != value)
                {
                    _codigop = value;
                    OnPropertyChanged("CodigoP");
                }
            }
        }

        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string Rfc
        {
            get { return _rfc!=null?_rfc.Trim():""; }
            set
            {
                if (_rfc != value)
                {
                    _rfc = value;
                    OnPropertyChanged("Rfc");
                }
            }
        }

        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string Tel
        {
            get { return _tel!=null?_tel.Trim():""; }

            set
            {
                if (_tel != value)
                {
                    _tel = value;
                    OnPropertyChanged("Tel");
                }
            }
        }

        public virtual string Tel2
        {
            get { return _tel2!=null?_tel2.Trim():""; }
            set
            {
                if (_tel2 != value)
                {
                    _tel2 = value;
                    OnPropertyChanged("Tel2");
                }
            }
        }

        public virtual string Tel3
        {
            get { return _tel3!=null?_tel3.Trim():""; }
            set
            {
                if (_tel3 != value)
                {
                    _tel3 = value;
                    OnPropertyChanged("Tel3");
                }
            }
        }

        public virtual string Fax
        {
            get { return _fax!=null?_fax.Trim():""; }
            set
            {
                if (_fax != value)
                {
                    _fax = value;
                    OnPropertyChanged("Fax");
                }
            }
        }

        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        [Email(Message = "Correo no valido")]
        public virtual string Correo
        {
            get { return _correo!=null?_correo.Trim():""; }
            set
            {
                if (_correo != value)
                {
                    _correo = value;
                    OnPropertyChanged("Correo");
                }
            }
        }

        [StringOptional]
        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string Rpaterno
        {
            get { return _rpaterno!=null?_rpaterno.Trim():""; }
            set
            {
                if (_rpaterno != value)
                {
                    _rpaterno = value;
                    OnPropertyChanged("Rpaterno");
                }
            }
        }

        [StringOptional]
        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string Rmaterno
        {
            get { return _rmaterno!=null?_rmaterno.Trim():""; }
            set
            {
                if (_rmaterno != value)
                {
                    _rmaterno = value;
                    OnPropertyChanged("Rmaterno");
                }
            }
        }

        [StringOptional]
        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string Rnombre
        {
            get { return _rnombre!=null?_rnombre.Trim():""; }
            set
            {
                if (_rnombre != value)
                {
                    _rnombre = value;
                    OnPropertyChanged("Rnombre");
                }
            }
        }

        [StringOptional]
        [NotNullNotEmpty(Message = ("Campo Requerido"))]
        public virtual string Giro
        {
            get { return _giro!=null?_giro.Trim():""; }
            set
            {
                if (_giro != value)
                {
                    _giro = value;
                    OnPropertyChanged("Giro");
                }
            }
        }

        public virtual string Observacion
        {
            get { return _observacion!=null?_observacion.Trim():""; }
            set
            {
                if (_observacion != value)
                {
                    _observacion = value;
                    OnPropertyChanged("Observacion");
                }
            }
        }

        public virtual string IpTerminal
        {
            get { return _ipterminal; }
            set { _ipterminal = value; }
        }

        public virtual DateTime? FechaAlta
        {
            get { return _fechaalta; }set { _fechaalta = value; }
        }

        public virtual Usuario Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public virtual string Estatus
        {
            get { return _estatus; }set { _estatus = value; }
        }

        public virtual CatEmpresa CatEmpresa
        {
            get;set;
        }

        public virtual IList<Cotizacion> Cotizacion
        {
            get { return _cotizacion; }
            set { _cotizacion = value; }
        }

        public virtual IList<CotizacionHist> CotizacionHist
        {
            get { return _cotizacionhist; }
            set { _cotizacionhist = value; }
        }

        public virtual IList<Fallo> Fallo
        {
            get { return _fallo; }
            set { _fallo = value; }
        }

        public virtual IList<FalloHist> FalloHist
        {
            get { return _fallohist; }
            set { _fallohist = value; }
        }

        public virtual IList<Pedido> Pedido
        {
            get { return _pedido; }
            set { _pedido = value; }
        }

        public virtual IList<PedidoHist> PedidoHist
        {
            get { return _pedidohist; }
            set { _pedidohist = value; }
        }
        #endregion

        #region Equals And HashCode Overrides
        /// <summary>
        /// local implementation of Equals based on unique value members
        /// </summary>
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if ((obj == null) || (obj.GetType() != this.GetType())) return false;
            Proveedor castObj = (Proveedor)obj;
            return (castObj != null) &&
            this._cveproveedor == castObj.CveProveedor;
        }
        /// <summary>
        /// local implementation of GetHashCode based on unique value members
        /// </summary>
        public override int GetHashCode()
        {
            int hash = 57;
            //hash = 27 * hash * _cveproveedor.GetHashCode();
            return hash;
        }
        #endregion

        public int CompareTo(object other)
        {
            return CveProveedor.Value.CompareTo((other as Proveedor).CveProveedor.Value);
        }

        public override string ToString()
        {
            return CveProveedor + " - " + NombreFiscal;
        }

        #region business logic

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
