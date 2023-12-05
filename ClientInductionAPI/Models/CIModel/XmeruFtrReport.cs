using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class XmeruFtrReport
    {
        [Column("TRANSACTION_NO")]
        [StringLength(100)]
        public string TransactionNo { get; set; }
        [Required]
        [Column("SERVICEPROVIDER_ID")]
        [StringLength(1000)]
        public string ServiceproviderId { get; set; }
        [Column("SERVICEPROVIDER_NAME")]
        [StringLength(767)]
        public string ServiceproviderName { get; set; }
        [Column("SITE_NAME")]
        [StringLength(100)]
        public string SiteName { get; set; }
        [Required]
        [Column("LEGALENTITY_NAME")]
        [StringLength(200)]
        public string LegalentityName { get; set; }
        [Required]
        [Column("CITY_NAME")]
        [StringLength(200)]
        public string CityName { get; set; }
        [Column("BRAND_NAME")]
        [StringLength(200)]
        public string BrandName { get; set; }
        [Column("MODEL_NAME")]
        [StringLength(200)]
        public string ModelName { get; set; }
        [Column("TRANSACTION_TYPE")]
        [StringLength(255)]
        public string TransactionType { get; set; }
        [Column("SUB_TYPE")]
        [StringLength(255)]
        public string SubType { get; set; }
        [Column("TRANSACTION_AMOUNT", TypeName = "NUMBER(12,2)")]
        public decimal? TransactionAmount { get; set; }
        [Column("TRANSACTIONDATE", TypeName = "DATE")]
        public DateTime? Transactiondate { get; set; }
        [Column("TRANSACTION_STATUS")]
        [StringLength(200)]
        public string TransactionStatus { get; set; }
        [Column("USER NAME")]
        public string UserName { get; set; }
        [Column("TRIP_ID")]
        [StringLength(36)]
        public string TripId { get; set; }
        [Column("COMMENTS")]
        [StringLength(2000)]
        public string Comments { get; set; }
        [Required]
        [Column("SEC_GUID")]
        [StringLength(36)]
        public string SecGuid { get; set; }
        [Column("SHOWNINSTATEMENT")]
        [StringLength(3)]
        public string Showninstatement { get; set; }
    }
}
