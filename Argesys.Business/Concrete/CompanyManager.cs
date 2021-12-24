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
   public class CompanyManager : ICompanyService
    {
        private EfCompanyDal _companyDal;

        public CompanyManager(EfCompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public void Add(Company company)
        {
            _companyDal.Add(company);
        }

        public void Delete(Company company)
        {
            _companyDal.Delete(company);
        }

        public List<Company> GetAll()
        {
            return _companyDal.GetAll();
        }

        public void Update(Company company)
        {
            _companyDal.Update(company);
        }
    }

       
    }

