using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("DRIVERRATING")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "DRIVERRATING_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_DRIVERRATING_PKGUID", IsUnique = true)]
    [Index(nameof(Drivermasterguid), Name = "XMERU_DRV_RAT_DRV_ID")]
    [Index(nameof(Ratingmasterguid), Name = "XMERU_DR_RATINGGUID")]
    [Index(nameof(Guid), Name = "XMERU_DR_RATING_GUID", IsUnique = true)]
    public partial class Driverrating
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("DRIVERMASTERGUID")]
        [StringLength(36)]
        public string Drivermasterguid { get; set; }
        [Column("RATINGDATE", TypeName = "DATE")]
        public DateTime Ratingdate { get; set; }
        [Column("ABSOLUTERATING", TypeName = "NUMBER(3,1)")]
        public decimal Absoluterating { get; set; }
        [Required]
        [Column("RATINGMASTERGUID")]
        [StringLength(36)]
        public string Ratingmasterguid { get; set; }
        [Column("COMMENTS")]
        [StringLength(2000)]
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
        [StringLength(1000)]
        public string Oracleentityname { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(1000)]
        public string Oracleentityid { get; set; }
        [Column("OBJECTVERSIONNO")]
        [StringLength(100)]
        public string Objectversionno { get; set; }
        [Required]
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
    }
}
