﻿using Argesys.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.DataAccess.Abstract
{
    public interface IContactDal : IEntityRepository<Contact>
    {
    }
}
