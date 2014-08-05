using UnitOfWork.Dal.Model;

namespace UnitOfWork.Dal.Interface
{
    public interface IMenuDal
    {
        Menu GetByMenuId(int id);
        void SaveMenu();
    }
}