using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class SpbalanceV
    {
        [Column("SP_GUID")]
        [StringLength(36)]
        public string SpGuid { get; set; }
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
        [Column("SP_BIO_ID")]
        [StringLength(255)]
        public string SpBioId { get; set; }
        [Column("SP_STATUS")]
        [StringLength(25)]
        public string SpStatus { get; set; }
        [Column("SITEMASTERGUID")]
        [StringLength(36)]
        public string Sitemasterguid { get; set; }
        [Column("SITE_STATUS_CODE")]
        [StringLength(25)]
        public string SiteStatusCode { get; set; }
        [Column("SITE_STATUS_NAME")]
        [StringLength(200)]
        public string SiteStatusName { get; set; }
        [Column("SITENAME")]
        [StringLength(100)]
        public string Sitename { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("SITESTARTDATE", TypeName = "DATE")]
        public DateTime? Sitestartdate { get; set; }
        [Column("SITEENDDATE", TypeName = "DATE")]
        public DateTime? Siteenddate { get; set; }
        [Column("BILLSITEUSEID")]
        [StringLength(20)]
        public string Billsiteuseid { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("BALANCE_DT", TypeName = "DATE")]
        public DateTime? BalanceDt { get; set; }
        [Column("DEP_TOT", TypeName = "NUMBER")]
        public decimal? DepTot { get; set; }
        [Column("DEP_POST", TypeName = "NUMBER")]
        public decimal? DepPost { get; set; }
        [Column("DEP_UNPOST", TypeName = "NUMBER")]
        public decimal? DepUnpost { get; set; }
        [Column("DEP_DUE", TypeName = "NUMBER")]
        public decimal? DepDue { get; set; }
        [Column("DEP_REM", TypeName = "NUMBER")]
        public decimal? DepRem { get; set; }
        [Column("ACCRUAL_TOT", TypeName = "NUMBER")]
        public decimal? AccrualTot { get; set; }
        [Column("ACCRUAL_POST_TOT", TypeName = "NUMBER")]
        public decimal? AccrualPostTot { get; set; }
        [Column("ACCRUAL_UNPOST", TypeName = "NUMBER")]
        public decimal? AccrualUnpost { get; set; }
        [Column("ACCRUAL_DUE", TypeName = "NUMBER")]
        public decimal? AccrualDue { get; set; }
        [Column("ACCRUAL_REM", TypeName = "NUMBER")]
        public decimal? AccrualRem { get; set; }
        [Column("INV_TOT", TypeName = "NUMBER")]
        public decimal? InvTot { get; set; }
        [Column("INV_POST", TypeName = "NUMBER")]
        public decimal? InvPost { get; set; }
        [Column("INV_UNPOST", TypeName = "NUMBER")]
        public decimal? InvUnpost { get; set; }
        [Column("INV_DUE", TypeName = "NUMBER")]
        public decimal? InvDue { get; set; }
        [Column("INV_REM", TypeName = "NUMBER")]
        public decimal? InvRem { get; set; }
        [Column("DR_TOT", TypeName = "NUMBER")]
        public decimal? DrTot { get; set; }
        [Column("DR_POST_TOT", TypeName = "NUMBER")]
        public decimal? DrPostTot { get; set; }
        [Column("DR_UNPOST", TypeName = "NUMBER")]
        public decimal? DrUnpost { get; set; }
        [Column("DR_DUE", TypeName = "NUMBER")]
        public decimal? DrDue { get; set; }
        [Column("DR_REM", TypeName = "NUMBER")]
        public decimal? DrRem { get; set; }
        [Column("CR_TOT", TypeName = "NUMBER")]
        public decimal? CrTot { get; set; }
        [Column("CR_POST_TOT", TypeName = "NUMBER")]
        public decimal? CrPostTot { get; set; }
        [Column("CR_UNPOST", TypeName = "NUMBER")]
        public decimal? CrUnpost { get; set; }
        [Column("CR_UNAPP", TypeName = "NUMBER")]
        public decimal? CrUnapp { get; set; }
        [Column("PMNT_TOT", TypeName = "NUMBER")]
        public decimal? PmntTot { get; set; }
        [Column("PMNT_POST", TypeName = "NUMBER")]
        public decimal? PmntPost { get; set; }
        [Column("PMNT_UNPOST", TypeName = "NUMBER")]
        public decimal? PmntUnpost { get; set; }
        [Column("PMNT_UNAPP", TypeName = "NUMBER")]
        public decimal? PmntUnapp { get; set; }
        [Column("ADJ_TOT", TypeName = "NUMBER")]
        public decimal? AdjTot { get; set; }
        [Column("ADJ_POST_TOT", TypeName = "NUMBER")]
        public decimal? AdjPostTot { get; set; }
        [Column("ADJ_UNPOST", TypeName = "NUMBER")]
        public decimal? AdjUnpost { get; set; }
        [Column("ADJ_UNAPP", TypeName = "NUMBER")]
        public decimal? AdjUnapp { get; set; }
        [Column("REFUND_TOT", TypeName = "NUMBER")]
        public decimal? RefundTot { get; set; }
        [Column("REFUND_POST", TypeName = "NUMBER")]
        public decimal? RefundPost { get; set; }
        [Column("REFUND_UNPOST", TypeName = "NUMBER")]
        public decimal? RefundUnpost { get; set; }
        [Column("REFUND_UNPAID", TypeName = "NUMBER")]
        public decimal? RefundUnpaid { get; set; }
        [Column("LOCK_BAL", TypeName = "NUMBER")]
        public decimal? LockBal { get; set; }
        [Column("LOCK_LIMIT", TypeName = "NUMBER")]
        public decimal? LockLimit { get; set; }
        [Column("LOCK_BAL_CALC_DATE", TypeName = "DATE")]
        public DateTime? LockBalCalcDate { get; set; }
        [Column("OS_LOCK_CREATED_DT", TypeName = "DATE")]
        public DateTime? OsLockCreatedDt { get; set; }
        [Column("OS_LOCK_CLEARED_DT", TypeName = "DATE")]
        public DateTime? OsLockClearedDt { get; set; }
        [Column("CREATION_DATE", TypeName = "DATE")]
        public DateTime? CreationDate { get; set; }
        [Column("CREATED_BY", TypeName = "NUMBER")]
        public decimal? CreatedBy { get; set; }
        [Column("UPDATE_DATE", TypeName = "DATE")]
        public DateTime? UpdateDate { get; set; }
        [Column("UPDATED_BY", TypeName = "NUMBER")]
        public decimal? UpdatedBy { get; set; }
        [Column("TODAY_DEP", TypeName = "NUMBER")]
        public decimal? TodayDep { get; set; }
        [Column("TODAY_ACCRUAL", TypeName = "NUMBER")]
        public decimal? TodayAccrual { get; set; }
        [Column("TODAY_INV", TypeName = "NUMBER")]
        public decimal? TodayInv { get; set; }
        [Column("TODAY_DR", TypeName = "NUMBER")]
        public decimal? TodayDr { get; set; }
        [Column("TODAY_CR", TypeName = "NUMBER")]
        public decimal? TodayCr { get; set; }
        [Column("TODAY_PMNT", TypeName = "NUMBER")]
        public decimal? TodayPmnt { get; set; }
        [Column("BACKDATE_DEP", TypeName = "NUMBER")]
        public decimal? BackdateDep { get; set; }
        [Column("BACKDATE_ACCRUAL", TypeName = "NUMBER")]
        public decimal? BackdateAccrual { get; set; }
        [Column("BACKDATE_INV", TypeName = "NUMBER")]
        public decimal? BackdateInv { get; set; }
        [Column("BACKDATE_DR", TypeName = "NUMBER")]
        public decimal? BackdateDr { get; set; }
        [Column("BACKDATE_CR", TypeName = "NUMBER")]
        public decimal? BackdateCr { get; set; }
        [Column("BACKDATE_PMNT", TypeName = "NUMBER")]
        public decimal? BackdatePmnt { get; set; }
        [Column("NET_OS", TypeName = "NUMBER")]
        public decimal? NetOs { get; set; }
        [Column("NET_OS_DUE", TypeName = "NUMBER")]
        public decimal? NetOsDue { get; set; }
        [Column("TOTAL_CREDIT", TypeName = "NUMBER")]
        public decimal? TotalCredit { get; set; }
        [Column("TOTAL_DEBIT", TypeName = "NUMBER")]
        public decimal? TotalDebit { get; set; }
        [Column("TOTAL_DEBIT_REM", TypeName = "NUMBER")]
        public decimal? TotalDebitRem { get; set; }
        [Column("TOTAL_CREDIT_REM", TypeName = "NUMBER")]
        public decimal? TotalCreditRem { get; set; }
        [Column("TOTAL_RECEIPT", TypeName = "NUMBER")]
        public decimal? TotalReceipt { get; set; }
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
        [Column("CREDITLIMIT")]
        public int? Creditlimit { get; set; }
        [Column("LOCKCALC_LOCKBAL", TypeName = "NUMBER(12,2)")]
        public decimal? LockcalcLockbal { get; set; }
        [Column("CREDITBALANCELIMIT", TypeName = "NUMBER")]
        public decimal? Creditbalancelimit { get; set; }
    }
}
