using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("FUNDWITHDRAWAL_TXN")]
    public partial class FundwithdrawalTxn
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("UNIQUEREQUESTNO")]
        [StringLength(30)]
        public string Uniquerequestno { get; set; }
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("SITE")]
        [StringLength(255)]
        public string Site { get; set; }
        [Column("TRANSFERAMOUNT", TypeName = "NUMBER(10,4)")]
        public decimal? Transferamount { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("FUNDTRANSFERSTATUSCODE")]
        [StringLength(50)]
        public string Fundtransferstatuscode { get; set; }
        [Column("SUBSTATUSCODE")]
        [StringLength(50)]
        public string Substatuscode { get; set; }
        [Column("SUBSTATUSTEXT")]
        [StringLength(1500)]
        public string Substatustext { get; set; }
        [Column("COMMENTS")]
        [StringLength(255)]
        public string Comments { get; set; }
        [Column("GETSTATUSSTATUSCODE")]
        [StringLength(50)]
        public string Getstatusstatuscode { get; set; }
        [Column("BANKREFERENCENO")]
        [StringLength(50)]
        public string Bankreferenceno { get; set; }
        [Column("TRANSACTIONDATE", TypeName = "DATE")]
        public DateTime? Transactiondate { get; set; }
        [Column("FUNDTRANSFERREQUEST")]
        public string Fundtransferrequest { get; set; }
        [Column("FUNDTRANSFERRESPONSE")]
        public string Fundtransferresponse { get; set; }
        [Column("GETSTATUSREQUEST")]
        public string Getstatusrequest { get; set; }
        [Column("GETSTATUSRESPONSE")]
        public string Getstatusresponse { get; set; }
        [Column("UNIQUERESPONSENO")]
        [StringLength(32)]
        public string Uniqueresponseno { get; set; }
        [Column("ISSENDNOTIFICATION")]
        [StringLength(5)]
        public string Issendnotification { get; set; }
        [Column("NET_OS", TypeName = "NUMBER(10,4)")]
        public decimal? NetOs { get; set; }
        [Column("LOCKCALC_LOCKBAL", TypeName = "NUMBER(10,4)")]
        public decimal? LockcalcLockbal { get; set; }
        [Column("CREDITBALLIMIT", TypeName = "NUMBER(10,4)")]
        public decimal? Creditballimit { get; set; }
        [Column("CREDITLIMIT", TypeName = "NUMBER(10,4)")]
        public decimal? Creditlimit { get; set; }
        [Column("FORMULATYPE")]
        [StringLength(10)]
        public string Formulatype { get; set; }
        [Column("TRANSACTIONID", TypeName = "NUMBER")]
        public decimal? Transactionid { get; set; }
        [Column("SETTLEMENTDATE", TypeName = "DATE")]
        public DateTime? Settlementdate { get; set; }
    }
}
