using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TEMP_DSE_TXN_TBL")]
    public partial class TempDseTxnTbl
    {
        [Column("SR_NO", TypeName = "NUMBER")]
        public decimal? SrNo { get; set; }
        [Column("SPID")]
        [StringLength(36)]
        public string Spid { get; set; }
        [Column("TXN_TYPE")]
        [StringLength(100)]
        public string TxnType { get; set; }
        [Column("AMOUNT")]
        [StringLength(100)]
        public string Amount { get; set; }
        [Column("SITENAME")]
        [StringLength(50)]
        public string Sitename { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("TXN_GUID")]
        [StringLength(36)]
        public string TxnGuid { get; set; }
        [Column("SEC_GUID")]
        [StringLength(36)]
        public string SecGuid { get; set; }
        [Column("STATUS")]
        [StringLength(36)]
        public string Status { get; set; }
        [Column("TXN_ID", TypeName = "NUMBER")]
        public decimal? TxnId { get; set; }
        [Column("TXN_NO", TypeName = "NUMBER")]
        public decimal? TxnNo { get; set; }
    }
}
