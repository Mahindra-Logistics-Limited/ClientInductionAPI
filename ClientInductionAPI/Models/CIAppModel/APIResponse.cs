using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientInductionAPI.Models.CIAppModel
{
    public class APIResponse
    {
        public string status { get; set; }
        public int statuscode { get; set; }
        public string message { get; set; }
    }
}
