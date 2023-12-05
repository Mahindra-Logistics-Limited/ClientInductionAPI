using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class BbmparameterBaseV
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("PARAMETERMASTERGUID")]
        [StringLength(36)]
        public string Parametermasterguid { get; set; }
        [Column("PARAMETERVALUE")]
        [StringLength(20)]
        public string Parametervalue { get; set; }
        [Column("UNITMASTERGUID")]
        [StringLength(36)]
        public string Unitmasterguid { get; set; }
        [Required]
        [Column("PARAMETERNAME")]
        [StringLength(255)]
        public string Parametername { get; set; }
        [Column("PARAMETERDESCRIPTION")]
        [StringLength(100)]
        public string Parameterdescription { get; set; }
        [Column("PARAMETERQUICKACCESSCODE")]
        [StringLength(25)]
        public string Parameterquickaccesscode { get; set; }
        [Column("PARAMETERCOMMENTS")]
        [StringLength(100)]
        public string Parametercomments { get; set; }
        [Column("PARAMETERDISABLED")]
        public bool? Parameterdisabled { get; set; }
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
        public byte? Objectversionno { get; set; }
        [Column("TRANSACTIONTYPEGUID")]
        [StringLength(36)]
        public string Transactiontypeguid { get; set; }
        [Column("BBM_BRAND_GUID")]
        [StringLength(36)]
        public string BbmBrandGuid { get; set; }
        [Column("BBM_MODEL_GUID")]
        [StringLength(36)]
        public string BbmModelGuid { get; set; }
        [Column("BBM_BRANCH_GUID")]
        [StringLength(36)]
        public string BbmBranchGuid { get; set; }
        [Column("BBM_LE_GUID")]
        [StringLength(36)]
        public string BbmLeGuid { get; set; }
        [Required]
        [Column("LE_GUID")]
        [StringLength(36)]
        public string LeGuid { get; set; }
        [Required]
        [Column("LE_NAME")]
        [StringLength(200)]
        public string LeName { get; set; }
        [Column("LE_CODE")]
        [StringLength(200)]
        public string LeCode { get; set; }
        [Required]
        [Column("CITY_GUID")]
        [StringLength(36)]
        public string CityGuid { get; set; }
        [Required]
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
        [Required]
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
    }
}
