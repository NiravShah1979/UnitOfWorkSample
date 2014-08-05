using System.Reflection;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace UnitOfWorkDal.Mappings.Repository
{
    public class NhibernateSessionFactory
    {
        protected ISessionFactory SessionFactory;
        private readonly string _connectionString;

        public NhibernateSessionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(
                    MsSqlConfiguration
                        .MsSql2008
                        .ConnectionString(_connectionString))
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                .BuildConfiguration().BuildSessionFactory();
        }

    }
}