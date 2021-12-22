﻿using Argesys.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.DataAccess.Abstract
{
    interface IProductDal
    {
        List<Product> GetAll();
        Product Get(int id);
        void Add(Product product);
        void Update(Product services);
        void Delete(Product services);
    }
}
