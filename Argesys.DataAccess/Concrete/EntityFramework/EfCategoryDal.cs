using Argesys.DataAccess.Abstract;
using Argesys.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        public void Add(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            using (ArgesysContext context = new ArgesysContext())
            {
                return context.Categories.ToList();
            }

        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
