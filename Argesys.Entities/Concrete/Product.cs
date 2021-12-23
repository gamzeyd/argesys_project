using Argesys.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.Entities.Concrete
{
   public  class Product: IEntity
    {

        public int Service_Id { get; set; }
        public string Service_Name { get; set; }
        public int Advertising_Firm_Id { get; set; }
        public DateTime Fault_Date { get; set; }
        public string Station_Name { get; set; }
        public int Contact_Id { get; set; }
        public int Brand_Id { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Fault_Description { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public string Picture4 { get; set; }
        public string Picture5 { get; set; }
        public string Picture6 { get; set; }
        

    }
}
