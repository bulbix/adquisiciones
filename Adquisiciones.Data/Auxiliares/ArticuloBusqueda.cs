using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adquisiciones.Data.Auxiliares
{
    public class ArticuloBusqueda
    {
        private int _cveArt;
        public ArticuloBusqueda()
        {
            }

        public ArticuloBusqueda(int cveArt, string descripcion, string presentacion)
        {
            _cveArt = cveArt;
            _descripcion = descripcion;
            _presentacion = presentacion;
        }

        private string _descripcion;
        private string _presentacion;

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

        public string Presentacion
        {
            get { return _presentacion; }
            set { _presentacion = value; }
        }
    }
}
