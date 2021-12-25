using Argesys.Business.Abstract;
using Argesys.DataAccess.Concrete.EntityFramework;
using Argesys.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argesys.Business.Concrete
{
    public class FaultRecordManager : IFaultRecordService
    {
        private EfFaultRecordDal _faultRecordDal;

        public FaultRecordManager(EfFaultRecordDal faultRecordDal)
        {
            _faultRecordDal = faultRecordDal;
        }
        public void Add(FaultRecord faultrecord)
        {
            _faultRecordDal.Add(faultrecord);
        }

        public void Delete(FaultRecord faultrecord)
        {
            _faultRecordDal.Delete(faultrecord);
        }

        public List<FaultRecord> GetAll()
        {
            return _faultRecordDal.GetAll();
        }

        

        public List<FaultRecord> GetRecordsByStationName(string stationname)
        {
            return _faultRecordDal.GetAll(p => p.StationNames.ToLower().Contains(stationname.ToLower()));
        }

        public void Update(FaultRecord faultrecord)
        {
            _faultRecordDal.Update(faultrecord);
        }

        List<FaultRecord> IFaultRecordService.GetRecordsByCompany(string company)
        {
            return _faultRecordDal.GetAll(p => p.AdvertisingFirmId.Equals(Convert.ToInt32(company)));
        }
    }

   
}
