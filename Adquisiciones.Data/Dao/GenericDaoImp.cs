using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Spring.Stereotype;


namespace Adquisiciones.Data.Dao
{
    /// <summary>
    /// Implementacion de los metodos comunes
    /// </summary>
    /// <typeparam name="TE">Entidad</typeparam>
    /// <typeparam name="TId">Id</typeparam>
    [Repository]
    public abstract class GenericDaoImp<TE, TId> : IGenericDao<TE, TId>
    {
        public ISessionFactory SessionFactory { get; set; }

        protected ISession CurrentSession
        {
            get { return SessionFactory.GetCurrentSession(); }
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="entity">Entidad a persistir</param>
        /// <returns>El id generado por la estrategia</returns>
        [Transaction]public virtual TId Insert(TE entity)
        {
            return (TId)CurrentSession.Save(entity);
        }

        [Transaction]
        public void Update(TE entity)
        {
            CurrentSession.SaveOrUpdate(entity);
            CurrentSession.Flush();//Forzar
        }

        [Transaction]
        public TE Merge(TE entity)
        {
            var id = (TE)CurrentSession.Merge(entity);
            CurrentSession.Flush();//Forzar 
            return id;
        }


        [Transaction]
        public void Delete(TE entity)
        {
            if(!CurrentSession.Contains(entity))
                CurrentSession.Refresh(entity);
            CurrentSession.Delete(entity);
            CurrentSession.Flush();
        }

        [Transaction(ReadOnly = true)]
        public TE Get(TId id)
        {
            return CurrentSession.Get<TE>(id);
        }

        [Transaction(ReadOnly = true)]
        public IList<TE> FindAll()
        {
            var crit = CurrentSession.CreateCriteria(typeof(TE));
            return crit.List<TE>();
        }

        [Transaction(ReadOnly = true)]
        public DateTime FechaServidor()
        {
            var query = CurrentSession.GetNamedQuery("Util.FechaServidor");
            return query.UniqueResult<DateTime>();
        }


        [Transaction(ReadOnly = true)]
        public IList<T> CargarCatalogo<T>(string claveOrder, params object[] parametros)
        {

            object campo = "Estatus";
            object valor = "A";
            if(parametros.Count() == 2)
            {
                campo = parametros[0];
                valor = parametros[1];
            }

            var criteria = CurrentSession.CreateCriteria(typeof(T));
            criteria.Add(Restrictions.Eq(campo.ToString(), valor));
            criteria.AddOrder(Order.Desc(claveOrder));
            return criteria.List<T>();
        }
    }
}
