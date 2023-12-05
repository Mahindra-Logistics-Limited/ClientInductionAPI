using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("BRANDMASTER")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "BRANDMASTER_GUID_OVN", IsUnique = true)]
    [Index(nameof(Name), Name = "XMERU_BARND_NAME", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_BRANDMASTER_PKGUID", IsUnique = true)]
    public partial class Brandmaster
    {
        public Brandmaster()
        {
            DobDocBrandMapping22s = new HashSet<DobDocBrandMapping22>();
            DobDocBrandMappings = new HashSet<DobDocBrandMapping>();
        }

        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(200)]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(200)]
        public string Description { get; set; }
        [Column("QUICKACCESSCODE")]
        [StringLength(200)]
        public string Quickaccesscode { get; set; }
        [Column("COMMENTS")]
        [StringLength(200)]
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
        [Column("MANTHANBRANDTYPE")]
        [StringLength(200)]
        public string Manthanbrandtype { get; set; }
        [Column("MANTHANBRANDID")]
        public byte? Manthanbrandid { get; set; }
        [Column("SHOWINVERIFICATIONSCREEN")]
        public bool? Showinverificationscreen { get; set; }

        [InverseProperty(nameof(DobDocBrandMapping22.Brandmastergu))]
        public virtual ICollection<DobDocBrandMapping22> DobDocBrandMapping22s { get; set; }
        [InverseProperty(nameof(DobDocBrandMapping.Brandmastergu))]
        public virtual ICollection<DobDocBrandMapping> DobDocBrandMappings { get; set; }
    }
}
