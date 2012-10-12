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

        public ArticuloBusqueda(int cveArt, string descripcion, string unidad)
        {
            _cveArt = cveArt;
            _descripcion = descripcion;
            _unidad = unidad;
        }

        private string _descripcion;
        private string _unidad;

        public int CveArt
        {
            get { return _cveArt; }
            set { _cveArt = value; }
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
