using System.Collections.Generic;

namespace UnitOfWorkDal.Mappings.Repository
{
    public interface IRepository<T>
    {
        T Get(object id);
        bool Save(T value);
        bool Update(T value);
        bool Delete(T value);
        IList<T> GetAll();
        bool Delete(System.Collections.Generic.IEnumerable<T> entities);
    }
}