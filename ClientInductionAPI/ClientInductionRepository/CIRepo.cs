using ClientInductionAPI.ClientInductionDataAccess;
using ClientInductionAPI.Models.CIAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientInductionAPI.ClientInductionRepository
{
    public class CIRepo:ICIRepo
    {
        private readonly IDataAccessRepo repo;

        public CIRepo()
        {
            repo = new DataAccessRepo(new Appdbcontext.DBContext());
        }
        public List<CIResponse> getClientInductiondetail(string clientid)
        {
            List<CIResponse> ciresp = new List<CIResponse>();
            ciresp = repo.GetIndctdetail(clientid);
            return ciresp;
        }
    }
}
