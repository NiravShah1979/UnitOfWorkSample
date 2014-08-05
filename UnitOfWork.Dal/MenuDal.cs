using UnitOfWork.Dal.Interface;
using UnitOfWork.Dal.Model;
using UnitOfWorkDal.Mappings.Repository;

namespace UnitOfWork.Dal
{
    public class MenuDal : IMenuDal
    {
        private NhibernateSessionFactory _sessionFactory;
        private UnitOfWorkDal.Mappings.UoW.UnitOfWork _unitOfWork;
        private Repository<Menu> _menuRepository;
        private Repository<Category> _categoryRepository;
        private const string ConnectionString = @"Data Source=localhost;Initial Catalog=Sample;Integrated Security=True";

        public MenuDal()
        {
            _sessionFactory = new NhibernateSessionFactory(ConnectionString);
            _unitOfWork = new UnitOfWorkDal.Mappings.UoW.UnitOfWork(_sessionFactory.CreateSessionFactory());
            _menuRepository = new Repository<Menu>(_unitOfWork.Session);
            _categoryRepository = new Repository<Category>(_unitOfWork.Session);
        }
        public Menu GetByMenuId(int id)
        {
            return _menuRepository.Get(id);
        }

        public void SaveMenu()
        {
            var menu = new Menu()
            {
                Category = _categoryRepository.Get(1),
                ItemName = "Spring Roll",
                Price = 3.95f
            };
            _menuRepository.Save(menu);
            _unitOfWork.Commit();
        }
    }
}
