using ClientInductionAPI.ClientInductionRepository;
using ClientInductionAPI.Models.CIAppModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientInductionAPI.Controllers
{
    public class ClientInductionController : Controller
    {
        #region PROPERTIES
        private readonly ICIRepo APIRepositoryInstance;
        #endregion

        public ClientInductionController(ICIRepo _APIRepositoryInstance)
        {
            this.APIRepositoryInstance = _APIRepositoryInstance;
        }


        [HttpPost("GetInductionDetails")]
        public async Task<IActionResult> GetInductionDetails(string ClientID)
        {

            dynamic response = null;
            try
            {

                response = APIRepositoryInstance.getClientInductiondetail(ClientID);




                return Ok(response);
            }
            catch (Exception ex)
            {
                return Ok(new APIResponse
                {
                    statuscode = 500,
                    status = "Failed",
                    message = ex.Message
                });
            }
            if (response == null)
                return Ok(new APIResponse
                {
                    statuscode = 401,
                    status = "Failed",
                    message = "Authentication id creation failed."
                });
            return Ok(response);
        }

    }
}

