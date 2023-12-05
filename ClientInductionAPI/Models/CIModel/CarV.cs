using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CarV
    {
        [Column("CAR_GUID")]
        [StringLength(36)]
        public string CarGuid { get; set; }
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
        [Column("WORKSHOPMASTERGUID")]
        [StringLength(36)]
        public string Workshopmasterguid { get; set; }
        [Column("LOCATIONWORKSHOPMASTERGUID")]
        [StringLength(36)]
        public string Locationworkshopmasterguid { get; set; }
        [Column("LOCKCOUNT", TypeName = "NUMBER")]
        public decimal? Lockcount { get; set; }
        [Column("LOCKSTATUS")]
        [StringLength(6)]
        public string Lockstatus { get; set; }
        [Column("ENGINENO")]
        [StringLength(100)]
        public string Engineno { get; set; }
        [Column("READYFLAG")]
        [StringLength(30)]
        public string Readyflag { get; set; }
        [Column("POOLFLAG")]
        [StringLength(1)]
        public string Poolflag { get; set; }
        [Column("RFIDFLAG")]
        public bool? Rfidflag { get; set; }
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
        [Column("CAPITALRECOVERYPERIOD", TypeName = "NUMBER")]
        public decimal? Capitalrecoveryperiod { get; set; }
        [Column("CAR_OWNER")]
        [StringLength(255)]
        public string CarOwner { get; set; }
        [Column("SPGUID")]
        [StringLength(36)]
        public string Spguid { get; set; }
        [Column("SP_PERSONGUID")]
        [StringLength(36)]
        public string SpPersonguid { get; set; }
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
        [Column("CAR_CITY_GUID")]
        [StringLength(36)]
        public string CarCityGuid { get; set; }
        [Column("CAR_CITY_CODE")]
        [StringLength(100)]
        public string CarCityCode { get; set; }
        [Column("CAR_CITY_NAME")]
        [StringLength(200)]
        public string CarCityName { get; set; }
        [Column("CAR_BRAND_GUID")]
        [StringLength(36)]
        public string CarBrandGuid { get; set; }
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
        [Column("CAR_MODEL_GUID")]
        [StringLength(36)]
        public string CarModelGuid { get; set; }
        [Column("ORG_ID")]
        public byte? OrgId { get; set; }
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
        [Column("WORKSHOPDESCRIPTION")]
        [StringLength(2000)]
        public string Workshopdescription { get; set; }
        [Column("BRANCHMASTERGUID")]
        [StringLength(36)]
        public string Branchmasterguid { get; set; }
        [Column("WORKSHOPPKGUID")]
        [StringLength(36)]
        public string Workshoppkguid { get; set; }
        [Column("WORKSHOPLOCATIONTYPE")]
        [StringLength(30)]
        public string Workshoplocationtype { get; set; }
        [Column("CAR_COLOR_GUID")]
        [StringLength(36)]
        public string CarColorGuid { get; set; }
        [Column("CAR_COLOR_NAME")]
        [StringLength(255)]
        public string CarColorName { get; set; }
        [Column("CAR_COLOR_QUICKACCESSCODE")]
        [StringLength(50)]
        public string CarColorQuickaccesscode { get; set; }
        [Column("CAR_BUSINESSCATEGORY_GUID")]
        [StringLength(36)]
        public string CarBusinesscategoryGuid { get; set; }
        [Column("CAR_BUSINESSCATEGORY_NAME")]
        [StringLength(255)]
        public string CarBusinesscategoryName { get; set; }
        [Column("BUSINESSCODE")]
        [StringLength(50)]
        public string Businesscode { get; set; }
        [Column("ISSENDTOMONROE")]
        public short? Issendtomonroe { get; set; }
        [Column("CLIENTMAPGUID")]
        [StringLength(36)]
        public string Clientmapguid { get; set; }
        [Column("CAR_YEAR")]
        [StringLength(10)]
        public string CarYear { get; set; }
        [Column("NOOFSEATS", TypeName = "NUMBER(38)")]
        public decimal? Noofseats { get; set; }
    }
}
