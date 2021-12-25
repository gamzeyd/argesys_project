using Argesys.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.Business.Abstract
{
   public  interface IFaultService
    {
        List<Fault> GetAll();
        void Add(Fault fault);
        void Update(Fault fault);
        void Delete(Fault fault);
    }
}
