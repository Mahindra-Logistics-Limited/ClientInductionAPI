using ClientInductionAPI.Models.CIAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientInductionAPI.ClientInductionRepository
{
    public interface ICIRepo
    {
        public List<CIResponse> getClientInductiondetail(string mob_no);


    }
}
