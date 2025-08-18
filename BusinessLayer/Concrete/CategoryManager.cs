using BusinessLayer.Abstract;
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
        EfCategoryRepository efCategoryRepository;
        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        public void TAdd(Category entity)
        {

            efCategoryRepository.Add(entity);
        }

        public void TDelete(Category entity)
        {
            efCategoryRepository.Delete(entity);
        }

        public Category TGetById(int id)
        {
           return efCategoryRepository.GetById(id);
        }

        public List<Category> TListAll()
        {
           return efCategoryRepository.ListAll();
        }

        public void TUpdate(Category entity)
        {
            efCategoryRepository.Update(entity);
        }
    }
}
