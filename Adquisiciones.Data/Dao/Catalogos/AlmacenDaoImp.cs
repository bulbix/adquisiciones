using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adquisiciones.Data.Entities;
using Spring.Transaction.Interceptor;

namespace Adquisiciones.Data.Dao.Catalogos
{
    public class AlmacenDaoImp:GenericDaoImp<Almacen,string>,IAlmacenDao
    {

        [Transaction(ReadOnly = true)]
        public IList<Almacen> getAlmacenes(Almacen almacenAdq)
        {
            var almacenes = new List<Almacen>();
            switch (almacenAdq.IdAlmacen)
            {
                case "C2":
                    almacenes.Add(Get("PC"));
                    almacenes.Add(Get("GC"));
                    almacenes.Add(Get("FC"));
                    break;
                case "C5":
                    almacenes.Add(Get("AC"));
                    break;
                case "P2":
                    almacenes.Add(Get("F"));
                    almacenes.Add(Get("G"));
                    almacenes.Add(Get("P"));
                    break;
                case "P5":
                    almacenes.Add(Get("A"));
                    break;
            }

            return almacenes;
        }
    }
}
