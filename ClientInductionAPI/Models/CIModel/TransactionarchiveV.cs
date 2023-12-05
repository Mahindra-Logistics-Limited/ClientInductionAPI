using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class TransactionarchiveV
    {
        [Column("TXN_ID", TypeName = "NUMBER")]
        public decimal? TxnId { get; set; }
        [Column("TXN_NO")]
        [StringLength(100)]
        public string TxnNo { get; set; }
        [Column("GVCOMPONENTGUID")]
        [StringLength(36)]
        public string Gvcomponentguid { get; set; }
        [Column("TXN_COMMENTS")]
        [StringLength(2000)]
        public string TxnComments { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("SP_GUID")]
        [StringLength(36)]
        public string SpGuid { get; set; }
        [Column("SP_ID")]
        [StringLength(1000)]
        public string SpId { get; set; }
        [Column("SITE_GUID")]
        [StringLength(36)]
        public string SiteGuid { get; set; }
        [Column("SITENAME")]
        [StringLength(100)]
        public string Sitename { get; set; }
        [Column("SITETYPEMASTERGUID")]
        [StringLength(36)]
        public string Sitetypemasterguid { get; set; }
        [Column("SITETYPE_NAME")]
        [StringLength(500)]
        public string SitetypeName { get; set; }
        [Column("SITETYPE_DESCRIPTION")]
        [StringLength(2000)]
        public string SitetypeDescription { get; set; }
        [Column("SITETYPE_QUICKACCESSCODE")]
        [StringLength(25)]
        public string SitetypeQuickaccesscode { get; set; }
        [Column("SP_NAME")]
        [StringLength(767)]
        public string SpName { get; set; }
        [Column("TXN_DATE", TypeName = "DATE")]
        public DateTime? TxnDate { get; set; }
        [Column("TXN_VAL_ST_DATE", TypeName = "DATE")]
        public DateTime? TxnValStDate { get; set; }
        [Column("TXN_VAL_END_DATE", TypeName = "DATE")]
        public DateTime? TxnValEndDate { get; set; }
        [Column("SEC_GUID")]
        [StringLength(36)]
        public string SecGuid { get; set; }
        [Column("LE_GUID")]
        [StringLength(36)]
        public string LeGuid { get; set; }
        [Column("CITY_GUID")]
        [StringLength(36)]
        public string CityGuid { get; set; }
        [Column("BRAND_GUID")]
        [StringLength(36)]
        public string BrandGuid { get; set; }
        [Column("MODEL_GUID")]
        [StringLength(36)]
        public string ModelGuid { get; set; }
        [Column("LEBRANCH_GUID")]
        [StringLength(36)]
        public string LebranchGuid { get; set; }
        [Column("TXN_TYPE_GUID")]
        [StringLength(36)]
        public string TxnTypeGuid { get; set; }
        [Column("TXN_TYPE")]
        [StringLength(255)]
        public string TxnType { get; set; }
        [Column("TXN_TYPE_CODE")]
        [StringLength(60)]
        public string TxnTypeCode { get; set; }
        [Column("ADJ_TXN_TYPE_GUID")]
        [StringLength(36)]
        public string AdjTxnTypeGuid { get; set; }
        [Column("CONTRA_TXN_TYPE_GUID")]
        [StringLength(36)]
        public string ContraTxnTypeGuid { get; set; }
        [Column("SPSERVICECHARGEFLAG")]
        [StringLength(30)]
        public string Spservicechargeflag { get; set; }
        [Column("TXN_CLASS")]
        [StringLength(255)]
        public string TxnClass { get; set; }
        [Column("TXN_CLASS_CODE")]
        [StringLength(25)]
        public string TxnClassCode { get; set; }
        [Column("TXN_SOURCE_GUID")]
        [StringLength(36)]
        public string TxnSourceGuid { get; set; }
        [Column("TXN_SOURCE_CODE")]
        [StringLength(25)]
        public string TxnSourceCode { get; set; }
        [Column("TXN_SOURCE_NAME")]
        [StringLength(255)]
        public string TxnSourceName { get; set; }
        [Column("TXN_STATUS_CODE")]
        [StringLength(25)]
        public string TxnStatusCode { get; set; }
        [Column("TXN_STATUS_NAME")]
        [StringLength(200)]
        public string TxnStatusName { get; set; }
        [Column("LE_CODE")]
        [StringLength(200)]
        public string LeCode { get; set; }
        [Column("LE_NAME")]
        [StringLength(200)]
        public string LeName { get; set; }
        [Column("CITY_CODE")]
        [StringLength(100)]
        public string CityCode { get; set; }
        [Column("CITY_NAME")]
        [StringLength(200)]
        public string CityName { get; set; }
        [Column("BRAND_CODE")]
        [StringLength(200)]
        public string BrandCode { get; set; }
        [Column("BRAND_NAME")]
        [StringLength(200)]
        public string BrandName { get; set; }
        [Column("MODEL_CODE")]
        [StringLength(200)]
        public string ModelCode { get; set; }
        [Column("MODEL_NAME")]
        [StringLength(200)]
        public string ModelName { get; set; }
        [Column("ORG_ID")]
        public byte? OrgId { get; set; }
        [Column("TXN_AMOUNT", TypeName = "NUMBER(12,2)")]
        public decimal? TxnAmount { get; set; }
        [Column("TXN_ST_AMOUNT", TypeName = "NUMBER(12,2)")]
        public decimal? TxnStAmount { get; set; }
        [Column("TXN_ST_ED_AMOUNT", TypeName = "NUMBER(12,2)")]
        public decimal? TxnStEdAmount { get; set; }
        [Column("TXN_ST_HS_AMOUNT", TypeName = "NUMBER(12,2)")]
        public decimal? TxnStHsAmount { get; set; }
        [Column("TXN_UNIT", TypeName = "NUMBER")]
        public decimal? TxnUnit { get; set; }
        [Column("TXN_PRICE", TypeName = "NUMBER")]
        public decimal? TxnPrice { get; set; }
        [Column("SIGNINDICATOR")]
        [StringLength(36)]
        public string Signindicator { get; set; }
        [Column("TXN_OBJ_VER_NO")]
        public int? TxnObjVerNo { get; set; }
        [Column("GLDATE", TypeName = "DATE")]
        public DateTime? Gldate { get; set; }
        [Column("TXN_ORACLEENTITYNAME")]
        [StringLength(100)]
        public string TxnOracleentityname { get; set; }
        [Column("TXN_ORACLEENTITYID")]
        [StringLength(1000)]
        public string TxnOracleentityid { get; set; }
        [Column("GV_QUICKACCESSCODE")]
        [StringLength(50)]
        public string GvQuickaccesscode { get; set; }
        [Column("GROUPVARIANTNAME")]
        [StringLength(255)]
        public string Groupvariantname { get; set; }
        [Column("SOURCEENTITYGUID")]
        [StringLength(36)]
        public string Sourceentityguid { get; set; }
        [Column("SOURCETRANSACTIONID")]
        [StringLength(36)]
        public string Sourcetransactionid { get; set; }
        [Column("TXN_CLASS_DESC")]
        [StringLength(2000)]
        public string TxnClassDesc { get; set; }
        [Column("USERMASTERGUID")]
        [StringLength(36)]
        public string Usermasterguid { get; set; }
        [Column("USEREMAIL")]
        [StringLength(2000)]
        public string Useremail { get; set; }
        [Column("USERNAME")]
        public string Username { get; set; }
        [Column("USERCONTACTNUMBER")]
        [StringLength(2000)]
        public string Usercontactnumber { get; set; }
        [Column("USERDOMAINLOGINNAME")]
        [StringLength(2000)]
        public string Userdomainloginname { get; set; }
        [Column("AVOIDTRANSACTIONTYPE")]
        public bool? Avoidtransactiontype { get; set; }
    }
}
