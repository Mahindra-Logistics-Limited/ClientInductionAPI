using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("BRANCHMASTER")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "BRANCHMASTER_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_BRANCHMASTER_PKGUID", IsUnique = true)]
    public partial class Branchmaster
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("COUNTRYMASTERGUID")]
        [StringLength(36)]
        public string Countrymasterguid { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(200)]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(1000)]
        public string Description { get; set; }
        [Column("QUICKACCESSCODE")]
        [StringLength(100)]
        public string Quickaccesscode { get; set; }
        [Column("COMMENTS")]
        [StringLength(1000)]
        public string Comments { get; set; }
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
        [Column("CAMPAIGNNAME")]
        [StringLength(50)]
        public string Campaignname { get; set; }
        [Column("DIALNO")]
        [StringLength(50)]
        public string Dialno { get; set; }
        [Column("MANTHANCITYID")]
        public byte? Manthancityid { get; set; }
        [Column("SHOWINVERIFICATIONSCREEN")]
        public bool? Showinverificationscreen { get; set; }
        [Column("CCPHONENO")]
        [StringLength(20)]
        public string Ccphoneno { get; set; }
        [Column("SAPBUSINESSPLACE")]
        [StringLength(4)]
        public string Sapbusinessplace { get; set; }
        [Column("SAPINTERNALORDER")]
        [StringLength(20)]
        public string Sapinternalorder { get; set; }
        [Column("SAPCITYCODE")]
        [StringLength(3)]
        public string Sapcitycode { get; set; }
        [Column("PROFITCENTER")]
        [StringLength(20)]
        public string Profitcenter { get; set; }
        [Column("COSTCENTER")]
        [StringLength(20)]
        public string Costcenter { get; set; }
    }
}
