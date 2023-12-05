using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("XMERU_DATA_LOG")]
    public partial class XmeruDataLog
    {
        [Column("SEQ_ID")]
        public long? SeqId { get; set; }
        [Column("PKG")]
        [StringLength(30)]
        public string Pkg { get; set; }
        [Column("PROC")]
        [StringLength(50)]
        public string Proc { get; set; }
        [Column("LOC")]
        public long? Loc { get; set; }
        [Column("MESSAGE")]
        [StringLength(2000)]
        public string Message { get; set; }
        [Column("LOG_TIME", TypeName = "DATE")]
        public DateTime? LogTime { get; set; }
        [Column("VOUCHER_ID", TypeName = "NUMBER")]
        public decimal? VoucherId { get; set; }
    }
}
