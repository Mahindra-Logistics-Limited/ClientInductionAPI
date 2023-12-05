using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("SALES_FUELTYPE_INTERFACE")]
    public partial class SalesFueltypeInterface
    {
        [Key]
        [Column("GUID")]
        [StringLength(250)]
        public string Guid { get; set; }
        [Column("FUELTYPE")]
        [StringLength(50)]
        public string Fueltype { get; set; }
    }
}
