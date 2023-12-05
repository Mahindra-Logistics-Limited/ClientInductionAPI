using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CcMasterV
    {
        [Column("CAR_NO")]
        [StringLength(36)]
        public string CarNo { get; set; }
        [Column("TOTAL_KM", TypeName = "NUMBER")]
        public decimal? TotalKm { get; set; }
        [Column("DRIVER_ID", TypeName = "NUMBER")]
        public decimal? DriverId { get; set; }
        [Column("BOOKING_REFUSES", TypeName = "NUMBER")]
        public decimal? BookingRefuses { get; set; }
        [Column("STF_COUNT", TypeName = "NUMBER")]
        public decimal? StfCount { get; set; }
        [Column("DRY_RUN_KM", TypeName = "NUMBER")]
        public decimal? DryRunKm { get; set; }
        [Column("LOGOUT_KM", TypeName = "NUMBER")]
        public decimal? LogoutKm { get; set; }
    }
}
