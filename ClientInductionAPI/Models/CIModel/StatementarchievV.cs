using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class StatementarchievV
    {
        [Column("TXN_NO")]
        [StringLength(100)]
        public string TxnNo { get; set; }
        [Column("TXN_TYPE")]
        [StringLength(255)]
        public string TxnType { get; set; }
        [Column("TXN_DATE", TypeName = "DATE")]
        public DateTime? TxnDate { get; set; }
        [Column("DR_TXN_AMOUNT", TypeName = "NUMBER")]
        public decimal? DrTxnAmount { get; set; }
        [Column("CR_TXN_AMOUNT", TypeName = "NUMBER")]
        public decimal? CrTxnAmount { get; set; }
        [Column("SITENAME")]
        [StringLength(100)]
        public string Sitename { get; set; }
        [Column("SP_ID")]
        [StringLength(1000)]
        public string SpId { get; set; }
        [Column("SP_NAME")]
        [StringLength(767)]
        public string SpName { get; set; }
        [Column("TRIPID")]
        [StringLength(36)]
        public string Tripid { get; set; }
        [Column("COMMENTS")]
        [StringLength(2000)]
        public string Comments { get; set; }
        [Column("PARAM_DATE", TypeName = "DATE")]
        public DateTime? ParamDate { get; set; }
        [Column("QUERY_PART")]
        [StringLength(10)]
        public string QueryPart { get; set; }
    }
}
