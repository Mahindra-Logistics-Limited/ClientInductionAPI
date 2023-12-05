using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SPSITEMASTER")]
    [Index(nameof(Billsiteuseid), Name = "SITE_BILL_SITE_IDX")]
    [Index(nameof(Serviceproviderguid), Name = "SITE_SP_IDX")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "SPSITEMASTER_GUID_OVN", IsUnique = true)]
    [Index(nameof(Carmasterguid), Name = "XMERU_CAR_IND")]
    [Index(nameof(Sitename), Name = "XMERU_SITENAME_IND")]
    [Index(nameof(Securitycombinationguid), Name = "XMERU_SITE_SEC")]
    [Index(nameof(Pkguid), Name = "XMERU_SPSITEMASTER_PKGUID", IsUnique = true)]
    public partial class Spsitemaster
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("SERVICEPROVIDERGUID")]
        [StringLength(36)]
        public string Serviceproviderguid { get; set; }
        [Required]
        [Column("LEBRANCHSECURITYGUID")]
        [StringLength(36)]
        public string Lebranchsecurityguid { get; set; }
        [Required]
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime Effectiveenddate { get; set; }
        [Column("ADDRESSGUID")]
        [StringLength(36)]
        public string Addressguid { get; set; }
        [Column("SITETYPEMASTERGUID")]
        [StringLength(36)]
        public string Sitetypemasterguid { get; set; }
        [Column("BILLSITEUSEID")]
        [StringLength(20)]
        public string Billsiteuseid { get; set; }
        [Column("SPAREFIELDSTRING1")]
        [StringLength(2000)]
        public string Sparefieldstring1 { get; set; }
        [Column("SPAREFIELDSTRING2")]
        [StringLength(2000)]
        public string Sparefieldstring2 { get; set; }
        [Column("SPAREFIELDSTRING3")]
        [StringLength(2000)]
        public string Sparefieldstring3 { get; set; }
        [Column("SPAREFIELDNUMBER1")]
        [StringLength(20)]
        public string Sparefieldnumber1 { get; set; }
        [Column("SPAREFIELDNUMBER2")]
        [StringLength(20)]
        public string Sparefieldnumber2 { get; set; }
        [Column("SPAREFIELDNUMBER3")]
        [StringLength(20)]
        public string Sparefieldnumber3 { get; set; }
        [Column("SPAREFIELDDATETIME1", TypeName = "DATE")]
        public DateTime? Sparefielddatetime1 { get; set; }
        [Column("SPAREFIELDDATETIME2", TypeName = "DATE")]
        public DateTime? Sparefielddatetime2 { get; set; }
        [Column("SPAREFIELDDATETIME3", TypeName = "DATE")]
        public DateTime? Sparefielddatetime3 { get; set; }
        [Column("DISABLED")]
        public bool? Disabled { get; set; }
        [Required]
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
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
        [Column("SITENAME")]
        [StringLength(100)]
        public string Sitename { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("SPSITESTARTDATE", TypeName = "DATE")]
        public DateTime? Spsitestartdate { get; set; }
        [Column("SPSITEENDDATE", TypeName = "DATE")]
        public DateTime? Spsiteenddate { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("CAPITAL_RECOVERY_END_DT", TypeName = "DATE")]
        public DateTime? CapitalRecoveryEndDt { get; set; }
        [Column("CAPITALRECOVERYSTARTDT", TypeName = "DATE")]
        public DateTime? Capitalrecoverystartdt { get; set; }
        [Column("CAPITALRECOVERYENDDT", TypeName = "DATE")]
        public DateTime? Capitalrecoveryenddt1 { get; set; }
        [Column("DEPOSITAMOUNT", TypeName = "NUMBER")]
        public decimal? Depositamount { get; set; }
        [Column("CREDITLIMIT")]
        public int? Creditlimit { get; set; }
        [Column("CREDITBALANCELIMIT", TypeName = "NUMBER")]
        public decimal? Creditbalancelimit { get; set; }
    }
}
