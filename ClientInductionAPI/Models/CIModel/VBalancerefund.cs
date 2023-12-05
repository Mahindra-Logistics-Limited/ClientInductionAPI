using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class VBalancerefund
    {
        [Column("ADJ_UNAPP", TypeName = "NUMBER")]
        public decimal? AdjUnapp { get; set; }
        [Column("PAYMENT_UNAPP", TypeName = "NUMBER")]
        public decimal? PaymentUnapp { get; set; }
        [Column("C_UNAPP", TypeName = "NUMBER")]
        public decimal? CUnapp { get; set; }
        [Column("DR_DUE", TypeName = "NUMBER")]
        public decimal? DrDue { get; set; }
        [Column("INVOICE_DUE", TypeName = "NUMBER")]
        public decimal? InvoiceDue { get; set; }
        [Column("ACC_DUE", TypeName = "NUMBER")]
        public decimal? AccDue { get; set; }
        [Column("DEP_DUE", TypeName = "NUMBER")]
        public decimal? DepDue { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
    }
}
