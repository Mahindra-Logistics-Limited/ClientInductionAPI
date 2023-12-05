using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("XMERU_AR_TERMINATION_DEP")]
    public partial class XmeruArTerminationDep
    {
        [Column("SEQ_ID", TypeName = "NUMBER")]
        public decimal? SeqId { get; set; }
        [Column("DEP_TRX_ID", TypeName = "NUMBER")]
        public decimal? DepTrxId { get; set; }
        [Column("INV_TRX_ID", TypeName = "NUMBER")]
        public decimal? InvTrxId { get; set; }
        [Column("INVOICE_AMT", TypeName = "NUMBER")]
        public decimal? InvoiceAmt { get; set; }
    }
}
