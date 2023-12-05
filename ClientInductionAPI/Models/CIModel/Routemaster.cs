using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("ROUTEMASTER")]
    public partial class Routemaster
    {
        [Key]
        [Column("ROUTEID", TypeName = "NUMBER")]
        public decimal Routeid { get; set; }
        [Required]
        [Column("SOURCE")]
        [StringLength(1000)]
        public string Source { get; set; }
        [Column("DESTINATION")]
        [StringLength(1000)]
        public string Destination { get; set; }
        [Column("TRIPTYPE", TypeName = "NUMBER(38)")]
        public decimal Triptype { get; set; }
        [Required]
        [Column("BRAND")]
        [StringLength(200)]
        public string Brand { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("DISABLED")]
        public bool? Disabled { get; set; }
    }
}
