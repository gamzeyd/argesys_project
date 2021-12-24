using Argesys.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.Entities.Concrete
{
  
        public class Company : IEntity
        {
            [Key]

            public int CompanyId { get; set; }
            public string CompanyName { get; set; }
        }
    }

