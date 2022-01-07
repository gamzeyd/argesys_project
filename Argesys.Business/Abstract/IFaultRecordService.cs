using Argesys.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.Business.Abstract
{
   public  interface IFaultRecordService
    {
        List<FaultRecord> GetAll();
        void Add(FaultRecord faultrecord);
        void Update(FaultRecord faultrecord);
        void Delete(FaultRecord faultrecord);
        List<FaultRecord> GetRecordsByCompany(string company);
        List<FaultRecord> GetRecordsByStationName(string stationname);
        List<FaultRecord> GetRecordsByContact(string contact);
    }
}
