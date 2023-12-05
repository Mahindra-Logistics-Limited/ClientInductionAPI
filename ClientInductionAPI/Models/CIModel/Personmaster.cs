using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("PERSONMASTER")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "PERSONMASTER_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_PERSONMASTER_PKGUID", IsUnique = true)]
    public partial class Personmaster
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("PERSONID")]
        [StringLength(1000)]
        public string Personid { get; set; }
        [Required]
        [Column("TITLE")]
        [StringLength(10)]
        public string Title { get; set; }
        [Required]
        [Column("FIRSTNAME")]
        [StringLength(255)]
        public string Firstname { get; set; }
        [Column("MIDDLENAME")]
        [StringLength(255)]
        public string Middlename { get; set; }
        [Required]
        [Column("LASTNAME")]
        [StringLength(255)]
        public string Lastname { get; set; }
        [Column("GENDER")]
        [StringLength(10)]
        public string Gender { get; set; }
        [Column("DOB", TypeName = "DATE")]
        public DateTime Dob { get; set; }
        [Column("LEADREFERENCEGUID")]
        [StringLength(36)]
        public string Leadreferenceguid { get; set; }
        [Required]
        [Column("BIOMETRICID")]
        [StringLength(255)]
        public string Biometricid { get; set; }
        [Required]
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("DSEFLAG")]
        public bool? Dseflag { get; set; }
        [Column("SPFLAG")]
        public bool? Spflag { get; set; }
        [Column("DRIVERFLAG")]
        public bool? Driverflag { get; set; }
        [Column("SPAREFIELDNUMBER1", TypeName = "NUMBER(38)")]
        public decimal? Sparefieldnumber1 { get; set; }
        [Column("SPAREFIELDNUMBER2", TypeName = "NUMBER(38)")]
        public decimal? Sparefieldnumber2 { get; set; }
        [Column("SPAREFIELDNUMBER3", TypeName = "NUMBER(38)")]
        public decimal? Sparefieldnumber3 { get; set; }
        [Column("SPAREFIELDSTRING1")]
        [StringLength(1000)]
        public string Sparefieldstring1 { get; set; }
        [Column("SPAREFIELDSTRING2")]
        [StringLength(1000)]
        public string Sparefieldstring2 { get; set; }
        [Column("SPAREFIELDSTRING3")]
        [StringLength(1000)]
        public string Sparefieldstring3 { get; set; }
        [Column("SPAREFIELDTIMESTAMP1", TypeName = "DATE")]
        public DateTime? Sparefieldtimestamp1 { get; set; }
        [Column("SPAREFIELDTIMESTAMP2", TypeName = "DATE")]
        public DateTime? Sparefieldtimestamp2 { get; set; }
        [Column("SPAREFIELDTIMESTAMP3", TypeName = "DATE")]
        public DateTime? Sparefieldtimestamp3 { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime Effectiveenddate { get; set; }
        [Column("DISABLED")]
        public bool? Disabled { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
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
        [Column("MENTORREFERENCEID")]
        [StringLength(100)]
        public string Mentorreferenceid { get; set; }
        [Column("REASONMASTERGUID")]
        [StringLength(36)]
        public string Reasonmasterguid { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("TENURE", TypeName = "NUMBER")]
        public decimal? Tenure { get; set; }
        [Column("SPCLIENTMAPGUID")]
        [StringLength(36)]
        public string Spclientmapguid { get; set; }
        [Column("ISSPSENTFORINDUCTION")]
        public short? Isspsentforinduction { get; set; }
        [Column("ISDRIVERSENTFORINDUCTION")]
        public short? Isdriversentforinduction { get; set; }
        [Column("BUSINESSCATEGORY")]
        [StringLength(36)]
        public string Businesscategory { get; set; }
    }
}
