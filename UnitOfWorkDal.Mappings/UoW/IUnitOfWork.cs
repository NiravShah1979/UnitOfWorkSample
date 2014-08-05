using System;
using NHibernate;

namespace UnitOfWorkDal.Mappings.UoW
{
    public interface IUnitOfWork : IDisposable 
    {
        ISession Session { get; }
        void Commit();
        void Rollback();
    }
}