using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    public class CategoryManager : ICategoryService
    {
        ICategoryDal _category;

        public CategoryManager(ICategoryDal categoryDal)
        {
             _category = categoryDal;
        }

        public void TAdd(Category entity)
        {

            _category.Add(entity);
        }

        public void TDelete(Category entity)
        {
            _category.Delete(entity);
        }

        public Category TGetById(int id)
        {
           return _category.GetById(id);
        }

        public List<Category> TListAll()
        {
           return _category.ListAll();
        }

        public void TUpdate(Category entity)
        {
            _category.Update(entity);
        }
    }
}
