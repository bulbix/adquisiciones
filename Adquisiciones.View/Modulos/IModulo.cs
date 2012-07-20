using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adquisiciones.View
{
    public interface IModulo
    {
        void BindearCampos();
        void InicializarCatalogos();
        void Nuevo();
        void Guardar();
        void Consultar();
    }
}
