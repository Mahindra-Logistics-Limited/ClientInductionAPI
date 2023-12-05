using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("LINQLOGTABLE")]
    public partial class Linqlogtable
    {
        [Column("DATETIMEVALUE", TypeName = "DATE")]
        public DateTime? Datetimevalue { get; set; }
        [Column("LOGTEXT")]
        [StringLength(1000)]
        public string Logtext { get; set; }
        [Column("NO", TypeName = "NUMBER")]
        public decimal? No { get; set; }
    }
}
