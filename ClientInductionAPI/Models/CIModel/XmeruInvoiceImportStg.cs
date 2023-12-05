using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("XMERU_INVOICE_IMPORT_STG")]
    public partial class XmeruInvoiceImportStg
    {
        [Column("INVOICE_ID", TypeName = "NUMBER")]
        public decimal? InvoiceId { get; set; }
        [Column("OPERATING_UNIT")]
        [StringLength(200)]
        public string OperatingUnit { get; set; }
        [Column("INVOICE_TYPE")]
        [StringLength(200)]
        public string InvoiceType { get; set; }
        [Column("TRADING_PARTNER_NAME")]
        [StringLength(200)]
        public string TradingPartnerName { get; set; }
        [Column("SUPPLIER_NUMB", TypeName = "NUMBER")]
        public decimal? SupplierNumb { get; set; }
        [Column("LIABILITY_ACCO")]
        [StringLength(200)]
        public string LiabilityAcco { get; set; }
        [Column("INVOICE_CURR")]
        [StringLength(20)]
        public string InvoiceCurr { get; set; }
        [Column("INVOICE_DATE", TypeName = "DATE")]
        public DateTime? InvoiceDate { get; set; }
        [Column("INVOICE_NUM")]
        [StringLength(200)]
        public string InvoiceNum { get; set; }
        [Column("INVOICE_AMOUNT", TypeName = "NUMBER(10,2)")]
        public decimal? InvoiceAmount { get; set; }
        [Column("GL_DATE", TypeName = "DATE")]
        public DateTime? GlDate { get; set; }
        [Column("PAYMENT_CURR")]
        [StringLength(20)]
        public string PaymentCurr { get; set; }
        [Column("DESCRIPTION")]
        public string Description { get; set; }
        [Column("TERM_DATE", TypeName = "DATE")]
        public DateTime? TermDate { get; set; }
        [Column("PAYMENT_TERMS")]
        [StringLength(200)]
        public string PaymentTerms { get; set; }
        [Column("PAYMENT_METHOD")]
        [StringLength(200)]
        public string PaymentMethod { get; set; }
        [Column("SOURCE")]
        [StringLength(50)]
        public string Source { get; set; }
        [Column("LINE_TYPE")]
        [StringLength(20)]
        public string LineType { get; set; }
        [Column("TDS_TAX", TypeName = "NUMBER(10,2)")]
        public decimal? TdsTax { get; set; }
        [Column("GL_CODE", TypeName = "NUMBER")]
        public decimal? GlCode { get; set; }
        [Column("DIS_DEESCRIPTION")]
        public string DisDeescription { get; set; }
        [Column("ORG_ID", TypeName = "NUMBER")]
        public decimal? OrgId { get; set; }
        [Column("INSERT_FLAG")]
        [StringLength(20)]
        public string InsertFlag { get; set; }
        [Column("PROCESS_FLAG")]
        [StringLength(20)]
        public string ProcessFlag { get; set; }
        [Column("ERROR_MESSAGE")]
        public string ErrorMessage { get; set; }
        [Column("VENDOR_SITE_ID", TypeName = "NUMBER")]
        public decimal? VendorSiteId { get; set; }
    }
}
