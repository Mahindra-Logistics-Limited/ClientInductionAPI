using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class SpTotalBreakV
    {
        [Column("COUNT", TypeName = "NUMBER")]
        public decimal? Count { get; set; }
        [Column("SERVICEPROVIDERGUID")]
        [StringLength(36)]
        public string Serviceproviderguid { get; set; }
        [Column("TOTAL_BREAKS", TypeName = "NUMBER")]
        public decimal? TotalBreaks { get; set; }
    }
}
