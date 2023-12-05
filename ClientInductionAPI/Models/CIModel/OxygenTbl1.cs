using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("OXYGEN_TBL1")]
    [Index(nameof(Guid), Name = "OXY1_GUID_IDX", IsUnique = true)]
    [Index(nameof(UniqueTransactionId), Name = "OXY1_UNIQUE_TRANSACTION_ID_IDX", IsUnique = true)]
    public partial class OxygenTbl1
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("CAR_NO")]
        [StringLength(255)]
        public string CarNo { get; set; }
        [Column("TRANSACTION_DATE", TypeName = "DATE")]
        public DateTime? TransactionDate { get; set; }
        [Column("UNIQUE_TRANSACTION_ID")]
        [StringLength(1000)]
        public string UniqueTransactionId { get; set; }
        [Column("TRANSACTION_AMOUNT", TypeName = "NUMBER(12,2)")]
        public decimal? TransactionAmount { get; set; }
        [Column("MERCHANT_ID")]
        [StringLength(1000)]
        public string MerchantId { get; set; }
        [Column("TRANSACTION_SOURCE")]
        [StringLength(36)]
        public string TransactionSource { get; set; }
        [Column("STATUS")]
        [StringLength(36)]
        public string Status { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
    }
}
