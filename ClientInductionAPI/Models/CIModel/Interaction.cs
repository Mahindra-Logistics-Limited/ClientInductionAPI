using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("INTERACTIONS")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "INTERACTIONS_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_INTERACTIONS_PKGUID", IsUnique = true)]
    public partial class Interaction
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("INTERACTIONTYPE")]
        [StringLength(255)]
        public string Interactiontype { get; set; }
        [Column("INTERACTIONDATETIME", TypeName = "DATE")]
        public DateTime Interactiondatetime { get; set; }
        [Column("REMARKS")]
        [StringLength(255)]
        public string Remarks { get; set; }
        [Required]
        [Column("INTERACTIONRESULT")]
        [StringLength(20)]
        public string Interactionresult { get; set; }
        [Required]
        [Column("LEADMASTERGUID")]
        [StringLength(36)]
        public string Leadmasterguid { get; set; }
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
        public byte? Objectversionno { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
    }
}
