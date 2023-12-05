using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("EXTERNAL_PAYMENTS")]
    public partial class ExternalPayment
    {
        [Column("SEQ_NO", TypeName = "NUMBER")]
        public decimal? SeqNo { get; set; }
        [Column("CAB_NO")]
        [StringLength(12)]
        public string CabNo { get; set; }
        [Column("SP_ID")]
        [StringLength(10)]
        public string SpId { get; set; }
        [Column("TXN_AMOUNT", TypeName = "NUMBER(12,2)")]
        public decimal? TxnAmount { get; set; }
        [Column("TXN_DATE", TypeName = "DATE")]
        public DateTime? TxnDate { get; set; }
        [Column("TXN_SOURCE")]
        [StringLength(10)]
        public string TxnSource { get; set; }
        [Column("COMMENTS")]
        [StringLength(1000)]
        public string Comments { get; set; }
        [Column("CREATION_DATE", TypeName = "DATE")]
        public DateTime? CreationDate { get; set; }
        [Column("PROCESSING_STATUS")]
        [StringLength(10)]
        public string ProcessingStatus { get; set; }
    }
}
