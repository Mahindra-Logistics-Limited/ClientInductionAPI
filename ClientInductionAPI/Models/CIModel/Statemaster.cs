using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("STATEMASTER")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "STATEMASTER_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_STATEMASTER_PKGUID", IsUnique = true)]
    public partial class Statemaster
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
        [StringLength(255)]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(1000)]
        public string Description { get; set; }
        [Required]
        [Column("QUICKACCESSCODE")]
        [StringLength(25)]
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
        [Column("GSTNO")]
        [StringLength(1)]
        public string Gstno { get; set; }
        [Column("IGST", TypeName = "NUMBER(10,3)")]
        public decimal? Igst { get; set; }
        [Column("CGST", TypeName = "NUMBER(10,3)")]
        public decimal? Cgst { get; set; }
        [Column("OIGST", TypeName = "NUMBER(10,3)")]
        public decimal? Oigst { get; set; }
        [Column("OCGST", TypeName = "NUMBER(10,3)")]
        public decimal? Ocgst { get; set; }
    }
}
