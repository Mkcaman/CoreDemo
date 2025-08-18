using BusinessLayer.Abstract;
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
        public void TAdd(Blog entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Blog entity)
        {
            throw new NotImplementedException();
        }

        public Blog TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> TListAll()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Blog entity)
        {
            throw new NotImplementedException();
        }
    }
}
