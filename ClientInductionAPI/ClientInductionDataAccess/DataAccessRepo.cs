using ClientInductionAPI.Appdbcontext;
using ClientInductionAPI.Models.CIAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientInductionAPI.ClientInductionDataAccess
{
    public class DataAccessRepo : IDataAccessRepo
    {
        private readonly DBContext _context;
        public DataAccessRepo(DBContext context)
        {
            _context = context;
        }

     
        
        public List<CIResponse> GetIndctdetail(string clientid)
        {


            CIResponse ciresponse=new CIResponse();
            var CIResponselist = new List<CIResponse>();
            try
            {
                var result =( from cv in _context.CarVs
                             join cm in (from cm in _context.Clientmapmasters
                                         where cm.Clientid == clientid
                                         select new { cm.Clientid, cm.Clientmapguid , cm.Clientname }).Distinct() on cv.Clientmapguid equals cm.Clientmapguid
                             join cdv in _context.CarDriverVs on cv.CarRegnNo equals cdv.CarRegnNo
                              join dv in _context.DriverVs on cdv.DriverId equals dv.Driverid
                             join pl in _context.PersondocsLicenseVs on dv.Driverid equals pl.PersonId
                             where cm.Clientid == clientid
                              select new
                             {
                                 cv.CarRegnNo,
                                 dv.Driverid,
                                 Drivername =dv.DriverFname+ " "+ dv.DriverMname + " " + dv.DriverLname,
                                 pl.DocNo,
                                 dv.Spid,
                                 SPName= dv.SpFname + " "+dv.SpMname + " " + dv.SpLname,
                                 cm.Clientname,
                                 dv.ContactNo,
                                 cv.CarStatusName
                             });


                foreach(var res in result)
                {
                    ciresponse = new CIResponse
                    {
                        BusinessArea = clientid,
                        Customer = res.Clientname.Replace("(" + clientid+")", "").Trim(),
                        BAName = res.SPName.Trim(),
                        VehicleNo = res.CarRegnNo,
                        DriverName = res.Drivername.Trim(),
                        DriverLicenseNo = res.DocNo,
                        DriverMobNo = res.ContactNo,
                        VehicleStatus= res.CarStatusName
                    };
                    CIResponselist.Add(ciresponse);
                }

                return CIResponselist;

            }
            catch (Exception ex)
            {
                throw;
            }

            return CIResponselist;

        }
    }
}
