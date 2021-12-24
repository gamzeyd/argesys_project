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
 
        public BrandManager(EfBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
             _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {

            return _brandDal.GetAll();
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }
    }

}

    

