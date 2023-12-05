using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("AR_PAYMENT_SCHEDULES_ALL_ARCHIVE")]
    [Index(nameof(Attribute1), Name = "AR_PAYMENT_SCHEDULES_ALL_ARCHIVE_ATTRIBUTE1")]
    [Index(nameof(DueDate), Name = "AR_PAYMENT_SCHEDULES_ALL_ARCHIVE_DUEDATE")]
    public partial class ArPaymentSchedulesAllArchive
    {
        [Column("PAYMENT_SCHEDULE_ID")]
        public long PaymentScheduleId { get; set; }
        [Column("STAGED_DUNNING_LEVEL")]
        public byte? StagedDunningLevel { get; set; }
        [Column("DUNNING_LEVEL_OVERRIDE_DATE", TypeName = "DATE")]
        public DateTime? DunningLevelOverrideDate { get; set; }
        [Column("LAST_UPDATE_DATE", TypeName = "DATE")]
        public DateTime LastUpdateDate { get; set; }
        [Column("LAST_UPDATED_BY")]
        public long LastUpdatedBy { get; set; }
        [Column("CREATION_DATE", TypeName = "DATE")]
        public DateTime CreationDate { get; set; }
        [Column("CREATED_BY")]
        public long CreatedBy { get; set; }
        [Column("LAST_UPDATE_LOGIN")]
        public long? LastUpdateLogin { get; set; }
        [Column("DUE_DATE", TypeName = "DATE")]
        public DateTime DueDate { get; set; }
        [Column("AMOUNT_DUE_ORIGINAL", TypeName = "NUMBER")]
        public decimal AmountDueOriginal { get; set; }
        [Column("AMOUNT_DUE_REMAINING", TypeName = "NUMBER")]
        public decimal AmountDueRemaining { get; set; }
        [Column("NUMBER_OF_DUE_DATES")]
        public long NumberOfDueDates { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(30)]
        public string Status { get; set; }
        [Required]
        [Column("INVOICE_CURRENCY_CODE")]
        [StringLength(15)]
        public string InvoiceCurrencyCode { get; set; }
        [Required]
        [Column("CLASS")]
        [StringLength(20)]
        public string Class { get; set; }
        [Column("CUST_TRX_TYPE_ID")]
        public long? CustTrxTypeId { get; set; }
        [Column("CUSTOMER_ID")]
        public long? CustomerId { get; set; }
        [Column("CUSTOMER_SITE_USE_ID")]
        public long? CustomerSiteUseId { get; set; }
        [Column("CUSTOMER_TRX_ID")]
        public long? CustomerTrxId { get; set; }
        [Column("CASH_RECEIPT_ID")]
        public long? CashReceiptId { get; set; }
        [Column("ASSOCIATED_CASH_RECEIPT_ID")]
        public long? AssociatedCashReceiptId { get; set; }
        [Column("TERM_ID")]
        public long? TermId { get; set; }
        [Column("TERMS_SEQUENCE_NUMBER")]
        public long? TermsSequenceNumber { get; set; }
        [Column("GL_DATE_CLOSED", TypeName = "DATE")]
        public DateTime GlDateClosed { get; set; }
        [Column("ACTUAL_DATE_CLOSED", TypeName = "DATE")]
        public DateTime ActualDateClosed { get; set; }
        [Column("DISCOUNT_DATE", TypeName = "DATE")]
        public DateTime? DiscountDate { get; set; }
        [Column("AMOUNT_LINE_ITEMS_ORIGINAL", TypeName = "NUMBER")]
        public decimal? AmountLineItemsOriginal { get; set; }
        [Column("AMOUNT_LINE_ITEMS_REMAINING", TypeName = "NUMBER")]
        public decimal? AmountLineItemsRemaining { get; set; }
        [Column("AMOUNT_APPLIED", TypeName = "NUMBER")]
        public decimal? AmountApplied { get; set; }
        [Column("AMOUNT_ADJUSTED", TypeName = "NUMBER")]
        public decimal? AmountAdjusted { get; set; }
        [Column("AMOUNT_IN_DISPUTE", TypeName = "NUMBER")]
        public decimal? AmountInDispute { get; set; }
        [Column("AMOUNT_CREDITED", TypeName = "NUMBER")]
        public decimal? AmountCredited { get; set; }
        [Column("RECEIVABLES_CHARGES_CHARGED", TypeName = "NUMBER")]
        public decimal? ReceivablesChargesCharged { get; set; }
        [Column("RECEIVABLES_CHARGES_REMAINING", TypeName = "NUMBER")]
        public decimal? ReceivablesChargesRemaining { get; set; }
        [Column("FREIGHT_ORIGINAL", TypeName = "NUMBER")]
        public decimal? FreightOriginal { get; set; }
        [Column("FREIGHT_REMAINING", TypeName = "NUMBER")]
        public decimal? FreightRemaining { get; set; }
        [Column("TAX_ORIGINAL", TypeName = "NUMBER")]
        public decimal? TaxOriginal { get; set; }
        [Column("TAX_REMAINING", TypeName = "NUMBER")]
        public decimal? TaxRemaining { get; set; }
        [Column("DISCOUNT_ORIGINAL", TypeName = "NUMBER")]
        public decimal? DiscountOriginal { get; set; }
        [Column("DISCOUNT_REMAINING", TypeName = "NUMBER")]
        public decimal? DiscountRemaining { get; set; }
        [Column("DISCOUNT_TAKEN_EARNED", TypeName = "NUMBER")]
        public decimal? DiscountTakenEarned { get; set; }
        [Column("DISCOUNT_TAKEN_UNEARNED", TypeName = "NUMBER")]
        public decimal? DiscountTakenUnearned { get; set; }
        [Column("IN_COLLECTION")]
        [StringLength(1)]
        public string InCollection { get; set; }
        [Column("CASH_APPLIED_ID_LAST", TypeName = "NUMBER")]
        public decimal? CashAppliedIdLast { get; set; }
        [Column("CASH_APPLIED_DATE_LAST", TypeName = "DATE")]
        public DateTime? CashAppliedDateLast { get; set; }
        [Column("CASH_APPLIED_AMOUNT_LAST", TypeName = "NUMBER")]
        public decimal? CashAppliedAmountLast { get; set; }
        [Column("CASH_APPLIED_STATUS_LAST")]
        [StringLength(30)]
        public string CashAppliedStatusLast { get; set; }
        [Column("CASH_GL_DATE_LAST", TypeName = "DATE")]
        public DateTime? CashGlDateLast { get; set; }
        [Column("CASH_RECEIPT_ID_LAST")]
        public long? CashReceiptIdLast { get; set; }
        [Column("CASH_RECEIPT_DATE_LAST", TypeName = "DATE")]
        public DateTime? CashReceiptDateLast { get; set; }
        [Column("CASH_RECEIPT_AMOUNT_LAST", TypeName = "NUMBER")]
        public decimal? CashReceiptAmountLast { get; set; }
        [Column("CASH_RECEIPT_STATUS_LAST")]
        [StringLength(30)]
        public string CashReceiptStatusLast { get; set; }
        [Column("EXCHANGE_RATE_TYPE")]
        [StringLength(30)]
        public string ExchangeRateType { get; set; }
        [Column("EXCHANGE_DATE", TypeName = "DATE")]
        public DateTime? ExchangeDate { get; set; }
        [Column("EXCHANGE_RATE", TypeName = "NUMBER")]
        public decimal? ExchangeRate { get; set; }
        [Column("ADJUSTMENT_ID_LAST")]
        public long? AdjustmentIdLast { get; set; }
        [Column("ADJUSTMENT_DATE_LAST", TypeName = "DATE")]
        public DateTime? AdjustmentDateLast { get; set; }
        [Column("ADJUSTMENT_GL_DATE_LAST", TypeName = "DATE")]
        public DateTime? AdjustmentGlDateLast { get; set; }
        [Column("ADJUSTMENT_AMOUNT_LAST", TypeName = "NUMBER")]
        public decimal? AdjustmentAmountLast { get; set; }
        [Column("FOLLOW_UP_DATE_LAST", TypeName = "DATE")]
        public DateTime? FollowUpDateLast { get; set; }
        [Column("FOLLOW_UP_CODE_LAST")]
        [StringLength(30)]
        public string FollowUpCodeLast { get; set; }
        [Column("PROMISE_DATE_LAST", TypeName = "DATE")]
        public DateTime? PromiseDateLast { get; set; }
        [Column("PROMISE_AMOUNT_LAST", TypeName = "NUMBER")]
        public decimal? PromiseAmountLast { get; set; }
        [Column("COLLECTOR_LAST")]
        public long? CollectorLast { get; set; }
        [Column("CALL_DATE_LAST", TypeName = "DATE")]
        public DateTime? CallDateLast { get; set; }
        [Column("TRX_NUMBER")]
        [StringLength(30)]
        public string TrxNumber { get; set; }
        [Column("TRX_DATE", TypeName = "DATE")]
        public DateTime? TrxDate { get; set; }
        [Column("ATTRIBUTE_CATEGORY")]
        [StringLength(30)]
        public string AttributeCategory { get; set; }
        [Column("ATTRIBUTE1")]
        [StringLength(150)]
        public string Attribute1 { get; set; }
        [Column("ATTRIBUTE2")]
        [StringLength(150)]
        public string Attribute2 { get; set; }
        [Column("ATTRIBUTE3")]
        [StringLength(150)]
        public string Attribute3 { get; set; }
        [Column("ATTRIBUTE4")]
        [StringLength(150)]
        public string Attribute4 { get; set; }
        [Column("ATTRIBUTE5")]
        [StringLength(150)]
        public string Attribute5 { get; set; }
        [Column("ATTRIBUTE6")]
        [StringLength(150)]
        public string Attribute6 { get; set; }
        [Column("ATTRIBUTE7")]
        [StringLength(150)]
        public string Attribute7 { get; set; }
        [Column("ATTRIBUTE8")]
        [StringLength(150)]
        public string Attribute8 { get; set; }
        [Column("ATTRIBUTE9")]
        [StringLength(150)]
        public string Attribute9 { get; set; }
        [Column("ATTRIBUTE10")]
        [StringLength(150)]
        public string Attribute10 { get; set; }
        [Column("REVERSED_CASH_RECEIPT_ID")]
        public long? ReversedCashReceiptId { get; set; }
        [Column("AMOUNT_ADJUSTED_PENDING", TypeName = "NUMBER")]
        public decimal? AmountAdjustedPending { get; set; }
        [Column("ATTRIBUTE11")]
        [StringLength(150)]
        public string Attribute11 { get; set; }
        [Column("ATTRIBUTE12")]
        [StringLength(150)]
        public string Attribute12 { get; set; }
        [Column("ATTRIBUTE13")]
        [StringLength(150)]
        public string Attribute13 { get; set; }
        [Column("ATTRIBUTE14")]
        [StringLength(150)]
        public string Attribute14 { get; set; }
        [Column("ATTRIBUTE15")]
        [StringLength(150)]
        public string Attribute15 { get; set; }
        [Column("GL_DATE", TypeName = "DATE")]
        public DateTime GlDate { get; set; }
        [Column("ACCTD_AMOUNT_DUE_REMAINING", TypeName = "NUMBER")]
        public decimal AcctdAmountDueRemaining { get; set; }
        [Column("PROGRAM_APPLICATION_ID")]
        public long? ProgramApplicationId { get; set; }
        [Column("PROGRAM_ID")]
        public long? ProgramId { get; set; }
        [Column("PROGRAM_UPDATE_DATE", TypeName = "DATE")]
        public DateTime? ProgramUpdateDate { get; set; }
        [Column("RECEIPT_CONFIRMED_FLAG")]
        [StringLength(1)]
        public string ReceiptConfirmedFlag { get; set; }
        [Column("REQUEST_ID")]
        public long? RequestId { get; set; }
        [Column("SELECTED_FOR_RECEIPT_BATCH_ID")]
        public long? SelectedForReceiptBatchId { get; set; }
        [Column("LAST_CHARGE_DATE", TypeName = "DATE")]
        public DateTime? LastChargeDate { get; set; }
        [Column("SECOND_LAST_CHARGE_DATE", TypeName = "DATE")]
        public DateTime? SecondLastChargeDate { get; set; }
        [Column("DISPUTE_DATE", TypeName = "DATE")]
        public DateTime? DisputeDate { get; set; }
        [Column("ORG_ID")]
        public long? OrgId { get; set; }
        [Column("GLOBAL_ATTRIBUTE1")]
        [StringLength(150)]
        public string GlobalAttribute1 { get; set; }
        [Column("GLOBAL_ATTRIBUTE2")]
        [StringLength(150)]
        public string GlobalAttribute2 { get; set; }
        [Column("GLOBAL_ATTRIBUTE3")]
        [StringLength(150)]
        public string GlobalAttribute3 { get; set; }
        [Column("GLOBAL_ATTRIBUTE4")]
        [StringLength(150)]
        public string GlobalAttribute4 { get; set; }
        [Column("GLOBAL_ATTRIBUTE5")]
        [StringLength(150)]
        public string GlobalAttribute5 { get; set; }
        [Column("GLOBAL_ATTRIBUTE6")]
        [StringLength(150)]
        public string GlobalAttribute6 { get; set; }
        [Column("GLOBAL_ATTRIBUTE7")]
        [StringLength(150)]
        public string GlobalAttribute7 { get; set; }
        [Column("GLOBAL_ATTRIBUTE8")]
        [StringLength(150)]
        public string GlobalAttribute8 { get; set; }
        [Column("GLOBAL_ATTRIBUTE9")]
        [StringLength(150)]
        public string GlobalAttribute9 { get; set; }
        [Column("GLOBAL_ATTRIBUTE10")]
        [StringLength(150)]
        public string GlobalAttribute10 { get; set; }
        [Column("GLOBAL_ATTRIBUTE11")]
        [StringLength(150)]
        public string GlobalAttribute11 { get; set; }
        [Column("GLOBAL_ATTRIBUTE12")]
        [StringLength(150)]
        public string GlobalAttribute12 { get; set; }
        [Column("GLOBAL_ATTRIBUTE13")]
        [StringLength(150)]
        public string GlobalAttribute13 { get; set; }
        [Column("GLOBAL_ATTRIBUTE14")]
        [StringLength(150)]
        public string GlobalAttribute14 { get; set; }
        [Column("GLOBAL_ATTRIBUTE15")]
        [StringLength(150)]
        public string GlobalAttribute15 { get; set; }
        [Column("GLOBAL_ATTRIBUTE16")]
        [StringLength(150)]
        public string GlobalAttribute16 { get; set; }
        [Column("GLOBAL_ATTRIBUTE17")]
        [StringLength(150)]
        public string GlobalAttribute17 { get; set; }
        [Column("GLOBAL_ATTRIBUTE18")]
        [StringLength(150)]
        public string GlobalAttribute18 { get; set; }
        [Column("GLOBAL_ATTRIBUTE19")]
        [StringLength(150)]
        public string GlobalAttribute19 { get; set; }
        [Column("GLOBAL_ATTRIBUTE20")]
        [StringLength(150)]
        public string GlobalAttribute20 { get; set; }
        [Column("GLOBAL_ATTRIBUTE_CATEGORY")]
        [StringLength(30)]
        public string GlobalAttributeCategory { get; set; }
        [Column("CONS_INV_ID")]
        public long? ConsInvId { get; set; }
        [Column("CONS_INV_ID_REV")]
        public long? ConsInvIdRev { get; set; }
        [Column("EXCLUDE_FROM_DUNNING_FLAG")]
        [StringLength(1)]
        public string ExcludeFromDunningFlag { get; set; }
        [Column("MRC_CUSTOMER_TRX_ID")]
        [StringLength(2000)]
        public string MrcCustomerTrxId { get; set; }
        [Column("MRC_EXCHANGE_RATE_TYPE")]
        [StringLength(2000)]
        public string MrcExchangeRateType { get; set; }
        [Column("MRC_EXCHANGE_DATE")]
        [StringLength(2000)]
        public string MrcExchangeDate { get; set; }
        [Column("MRC_EXCHANGE_RATE")]
        [StringLength(2000)]
        public string MrcExchangeRate { get; set; }
        [Column("MRC_ACCTD_AMOUNT_DUE_REMAINING")]
        [StringLength(2000)]
        public string MrcAcctdAmountDueRemaining { get; set; }
        [Column("BR_AMOUNT_ASSIGNED", TypeName = "NUMBER")]
        public decimal? BrAmountAssigned { get; set; }
        [Column("RESERVED_TYPE")]
        [StringLength(30)]
        public string ReservedType { get; set; }
        [Column("RESERVED_VALUE")]
        public long? ReservedValue { get; set; }
        [Column("ACTIVE_CLAIM_FLAG")]
        [StringLength(1)]
        public string ActiveClaimFlag { get; set; }
        [Column("EXCLUDE_FROM_CONS_BILL_FLAG")]
        [StringLength(1)]
        public string ExcludeFromConsBillFlag { get; set; }
        [Column("PAYMENT_APPROVAL")]
        [StringLength(30)]
        public string PaymentApproval { get; set; }
    }
}
