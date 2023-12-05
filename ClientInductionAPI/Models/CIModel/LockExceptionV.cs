using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class LockExceptionV
    {
        [Column("LOCKEXCEPTIONGUID")]
        [StringLength(36)]
        public string Lockexceptionguid { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("LOCKTYPEMASTERGUID")]
        [StringLength(36)]
        public string Locktypemasterguid { get; set; }
        [Column("STARTDATE", TypeName = "DATE")]
        public DateTime? Startdate { get; set; }
        [Column("ENDDATE", TypeName = "DATE")]
        public DateTime? Enddate { get; set; }
        [Column("LOCKREFERENCE")]
        [StringLength(36)]
        public string Lockreference { get; set; }
        [Column("SOURCEENTITY")]
        [StringLength(36)]
        public string Sourceentity { get; set; }
        [Column("LOCKDETAILS")]
        [StringLength(1000)]
        public string Lockdetails { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("LOCKEXCEPTIONID", TypeName = "NUMBER")]
        public decimal? Lockexceptionid { get; set; }
        [Column("CARLOCKGUID")]
        [StringLength(36)]
        public string Carlockguid { get; set; }
        [Column("LOCKID", TypeName = "NUMBER")]
        public decimal? Lockid { get; set; }
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
        [Column("CAR_PKGUID")]
        [StringLength(36)]
        public string CarPkguid { get; set; }
        [Column("WORKSHOPMASTERGUID")]
        [StringLength(36)]
        public string Workshopmasterguid { get; set; }
        [Column("LOCATIONWORKSHOPMASTERGUID")]
        [StringLength(36)]
        public string Locationworkshopmasterguid { get; set; }
        [Column("CAR_STATUS_CODE")]
        [StringLength(25)]
        public string CarStatusCode { get; set; }
        [Column("CAR_MAKE_CODE")]
        [StringLength(25)]
        public string CarMakeCode { get; set; }
        [Column("CAR_MODELCODE")]
        [StringLength(25)]
        public string CarModelcode { get; set; }
        [Required]
        [Column("CAR_GVGUID")]
        [StringLength(36)]
        public string CarGvguid { get; set; }
        [Column("CAR_OWNER")]
        [StringLength(255)]
        public string CarOwner { get; set; }
        [Column("SPGUID")]
        [StringLength(36)]
        public string Spguid { get; set; }
        [Column("CAR_OWNER_SPID")]
        [StringLength(1000)]
        public string CarOwnerSpid { get; set; }
        [Column("SP_PKGUID")]
        [StringLength(36)]
        public string SpPkguid { get; set; }
        [Required]
        [Column("CAR_SEC_GUID")]
        [StringLength(36)]
        public string CarSecGuid { get; set; }
        [Required]
        [Column("CAR_LE_BRANCH_GUID")]
        [StringLength(36)]
        public string CarLeBranchGuid { get; set; }
        [Column("CAR_LE_CODE")]
        [StringLength(200)]
        public string CarLeCode { get; set; }
        [Required]
        [Column("CAR_SEC_GUID_LE_CODE")]
        [StringLength(36)]
        public string CarSecGuidLeCode { get; set; }
        [Column("CAR_CITY_CODE")]
        [StringLength(100)]
        public string CarCityCode { get; set; }
        [Column("CAR_BRAND_CODE")]
        [StringLength(200)]
        public string CarBrandCode { get; set; }
        [Column("CAR_BRAND_NAME")]
        [StringLength(200)]
        public string CarBrandName { get; set; }
        [Column("CAR_OP_MODEL_CODE")]
        [StringLength(200)]
        public string CarOpModelCode { get; set; }
        [Column("WORKSHOPQUICKACCESSCODE")]
        [StringLength(200)]
        public string Workshopquickaccesscode { get; set; }
        [Column("BRANCHMASTERGUID")]
        [StringLength(36)]
        public string Branchmasterguid { get; set; }
        [Column("WORKSHOPPKGUID")]
        [StringLength(36)]
        public string Workshoppkguid { get; set; }
        [Required]
        [Column("STATUS_ENT_STSGUID")]
        [StringLength(36)]
        public string StatusEntStsguid { get; set; }
        [Column("STATUS_ENT_ENTGUID")]
        [StringLength(36)]
        public string StatusEntEntguid { get; set; }
        [Column("STATUS_ENT_OBJ_VER_NO")]
        public int? StatusEntObjVerNo { get; set; }
        [Column("LOCKEXCEPTION_STATUS_CODE")]
        [StringLength(25)]
        public string LockexceptionStatusCode { get; set; }
        [Column("LOCKEXCEPTION_STATUS_NAME")]
        [StringLength(200)]
        public string LockexceptionStatusName { get; set; }
        [Column("LOCKEXCEPTION_STATUS_DESC")]
        [StringLength(1000)]
        public string LockexceptionStatusDesc { get; set; }
        [Column("LOCKEXCEPTION_ENTITY_CODE")]
        [StringLength(50)]
        public string LockexceptionEntityCode { get; set; }
        [Column("LOCKNAME")]
        [StringLength(200)]
        public string Lockname { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(1000)]
        public string Description { get; set; }
        [Column("QUICKACCESSCODE")]
        [StringLength(25)]
        public string Quickaccesscode { get; set; }
        [Column("OBJECTVERSIONNO")]
        public int? Objectversionno { get; set; }
        [Column("STATUSCOLOR")]
        [StringLength(30)]
        public string Statuscolor { get; set; }
    }
}
