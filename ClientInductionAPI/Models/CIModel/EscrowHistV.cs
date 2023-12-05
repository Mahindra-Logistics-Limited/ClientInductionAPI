using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class EscrowHistV
    {
        [Column("SITENAME")]
        [StringLength(100)]
        public string Sitename { get; set; }
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("SP_FNAME")]
        [StringLength(255)]
        public string SpFname { get; set; }
        [Column("SP_LNAME")]
        [StringLength(255)]
        public string SpLname { get; set; }
        [Column("TRANSACTIONID", TypeName = "NUMBER")]
        public decimal? Transactionid { get; set; }
        [Column("AMOUNT", TypeName = "NUMBER(12,2)")]
        public decimal? Amount { get; set; }
        [Column("TRANSACTION_DATE")]
        [StringLength(20)]
        public string TransactionDate { get; set; }
        [Column("TRANSACTION_TYPE")]
        [StringLength(255)]
        public string TransactionType { get; set; }
        [Column("USERNAME")]
        public string Username { get; set; }
        [Column("NET_OUTSATNDING", TypeName = "NUMBER")]
        public decimal? NetOutsatnding { get; set; }
        [Column("LE_NAME")]
        [StringLength(200)]
        public string LeName { get; set; }
        [Column("CITY_NAME")]
        [StringLength(200)]
        public string CityName { get; set; }
        [Column("BRAND_NAME")]
        [StringLength(200)]
        public string BrandName { get; set; }
        [Column("MODEL_NAME")]
        [StringLength(200)]
        public string ModelName { get; set; }
        [Column("REGUID")]
        [StringLength(36)]
        public string Reguid { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("BALANCE_DT", TypeName = "DATE")]
        public DateTime? BalanceDt { get; set; }
    }
}
