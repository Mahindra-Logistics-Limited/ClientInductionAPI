using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CarlocksBaseV
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("CAR_REGN_NO")]
        [StringLength(255)]
        public string CarRegnNo { get; set; }
        [Column("LOCKCOUNT", TypeName = "NUMBER")]
        public decimal? Lockcount { get; set; }
        [Column("CARLOCKGUID")]
        [StringLength(36)]
        public string Carlockguid { get; set; }
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
        [Column("CARLOCK_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? CarlockEffectivestartdate { get; set; }
        [Column("CARLOCK_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? CarlockEffectiveenddate { get; set; }
        [Column("CARLOCKSPKGUID")]
        [StringLength(36)]
        public string Carlockspkguid { get; set; }
        [Column("LOCKID", TypeName = "NUMBER")]
        public decimal? Lockid { get; set; }
        [Column("LOCKNAME")]
        [StringLength(200)]
        public string Lockname { get; set; }
        [Column("LOCKDESCRIPTION")]
        [StringLength(1000)]
        public string Lockdescription { get; set; }
        [Column("LOCKQUICKACCESSCODE")]
        [StringLength(25)]
        public string Lockquickaccesscode { get; set; }
        [Column("LOCKCOMMENTS")]
        [StringLength(1000)]
        public string Lockcomments { get; set; }
        [Column("LOCKDISABLED")]
        public bool? Lockdisabled { get; set; }
        [Column("LOCKORACLEENTITYNAME")]
        [StringLength(100)]
        public string Lockoracleentityname { get; set; }
        [Column("LOCKORACLEENTITYID")]
        [StringLength(1000)]
        public string Lockoracleentityid { get; set; }
        [Column("LOCKOBJECTVERSIONNO")]
        public int? Lockobjectversionno { get; set; }
        [Column("LOCKSTATUSCOLOR")]
        [StringLength(30)]
        public string Lockstatuscolor { get; set; }
        [Column("LOCKTYPEMASTERPKGUID")]
        [StringLength(36)]
        public string Locktypemasterpkguid { get; set; }
        [Required]
        [Column("CARLOCKS_STATUS_ENT_STSGUID")]
        [StringLength(36)]
        public string CarlocksStatusEntStsguid { get; set; }
        [Column("CARLOCKS_STATUS_ENT_ENTGUID")]
        [StringLength(36)]
        public string CarlocksStatusEntEntguid { get; set; }
        [Column("STATUS_ENT_OBJ_VER_NO")]
        public int? StatusEntObjVerNo { get; set; }
        [Column("CARLOCKS_STATUS_CODE")]
        [StringLength(25)]
        public string CarlocksStatusCode { get; set; }
        [Column("CARLOCKS_STATUS_NAME")]
        [StringLength(200)]
        public string CarlocksStatusName { get; set; }
        [Column("CARLOCKS_STATUS_DESC")]
        [StringLength(1000)]
        public string CarlocksStatusDesc { get; set; }
        [Column("CARLOCKS_ENTITY_CODE")]
        [StringLength(50)]
        public string CarlocksEntityCode { get; set; }
    }
}
