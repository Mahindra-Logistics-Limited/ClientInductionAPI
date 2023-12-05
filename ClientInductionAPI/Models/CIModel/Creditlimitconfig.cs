using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("CREDITLIMITCONFIG")]
    public partial class Creditlimitconfig
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("CREDITLIMITDAY")]
        public byte Creditlimitday { get; set; }
        [Column("CREDITLIMITAMOUNT")]
        public long Creditlimitamount { get; set; }
        [Column("BBMPARAMETERUPDATEDDATE", TypeName = "DATE")]
        public DateTime? Bbmparameterupdateddate { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime Effectiveenddate { get; set; }
    }
}
