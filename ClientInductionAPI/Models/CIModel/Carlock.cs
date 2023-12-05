using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("CARLOCKS")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "CARLOCKS_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_CARLOCKS_PKGUID", IsUnique = true)]
    [Index(nameof(Carmasterguid), Name = "XMERU_LOCK_CAR")]
    [Index(nameof(Lockid), Name = "XMERU_LOCK_ID")]
    public partial class Carlock
    {
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("LOCKTYPEMASTERGUID")]
        [StringLength(36)]
        public string Locktypemasterguid { get; set; }
        [Column("LOCKDETAILS")]
        [StringLength(1000)]
        public string Lockdetails { get; set; }
        [Column("LOCKSOURCEENTITY")]
        [StringLength(36)]
        public string Locksourceentity { get; set; }
        [Column("UNLOCKDATE", TypeName = "DATE")]
        public DateTime? Unlockdate { get; set; }
        [Column("UNLOCKSOURCEENTITY")]
        [StringLength(36)]
        public string Unlocksourceentity { get; set; }
        [Column("UNLOCKTXNREF")]
        [StringLength(36)]
        public string Unlocktxnref { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("LOCKDATE", TypeName = "DATE")]
        public DateTime? Lockdate { get; set; }
        [Column("LOCKTXNREF")]
        [StringLength(36)]
        public string Locktxnref { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Effectiveenddate { get; set; }
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
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("ORACLEENTITYNAME")]
        [StringLength(100)]
        public string Oracleentityname { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(100)]
        public string Oracleentityid { get; set; }
        [Column("OBJECTVERSIONNO", TypeName = "NUMBER")]
        public decimal? Objectversionno { get; set; }
        [Column("LOCKID", TypeName = "NUMBER")]
        public decimal? Lockid { get; set; }
        [Column("CARLOCKSGUID")]
        [StringLength(36)]
        public string Carlocksguid { get; set; }
        [Column("MANTHANLOCKSTATUS")]
        [StringLength(100)]
        public string Manthanlockstatus { get; set; }
        [Column("MANTHANUNLOCKSTATUS")]
        [StringLength(100)]
        public string Manthanunlockstatus { get; set; }
    }
}
