using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class TripRevenueV
    {
        [Column("CAR_NO")]
        [StringLength(36)]
        public string CarNo { get; set; }
        [Column("SP_ID", TypeName = "NUMBER")]
        public decimal? SpId { get; set; }
        [Column("SP_NAME")]
        [StringLength(766)]
        public string SpName { get; set; }
        [Column("SP_CONTACT_NO")]
        [StringLength(255)]
        public string SpContactNo { get; set; }
        [Column("TRIP_ID", TypeName = "NUMBER")]
        public decimal? TripId { get; set; }
        [Column("TRIPRECEIVEDDATE", TypeName = "DATE")]
        public DateTime? Tripreceiveddate { get; set; }
        [Column("TRIP_REVENUE", TypeName = "NUMBER")]
        public decimal? TripRevenue { get; set; }
        [Column("BALANCE_DATE", TypeName = "DATE")]
        public DateTime? BalanceDate { get; set; }
        [Column("OS_OF_LASTDAY", TypeName = "NUMBER")]
        public decimal? OsOfLastday { get; set; }
        [Column("LE")]
        [StringLength(200)]
        public string Le { get; set; }
        [Column("CITY")]
        [StringLength(200)]
        public string City { get; set; }
        [Column("BRAND")]
        [StringLength(200)]
        public string Brand { get; set; }
        [Column("MODEL")]
        [StringLength(200)]
        public string Model { get; set; }
        [Column("REGUID")]
        [StringLength(36)]
        public string Reguid { get; set; }
        [Column("TRIP_SEC_GUID")]
        [StringLength(36)]
        public string TripSecGuid { get; set; }
    }
}
