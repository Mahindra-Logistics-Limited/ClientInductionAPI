using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("GROUPVARIANT")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "GROUPVARIANT_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_GROUPVARIANT_PKGUID", IsUnique = true)]
    public partial class Groupvariant
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("NAME")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Effectiveenddate { get; set; }
        [Column("AGREEMENTPERIOD", TypeName = "NUMBER")]
        public decimal? Agreementperiod { get; set; }
        [Column("MAXREFUNDDAYS", TypeName = "NUMBER")]
        public decimal? Maxrefunddays { get; set; }
        [Column("CAPITALRECOVERYPERIOD", TypeName = "NUMBER")]
        public decimal? Capitalrecoveryperiod { get; set; }
        [Required]
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("USERUPDATED")]
        [StringLength(36)]
        public string Userupdated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("USERDELETED")]
        [StringLength(36)]
        public string Userdeleted { get; set; }
        [Column("DATEDELETED", TypeName = "DATE")]
        public DateTime? Datedeleted { get; set; }
        [Column("USERARCHIVED")]
        [StringLength(36)]
        public string Userarchived { get; set; }
        [Column("DATEARCHIVED", TypeName = "DATE")]
        public DateTime? Datearchived { get; set; }
        [Column("ORACLEENTITYNAME")]
        [StringLength(100)]
        public string Oracleentityname { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(1000)]
        public string Oracleentityid { get; set; }
        [Column("OBJECTVERSIONNO")]
        public int? Objectversionno { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("REFUNDPERCENTAGE", TypeName = "NUMBER")]
        public decimal? Refundpercentage { get; set; }
        [Column("REFUNDABLEADJUSTABLEDEPOSIT", TypeName = "NUMBER")]
        public decimal? Refundableadjustabledeposit { get; set; }
        [Column("MINIMUMDEPOSIT", TypeName = "NUMBER")]
        public decimal? Minimumdeposit { get; set; }
        [Column("ISDEFAULTGV")]
        public bool? Isdefaultgv { get; set; }
    }
}
