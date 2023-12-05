using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisTripDataV
    {
        [Required]
        [Column("TRIPID")]
        [StringLength(36)]
        public string Tripid { get; set; }
        [Column("SPID", TypeName = "NUMBER")]
        public decimal? Spid { get; set; }
        [Column("CARREGNNO")]
        [StringLength(36)]
        public string Carregnno { get; set; }
        [Column("DRIVERID", TypeName = "NUMBER")]
        public decimal? Driverid { get; set; }
        [Column("TRIPSTARTTIME", TypeName = "DATE")]
        public DateTime? Tripstarttime { get; set; }
        [Column("TRIPENDTIME", TypeName = "DATE")]
        public DateTime? Tripendtime { get; set; }
        [Column("PICKUPLOCATION")]
        public string Pickuplocation { get; set; }
        [Column("DROPLOCATION")]
        public string Droplocation { get; set; }
        [Column("HIREDDISTANCEKM", TypeName = "NUMBER")]
        public decimal? Hireddistancekm { get; set; }
        [Column("ONCALLDISTCANE", TypeName = "NUMBER")]
        public decimal? Oncalldistcane { get; set; }
        [Column("PAYMENTTYPE")]
        [StringLength(36)]
        public string Paymenttype { get; set; }
        [Column("CHANNEL")]
        [StringLength(36)]
        public string Channel { get; set; }
        [Column("CONVENIENCECHARGE", TypeName = "NUMBER")]
        public decimal? Conveniencecharge { get; set; }
        [Column("RUNNINGFARE", TypeName = "NUMBER")]
        public decimal? Runningfare { get; set; }
        [Column("OTHERCHARGES", TypeName = "NUMBER")]
        public decimal? Othercharges { get; set; }
        [Column("REVENUE", TypeName = "NUMBER")]
        public decimal? Revenue { get; set; }
        [Column("COUPONAMOUNT", TypeName = "NUMBER")]
        public decimal? Couponamount { get; set; }
        [Column("PAYABLEAMOUNT", TypeName = "NUMBER")]
        public decimal? Payableamount { get; set; }
        [Column("ADDITIONALFARE", TypeName = "NUMBER")]
        public decimal? Additionalfare { get; set; }
        [Column("TOLLCHARGE", TypeName = "NUMBER")]
        public decimal? Tollcharge { get; set; }
        [Column("AIRPORTCHARGES", TypeName = "NUMBER")]
        public decimal? Airportcharges { get; set; }
        [Column("RSTRIPSEQUENCE", TypeName = "NUMBER")]
        public decimal? Rstripsequence { get; set; }
        [Column("RSDISCOUNT", TypeName = "NUMBER")]
        public decimal? Rsdiscount { get; set; }
        [Column("STATUS")]
        [StringLength(100)]
        public string Status { get; set; }
        [Column("TRIPRECEIVEDDATE", TypeName = "DATE")]
        public DateTime? Tripreceiveddate { get; set; }
    }
}
