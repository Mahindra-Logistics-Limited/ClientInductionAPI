using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class UpdatebalanceBaseV
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
    }
}
