using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisTripSubscriptionV
    {
        [Column("TXN_ID", TypeName = "NUMBER")]
        public decimal? TxnId { get; set; }
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("CARREGNNO")]
        [StringLength(100)]
        public string Carregnno { get; set; }
        [Column("TXN_DATE", TypeName = "DATE")]
        public DateTime? TxnDate { get; set; }
        [Column("TXN_TYPE")]
        [StringLength(255)]
        public string TxnType { get; set; }
        [Column("TXN_CLASS")]
        [StringLength(255)]
        public string TxnClass { get; set; }
        [Column("TXN_STATUS_CODE")]
        [StringLength(25)]
        public string TxnStatusCode { get; set; }
        [Column("LE_CODE")]
        [StringLength(200)]
        public string LeCode { get; set; }
        [Column("CITY_CODE")]
        [StringLength(100)]
        public string CityCode { get; set; }
        [Column("BRAND_CODE")]
        [StringLength(200)]
        public string BrandCode { get; set; }
        [Column("MODEL_CODE")]
        [StringLength(200)]
        public string ModelCode { get; set; }
        [Column("TXN_AMOUNT", TypeName = "NUMBER(12,2)")]
        public decimal? TxnAmount { get; set; }
        [Column("TRIPID")]
        [StringLength(36)]
        public string Tripid { get; set; }
    }
}
