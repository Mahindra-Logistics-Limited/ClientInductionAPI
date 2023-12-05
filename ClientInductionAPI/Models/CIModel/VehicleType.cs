using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("VEHICLE_TYPE")]
    public partial class VehicleType
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("NAME")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("SEQUENCENO", TypeName = "NUMBER")]
        public decimal? Sequenceno { get; set; }
    }
}
