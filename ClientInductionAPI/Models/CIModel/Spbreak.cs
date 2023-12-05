using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SPBREAK")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "SPBREAK_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_SPBREAK_PKGUID", IsUnique = true)]
    public partial class Spbreak
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("CARALLOCATIONGUID")]
        [StringLength(36)]
        public string Carallocationguid { get; set; }
        [Column("SERVICEPROVIDERGUID")]
        [StringLength(36)]
        public string Serviceproviderguid { get; set; }
        [Column("BREAKSTARTDATE", TypeName = "DATE")]
        public DateTime? Breakstartdate { get; set; }
        [Column("PROPOSEDBREAKENDDATE", TypeName = "DATE")]
        public DateTime? Proposedbreakenddate { get; set; }
        [Column("ACTUALBREAKENDDATE", TypeName = "DATE")]
        public DateTime? Actualbreakenddate { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("ISAPPROVALREQUIRED")]
        [StringLength(1)]
        public string Isapprovalrequired { get; set; }
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
        [Column("PROCESSEDFLAG")]
        [StringLength(2)]
        public string Processedflag { get; set; }
        [Column("COMMENTS")]
        [StringLength(500)]
        public string Comments { get; set; }
    }
}
