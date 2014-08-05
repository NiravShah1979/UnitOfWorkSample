using FluentNHibernate.Mapping;
using UnitOfWork.Dal.Model;

namespace UnitOfWorkDal.Mappings
{
    public class MenuMap : ClassMap<Menu>
    {
        public MenuMap()
        {
            Id(x => x.MenuId).GeneratedBy.Identity();
            Map(x => x.ItemName);
            Map(x => x.Price);
            References(x => x.Category).Column("CategoryId").Not.Cascade.Delete();
        }
    }
}
