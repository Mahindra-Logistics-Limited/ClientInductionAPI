using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class TemplateexecutiondetailV
    {
        [Column("TEMPLATEEXECUTIONSGUID")]
        [StringLength(36)]
        public string Templateexecutionsguid { get; set; }
        [Column("SEARCHTEMPLATEMASTERGUID")]
        [StringLength(36)]
        public string Searchtemplatemasterguid { get; set; }
        [Column("TEMPLATEEXECUTIONRESULT")]
        [StringLength(100)]
        public string Templateexecutionresult { get; set; }
        [Column("TEMPLATEEXECUTION_DATECREATED", TypeName = "DATE")]
        public DateTime TemplateexecutionDatecreated { get; set; }
        [Column("TEMPLATEEXECUTIONMESSAGE")]
        [StringLength(1000)]
        public string Templateexecutionmessage { get; set; }
        [Column("TEMPLATE_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime TemplateEffectivestartdate { get; set; }
        [Column("TEMPLATE_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime TemplateEffectiveenddate { get; set; }
        [Column("WF_URL")]
        [StringLength(1000)]
        public string WfUrl { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("TEMPLATEEXECUTIONSPKGUID")]
        [StringLength(36)]
        public string Templateexecutionspkguid { get; set; }
        [Column("TEMPLATE_STATUSENTITYGUID")]
        [StringLength(36)]
        public string TemplateStatusentityguid { get; set; }
        [Column("USERROLE")]
        [StringLength(36)]
        public string Userrole { get; set; }
        [Column("TEMPLATENAME")]
        [StringLength(100)]
        public string Templatename { get; set; }
        [Column("TEMPLATEDESCRIPTION")]
        [StringLength(1000)]
        public string Templatedescription { get; set; }
        [Column("SEARCHSTATUSENTITYGUID")]
        [StringLength(36)]
        public string Searchstatusentityguid { get; set; }
        [Column("APPROVALENABLED")]
        [StringLength(1)]
        public string Approvalenabled { get; set; }
        [Column("APPROVALHIERARCHYID", TypeName = "NUMBER")]
        public decimal? Approvalhierarchyid { get; set; }
        [Column("TEMPLATETYPE")]
        [StringLength(20)]
        public string Templatetype { get; set; }
        [Column("TEMPLATETRANSACTIONTYPEID")]
        [StringLength(36)]
        public string Templatetransactiontypeid { get; set; }
        [Column("TRANSACTIONRESULTFORMULA")]
        [StringLength(500)]
        public string Transactionresultformula { get; set; }
        [Column("SEARCH_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? SearchEffectivestartdate { get; set; }
        [Column("SEARCH_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? SearchEffectiveenddate { get; set; }
        [Column("SEARCHTEMPLATEMASTERPKGUID")]
        [StringLength(36)]
        public string Searchtemplatemasterpkguid { get; set; }
        [Column("SUMMARYVIEWNAME")]
        [StringLength(200)]
        public string Summaryviewname { get; set; }
        [Column("SUMMARYVIEWTEXT")]
        [StringLength(2000)]
        public string Summaryviewtext { get; set; }
        [Column("VIEWNAME")]
        [StringLength(100)]
        public string Viewname { get; set; }
        [Column("VIEWTEXT")]
        public string Viewtext { get; set; }
        [Required]
        [Column("TEMPLATE_STATUS_ENT_STSGUID")]
        [StringLength(36)]
        public string TemplateStatusEntStsguid { get; set; }
        [Column("TEMPLATE_STATUS_ENT_ENTGUID")]
        [StringLength(36)]
        public string TemplateStatusEntEntguid { get; set; }
        [Column("TEMPLATE_STATUS_ENT_OBJ_VER_NO")]
        public int? TemplateStatusEntObjVerNo { get; set; }
        [Column("TEMPLATE_STATUS_CODE")]
        [StringLength(25)]
        public string TemplateStatusCode { get; set; }
        [Column("TEMPLATE_STATUS_NAME")]
        [StringLength(200)]
        public string TemplateStatusName { get; set; }
        [Column("TEMPLATE_STATUS_DESC")]
        [StringLength(1000)]
        public string TemplateStatusDesc { get; set; }
        [Column("TEMPLATE_ENTITY_CODE")]
        [StringLength(50)]
        public string TemplateEntityCode { get; set; }
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
