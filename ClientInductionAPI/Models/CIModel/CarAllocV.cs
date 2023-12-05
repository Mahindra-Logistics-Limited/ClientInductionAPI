using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CarAllocV
    {
        [Column("ALLOC_GUID")]
        [StringLength(36)]
        public string AllocGuid { get; set; }
        [Column("CARMASTERPKGUID")]
        [StringLength(36)]
        public string Carmasterpkguid { get; set; }
        [Column("SERVICEPROVIDERPKGUID")]
        [StringLength(36)]
        public string Serviceproviderpkguid { get; set; }
        [Column("CAR_GUID")]
        [StringLength(36)]
        public string CarGuid { get; set; }
        [Column("CARDEVICEMAKEMASTERGUID")]
        [StringLength(36)]
        public string Cardevicemakemasterguid { get; set; }
        [Column("CARDEVICEMODELGUID")]
        [StringLength(36)]
        public string Cardevicemodelguid { get; set; }
        [Column("GROUPVARIANTGUID")]
        [StringLength(36)]
        public string Groupvariantguid { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("CAR_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? CarEffectivestartdate { get; set; }
        [Column("CAR_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? CarEffectiveenddate { get; set; }
        [Column("OWNERSHIPTYPE")]
        [StringLength(255)]
        public string Ownershiptype { get; set; }
        [Column("SERVICEPROVIDERGUID")]
        [StringLength(36)]
        public string Serviceproviderguid { get; set; }
        [Column("POOLFLAG")]
        [StringLength(1)]
        public string Poolflag { get; set; }
        [Column("RFIDFLAG")]
        public bool? Rfidflag { get; set; }
        [Column("CAR_ORACLEENTITYNAME")]
        [StringLength(100)]
        public string CarOracleentityname { get; set; }
        [Column("CAR_ORACLEENTITYID")]
        [StringLength(1000)]
        public string CarOracleentityid { get; set; }
        [Column("CAR_OBJECTVERSIONNO")]
        public byte? CarObjectversionno { get; set; }
        [Column("CAR_REGISTRATIONDATE", TypeName = "DATE")]
        public DateTime? CarRegistrationdate { get; set; }
        [Column("CAR_REGNNO")]
        [StringLength(255)]
        public string CarRegnno { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("CHASSISNO")]
        [StringLength(255)]
        public string Chassisno { get; set; }
        [Column("ENGINENO")]
        [StringLength(100)]
        public string Engineno { get; set; }
        [Column("WORKSHOPMASTERGUID")]
        [StringLength(36)]
        public string Workshopmasterguid { get; set; }
        [Column("REASONMASTERGUID")]
        [StringLength(36)]
        public string Reasonmasterguid { get; set; }
        [Column("CAR_READYFLAG")]
        [StringLength(30)]
        public string CarReadyflag { get; set; }
        [Column("CAR_DEFRRED_DOC_CHECK_FLAG")]
        [StringLength(1)]
        public string CarDefrredDocCheckFlag { get; set; }
        [Column("SITETYPENAME")]
        [StringLength(500)]
        public string Sitetypename { get; set; }
        [Column("SITETYPECODE")]
        [StringLength(25)]
        public string Sitetypecode { get; set; }
        [Column("SP_GUID")]
        [StringLength(36)]
        public string SpGuid { get; set; }
        [Column("SP_ID")]
        [StringLength(1000)]
        public string SpId { get; set; }
        [Column("SP_NAME")]
        [StringLength(767)]
        public string SpName { get; set; }
        [Column("DSEFLAG")]
        public bool? Dseflag { get; set; }
        [Column("SPFLAG")]
        public bool? Spflag { get; set; }
        [Column("DRIVERFLAG")]
        public bool? Driverflag { get; set; }
        [Column("TDSCODE")]
        [StringLength(36)]
        public string Tdscode { get; set; }
        [Column("ALLOC_ST_DATE", TypeName = "DATE")]
        public DateTime? AllocStDate { get; set; }
        [Column("ALLOC_END_DATE", TypeName = "DATE")]
        public DateTime? AllocEndDate { get; set; }
        [Column("ALLOCSTATUSENTITYGUID")]
        [StringLength(36)]
        public string Allocstatusentityguid { get; set; }
        [Column("ALLOC_PAY_SITE_GUID")]
        [StringLength(36)]
        public string AllocPaySiteGuid { get; set; }
        [Column("ALLOC_PAY_SITE_NAME")]
        [StringLength(100)]
        public string AllocPaySiteName { get; set; }
        [Column("STATUS_ENT_STSGUID")]
        [StringLength(36)]
        public string StatusEntStsguid { get; set; }
        [Column("STATUS_ENT_ENTGUID")]
        [StringLength(36)]
        public string StatusEntEntguid { get; set; }
        [Column("STATUS_CODE")]
        [StringLength(25)]
        public string StatusCode { get; set; }
        [Column("STATUS_NAME")]
        [StringLength(200)]
        public string StatusName { get; set; }
        [Column("ENTITY_CODE")]
        [StringLength(50)]
        public string EntityCode { get; set; }
        [Column("LE_GUID")]
        [StringLength(36)]
        public string LeGuid { get; set; }
        [Column("LE_NAME")]
        [StringLength(200)]
        public string LeName { get; set; }
        [Column("LE_CODE")]
        [StringLength(200)]
        public string LeCode { get; set; }
        [Column("CITY_GUID")]
        [StringLength(36)]
        public string CityGuid { get; set; }
        [Column("CITY_NAME")]
        [StringLength(200)]
        public string CityName { get; set; }
        [Column("CITY_CODE")]
        [StringLength(100)]
        public string CityCode { get; set; }
        [Column("BRAND_GUID")]
        [StringLength(36)]
        public string BrandGuid { get; set; }
        [Column("BRAND_NAME")]
        [StringLength(200)]
        public string BrandName { get; set; }
        [Column("BRAND_CODE")]
        [StringLength(200)]
        public string BrandCode { get; set; }
        [Column("GL_SEMENT4")]
        [StringLength(1000)]
        public string GlSement4 { get; set; }
        [Column("MODEL_GUID")]
        [StringLength(36)]
        public string ModelGuid { get; set; }
        [Column("MODEL_NAME")]
        [StringLength(200)]
        public string ModelName { get; set; }
        [Column("MODEL_CODE")]
        [StringLength(200)]
        public string ModelCode { get; set; }
        [Column("GL_SEMENT6")]
        [StringLength(1000)]
        public string GlSement6 { get; set; }
        [Column("LEBRANCH_GUID")]
        [StringLength(36)]
        public string LebranchGuid { get; set; }
        [Column("ORG_ID")]
        public byte? OrgId { get; set; }
        [Column("GL_SEGMENT1")]
        [StringLength(1000)]
        public string GlSegment1 { get; set; }
        [Column("SEC_OBJ_VER_NO")]
        public int? SecObjVerNo { get; set; }
        [Column("SP_DEFRRED_DOC_CHECK_FLAG")]
        [StringLength(1)]
        public string SpDefrredDocCheckFlag { get; set; }
        [Column("SP_PERSONGUID")]
        [StringLength(36)]
        public string SpPersonguid { get; set; }
    }
}
