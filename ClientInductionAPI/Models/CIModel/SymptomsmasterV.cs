using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class SymptomsmasterV
    {
        [Required]
        [Column("SYMPTOMSMASTERGUID")]
        [StringLength(36)]
        public string Symptomsmasterguid { get; set; }
        [Column("ISSUEMASTERGUID")]
        [StringLength(255)]
        public string Issuemasterguid { get; set; }
        [Column("WORKREQUESTGUID")]
        [StringLength(2000)]
        public string Workrequestguid { get; set; }
        [Column("SYMPTOMS")]
        [StringLength(1000)]
        public string Symptoms { get; set; }
        [Column("SYMPTOMSORACLEENTITYNAME")]
        [StringLength(1000)]
        public string Symptomsoracleentityname { get; set; }
        [Column("SYMPTOMSORACLEENTITYID")]
        [StringLength(1000)]
        public string Symptomsoracleentityid { get; set; }
        [Column("SYMPTOMSORACLEENTITYTYPE")]
        [StringLength(1000)]
        public string Symptomsoracleentitytype { get; set; }
        [Column("SYMPTOMSOBJECTVERSIONNO")]
        public byte? Symptomsobjectversionno { get; set; }
        [Column("SYMPTOMSPKGUID")]
        [StringLength(36)]
        public string Symptomspkguid { get; set; }
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
        [Column("WORKREQUESTORACLEENTITYNAME")]
        [StringLength(1000)]
        public string Workrequestoracleentityname { get; set; }
        [Column("WORKREQUESTORACLEENTITYID")]
        [StringLength(1000)]
        public string Workrequestoracleentityid { get; set; }
        [Column("WORKREQUESTORACLEENTITYTYPE")]
        [StringLength(1000)]
        public string Workrequestoracleentitytype { get; set; }
        [Column("WORKREQUESTOBJECTVERSIONNO")]
        public byte? Workrequestobjectversionno { get; set; }
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
        [Column("ISSUENAME")]
        [StringLength(255)]
        public string Issuename { get; set; }
        [Column("DEFAULTSYMPTOMS")]
        [StringLength(1000)]
        public string Defaultsymptoms { get; set; }
        [Column("ISSUEORACLEENTITYNAME")]
        [StringLength(1000)]
        public string Issueoracleentityname { get; set; }
        [Column("ISSUEORACLEENTITYID")]
        [StringLength(1000)]
        public string Issueoracleentityid { get; set; }
        [Column("ISSUEORACLEENTITYTYPE")]
        [StringLength(1000)]
        public string Issueoracleentitytype { get; set; }
        [Column("ISSUEOBJECTVERSIONNO")]
        public byte? Issueobjectversionno { get; set; }
        [Column("ISSUEPKGUID")]
        [StringLength(36)]
        public string Issuepkguid { get; set; }
        [Required]
        [Column("STATUS_ENT_STSGUID")]
        [StringLength(36)]
        public string StatusEntStsguid { get; set; }
        [Column("STATUS_ENT_ENTGUID")]
        [StringLength(36)]
        public string StatusEntEntguid { get; set; }
        [Column("STATUS_ENT_OBJ_VER_NO")]
        public int? StatusEntObjVerNo { get; set; }
        [Column("STATUS_CODE")]
        [StringLength(25)]
        public string StatusCode { get; set; }
        [Column("STATUS_NAME")]
        [StringLength(200)]
        public string StatusName { get; set; }
        [Column("STATUS_DESC")]
        [StringLength(1000)]
        public string StatusDesc { get; set; }
        [Column("ENTITY_CODE")]
        [StringLength(50)]
        public string EntityCode { get; set; }
    }
}
