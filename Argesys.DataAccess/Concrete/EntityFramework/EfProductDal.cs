using Argesys.DataAccess.Abstract;
using Argesys.DataAccess.Concrete.EntityFramework;
using Argesys.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {

        public List<Product> GetAll()
        {
            List<Product> products = new List<Product>
           // using (ArgesysContext context = new ArgesysContext())
            {
                //return context.Products.ToList();

                new Product {ServiceId=2, ServiceName="Gamzeeee", AdvertisingFirmId=44,  }
               

            };
        return products;
              
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

