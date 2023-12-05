using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("REINDUCTION")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "REINDUCTION_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_REINDUCTION_PKGUID", IsUnique = true)]
    public partial class Reinduction
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("PERSONMASTERGUID")]
        [StringLength(36)]
        public string Personmasterguid { get; set; }
        [Column("ISAPPROVALREQUIRED")]
        [StringLength(1)]
        public string Isapprovalrequired { get; set; }
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
        [Column("REINDUCTIONDATE", TypeName = "DATE")]
        public DateTime? Reinductiondate { get; set; }
        [Column("SPSITEMASTERGUID")]
        [StringLength(36)]
        public string Spsitemasterguid { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Effectiveenddate { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("SPFLAG", TypeName = "NUMBER")]
        public decimal? Spflag { get; set; }
        [Column("DSEFLAG", TypeName = "NUMBER")]
        public decimal? Dseflag { get; set; }
        [Column("DRIVERFLAG", TypeName = "NUMBER")]
        public decimal? Driverflag { get; set; }
        [Column("SPFLAG_NEW", TypeName = "NUMBER")]
        public decimal? SpflagNew { get; set; }
        [Column("DSEFLAG_NEW", TypeName = "NUMBER")]
        public decimal? DseflagNew { get; set; }
        [Column("DRIVERFLAG_NEW", TypeName = "NUMBER")]
        public decimal? DriverflagNew { get; set; }
        [Column("REASONMASTERGUID")]
        [StringLength(36)]
        public string Reasonmasterguid { get; set; }
        [Column("COMMENTS")]
        [StringLength(1000)]
        public string Comments { get; set; }
        [Column("REINDUCTIONTYPE")]
        [StringLength(20)]
        public string Reinductiontype { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
    }
}
