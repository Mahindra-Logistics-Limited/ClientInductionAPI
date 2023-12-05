using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TRANSACTIONTYPE")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "TRANSACTIONTYPE_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_TRANSACTIONTYPE_PKGUID", IsUnique = true)]
    [Index(nameof(Name), Name = "XMERU_TYPE_NAME", IsUnique = true)]
    public partial class Transactiontype
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("NAME")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(2000)]
        public string Description { get; set; }
        [Column("QUICKACCESSCODE")]
        [StringLength(60)]
        public string Quickaccesscode { get; set; }
        [Column("TRANSACTIONCLASSGUID")]
        [StringLength(36)]
        public string Transactionclassguid { get; set; }
        [Column("CONTRATRANSTYPEGUID")]
        [StringLength(36)]
        public string Contratranstypeguid { get; set; }
        [Column("ADJUSTMENTTRANSTYPEGUID")]
        [StringLength(36)]
        public string Adjustmenttranstypeguid { get; set; }
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
        [Column("ORACLEENTITYNAME")]
        [StringLength(1000)]
        public string Oracleentityname { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(100)]
        public string Oracleentityid { get; set; }
        [Column("ORACLEENTITYTYPE")]
        [StringLength(1000)]
        public string Oracleentitytype { get; set; }
        [Column("OBJECTVERSIONNO")]
        public byte? Objectversionno { get; set; }
        [Column("TDSTRXTYPEGUID")]
        [StringLength(36)]
        public string Tdstrxtypeguid { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("SPSERVICECHARGEFLAG")]
        [StringLength(30)]
        public string Spservicechargeflag { get; set; }
        [Column("TRANSACTIONCATEGORYGUID")]
        [StringLength(36)]
        public string Transactioncategoryguid { get; set; }
        [Column("REVENUEGROUP")]
        [StringLength(50)]
        public string Revenuegroup { get; set; }
        [Column("GLCODE")]
        public int? Glcode { get; set; }
        [Column("GLNAME")]
        [StringLength(250)]
        public string Glname { get; set; }
        [Column("SAPGLCODE")]
        [StringLength(20)]
        public string Sapglcode { get; set; }
        [Column("SAPGLNAME")]
        [StringLength(250)]
        public string Sapglname { get; set; }
        [Column("ISBALANCESHEET")]
        public bool? Isbalancesheet { get; set; }
        [Column("SHOWCOSTCENTER")]
        public bool? Showcostcenter { get; set; }
        [Column("DOCUMENTTYPE")]
        [StringLength(2)]
        public string Documenttype { get; set; }
    }
}
