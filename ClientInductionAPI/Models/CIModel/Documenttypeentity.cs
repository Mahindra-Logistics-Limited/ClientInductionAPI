using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("DOCUMENTTYPEENTITY")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "DOCUMENTTYPEENTITY_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_DOCUMENTTYPEEN_PK", IsUnique = true)]
    public partial class Documenttypeentity
    {
        public Documenttypeentity()
        {
            DobDocBrandMapping22s = new HashSet<DobDocBrandMapping22>();
            DobDocBrandMappings = new HashSet<DobDocBrandMapping>();
            DobMandatoryDocTbls = new HashSet<DobMandatoryDocTbl>();
        }

        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("DOCUMENTTYPEMASTERGUID")]
        [StringLength(36)]
        public string Documenttypemasterguid { get; set; }
        [Column("ENTITYMASTERGUID")]
        [StringLength(36)]
        public string Entitymasterguid { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(1000)]
        public string Description { get; set; }
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

        [InverseProperty(nameof(DobDocBrandMapping22.Documenttypeentitygu))]
        public virtual ICollection<DobDocBrandMapping22> DobDocBrandMapping22s { get; set; }
        [InverseProperty(nameof(DobDocBrandMapping.Documenttypeentitygu))]
        public virtual ICollection<DobDocBrandMapping> DobDocBrandMappings { get; set; }
        [InverseProperty(nameof(DobMandatoryDocTbl.Documenttypeentitygu))]
        public virtual ICollection<DobMandatoryDocTbl> DobMandatoryDocTbls { get; set; }
    }
}
