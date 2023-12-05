using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("USERMASTER")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "USERMASTER_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_USERMASTER_PKGUID", IsUnique = true)]
    [Index(nameof(Domainloginname), Name = "XMERU_USER_DOMAIN")]
    [Index(nameof(Oracleuserid), Name = "XMERU_USER_ORA")]
    public partial class Usermaster
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("EMAIL")]
        [StringLength(2000)]
        public string Email { get; set; }
        [Required]
        [Column("FIRSTNAME")]
        [StringLength(2000)]
        public string Firstname { get; set; }
        [Required]
        [Column("LASTNAME")]
        [StringLength(2000)]
        public string Lastname { get; set; }
        [Required]
        [Column("CONTACTNUMBER")]
        [StringLength(2000)]
        public string Contactnumber { get; set; }
        [Required]
        [Column("ALLOWDOMAINLOGIN")]
        [StringLength(1)]
        public string Allowdomainlogin { get; set; }
        [Required]
        [Column("DOMAINLOGINNAME")]
        [StringLength(2000)]
        public string Domainloginname { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime Effectiveenddate { get; set; }
        [Column("LOGINATTEMPTS")]
        [StringLength(20)]
        public string Loginattempts { get; set; }
        [Column("CULTURE")]
        [StringLength(2000)]
        public string Culture { get; set; }
        [Column("THEME")]
        [StringLength(2000)]
        public string Theme { get; set; }
        [Column("DISABLED")]
        public bool? Disabled { get; set; }
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
        [Column("LASTLOGIN", TypeName = "DATE")]
        public DateTime? Lastlogin { get; set; }
        [Column("FAILEDLOGINATTEMPTS")]
        [StringLength(20)]
        public string Failedloginattempts { get; set; }
        [Column("ORACLEENTITYNAME")]
        [StringLength(100)]
        public string Oracleentityname { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(1000)]
        public string Oracleentityid { get; set; }
        [Column("ORACLEUSERID")]
        [StringLength(30)]
        public string Oracleuserid { get; set; }
        [Column("OBJECTVERSIONNO")]
        public int? Objectversionno { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("CITY")]
        [StringLength(100)]
        public string City { get; set; }
        [Column("STATE")]
        [StringLength(100)]
        public string State { get; set; }
        [Column("MENTOR", TypeName = "NUMBER")]
        public decimal? Mentor { get; set; }
        [Column("TRAINER", TypeName = "NUMBER")]
        public decimal? Trainer { get; set; }
    }
}
