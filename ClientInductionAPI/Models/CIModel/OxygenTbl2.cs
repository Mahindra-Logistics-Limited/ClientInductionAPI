using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("OXYGEN_TBL2")]
    [Index(nameof(Guid), Name = "OXY2_GUID_IDX", IsUnique = true)]
    [Index(nameof(UniqueTransactionId), Name = "OXY2_UNIQUE_TRANSACTION_ID_IDX", IsUnique = true)]
    public partial class OxygenTbl2
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
        [Column("UNIQUE_TRANSACTION_ID")]
        [StringLength(255)]
        public string UniqueTransactionId { get; set; }
        [Column("TRANSACTION_DATE", TypeName = "DATE")]
        public DateTime? TransactionDate { get; set; }
        [Column("CARGUID")]
        [StringLength(36)]
        public string Carguid { get; set; }
        [Column("SEC_GUID")]
        [StringLength(36)]
        public string SecGuid { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("SP_GUID")]
        [StringLength(36)]
        public string SpGuid { get; set; }
        [Column("TRANSACTION_AMOUNT", TypeName = "NUMBER(12,2)")]
        public decimal? TransactionAmount { get; set; }
        [Column("TRANSACTION_SOURCE")]
        [StringLength(36)]
        public string TransactionSource { get; set; }
        [Column("STATUS")]
        [StringLength(36)]
        public string Status { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("TRANSACTION_ID")]
        [StringLength(36)]
        public string TransactionId { get; set; }
        [Column("TRANSACTION_NO")]
        [StringLength(36)]
        public string TransactionNo { get; set; }
    }
}
