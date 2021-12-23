using Argesys.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;

namespace Argesys.Entities.Concrete
{
    public  class Product: IEntity
    {
        [Key]
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int AdvertisingFirmId { get; set; }
        public DateTime FaultDate { get; set; }
        public string StationName { get; set; }
        public int ContactId { get; set; }
        public int BrandId { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string FaultDescription { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public string Picture4 { get; set; }
        public string Picture5 { get; set; }
        public string Picture6 { get; set; }
        

    }
}
