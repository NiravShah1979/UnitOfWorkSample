using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using UnitOfWork.Dal;

namespace UnitOfWorkDal.Mappings.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ISession _session;

        public Repository(ISession session)
        {
            _session = session;
        }
      
        public bool Save(T value)
        {
            _session.Save(value);
            return true;
        }

        public T Get(object id)
        {
            return _session.Get<T>(id);
        }

        public bool Update(T value)
        {
            _session.SaveOrUpdate(value);
            return true;
        }

        public bool Delete(T value)
        {
            _session.Delete(value);
            return true;
        }

        public bool Delete(System.Collections.Generic.IEnumerable<T> entities)
        {
            foreach (T entity in entities)
            {
                _session.Delete(entity);
            }
            return true;
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}