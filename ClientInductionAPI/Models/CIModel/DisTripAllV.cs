using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisTripAllV
    {
        [Required]
        [Column("TRIPID")]
        [StringLength(36)]
        public string Tripid { get; set; }
        [Column("TIME")]
        [StringLength(19)]
        public string Time { get; set; }
        [Column("trip start")]
        public string TripStart { get; set; }
        [Column("trip end")]
        public string TripEnd { get; set; }
        [Column("hired distance", TypeName = "NUMBER")]
        public decimal? HiredDistance { get; set; }
        [Column("oncall", TypeName = "NUMBER")]
        public decimal? Oncall { get; set; }
        [Column(TypeName = "NUMBER")]
        public decimal? Fare { get; set; }
        [Column(TypeName = "NUMBER")]
        public decimal? Coupon { get; set; }
        [Column("Parking/Toll charge", TypeName = "NUMBER")]
        public decimal? ParkingTollCharge { get; set; }
        [Column("service tax", TypeName = "NUMBER")]
        public decimal? ServiceTax { get; set; }
        [Column("convenience charge", TypeName = "NUMBER")]
        public decimal? ConvenienceCharge { get; set; }
        [Column("payment mode")]
        [StringLength(36)]
        public string PaymentMode { get; set; }
    }
}
