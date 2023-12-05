using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class TripSummaryV
    {
        [Column("TRIP_END_DATE", TypeName = "DATE")]
        public DateTime? TripEndDate { get; set; }
        [Column("TOTAL_TRIPS", TypeName = "NUMBER")]
        public decimal? TotalTrips { get; set; }
        [Column("TOTAL_RUN_FARE", TypeName = "NUMBER")]
        public decimal? TotalRunFare { get; set; }
        [Column("TOTAL_WAIT_FARE", TypeName = "NUMBER")]
        public decimal? TotalWaitFare { get; set; }
        [Column("TOTAL_TAXES", TypeName = "NUMBER")]
        public decimal? TotalTaxes { get; set; }
        [Column("TOTAL_REVENUE", TypeName = "NUMBER")]
        public decimal? TotalRevenue { get; set; }
        [Column("TOTAL_COUPON_AMT", TypeName = "NUMBER")]
        public decimal? TotalCouponAmt { get; set; }
        [Column("TOTAL_PAYABLE_AMT", TypeName = "NUMBER")]
        public decimal? TotalPayableAmt { get; set; }
        [Column("TOTAL_TOLL_CHARGES", TypeName = "NUMBER")]
        public decimal? TotalTollCharges { get; set; }
        [Required]
        [Column("LE_NAME")]
        [StringLength(200)]
        public string LeName { get; set; }
        [Column("LE_CODE")]
        [StringLength(200)]
        public string LeCode { get; set; }
        [Required]
        [Column("CITY_NAME")]
        [StringLength(200)]
        public string CityName { get; set; }
        [Column("CITY_CODE")]
        [StringLength(100)]
        public string CityCode { get; set; }
        [Column("BRAND_NAME")]
        [StringLength(200)]
        public string BrandName { get; set; }
        [Column("BRAND_CODE")]
        [StringLength(200)]
        public string BrandCode { get; set; }
        [Column("MODEL_NAME")]
        [StringLength(200)]
        public string ModelName { get; set; }
        [Column("MODEL_CODE")]
        [StringLength(200)]
        public string ModelCode { get; set; }
    }
}
