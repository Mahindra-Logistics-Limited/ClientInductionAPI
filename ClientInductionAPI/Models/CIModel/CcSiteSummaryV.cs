using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CcSiteSummaryV
    {
        [Column("SITEMASTERGUID")]
        [StringLength(36)]
        public string Sitemasterguid { get; set; }
        [Required]
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("CAR_NO")]
        [StringLength(36)]
        public string CarNo { get; set; }
        [Column("DRIVER_ID", TypeName = "NUMBER")]
        public decimal? DriverId { get; set; }
        [Column("CC_DATE", TypeName = "DATE")]
        public DateTime? CcDate { get; set; }
        [Column("BIDDING_PERCENTAGE", TypeName = "NUMBER")]
        public decimal? BiddingPercentage { get; set; }
        [Column("DRY_RUN_PERCENTAGE", TypeName = "NUMBER")]
        public decimal? DryRunPercentage { get; set; }
        [Column("WORKING_HRS", TypeName = "NUMBER")]
        public decimal? WorkingHrs { get; set; }
        [Column("LOGGED_IN_HRS", TypeName = "NUMBER")]
        public decimal? LoggedInHrs { get; set; }
        [Column("LOGIN_COUNT", TypeName = "NUMBER")]
        public decimal? LoginCount { get; set; }
        [Column("TOTAL_KM", TypeName = "NUMBER")]
        public decimal? TotalKm { get; set; }
        [Column("LOGOUT_KM", TypeName = "NUMBER")]
        public decimal? LogoutKm { get; set; }
        [Column("LOGIN_KM", TypeName = "NUMBER")]
        public decimal? LoginKm { get; set; }
        [Column("HIRED_KM", TypeName = "NUMBER")]
        public decimal? HiredKm { get; set; }
        [Column("ON_CALL_KM", TypeName = "NUMBER")]
        public decimal? OnCallKm { get; set; }
        [Column("DRY_RUN_KM", TypeName = "NUMBER")]
        public decimal? DryRunKm { get; set; }
        [Column("MANUAL_TRIPS", TypeName = "NUMBER")]
        public decimal? ManualTrips { get; set; }
        [Column("CALL_CENTER_TRIPS", TypeName = "NUMBER")]
        public decimal? CallCenterTrips { get; set; }
        [Column("STREET_PICKUPS", TypeName = "NUMBER")]
        public decimal? StreetPickups { get; set; }
        [Column("AIRPORT_TRIPS", TypeName = "NUMBER")]
        public decimal? AirportTrips { get; set; }
        [Column("TOTAL_TRIPS", TypeName = "NUMBER")]
        public decimal? TotalTrips { get; set; }
        [Column("TOTAL_BIDS_SENT", TypeName = "NUMBER")]
        public decimal? TotalBidsSent { get; set; }
        [Column("BOOKING_REFUSES", TypeName = "NUMBER")]
        public decimal? BookingRefuses { get; set; }
        [Column("STF_COUNT", TypeName = "NUMBER")]
        public decimal? StfCount { get; set; }
        [Column("NOT_DELIVERED", TypeName = "NUMBER")]
        public decimal? NotDelivered { get; set; }
        [Column("CC_REVENUE", TypeName = "NUMBER")]
        public decimal? CcRevenue { get; set; }
        [Column("BOOKING_FEE", TypeName = "NUMBER")]
        public decimal? BookingFee { get; set; }
        [Column("AIRPORT_REVENUE", TypeName = "NUMBER")]
        public decimal? AirportRevenue { get; set; }
        [Column("AIRPORT_PARKING_CHARGE", TypeName = "NUMBER")]
        public decimal? AirportParkingCharge { get; set; }
        [Column("STREET_REVENUE", TypeName = "NUMBER")]
        public decimal? StreetRevenue { get; set; }
        [Column("OTHER_CHARGES", TypeName = "NUMBER")]
        public decimal? OtherCharges { get; set; }
        [Column("TOTAL_REVENUE", TypeName = "NUMBER")]
        public decimal? TotalRevenue { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
    }
}
