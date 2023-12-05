using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TEMP_ESTIMATED_DRIVER_EARNING")]
    public partial class TempEstimatedDriverEarning
    {
        [Column("REQUESTID")]
        [StringLength(36)]
        public string Requestid { get; set; }
        [Column("CABNO")]
        [StringLength(200)]
        public string Cabno { get; set; }
        [Column("HIREDDISTKM", TypeName = "NUMBER")]
        public decimal? Hireddistkm { get; set; }
        [Column("BOOKINGTYPE")]
        [StringLength(15)]
        public string Bookingtype { get; set; }
        [Column("PKGBASEHR", TypeName = "NUMBER")]
        public decimal? Pkgbasehr { get; set; }
        [Column("PKGBASEKM", TypeName = "NUMBER")]
        public decimal? Pkgbasekm { get; set; }
        [Column("TRIPDURATION", TypeName = "NUMBER")]
        public decimal? Tripduration { get; set; }
        [Column("DRIVERDAYSPENT", TypeName = "NUMBER")]
        public decimal? Driverdayspent { get; set; }
        [Column("DRIVERNIGHTSPENT", TypeName = "NUMBER")]
        public decimal? Drivernightspent { get; set; }
        [Column("TOTALTRIPFARE", TypeName = "NUMBER")]
        public decimal? Totaltripfare { get; set; }
        [Column("DRIVERALLOWANCE", TypeName = "NUMBER")]
        public decimal? Driverallowance { get; set; }
        [Column("ONCALLDISTANCE", TypeName = "NUMBER")]
        public decimal? Oncalldistance { get; set; }
        [Column("WAITTIME", TypeName = "NUMBER")]
        public decimal? Waittime { get; set; }
        [Column("TRIPSTARTTIME", TypeName = "DATE")]
        public DateTime? Tripstarttime { get; set; }
        [Column("CHANNEL")]
        [StringLength(36)]
        public string Channel { get; set; }
        [Column("PICKUPLOCATION")]
        public string Pickuplocation { get; set; }
        [Column("PICKUPADDRESS")]
        public string Pickupaddress { get; set; }
        [Column("DROPLOCATION")]
        public string Droplocation { get; set; }
        [Column("DROPADDRESS")]
        public string Dropaddress { get; set; }
        [Column("ROUTEID", TypeName = "NUMBER")]
        public decimal? Routeid { get; set; }
        [Column("ESTIMATEDEARNING")]
        [StringLength(10)]
        public string Estimatedearning { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("ISDELETED")]
        public bool? Isdeleted { get; set; }
    }
}
