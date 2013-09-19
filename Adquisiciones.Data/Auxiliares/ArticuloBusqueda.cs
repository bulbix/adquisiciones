using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Entities;

namespace Adquisiciones.Data.Auxiliares
{
    public class ArticuloBusqueda
    {
        private int _cveArt;
        public ArticuloBusqueda()
        {
        }

        public ArticuloBusqueda(int cveArt, string descripcion, string unidad,
            string presentacion, string partida, string almacen)
        {
            _cveArt = cveArt;
            _descripcion = descripcion;
            _unidad = unidad;
            _presentacion = presentacion;
            _partida = partida;
            _almacen = almacen;
        }

        private string _descripcion;
        private string _unidad;
        private string _presentacion;
        private string _partida;
        private string _almacen;

        public int CveArt
        {
            get { return _cveArt; }
            set { _cveArt = value; }
        }

        public string Presentacion
        {
            get { return _presentacion; }
            set { _presentacion = value; }
        }

        public string Partida
        {
            get { return _partida; }
            set { _partida = value; }
        }

        public string Almacen
        {
            get { return _almacen; }
            set { _almacen = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string Unidad
        {
            get { return _unidad; }
            set { _unidad = value; }
        }
    }
}
