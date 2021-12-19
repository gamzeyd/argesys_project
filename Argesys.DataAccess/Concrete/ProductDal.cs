using Argesys.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.DataAccess.Concrete
{
    public class ProductDal
    {

        public List<Product> GetAll()
        {
            using (ArgesysContext context = new ArgesysContext())


            {
                return context.Products.ToList();

            }
              
        }

        public Product Get(int id)
        {
            using (ArgesysContext context = new ArgesysContext())


            {
                return context.Products.SingleOrDefault(p => p.ServiceId == id);

            }

        }

        public void Add(Product product)
        {
            using (ArgesysContext context = new ArgesysContext())


            {
                context.Products.Add(product);
                context.SaveChanges();

            }
        }

        public void Update(Product services)
        {
        }

        public void Delete(Product services)
        {
        }
    }
}

