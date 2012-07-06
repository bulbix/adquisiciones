using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adquisiciones.Business.ModFallo
{
    ///<summary>
    ///</summary>
    public class FalloProcesoEvento
    {
        ///<summary>
        ///</summary>
        ///<param name="porcentaje"></param>
        public FalloProcesoEvento(int porcentaje)
        {
            this.Porcentaje = porcentaje;

        }
        ///<summary>
        ///</summary>
        public int Porcentaje;
    }

    ///<summary>
    ///</summary>
    ///<param name="sender"></param>
    ///<param name="e"></param>
    public delegate void FalloEventHandler(object sender, FalloProcesoEvento e);
}
