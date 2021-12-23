using Argesys.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.Entities.Concrete
{
    public class Brand : IEntity
    {
        [Key]
    
        public int Brand_Id { get; set; }
        public string Brand_Name { get; set; }
    }
}
