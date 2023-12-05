using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class AllocbalanceV
    {
        [Required]
        [Column("SP_GUID")]
        [StringLength(36)]
        public string SpGuid { get; set; }
        [Required]
        [Column("PERSONGUID")]
        [StringLength(36)]
        public string Personguid { get; set; }
        [Required]
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Required]
        [Column("SP_NAME")]
        [StringLength(255)]
        public string SpName { get; set; }
        [Column("SP_MNAME")]
        [StringLength(255)]
        public string SpMname { get; set; }
        [Required]
        [Column("SP_LNAME")]
        [StringLength(255)]
        public string SpLname { get; set; }
        [Required]
        [Column("SP_BIO_ID")]
        [StringLength(255)]
        public string SpBioId { get; set; }
        [Column("SP_STATUS")]
        [StringLength(25)]
        public string SpStatus { get; set; }
        [Required]
        [Column("SITEMASTERGUID")]
        [StringLength(36)]
        public string Sitemasterguid { get; set; }
        [Column("SITENAME")]
        [StringLength(100)]
        public string Sitename { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("SITESTARTDATE", TypeName = "DATE")]
        public DateTime Sitestartdate { get; set; }
        [Column("SITEENDDATE", TypeName = "DATE")]
        public DateTime Siteenddate { get; set; }
        [Column("BILLSITEUSEID")]
        [StringLength(20)]
        public string Billsiteuseid { get; set; }
        [Column("BALANCE_DT", TypeName = "DATE")]
        public DateTime BalanceDt { get; set; }
        [Column("DEP_TOT", TypeName = "NUMBER")]
        public decimal? DepTot { get; set; }
        [Column("DEP_REM", TypeName = "NUMBER")]
        public decimal? DepRem { get; set; }
        [Column("DEP_DUE", TypeName = "NUMBER")]
        public decimal? DepDue { get; set; }
        [Column("DEP_UNPOST", TypeName = "NUMBER")]
        public decimal? DepUnpost { get; set; }
        [Column("ACCRUAL_UNPOST", TypeName = "NUMBER")]
        public decimal? AccrualUnpost { get; set; }
        [Column("ACCRUAL_POST_TOT", TypeName = "NUMBER")]
        public decimal? AccrualPostTot { get; set; }
        [Column("ACCRUAL_REM", TypeName = "NUMBER")]
        public decimal? AccrualRem { get; set; }
        [Column("ACCRUAL_DUE", TypeName = "NUMBER")]
        public decimal? AccrualDue { get; set; }
        [Column("INV_UNPOST", TypeName = "NUMBER")]
        public decimal? InvUnpost { get; set; }
        [Column("INV_TOT", TypeName = "NUMBER")]
        public decimal? InvTot { get; set; }
        [Column("INV_REM", TypeName = "NUMBER")]
        public decimal? InvRem { get; set; }
        [Column("INV_DUE", TypeName = "NUMBER")]
        public decimal? InvDue { get; set; }
        [Column("DR_UNPOST", TypeName = "NUMBER")]
        public decimal? DrUnpost { get; set; }
        [Column("DR_POST_TOT", TypeName = "NUMBER")]
        public decimal? DrPostTot { get; set; }
        [Column("DR_REM", TypeName = "NUMBER")]
        public decimal? DrRem { get; set; }
        [Column("DR_DUE", TypeName = "NUMBER")]
        public decimal? DrDue { get; set; }
        [Column("CR_UNPOST", TypeName = "NUMBER")]
        public decimal? CrUnpost { get; set; }
        [Column("CR_POST_TOT", TypeName = "NUMBER")]
        public decimal? CrPostTot { get; set; }
        [Column("CR_UNAPP", TypeName = "NUMBER")]
        public decimal? CrUnapp { get; set; }
        [Column("PMNT_UNPOST", TypeName = "NUMBER")]
        public decimal? PmntUnpost { get; set; }
        [Column("PMNT_POST", TypeName = "NUMBER")]
        public decimal? PmntPost { get; set; }
        [Column("PMNT_UNAPP", TypeName = "NUMBER")]
        public decimal? PmntUnapp { get; set; }
        [Column("ADJ_UNPOST", TypeName = "NUMBER")]
        public decimal? AdjUnpost { get; set; }
        [Column("ADJ_POST_TOT", TypeName = "NUMBER")]
        public decimal? AdjPostTot { get; set; }
        [Column("ADJ_UNAPP", TypeName = "NUMBER")]
        public decimal? AdjUnapp { get; set; }
        [Column("REFUND_UNPOST", TypeName = "NUMBER")]
        public decimal? RefundUnpost { get; set; }
        [Column("REFUND_POST", TypeName = "NUMBER")]
        public decimal? RefundPost { get; set; }
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
        public decimal CreatedBy { get; set; }
        [Column("UPDATE_DATE", TypeName = "DATE")]
        public DateTime? UpdateDate { get; set; }
        [Column("UPDATED_BY", TypeName = "NUMBER")]
        public decimal UpdatedBy { get; set; }
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
        [Required]
        [Column("ALLOC_GUID")]
        [StringLength(36)]
        public string AllocGuid { get; set; }
        [Column("CAR_REGNNO")]
        [StringLength(255)]
        public string CarRegnno { get; set; }
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
        [Required]
        [Column("STATUS_ENT_STSGUID")]
        [StringLength(36)]
        public string StatusEntStsguid { get; set; }
        [Column("STATUS_CODE")]
        [StringLength(25)]
        public string StatusCode { get; set; }
        [Column("STATUS_NAME")]
        [StringLength(200)]
        public string StatusName { get; set; }
        [Column("ENTITY_CODE")]
        [StringLength(50)]
        public string EntityCode { get; set; }
    }
}
