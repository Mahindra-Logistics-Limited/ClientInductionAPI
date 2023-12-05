using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientInductionAPI.Models.CIAppModel
{
    public class CIResponse
    {
        public string BusinessArea { get; set; }
        public string Customer { get; set; }
        public string BAName { get; set; }
        public string VehicleNo { get; set; }
        public string DriverName { get; set; }
        public string DriverLicenseNo { get; set; }
        public string DriverMobNo { get; set; }

        public string VehicleStatus { get; set; }

    }

    public class CIResponseList
    {
        public CIResponseList()
        {
            CIRespone = new List<CIResponse>();
        }
        public List<CIResponse> CIRespone { get; set; }
    }
}
