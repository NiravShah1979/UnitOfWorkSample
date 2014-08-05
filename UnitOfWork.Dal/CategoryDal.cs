using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnitOfWork.Dal.Model;
using UnitOfWorkDal.Mappings.Repository;

namespace UnitOfWork.Dal
{
    public class CategoryDal
    {
        private Repository<Category> _categoryRepository;
        Category GetByCategoryId(int id)
        {
            return _categoryRepository.Get(id);
        }
    }
}
