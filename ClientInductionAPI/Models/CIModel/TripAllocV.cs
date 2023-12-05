using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class TripAllocV
    {
        [Column("REGISTRATIONNO")]
        [StringLength(255)]
        public string Registrationno { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("SPSITEMASTERGUID")]
        [StringLength(36)]
        public string Spsitemasterguid { get; set; }
        [Required]
        [Column("PERSONID")]
        [StringLength(1000)]
        public string Personid { get; set; }
        [Column("SERVICEPROVIDERGUID")]
        [StringLength(36)]
        public string Serviceproviderguid { get; set; }
        [Required]
        [Column("SPPERSONGUID")]
        [StringLength(36)]
        public string Sppersonguid { get; set; }
        [Column("SP_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime SpEffectivestartdate { get; set; }
        [Column("SP_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? SpEffectiveenddate { get; set; }
        [Column("PM_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime PmEffectivestartdate { get; set; }
        [Column("PM_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime PmEffectiveenddate { get; set; }
        [Column("ALLOCATIONSTARTDATE", TypeName = "DATE")]
        public DateTime? Allocationstartdate { get; set; }
        [Column("ALLOCATIONENDDATE", TypeName = "DATE")]
        public DateTime? Allocationenddate { get; set; }
    }
}
