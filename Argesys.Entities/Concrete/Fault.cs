using Argesys.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.Entities.Concrete
{

        public class Fault : IEntity
        {
            [Key]

            public int FaultId { get; set; }
            public string FaultName { get; set; }
        }
    }

