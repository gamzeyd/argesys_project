﻿using Argesys.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.Entities.Concrete
{
   public  class Category:IEntity 
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
