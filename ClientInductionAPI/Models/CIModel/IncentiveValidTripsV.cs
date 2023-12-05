using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class IncentiveValidTripsV
    {
        [Column("CARREGISTRATIONNO")]
        [StringLength(36)]
        public string Carregistrationno { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Required]
        [Column("TRIPID")]
        [StringLength(36)]
        public string Tripid { get; set; }
        [Column("REVENUE", TypeName = "NUMBER")]
        public decimal? Revenue { get; set; }
        [Column("TRIPENDTIME", TypeName = "DATE")]
        public DateTime? Tripendtime { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
    }
}
