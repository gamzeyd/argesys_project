﻿using Argesys.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.Entities.Concrete

    {
        public class FaultRecord : IEntity
        {
            [Key]

            public int FaultRecordId { get; set; }
            public int AdvertisingFirmId { get; set; }
            public string FaultDate { get; set; }
            public string StationNames { get; set; }
            public int ContactId { get; set; }
            public int BrandId  { get; set; }
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

