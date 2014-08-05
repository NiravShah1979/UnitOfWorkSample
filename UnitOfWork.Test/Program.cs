using System;
using UnitOfWork.Dal;
using UnitOfWork.Dal.Interface;
using UnitOfWork.Dal.Model;

namespace UnitOfWork.Test
{
    class Program
    {
        private static IMenuDal _menuDal;
        static void Main(string[] args)
        {
            _menuDal = new MenuDal();
            var menu = _menuDal.GetByMenuId(1);
            Console.Write(menu.ItemName);
            Console.Write(menu.Price);
            Console.Write(menu.Category.CategoryName);

            _menuDal.SaveMenu();
            //var m = new Menu() { ItemName = "Test", Price = 4.95f};
            //IRepository<Menu> mRepo = new NHibernateRepository<Menu>();
            //mRepo.Save(m);
            Console.ReadLine();
        }
    }
}
