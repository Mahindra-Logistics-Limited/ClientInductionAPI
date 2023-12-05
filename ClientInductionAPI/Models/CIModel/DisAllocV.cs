using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisAllocV
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
    }
}
