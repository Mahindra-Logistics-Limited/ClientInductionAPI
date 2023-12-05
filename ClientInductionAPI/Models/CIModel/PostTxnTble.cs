using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("POST_TXN_TBLE")]
    public partial class PostTxnTble
    {
        [Column("DEAC_AMOUNT", TypeName = "NUMBER")]
        public decimal? DeacAmount { get; set; }
        [Column("ACE_AMOUNT", TypeName = "NUMBER")]
        public decimal? AceAmount { get; set; }
        [Column("TXN_ID", TypeName = "NUMBER")]
        public decimal? TxnId { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(1000)]
        public string Oracleentityid { get; set; }
    }
}
