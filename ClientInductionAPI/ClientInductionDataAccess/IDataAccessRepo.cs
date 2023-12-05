using ClientInductionAPI.Models.CIAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientInductionAPI.ClientInductionDataAccess
{
    public interface IDataAccessRepo
    {
        public List<CIResponse> GetIndctdetail(string clientid);
    }
}
