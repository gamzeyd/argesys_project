using Argesys.DataAccess.Concrete.EntityFramework;
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
        private EfProductDal _productDal;
        //EfProductDal _productDal = new EfProductDal();
        public ProductManager(EfProductDal productDal)
        {
            _productDal = productDal;
        }
           
        public List<Product> GetAll()
        {
            
            
            return _productDal.GetAll();
        }
    }
}
