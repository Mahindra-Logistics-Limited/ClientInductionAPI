using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("PERSONCONTACT")]
    [Index(nameof(Contactno), Name = "CONT_PHONE_IND")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "PERSONCONTACT_GUID_OVN", IsUnique = true)]
    [Index(nameof(Personmasterguid), nameof(Contactsubtypeguid), nameof(Primaryflag), nameof(Objectversionno), Name = "PERS_CONT_IDX", IsUnique = true)]
    [Index(nameof(Contactsubtypeguid), Name = "XMERU_CONT_SUBTYPE")]
    [Index(nameof(Pkguid), Name = "XMERU_PERSONCONTACT_PKGUID", IsUnique = true)]
    public partial class Personcontact
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("CONTACTSUBTYPEGUID")]
        [StringLength(36)]
        public string Contactsubtypeguid { get; set; }
        [Required]
        [Column("PERSONMASTERGUID")]
        [StringLength(36)]
        public string Personmasterguid { get; set; }
        [Column("PRIMARYFLAG")]
        public bool? Primaryflag { get; set; }
        [Column("ADDRESSLINE1")]
        [StringLength(255)]
        public string Addressline1 { get; set; }
        [Column("ADDRESSLINE2")]
        [StringLength(255)]
        public string Addressline2 { get; set; }
        [Column("COUNTRYMASTERGUID")]
        [StringLength(36)]
        public string Countrymasterguid { get; set; }
        [Column("STATEMASTERGUID")]
        [StringLength(36)]
        public string Statemasterguid { get; set; }
        [Column("CITYNAME")]
        [StringLength(255)]
        public string Cityname { get; set; }
        [Column("COUNTRYCODEGUID")]
        [StringLength(36)]
        public string Countrycodeguid { get; set; }
        [Column("CONTACTNO")]
        [StringLength(255)]
        public string Contactno { get; set; }
        [Column("EMAILID")]
        [StringLength(255)]
        public string Emailid { get; set; }
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
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Effectiveenddate { get; set; }
        [Column("ORACLEENTITYNAME")]
        [StringLength(1000)]
        public string Oracleentityname { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(1000)]
        public string Oracleentityid { get; set; }
        [Column("OBJECTVERSIONNO")]
        public int? Objectversionno { get; set; }
        [Column("PINCODE")]
        [StringLength(10)]
        public string Pincode { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
    }
}
