using Argesys.Business.Abstract;
using Argesys.DataAccess.Concrete.EntityFramework;
using Argesys.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private EfBrandDal _brandDal;
        //EfProductDal _productDal = new EfProductDal();
        public BrandManager(EfBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public List<Brand> GetAll()
        {

            return _brandDal.GetAll();
        }
     }

}

    

