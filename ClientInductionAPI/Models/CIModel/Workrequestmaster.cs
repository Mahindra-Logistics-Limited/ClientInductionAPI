using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("WORKREQUESTMASTER")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "WORKREQUESTMASTER_GUID_OVN", IsUnique = true)]
    [Index(nameof(Workrequestno), Name = "WORKREQUESTNO_IND", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_WORKREQUESTMASTER_PKGUID", IsUnique = true)]
    public partial class Workrequestmaster
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("WORKSHOPGUID")]
        [StringLength(255)]
        public string Workshopguid { get; set; }
        [Column("WORKTYPEGUID")]
        [StringLength(2000)]
        public string Worktypeguid { get; set; }
        [Column("CARGUID")]
        [StringLength(36)]
        public string Carguid { get; set; }
        [Column("ODOMETERREADING")]
        [StringLength(2000)]
        public string Odometerreading { get; set; }
        [Column("WORKREQUESTDATETIME", TypeName = "DATE")]
        public DateTime? Workrequestdatetime { get; set; }
        [Column("REMARKS")]
        [StringLength(200)]
        public string Remarks { get; set; }
        [Column("RONO")]
        [StringLength(200)]
        public string Rono { get; set; }
        [Column("PARTSCHARGES", TypeName = "NUMBER")]
        public decimal? Partscharges { get; set; }
        [Column("LABOURCHARGES", TypeName = "NUMBER")]
        public decimal? Labourcharges { get; set; }
        [Column("OTHERCHARGES", TypeName = "NUMBER")]
        public decimal? Othercharges { get; set; }
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
        [Column("ORACLEENTITYTYPE")]
        [StringLength(1000)]
        public string Oracleentitytype { get; set; }
        [Column("OBJECTVERSIONNO")]
        public byte? Objectversionno { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Required]
        [Column("WORKREQUESTNO")]
        [StringLength(100)]
        public string Workrequestno { get; set; }
        [Column("QCCHECKLISTNO")]
        [StringLength(225)]
        public string Qcchecklistno { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
    }
}
