using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adquisiciones.Business.Excepciones
{
    ///<summary>
    /// Lanza las excepciones de los pedidos
    ///</summary>
    public class PedidoException : Exception
    {
        ///<summary>
        ///</summary>
        ///<param name="mensaje"></param>
        public PedidoException(string mensaje)
            : base(mensaje)
        {
            

        }
    }
}
