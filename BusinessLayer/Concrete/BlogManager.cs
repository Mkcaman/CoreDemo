using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blog;
        public BlogManager(IBlogDal blogDal)
        {
            _blog = blogDal;
        }

        public void TAdd(Blog entity)
        {
            _blog.Add(entity);   
        }

        public void TDelete(Blog entity)
        {
            _blog.Delete(entity);
        }

        public Blog TGetById(int id)
        {
            return _blog.GetById(id);
        }

        public List<Blog> TListAll()
        {
            return _blog.ListAll();
        }

        public void TUpdate(Blog entity)
        {
            _blog.Update(entity);
        }
    }
}
