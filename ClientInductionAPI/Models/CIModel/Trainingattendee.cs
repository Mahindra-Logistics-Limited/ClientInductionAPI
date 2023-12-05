using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TRAININGATTENDEE")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "TRAININGATTENDEE_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_TRAININGATTENDEE_PKGUID", IsUnique = true)]
    [Index(nameof(Personmasterguid), Name = "XMERU_TRG_ATT_PERS")]
    public partial class Trainingattendee
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("PERSONMASTERGUID")]
        [StringLength(36)]
        public string Personmasterguid { get; set; }
        [Required]
        [Column("TRAININGBATCHMASTERGUID")]
        [StringLength(36)]
        public string Trainingbatchmasterguid { get; set; }
        [Column("ISATTENDED")]
        [StringLength(1)]
        public string Isattended { get; set; }
        [Column("OBTAINEDMARKS")]
        [StringLength(10)]
        public string Obtainedmarks { get; set; }
        [Column("TRAININGRESULT")]
        [StringLength(500)]
        public string Trainingresult { get; set; }
        [Column("REMARKS")]
        [StringLength(1000)]
        public string Remarks { get; set; }
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
        [Column("VALIDITYSTARTDATE", TypeName = "DATE")]
        public DateTime? Validitystartdate { get; set; }
        [Column("VALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? Validityenddate { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
    }
}
