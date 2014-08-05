using FluentNHibernate.Mapping;
using UnitOfWork.Dal.Model;

namespace UnitOfWorkDal.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Id(x => x.CategoryId).GeneratedBy.Identity();
            Map(x => x.CategoryName);
        }
    }
}
