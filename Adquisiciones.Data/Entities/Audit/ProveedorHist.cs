using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adquisiciones.Data.Entities
{
    public class ProveedorHist
    {
        protected long _id;
        protected long _idexterno;

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
        protected DateTime _fechaalta;
        protected Usuario _usuario;
        protected string _estatus;
        protected DateTime? _fechamodificacion;
        protected int _modificacion;

        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual long IdExterno
        {
            get { return _idexterno; }
            set { _idexterno = value; }
        }


        public virtual string NombreFiscal
        {
            get { return _nombrefiscal; }
            set { _nombrefiscal = value; }
        }

        public virtual string NombreComercial
        {
            get { return _nombrecomercial; }
            set { _nombrecomercial = value; }
        }

        public virtual string Paterno
        {
            get { return _paterno; }
            set { _paterno = value; }
        }

        public virtual string Materno
        {
            get { return _materno; }
            set { _materno = value; }
        }

        public virtual string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public virtual string Calle
        {
            get { return _calle; }
            set { _calle = value; }
        }

        public virtual string Colonia
        {
            get { return _colonia; }
            set { _colonia = value; }
        }

        public virtual string Delegacion
        {
            get { return _delegacion; }
            set { _delegacion = value; }
        }

        public virtual string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public virtual string Pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        public virtual string CodigoP
        {
            get { return _codigop; }
            set { _codigop = value; }
        }

        public virtual string Rfc
        {
            get { return _rfc; }
            set { _rfc = value; }
        }

        public virtual string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        public virtual string Tel2
        {
            get { return _tel2; }
            set { _tel2 = value; }
        }

        public virtual string Tel3
        {
            get { return _tel3; }
            set { _tel3 = value; }
        }

        public virtual string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        public virtual string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        public virtual string Rpaterno
        {
            get { return _rpaterno; }
            set { _rpaterno = value; }
        }

        public virtual string Rmaterno
        {
            get { return _rmaterno; }
            set { _rmaterno = value; }
        }

        public virtual string Rnombre
        {
            get { return _rnombre; }
            set { _rnombre = value; }
        }

        public virtual string Giro
        {
            get { return _giro; }
            set { _giro = value; }
        }

        public virtual string Observacion
        {
            get { return _observacion; }
            set { _observacion = value; }
        }

        public virtual string IpTerminal
        {
            get { return _ipterminal; }
            set { _ipterminal = value; }
        }

        public virtual DateTime FechaAlta
        {
            get { return _fechaalta; }
            set { _fechaalta = value; }
        }

        public virtual Usuario Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public virtual string Estatus
        {
            get { return _estatus; }
            set { _estatus = value; }
        }

        public virtual DateTime? FechaModificacion
        {
            get { return _fechamodificacion; }
            set { _fechamodificacion = value; }
        }

        public virtual int Modificacion
        {
            get { return _modificacion; }
            set { _modificacion = value; }
        }

        public virtual CatEmpresa CatEmpresa
        {
            get;
            set;
        }

        public virtual string Tipo { get; set; }

    }
}