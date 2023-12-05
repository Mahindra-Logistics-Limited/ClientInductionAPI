using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SP_SITE_BAL_TRIGGER")]
    public partial class SpSiteBalTrigger
    {
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("BALANCE_DT", TypeName = "DATE")]
        public DateTime BalanceDt { get; set; }
        [Column("DEP_TOT", TypeName = "NUMBER(12,2)")]
        public decimal DepTot { get; set; }
        [Column("DEP_REM", TypeName = "NUMBER(12,2)")]
        public decimal DepRem { get; set; }
        [Column("DEP_DUE", TypeName = "NUMBER(12,2)")]
        public decimal DepDue { get; set; }
        [Column("DEP_UNPOST", TypeName = "NUMBER(12,2)")]
        public decimal DepUnpost { get; set; }
        [Column("ACCRUAL_UNPOST", TypeName = "NUMBER(12,2)")]
        public decimal AccrualUnpost { get; set; }
        [Column("ACCRUAL_POST_TOT", TypeName = "NUMBER(12,2)")]
        public decimal AccrualPostTot { get; set; }
        [Column("ACCRUAL_REM", TypeName = "NUMBER(12,2)")]
        public decimal AccrualRem { get; set; }
        [Column("ACCRUAL_DUE", TypeName = "NUMBER(12,2)")]
        public decimal AccrualDue { get; set; }
        [Column("INV_UNPOST", TypeName = "NUMBER(12,2)")]
        public decimal InvUnpost { get; set; }
        [Column("INV_TOT", TypeName = "NUMBER(12,2)")]
        public decimal InvTot { get; set; }
        [Column("INV_REM", TypeName = "NUMBER(12,2)")]
        public decimal InvRem { get; set; }
        [Column("INV_DUE", TypeName = "NUMBER(12,2)")]
        public decimal InvDue { get; set; }
        [Column("DR_UNPOST", TypeName = "NUMBER(12,2)")]
        public decimal DrUnpost { get; set; }
        [Column("DR_POST_TOT", TypeName = "NUMBER(12,2)")]
        public decimal DrPostTot { get; set; }
        [Column("DR_REM", TypeName = "NUMBER(12,2)")]
        public decimal DrRem { get; set; }
        [Column("DR_DUE", TypeName = "NUMBER(12,2)")]
        public decimal DrDue { get; set; }
        [Column("CR_UNPOST", TypeName = "NUMBER(12,2)")]
        public decimal CrUnpost { get; set; }
        [Column("CR_POST_TOT", TypeName = "NUMBER(12,2)")]
        public decimal CrPostTot { get; set; }
        [Column("CR_UNAPP", TypeName = "NUMBER(12,2)")]
        public decimal CrUnapp { get; set; }
        [Column("PMNT_UNPOST", TypeName = "NUMBER(12,2)")]
        public decimal PmntUnpost { get; set; }
        [Column("PMNT_POST", TypeName = "NUMBER(12,2)")]
        public decimal PmntPost { get; set; }
        [Column("PMNT_UNAPP", TypeName = "NUMBER(12,2)")]
        public decimal PmntUnapp { get; set; }
        [Column("ADJ_UNPOST", TypeName = "NUMBER(12,2)")]
        public decimal AdjUnpost { get; set; }
        [Column("ADJ_POST_TOT", TypeName = "NUMBER(12,2)")]
        public decimal AdjPostTot { get; set; }
        [Column("ADJ_UNAPP", TypeName = "NUMBER(12,2)")]
        public decimal AdjUnapp { get; set; }
        [Column("REFUND_UNPOST", TypeName = "NUMBER(12,2)")]
        public decimal RefundUnpost { get; set; }
        [Column("REFUND_POST", TypeName = "NUMBER(12,2)")]
        public decimal RefundPost { get; set; }
        [Column("REFUND_UNPAID", TypeName = "NUMBER(12,2)")]
        public decimal RefundUnpaid { get; set; }
        [Column("LOCK_BAL", TypeName = "NUMBER(12,2)")]
        public decimal LockBal { get; set; }
        [Column("LOCK_LIMIT", TypeName = "NUMBER(12,2)")]
        public decimal LockLimit { get; set; }
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
        [Column("TODAY_DEP", TypeName = "NUMBER(12,2)")]
        public decimal TodayDep { get; set; }
        [Column("TODAY_ACCRUAL", TypeName = "NUMBER(12,2)")]
        public decimal TodayAccrual { get; set; }
        [Column("TODAY_INV", TypeName = "NUMBER(12,2)")]
        public decimal TodayInv { get; set; }
        [Column("TODAY_DR", TypeName = "NUMBER(12,2)")]
        public decimal TodayDr { get; set; }
        [Column("TODAY_CR", TypeName = "NUMBER(12,2)")]
        public decimal TodayCr { get; set; }
        [Column("TODAY_PMNT", TypeName = "NUMBER(12,2)")]
        public decimal TodayPmnt { get; set; }
        [Column("BACKDATE_DEP", TypeName = "NUMBER(12,2)")]
        public decimal BackdateDep { get; set; }
        [Column("BACKDATE_ACCRUAL", TypeName = "NUMBER(12,2)")]
        public decimal BackdateAccrual { get; set; }
        [Column("BACKDATE_INV", TypeName = "NUMBER(12,2)")]
        public decimal BackdateInv { get; set; }
        [Column("BACKDATE_DR", TypeName = "NUMBER(12,2)")]
        public decimal BackdateDr { get; set; }
        [Column("BACKDATE_CR", TypeName = "NUMBER(12,2)")]
        public decimal BackdateCr { get; set; }
        [Column("BACKDATE_PMNT", TypeName = "NUMBER(12,2)")]
        public decimal BackdatePmnt { get; set; }
        [Column("CR_TOT", TypeName = "NUMBER(12,2)")]
        public decimal CrTot { get; set; }
        [Column("PMNT_TOT", TypeName = "NUMBER(12,2)")]
        public decimal PmntTot { get; set; }
        [Column("ADJ_TOT", TypeName = "NUMBER(12,2)")]
        public decimal AdjTot { get; set; }
        [Column("REFUND_TOT", TypeName = "NUMBER(12,2)")]
        public decimal RefundTot { get; set; }
        [Column("DEP_POST", TypeName = "NUMBER(12,2)")]
        public decimal DepPost { get; set; }
        [Column("ACCRUAL_TOT", TypeName = "NUMBER(12,2)")]
        public decimal AccrualTot { get; set; }
        [Column("INV_POST", TypeName = "NUMBER(12,2)")]
        public decimal InvPost { get; set; }
        [Column("DR_TOT", TypeName = "NUMBER(12,2)")]
        public decimal DrTot { get; set; }
        [Column("CUMULATIVE_DEP", TypeName = "NUMBER(12,2)")]
        public decimal CumulativeDep { get; set; }
        [Column("CUMULATIVE_ACCRUAL", TypeName = "NUMBER(12,2)")]
        public decimal CumulativeAccrual { get; set; }
        [Column("CUMULATIVE_INV", TypeName = "NUMBER(12,2)")]
        public decimal CumulativeInv { get; set; }
        [Column("CUMULATIVE_DR", TypeName = "NUMBER(12,2)")]
        public decimal CumulativeDr { get; set; }
        [Column("CUMULATIVE_CR", TypeName = "NUMBER(12,2)")]
        public decimal CumulativeCr { get; set; }
        [Column("CUMULATIVE_PMNT", TypeName = "NUMBER(12,2)")]
        public decimal CumulativePmnt { get; set; }
        [Column("CUMULATIVE_ADJ", TypeName = "NUMBER(12,2)")]
        public decimal CumulativeAdj { get; set; }
        [Column("CUMULATIVE_REFUND", TypeName = "NUMBER(12,2)")]
        public decimal CumulativeRefund { get; set; }
    }
}
