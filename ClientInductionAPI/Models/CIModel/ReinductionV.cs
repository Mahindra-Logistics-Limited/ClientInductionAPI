using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class ReinductionV
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
        [Required]
        [Column("PERSONID")]
        [StringLength(1000)]
        public string Personid { get; set; }
        [Required]
        [Column("PERS_TITLE")]
        [StringLength(10)]
        public string PersTitle { get; set; }
        [Required]
        [Column("PERS_FNAME")]
        [StringLength(255)]
        public string PersFname { get; set; }
        [Column("PERS_MNAME")]
        [StringLength(255)]
        public string PersMname { get; set; }
        [Required]
        [Column("PERS_LNAME")]
        [StringLength(255)]
        public string PersLname { get; set; }
        [Column("PERS_GENDER")]
        [StringLength(10)]
        public string PersGender { get; set; }
        [Column("PERS_DOB", TypeName = "DATE")]
        public DateTime PersDob { get; set; }
        [Required]
        [Column("PERS_BIOID")]
        [StringLength(255)]
        public string PersBioid { get; set; }
        [Column("PERS_DSEFLAG")]
        public bool? PersDseflag { get; set; }
        [Column("PERS_SPFLAG")]
        public bool? PersSpflag { get; set; }
        [Column("PERS_DRIVERFLAG")]
        public bool? PersDriverflag { get; set; }
        [Column("PERS_STATUS_CODE")]
        [StringLength(25)]
        public string PersStatusCode { get; set; }
        [Column("PERS_OBJ_VER_NO")]
        public int? PersObjVerNo { get; set; }
        [Required]
        [Column("STATUS_ENT_STSGUID")]
        [StringLength(36)]
        public string StatusEntStsguid { get; set; }
        [Column("STATUS_ENT_ENTGUID")]
        [StringLength(36)]
        public string StatusEntEntguid { get; set; }
        [Column("STATUS_ENT_OBJ_VER_NO")]
        public int? StatusEntObjVerNo { get; set; }
        [Column("REINDUCTION_STATUS_CODE")]
        [StringLength(25)]
        public string ReinductionStatusCode { get; set; }
        [Column("REINDUCTION_STATUS_NAME")]
        [StringLength(200)]
        public string ReinductionStatusName { get; set; }
        [Column("REINDUCTION_STATUS_DESC")]
        [StringLength(1000)]
        public string ReinductionStatusDesc { get; set; }
        [Column("ENTITY_CODE")]
        [StringLength(50)]
        public string EntityCode { get; set; }
    }
}
