using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CarStatusSummaryV
    {
        [Column("TOTAL_CARS", TypeName = "NUMBER")]
        public decimal? TotalCars { get; set; }
        [Column("STATUS_CODE")]
        [StringLength(25)]
        public string StatusCode { get; set; }
        [Column("STATUS_NAME")]
        [StringLength(200)]
        public string StatusName { get; set; }
        [Column("STATUS_DATE", TypeName = "DATE")]
        public DateTime? StatusDate { get; set; }
        [Column("BRAND")]
        [StringLength(200)]
        public string Brand { get; set; }
        [Required]
        [Column("CITY")]
        [StringLength(200)]
        public string City { get; set; }
        [Column("MODEL")]
        [StringLength(200)]
        public string Model { get; set; }
    }
}
