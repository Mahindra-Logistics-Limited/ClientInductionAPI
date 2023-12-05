using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CdStatusV
    {
        [Required]
        [Column("CARDRIVERGUID")]
        [StringLength(36)]
        public string Cardriverguid { get; set; }
        [Column("REGISTRATIONNO")]
        [StringLength(255)]
        public string Registrationno { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("DRIVERMASTERGUID")]
        [StringLength(36)]
        public string Drivermasterguid { get; set; }
        [Column("STATUS_CODE")]
        [StringLength(25)]
        public string StatusCode { get; set; }
        [Column("CD_OBJECTVERSIONNO")]
        public int? CdObjectversionno { get; set; }
    }
}
