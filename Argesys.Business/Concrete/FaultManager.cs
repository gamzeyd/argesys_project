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
    public class FaultManager : IFaultService
    {
        private EfFaultDal _faultDal;

        public FaultManager(EfFaultDal faultDal)
        {
            _faultDal = faultDal;
        }
        public void Add(Fault fault)
        {
            _faultDal.Add(fault);
        }

        public void Delete(Fault fault)
        {
            _faultDal.Delete(fault);
        }

        public List<Fault> GetAll()
        {
            return _faultDal.GetAll();
        }

        public void Update(Fault fault)
        {
            _faultDal.Update(fault);
        }
    }
}
