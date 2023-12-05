using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("LEADMASTER")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "LEADMASTER_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_LEADMASTER_PKGUID", IsUnique = true)]
    public partial class Leadmaster
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("CONTACTNO")]
        [StringLength(20)]
        public string Contactno { get; set; }
        [Column("TITLE")]
        [StringLength(10)]
        public string Title { get; set; }
        [Column("FIRSTNAME")]
        [StringLength(50)]
        public string Firstname { get; set; }
        [Column("MIDDLENAME")]
        [StringLength(50)]
        public string Middlename { get; set; }
        [Column("LASTNAME")]
        [StringLength(50)]
        public string Lastname { get; set; }
        [Column("LEADSOURCEGUID")]
        [StringLength(36)]
        public string Leadsourceguid { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("PROBABILITY")]
        [StringLength(20)]
        public string Probability { get; set; }
        [Column("BIOMETRICID")]
        [StringLength(255)]
        public string Biometricid { get; set; }
        [Column("PERSONGUID")]
        [StringLength(36)]
        public string Personguid { get; set; }
        [Column("SALESREPPERSONID")]
        [StringLength(255)]
        public string Salesreppersonid { get; set; }
        [Column("BACKOFFICEPERSONID")]
        [StringLength(255)]
        public string Backofficepersonid { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime Effectiveenddate { get; set; }
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
        [Column("CONTACTSUBTYPEGUID")]
        [StringLength(36)]
        public string Contactsubtypeguid { get; set; }
        [Column("COUNTRYCODEGUID")]
        [StringLength(36)]
        public string Countrycodeguid { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("GENDER")]
        [StringLength(36)]
        public string Gender { get; set; }
        [Column("LEBRANCH_GUID")]
        [StringLength(36)]
        public string LebranchGuid { get; set; }
    }
}
