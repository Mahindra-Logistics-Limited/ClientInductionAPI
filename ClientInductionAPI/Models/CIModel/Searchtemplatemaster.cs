using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SEARCHTEMPLATEMASTER")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "SEARCHTEMPLATEMASTER_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_SEARCHTEMPLATEMASTER_PK", IsUnique = true)]
    public partial class Searchtemplatemaster
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("TEMPLATENAME")]
        [StringLength(100)]
        public string Templatename { get; set; }
        [Column("TEMPLATEDESCRIPTION")]
        [StringLength(1000)]
        public string Templatedescription { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("APPROVALENABLED")]
        [StringLength(1)]
        public string Approvalenabled { get; set; }
        [Column("APPROVALHIERARCHYID", TypeName = "NUMBER")]
        public decimal? Approvalhierarchyid { get; set; }
        [Column("TEMPLATETYPE")]
        [StringLength(20)]
        public string Templatetype { get; set; }
        [Column("TEMPLATETRANSACTIONTYPEID")]
        [StringLength(36)]
        public string Templatetransactiontypeid { get; set; }
        [Column("TRANSACTIONRESULTFORMULA")]
        [StringLength(500)]
        public string Transactionresultformula { get; set; }
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
        public byte? Objectversionno { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Effectiveenddate { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("SUMMARYVIEWNAME")]
        [StringLength(200)]
        public string Summaryviewname { get; set; }
        [Column("SUMMARYVIEWTEXT")]
        [StringLength(2000)]
        public string Summaryviewtext { get; set; }
        [Column("VIEWNAME")]
        [StringLength(100)]
        public string Viewname { get; set; }
        [Column("VIEWTEXT")]
        public string Viewtext { get; set; }
    }
}
