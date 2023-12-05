using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class TripDriverV
    {
        [Required]
        [Column("DRIVERGUID")]
        [StringLength(36)]
        public string Driverguid { get; set; }
        [Required]
        [Column("DRIVERID")]
        [StringLength(1000)]
        public string Driverid { get; set; }
        [Column("PER_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime PerEffectivestartdate { get; set; }
        [Column("PER_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime PerEffectiveenddate { get; set; }
        [Column("DRV_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime DrvEffectivestartdate { get; set; }
        [Column("DRV_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? DrvEffectiveenddate { get; set; }
    }
}
