using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TRAININGBATCHMASTER")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "TRAININGBATCHMASTER_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_TRAININGBATCHMASTER_PK", IsUnique = true)]
    public partial class Trainingbatchmaster
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("TRAININGDATETIME", TypeName = "DATE")]
        public DateTime Trainingdatetime { get; set; }
        [Required]
        [Column("TRAININGTYPEMASTERGUID")]
        [StringLength(36)]
        public string Trainingtypemasterguid { get; set; }
        [Required]
        [Column("TRAININGNAME")]
        [StringLength(500)]
        public string Trainingname { get; set; }
        [Required]
        [Column("TRAINERMASTERGUID")]
        [StringLength(36)]
        public string Trainermasterguid { get; set; }
        [Required]
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("TOTALMARKS", TypeName = "NUMBER(38)")]
        public decimal? Totalmarks { get; set; }
        [Column("ATTENDEETYPE")]
        [StringLength(100)]
        public string Attendeetype { get; set; }
        [Column("VALIDITYSTARTDATE", TypeName = "DATE")]
        public DateTime Validitystartdate { get; set; }
        [Column("VALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? Validityenddate { get; set; }
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
        [Column("TRAININGTOPIC")]
        [StringLength(100)]
        public string Trainingtopic { get; set; }
        [Column("REMARKS")]
        [StringLength(100)]
        public string Remarks { get; set; }
        [Column("TRAININGRESULT")]
        [StringLength(100)]
        public string Trainingresult { get; set; }
        [Column("ISATTENDED")]
        [StringLength(1)]
        public string Isattended { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("LOCATION")]
        [StringLength(100)]
        public string Location { get; set; }
    }
}
