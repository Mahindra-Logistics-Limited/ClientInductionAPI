using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class WorkrequestBaseV
    {
        [Required]
        [Column("WORKREQUESTMASTERGUID")]
        [StringLength(36)]
        public string Workrequestmasterguid { get; set; }
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
        [Column("WORKREQUEST_ORACLEENTITYNAME")]
        [StringLength(1000)]
        public string WorkrequestOracleentityname { get; set; }
        [Column("WORKREQUEST_ORACLEENTITYID")]
        [StringLength(1000)]
        public string WorkrequestOracleentityid { get; set; }
        [Column("WORKREQUEST_ORACLEENTITYTYPE")]
        [StringLength(1000)]
        public string WorkrequestOracleentitytype { get; set; }
        [Column("WORKREQUEST_OBJECTVERSIONNO")]
        public byte? WorkrequestObjectversionno { get; set; }
        [Column("WORKREQUEST_STATUSENTITYGUID")]
        [StringLength(36)]
        public string WorkrequestStatusentityguid { get; set; }
        [Required]
        [Column("WORKREQUESTNO")]
        [StringLength(100)]
        public string Workrequestno { get; set; }
        [Column("QCCHECKLISTNO")]
        [StringLength(225)]
        public string Qcchecklistno { get; set; }
        [Column("WORKREQUEST_PKGUID")]
        [StringLength(36)]
        public string WorkrequestPkguid { get; set; }
        [Required]
        [Column("REQUEST_STATUS_ENT_STSGUID")]
        [StringLength(36)]
        public string RequestStatusEntStsguid { get; set; }
        [Column("REQUEST_STATUS_ENT_ENTGUID")]
        [StringLength(36)]
        public string RequestStatusEntEntguid { get; set; }
        [Column("REQUEST_STATUS_ENT_OBJ_VER_NO")]
        public int? RequestStatusEntObjVerNo { get; set; }
        [Column("REQUEST_STATUS_CODE")]
        [StringLength(25)]
        public string RequestStatusCode { get; set; }
        [Column("REQUEST_STATUS_NAME")]
        [StringLength(200)]
        public string RequestStatusName { get; set; }
        [Column("REQUEST_STATUS_DESC")]
        [StringLength(1000)]
        public string RequestStatusDesc { get; set; }
        [Column("REQUEST_ENTITY_CODE")]
        [StringLength(50)]
        public string RequestEntityCode { get; set; }
        [Column("CAR_REGN_NO")]
        [StringLength(255)]
        public string CarRegnNo { get; set; }
        [Column("CAR_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? CarEffectivestartdate { get; set; }
        [Column("CAR_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? CarEffectiveenddate { get; set; }
        [Column("CAR_CHASSISNO")]
        [StringLength(255)]
        public string CarChassisno { get; set; }
        [Column("CAR_REGN_DATE", TypeName = "DATE")]
        public DateTime? CarRegnDate { get; set; }
        [Column("CAR_OBJ_VER_NO")]
        public byte? CarObjVerNo { get; set; }
        [Column("CAR_DEFRRED_DOC_CHECK_FLAG")]
        [StringLength(1)]
        public string CarDefrredDocCheckFlag { get; set; }
        [Column("CAR_PKGUID")]
        [StringLength(36)]
        public string CarPkguid { get; set; }
        [Column("CAR_STATUS_CODE")]
        [StringLength(25)]
        public string CarStatusCode { get; set; }
        [Column("CAR_STATUS_NAME")]
        [StringLength(200)]
        public string CarStatusName { get; set; }
        [Column("CAR_MAKE")]
        [StringLength(255)]
        public string CarMake { get; set; }
        [Column("CAR_MAKE_CODE")]
        [StringLength(25)]
        public string CarMakeCode { get; set; }
        [Column("CAR_MODEL")]
        [StringLength(255)]
        public string CarModel { get; set; }
        [Column("CAR_MODELCODE")]
        [StringLength(25)]
        public string CarModelcode { get; set; }
        [Column("CAR_GVGUID")]
        [StringLength(36)]
        public string CarGvguid { get; set; }
        [Column("CAR_GVNAME")]
        [StringLength(255)]
        public string CarGvname { get; set; }
        [Column("CAR_OWNER")]
        [StringLength(255)]
        public string CarOwner { get; set; }
        [Column("SPGUID")]
        [StringLength(36)]
        public string Spguid { get; set; }
        [Column("CAR_OWNER_SPID")]
        [StringLength(1000)]
        public string CarOwnerSpid { get; set; }
        [Column("CAR_OWNER_SPNAME")]
        [StringLength(767)]
        public string CarOwnerSpname { get; set; }
        [Column("CAR_OWNER_SP_STATUS")]
        [StringLength(25)]
        public string CarOwnerSpStatus { get; set; }
        [Column("SP_DEFRRED_DOC_CHECK_FLAG")]
        [StringLength(1)]
        public string SpDefrredDocCheckFlag { get; set; }
        [Column("SP_PKGUID")]
        [StringLength(36)]
        public string SpPkguid { get; set; }
        [Column("CAR_SEC_GUID")]
        [StringLength(36)]
        public string CarSecGuid { get; set; }
        [Column("CAR_LE_BRANCH_GUID")]
        [StringLength(36)]
        public string CarLeBranchGuid { get; set; }
        [Column("CAR_LE_CODE")]
        [StringLength(200)]
        public string CarLeCode { get; set; }
        [Column("CAR_LE_NAME")]
        [StringLength(200)]
        public string CarLeName { get; set; }
        [Column("CAR_CITY_CODE")]
        [StringLength(100)]
        public string CarCityCode { get; set; }
        [Column("CAR_CITY_NAME")]
        [StringLength(200)]
        public string CarCityName { get; set; }
        [Column("CAR_BRAND_CODE")]
        [StringLength(200)]
        public string CarBrandCode { get; set; }
        [Column("CAR_BRAND_NAME")]
        [StringLength(200)]
        public string CarBrandName { get; set; }
        [Column("CAR_OP_MODEL_CODE")]
        [StringLength(200)]
        public string CarOpModelCode { get; set; }
        [Column("CAR_OP_MODEL_NAME")]
        [StringLength(200)]
        public string CarOpModelName { get; set; }
        [Required]
        [Column("WORKSHOPNAME")]
        [StringLength(225)]
        public string Workshopname { get; set; }
        [Column("WORKSHOPQUICKACCESSCODE")]
        [StringLength(200)]
        public string Workshopquickaccesscode { get; set; }
        [Column("WORKSHOPCOMMENTS")]
        [StringLength(200)]
        public string Workshopcomments { get; set; }
        [Column("WORKSHOPDISABLED")]
        public bool? Workshopdisabled { get; set; }
        [Column("WORKSHOPEFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Workshopeffectivestartdate { get; set; }
        [Column("WORKSHOPEFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Workshopeffectiveenddate { get; set; }
        [Column("WORKSHOPORACLEENTITYNAME")]
        [StringLength(100)]
        public string Workshoporacleentityname { get; set; }
        [Column("WORKSHOPORACLEENTITYID")]
        [StringLength(1000)]
        public string Workshoporacleentityid { get; set; }
        [Column("WORKSHOPOBJECTVERSIONNO")]
        public int? Workshopobjectversionno { get; set; }
        [Column("WORKSHOPDESCRIPTION")]
        [StringLength(2000)]
        public string Workshopdescription { get; set; }
        [Column("WORKSHOPBRANCHMASTERGUID")]
        [StringLength(36)]
        public string Workshopbranchmasterguid { get; set; }
        [Column("WORKSHOPPKGUID")]
        [StringLength(36)]
        public string Workshoppkguid { get; set; }
        [Required]
        [Column("WORKTYPENAME")]
        [StringLength(255)]
        public string Worktypename { get; set; }
        [Column("WORKTYPEDESCRIPTION")]
        [StringLength(2000)]
        public string Worktypedescription { get; set; }
        [Column("WORKTYPEQUICKACCESSCODE")]
        [StringLength(25)]
        public string Worktypequickaccesscode { get; set; }
        [Column("WORKTYPECOMMENTS")]
        [StringLength(2000)]
        public string Worktypecomments { get; set; }
        [Column("WORKTYPEDISABLED")]
        public bool? Worktypedisabled { get; set; }
        [Column("WORKTYPEORACLEENTITYNAME")]
        [StringLength(1000)]
        public string Worktypeoracleentityname { get; set; }
        [Column("WORKTYPEORACLEENTITYID")]
        [StringLength(1000)]
        public string Worktypeoracleentityid { get; set; }
        [Column("WORKTYPEOBJECTVERSIONNO")]
        public byte? Worktypeobjectversionno { get; set; }
        [Column("WORKTYPEPKGUID")]
        [StringLength(36)]
        public string Worktypepkguid { get; set; }
    }
}
