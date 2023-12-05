using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DailyTransactionSummaryV
    {
        [Column("SITE_GUID")]
        [StringLength(36)]
        public string SiteGuid { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("DATES", TypeName = "DATE")]
        public DateTime? Dates { get; set; }
        [Column("ACCRUAL_AMOUNT", TypeName = "NUMBER")]
        public decimal? AccrualAmount { get; set; }
        [Column("CC_AMOUNT", TypeName = "NUMBER")]
        public decimal? CcAmount { get; set; }
        [Column("AIRPORT_AMOUNT", TypeName = "NUMBER")]
        public decimal? AirportAmount { get; set; }
        [Column("ST_AMOUNT", TypeName = "NUMBER")]
        public decimal? StAmount { get; set; }
        [Column("OTHER_AMOUNT", TypeName = "NUMBER")]
        public decimal? OtherAmount { get; set; }
    }
}
