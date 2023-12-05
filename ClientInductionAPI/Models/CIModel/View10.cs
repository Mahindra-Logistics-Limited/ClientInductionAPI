using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class View10
    {
        [Column("SPGUID")]
        [StringLength(36)]
        public string Spguid { get; set; }
        [Column("PERSONGUID")]
        [StringLength(36)]
        public string Personguid { get; set; }
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("SP_FNAME")]
        [StringLength(255)]
        public string SpFname { get; set; }
        [Column("SP_MNAME")]
        [StringLength(255)]
        public string SpMname { get; set; }
        [Column("SP_LNAME")]
        [StringLength(255)]
        public string SpLname { get; set; }
        [Column("SP_BIOID")]
        [StringLength(255)]
        public string SpBioid { get; set; }
        [Column("DSEFLAG")]
        public bool? Dseflag { get; set; }
        [Column("SPFLAG")]
        public bool? Spflag { get; set; }
        [Column("DRIVERFLAG")]
        public bool? Driverflag { get; set; }
        [Column("SP_OBJ_VER_NO")]
        public int? SpObjVerNo { get; set; }
        [Column("CUST_ID")]
        [StringLength(255)]
        public string CustId { get; set; }
        [Column("SP_STATUS")]
        [StringLength(25)]
        public string SpStatus { get; set; }
        [Column("PERS_STATUS")]
        [StringLength(25)]
        public string PersStatus { get; set; }
        [Column("SP_PKGUID")]
        [StringLength(36)]
        public string SpPkguid { get; set; }
        [Column("ADDR_TYPE_CODE")]
        [StringLength(25)]
        public string AddrTypeCode { get; set; }
        [Column("ADDR_TYPE_NAME")]
        [StringLength(255)]
        public string AddrTypeName { get; set; }
        [Column("FULL_ADDRESS")]
        [StringLength(1236)]
        public string FullAddress { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("LEBRANCHSECURITYGUID")]
        [StringLength(36)]
        public string Lebranchsecurityguid { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Effectiveenddate { get; set; }
        [Column("ADDRESSGUID")]
        [StringLength(36)]
        public string Addressguid { get; set; }
        [Column("SITETYPEMASTERGUID")]
        [StringLength(36)]
        public string Sitetypemasterguid { get; set; }
        [Column("BILLSITEUSEID")]
        [StringLength(20)]
        public string Billsiteuseid { get; set; }
        [Column("DISABLED")]
        public bool? Disabled { get; set; }
        [Column("ORACLEENTITYNAME")]
        [StringLength(100)]
        public string Oracleentityname { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(1000)]
        public string Oracleentityid { get; set; }
        [Column("OBJECTVERSIONNO")]
        public int? Objectversionno { get; set; }
        [Column("SITENAME")]
        [StringLength(100)]
        public string Sitename { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("SPSITESTARTDATE", TypeName = "DATE")]
        public DateTime? Spsitestartdate { get; set; }
        [Column("SPSITEENDDATE", TypeName = "DATE")]
        public DateTime? Spsiteenddate { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("CAPITALRECOVERYENDDT", TypeName = "DATE")]
        public DateTime? Capitalrecoveryenddt { get; set; }
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
        [Column("SITETYPE_NAME")]
        [StringLength(500)]
        public string SitetypeName { get; set; }
        [Column("SITETYPE_DESCRIPTION")]
        [StringLength(2000)]
        public string SitetypeDescription { get; set; }
        [Column("SITETYPE_DISABLED")]
        public bool? SitetypeDisabled { get; set; }
        [Column("SITETYPE_ORACLEENTITYNAME")]
        [StringLength(100)]
        public string SitetypeOracleentityname { get; set; }
        [Column("SITETYPE_ORACLEENTITYID")]
        [StringLength(1000)]
        public string SitetypeOracleentityid { get; set; }
        [Column("SITETYPE_OBJECTVERSIONNO")]
        public byte? SitetypeObjectversionno { get; set; }
        [Column("SITETYPE_QUICKACCESSCODE")]
        [StringLength(25)]
        public string SitetypeQuickaccesscode { get; set; }
        [Column("SITETYPE_PKGUID")]
        [StringLength(36)]
        public string SitetypePkguid { get; set; }
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
