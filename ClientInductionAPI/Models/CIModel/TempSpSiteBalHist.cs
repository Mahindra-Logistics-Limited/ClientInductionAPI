using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TEMP_SP_SITE_BAL_HIST")]
    public partial class TempSpSiteBalHist
    {
        [Column("TOT_HIST", TypeName = "NUMBER")]
        public decimal? TotHist { get; set; }
        [Column("BALANCE_DT", TypeName = "DATE")]
        public DateTime? BalanceDt { get; set; }
    }
}
