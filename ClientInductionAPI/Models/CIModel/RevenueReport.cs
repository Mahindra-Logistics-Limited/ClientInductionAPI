using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("REVENUE_REPORT")]
    public partial class RevenueReport
    {
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("SP_ID")]
        [StringLength(20)]
        public string SpId { get; set; }
        [Column("CAR_NO")]
        [StringLength(20)]
        public string CarNo { get; set; }
        [Column("MODEL")]
        [StringLength(10)]
        public string Model { get; set; }
        [Column("CITY")]
        [StringLength(20)]
        public string City { get; set; }
        [Column("LE_NAME")]
        [StringLength(10)]
        public string LeName { get; set; }
        [Column("FARE_REVENUE", TypeName = "NUMBER(10,2)")]
        public decimal? FareRevenue { get; set; }
        [Column("E_COUPONS", TypeName = "NUMBER(10,2)")]
        public decimal? ECoupons { get; set; }
        [Column("NET_FARE", TypeName = "NUMBER(10,2)")]
        public decimal? NetFare { get; set; }
        [Column("SUBSCRIPTION", TypeName = "NUMBER(10,2)")]
        public decimal? Subscription { get; set; }
        [Column("DEBIT_NOTE", TypeName = "NUMBER(10,2)")]
        public decimal? DebitNote { get; set; }
        [Column("CREDIT_NOTE", TypeName = "NUMBER(10,2)")]
        public decimal? CreditNote { get; set; }
        [Column("REPAIRMAINTENANCEDM", TypeName = "NUMBER(10,2)")]
        public decimal? Repairmaintenancedm { get; set; }
        [Column("REPAIRMAINTENANCECM", TypeName = "NUMBER(10,2)")]
        public decimal? Repairmaintenancecm { get; set; }
        [Column("NET_SPSHARE", TypeName = "NUMBER(10,2)")]
        public decimal? NetSpshare { get; set; }
        [Column("USERCREATED")]
        [StringLength(20)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
    }
}
