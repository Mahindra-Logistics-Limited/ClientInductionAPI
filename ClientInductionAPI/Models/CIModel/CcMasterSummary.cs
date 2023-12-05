using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CcMasterSummary
    {
        [Column("CAR_NO")]
        [StringLength(36)]
        public string CarNo { get; set; }
        [Column("DRIVER_ID", TypeName = "NUMBER")]
        public decimal? DriverId { get; set; }
        [Column("BIDDING", TypeName = "NUMBER")]
        public decimal? Bidding { get; set; }
        [Column("DRY_RUN", TypeName = "NUMBER")]
        public decimal? DryRun { get; set; }
    }
}
