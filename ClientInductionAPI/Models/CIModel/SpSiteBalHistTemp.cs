using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SP_SITE_BAL_HIST_TEMP")]
    public partial class SpSiteBalHistTemp
    {
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("BALANCE_DT", TypeName = "DATE")]
        public DateTime? BalanceDt { get; set; }
        [Column("DEP_OPEN_BAL", TypeName = "NUMBER")]
        public decimal? DepOpenBal { get; set; }
        [Column("DEP_TOT", TypeName = "NUMBER")]
        public decimal? DepTot { get; set; }
        [Column("DEP_REM", TypeName = "NUMBER")]
        public decimal? DepRem { get; set; }
        [Column("DEP_DUE", TypeName = "NUMBER")]
        public decimal? DepDue { get; set; }
        [Column("DEP_UNPOST", TypeName = "NUMBER")]
        public decimal? DepUnpost { get; set; }
        [Column("ACCRUAL_OPEN_BAL", TypeName = "NUMBER")]
        public decimal? AccrualOpenBal { get; set; }
        [Column("ACCRUAL_UNPOST", TypeName = "NUMBER")]
        public decimal? AccrualUnpost { get; set; }
        [Column("ACCRUAL_POST_TOT", TypeName = "NUMBER")]
        public decimal? AccrualPostTot { get; set; }
        [Column("ACCRUAL_REM", TypeName = "NUMBER")]
        public decimal? AccrualRem { get; set; }
        [Column("ACCRUAL_DUE", TypeName = "NUMBER")]
        public decimal? AccrualDue { get; set; }
        [Column("INV_OPEN_BAL", TypeName = "NUMBER")]
        public decimal? InvOpenBal { get; set; }
        [Column("INV_UNPOST", TypeName = "NUMBER")]
        public decimal? InvUnpost { get; set; }
        [Column("INV_TOT", TypeName = "NUMBER")]
        public decimal? InvTot { get; set; }
        [Column("INV_REM", TypeName = "NUMBER")]
        public decimal? InvRem { get; set; }
        [Column("INV_DUE", TypeName = "NUMBER")]
        public decimal? InvDue { get; set; }
        [Column("DR_OPEN_BAL", TypeName = "NUMBER")]
        public decimal? DrOpenBal { get; set; }
        [Column("DR_UNPOST", TypeName = "NUMBER")]
        public decimal? DrUnpost { get; set; }
        [Column("DR_POST_TOT", TypeName = "NUMBER")]
        public decimal? DrPostTot { get; set; }
        [Column("DR_REM", TypeName = "NUMBER")]
        public decimal? DrRem { get; set; }
        [Column("DR_DUE", TypeName = "NUMBER")]
        public decimal? DrDue { get; set; }
        [Column("CR_OPEN_BAL", TypeName = "NUMBER")]
        public decimal? CrOpenBal { get; set; }
        [Column("CR_UNPOST", TypeName = "NUMBER")]
        public decimal? CrUnpost { get; set; }
        [Column("CR_POST_TOT", TypeName = "NUMBER")]
        public decimal? CrPostTot { get; set; }
        [Column("CR_UNAPP", TypeName = "NUMBER")]
        public decimal? CrUnapp { get; set; }
        [Column("PMNT_OPEN_BAL", TypeName = "NUMBER")]
        public decimal? PmntOpenBal { get; set; }
        [Column("PMNT_UNPOST", TypeName = "NUMBER")]
        public decimal? PmntUnpost { get; set; }
        [Column("PMNT_POST", TypeName = "NUMBER")]
        public decimal? PmntPost { get; set; }
        [Column("PMNT_UNAPP", TypeName = "NUMBER")]
        public decimal? PmntUnapp { get; set; }
        [Column("ADJ_OPEN_BAL", TypeName = "NUMBER")]
        public decimal? AdjOpenBal { get; set; }
        [Column("ADJ_UNPOST", TypeName = "NUMBER")]
        public decimal? AdjUnpost { get; set; }
        [Column("ADJ_POST_TOT", TypeName = "NUMBER")]
        public decimal? AdjPostTot { get; set; }
        [Column("ADJ_UNAPP", TypeName = "NUMBER")]
        public decimal? AdjUnapp { get; set; }
        [Column("REFUND_OPEN_BAL", TypeName = "NUMBER")]
        public decimal? RefundOpenBal { get; set; }
        [Column("REFUND_UNPOST", TypeName = "NUMBER")]
        public decimal? RefundUnpost { get; set; }
        [Column("REFUND_POST", TypeName = "NUMBER")]
        public decimal? RefundPost { get; set; }
        [Column("REFUND_UNPAID", TypeName = "NUMBER")]
        public decimal? RefundUnpaid { get; set; }
        [Column("NET_OS_OPEN_BAL", TypeName = "NUMBER")]
        public decimal? NetOsOpenBal { get; set; }
        [Column("TODAY_BACK_DATE_OPEN", TypeName = "NUMBER")]
        public decimal? TodayBackDateOpen { get; set; }
        [Column("TODAY_BACK_DATE_NET", TypeName = "NUMBER")]
        public decimal? TodayBackDateNet { get; set; }
        [Column("LOCK_OPEN_BAL", TypeName = "NUMBER")]
        public decimal? LockOpenBal { get; set; }
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
        [Column("BACKDATE_DEP_OPEN", TypeName = "NUMBER")]
        public decimal? BackdateDepOpen { get; set; }
        [Column("BACKDATE_ACCRUAL_OPEN", TypeName = "NUMBER")]
        public decimal? BackdateAccrualOpen { get; set; }
        [Column("BACKDATE_INV_OPEN", TypeName = "NUMBER")]
        public decimal? BackdateInvOpen { get; set; }
        [Column("BACKDATE_DR_OPEN", TypeName = "NUMBER")]
        public decimal? BackdateDrOpen { get; set; }
        [Column("BACKDATE_CR_OPEN", TypeName = "NUMBER")]
        public decimal? BackdateCrOpen { get; set; }
        [Column("BACKDATE_PMNT_OPEN", TypeName = "NUMBER")]
        public decimal? BackdatePmntOpen { get; set; }
        [Column("CR_TOT", TypeName = "NUMBER")]
        public decimal? CrTot { get; set; }
        [Column("PMNT_TOT", TypeName = "NUMBER")]
        public decimal? PmntTot { get; set; }
        [Column("ADJ_TOT", TypeName = "NUMBER")]
        public decimal? AdjTot { get; set; }
        [Column("REFUND_TOT", TypeName = "NUMBER")]
        public decimal? RefundTot { get; set; }
        [Column("DEP_POST", TypeName = "NUMBER")]
        public decimal? DepPost { get; set; }
        [Column("ACCRUAL_TOT", TypeName = "NUMBER")]
        public decimal? AccrualTot { get; set; }
        [Column("INV_POST", TypeName = "NUMBER")]
        public decimal? InvPost { get; set; }
        [Column("DR_TOT", TypeName = "NUMBER")]
        public decimal? DrTot { get; set; }
        [Column("CUMULATIVE_DEP", TypeName = "NUMBER")]
        public decimal? CumulativeDep { get; set; }
        [Column("CUMULATIVE_ACCRUAL", TypeName = "NUMBER")]
        public decimal? CumulativeAccrual { get; set; }
        [Column("CUMULATIVE_INV", TypeName = "NUMBER")]
        public decimal? CumulativeInv { get; set; }
        [Column("CUMULATIVE_DR", TypeName = "NUMBER")]
        public decimal? CumulativeDr { get; set; }
        [Column("CUMULATIVE_CR", TypeName = "NUMBER")]
        public decimal? CumulativeCr { get; set; }
        [Column("CUMULATIVE_PMNT", TypeName = "NUMBER")]
        public decimal? CumulativePmnt { get; set; }
        [Column("CUMULATIVE_ADJ", TypeName = "NUMBER")]
        public decimal? CumulativeAdj { get; set; }
        [Column("CUMULATIVE_REFUND", TypeName = "NUMBER")]
        public decimal? CumulativeRefund { get; set; }
        [Column("REVISEDLOCKAMOUNT", TypeName = "NUMBER")]
        public decimal? Revisedlockamount { get; set; }
        [Column("REVISEDLOCKFLAG", TypeName = "NUMBER")]
        public decimal? Revisedlockflag { get; set; }
    }
}
