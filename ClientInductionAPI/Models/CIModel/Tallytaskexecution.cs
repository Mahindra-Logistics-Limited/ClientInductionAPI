using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TALLYTASKEXECUTION")]
    public partial class Tallytaskexecution
    {
        [Required]
        [Column("GUID")]
        [StringLength(50)]
        public string Guid { get; set; }
        [Column("FROMDATE", TypeName = "DATE")]
        public DateTime Fromdate { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(20)]
        public string Status { get; set; }
        [Column("TODATE", TypeName = "DATE")]
        public DateTime Todate { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("ROWCOUNT", TypeName = "NUMBER")]
        public decimal? Rowcount { get; set; }
        [Column("TALLYDLLRESPONSE")]
        [StringLength(1000)]
        public string Tallydllresponse { get; set; }
    }
}
