using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("EMI_TRANSACTIONMASTER")]
    public partial class EmiTransactionmaster
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("AMOUNT", TypeName = "NUMBER")]
        public decimal? Amount { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("TXN_GUID")]
        [StringLength(36)]
        public string TxnGuid { get; set; }
        [Column("TXN_NAME")]
        [StringLength(100)]
        public string TxnName { get; set; }
    }
}
