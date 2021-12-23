using Argesys.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.Entities.Concrete
{
   public  class Category:IEntity 
    {
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }

    }
}
