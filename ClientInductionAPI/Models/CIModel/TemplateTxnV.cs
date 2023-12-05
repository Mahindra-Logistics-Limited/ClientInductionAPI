using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class TemplateTxnV
    {
        [Column("TEMPLATE_EXECUTION_ID")]
        [StringLength(36)]
        public string TemplateExecutionId { get; set; }
        [Column("SPSITEGUID")]
        [StringLength(36)]
        public string Spsiteguid { get; set; }
        [Column("TXN_TYPE_GUID")]
        [StringLength(36)]
        public string TxnTypeGuid { get; set; }
        [Column("TEMPLATENAME")]
        [StringLength(100)]
        public string Templatename { get; set; }
        [Column("TYPENAME")]
        [StringLength(255)]
        public string Typename { get; set; }
        [Column("TRANSACTIONTYPE_QCODE")]
        [StringLength(60)]
        public string TransactiontypeQcode { get; set; }
        [Column("AMOUNT", TypeName = "NUMBER")]
        public decimal? Amount { get; set; }
        [Column("TXN_DATE")]
        [StringLength(30)]
        public string TxnDate { get; set; }
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("SPNAME")]
        [StringLength(767)]
        public string Spname { get; set; }
        [Column("SITENAME")]
        [StringLength(100)]
        public string Sitename { get; set; }
    }
}
