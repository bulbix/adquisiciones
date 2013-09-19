using System;
using System.Collections.Generic;
using NHibernate;

namespace Adquisiciones.Data.Dao
{
    public interface IGenericDao<TE,TId>
    {
        ISessionFactory SessionFactory { get; set; }

        TId Insert(TE entity);
        void Update(TE entity);
        TE Merge(TE entity);
        void Delete(TE entity);
        TE Get(TId id);
        IList<TE> FindAll();
        IList<T> CargarCatalogo<T>(string claveOrder, params object[] parametros);
        IList<T> CargarCatalogoSinEstatus<T>(string claveOrder);
        DateTime FechaServidor();
    }
}
