using Argesys.DataAccess.Abstract;
using Argesys.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.DataAccess.Concrete.EntityFramework
{
    public class EfCompanyDal : EfEntityRepositoryBase<Company, ArgesysContext>, ICompanyDal
    {
        
    }
}
