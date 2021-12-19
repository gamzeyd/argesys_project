using Argesys.DataAccess.Concrete;
using Argesys.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.Business.Concrete
{
   public class ProductManager
    {
        ProductDal productDal = new ProductDal();
        public List<Product> GetAll()
        {
            
            return productDal.GetAll();
        }
    }
}
