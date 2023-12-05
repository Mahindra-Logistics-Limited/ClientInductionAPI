using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("UPI_TXN_TABLE_TEST")]
    public partial class UpiTxnTableTest
    {
        [Key]
        [Column("MERCHANTTXNID")]
        [StringLength(30)]
        public string Merchanttxnid { get; set; }
        [Required]
        [Column("SPID")]
        [StringLength(500)]
        public string Spid { get; set; }
        [Required]
        [Column("SITE")]
        [StringLength(500)]
        public string Site { get; set; }
        [Column("AMOUNT", TypeName = "NUMBER(10,4)")]
        public decimal Amount { get; set; }
        [Column("SPAMOUNT", TypeName = "NUMBER(10,4)")]
        public decimal? Spamount { get; set; }
        [Column("BANKTXNID")]
        [StringLength(500)]
        public string Banktxnid { get; set; }
        [Column("SPTRANSACTIONAUTHDATE")]
        [StringLength(20)]
        public string Sptransactionauthdate { get; set; }
        [Required]
        [Column("SPSTATUS")]
        [StringLength(50)]
        public string Spstatus { get; set; }
        [Required]
        [Column("SPSTATUSDESCRIPTION")]
        [StringLength(100)]
        public string Spstatusdescription { get; set; }
        [Column("SPNPCITXNID")]
        [StringLength(500)]
        public string Spnpcitxnid { get; set; }
        [Column("SPPAYERMOBILENUMBER")]
        [StringLength(30)]
        public string Sppayermobilenumber { get; set; }
        [Column("SPPAYERVIRTUALADDRESS")]
        [StringLength(100)]
        public string Sppayervirtualaddress { get; set; }
        [Column("APPPRAGATIREQUEST")]
        [StringLength(255)]
        public string Apppragatirequest { get; set; }
        [Column("APPPRAGATIRESPONSE")]
        [StringLength(255)]
        public string Apppragatiresponse { get; set; }
        [Column("APPUPISERVERRESPONSE")]
        [StringLength(2000)]
        public string Appupiserverresponse { get; set; }
        [Column("SCHEDULERREQUEST")]
        [StringLength(255)]
        public string Schedulerrequest { get; set; }
        [Column("SCHEDULERRESPONSE")]
        [StringLength(255)]
        public string Schedulerresponse { get; set; }
        [Column("TEMPREFID")]
        [StringLength(255)]
        public string Temprefid { get; set; }
        [Column("PAYERIFSC")]
        [StringLength(255)]
        public string Payerifsc { get; set; }
        [Column("APPROVALCODE")]
        [StringLength(255)]
        public string Approvalcode { get; set; }
        [Column("RESPONSECODE")]
        [StringLength(255)]
        public string Responsecode { get; set; }
        [Column("PAYERACCOUNTNO")]
        [StringLength(100)]
        public string Payeraccountno { get; set; }
        [Column("PAYERACCNAME")]
        [StringLength(500)]
        public string Payeraccname { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("APPUPDATED", TypeName = "DATE")]
        public DateTime? Appupdated { get; set; }
        [Column("SPUPDATED", TypeName = "DATE")]
        public DateTime? Spupdated { get; set; }
        [Column("SOURCE")]
        [StringLength(36)]
        public string Source { get; set; }
        [Column("PRAGATISTATUS")]
        [StringLength(20)]
        public string Pragatistatus { get; set; }
        [Column("PRAGATITXNID", TypeName = "NUMBER")]
        public decimal? Pragatitxnid { get; set; }
        [Column("UPISTATUSCHECK", TypeName = "NUMBER(38)")]
        public decimal? Upistatuscheck { get; set; }
    }
}
