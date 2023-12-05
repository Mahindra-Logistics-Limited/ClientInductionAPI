using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class RuleCarDriverV
    {
        [Required]
        [Column("CARDRIVER_GUID")]
        [StringLength(36)]
        public string CardriverGuid { get; set; }
        [Required]
        [Column("CAR_GUID")]
        [StringLength(36)]
        public string CarGuid { get; set; }
        [Column("CAR_REGN_NO")]
        [StringLength(255)]
        public string CarRegnNo { get; set; }
        [Required]
        [Column("DRIVERGUID")]
        [StringLength(36)]
        public string Driverguid { get; set; }
    }
}
