using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("DEVICEDOCS")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "DEVICEDOCS_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_DEVICEDOCS_PKGUID", IsUnique = true)]
    public partial class Devicedoc
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("DOCUMENTTYPEENTITYGUID")]
        [StringLength(36)]
        public string Documenttypeentityguid { get; set; }
        [Required]
        [Column("DOCUMENTNO")]
        [StringLength(255)]
        public string Documentno { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Effectiveenddate { get; set; }
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
        [Column("DEVICEMASTERGUID")]
        [StringLength(36)]
        public string Devicemasterguid { get; set; }
        [Required]
        [Column("DOCUMENTNAME")]
        [StringLength(255)]
        public string Documentname { get; set; }
        [Column("VALIDITYSTARTDATE", TypeName = "DATE")]
        public DateTime? Validitystartdate { get; set; }
        [Column("VALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? Validityenddate { get; set; }
        [Column("DOCUMENTTYPECATEGORYGUID")]
        [StringLength(36)]
        public string Documenttypecategoryguid { get; set; }
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
        [Column("DOCUMENTPATH")]
        public string Documentpath { get; set; }
    }
}
