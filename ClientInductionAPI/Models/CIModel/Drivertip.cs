using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("DRIVERTIP")]
    public partial class Drivertip
    {
        [Key]
        [Column("TRIPID")]
        [StringLength(36)]
        public string Tripid { get; set; }
        [Column("CARNO")]
        [StringLength(255)]
        public string Carno { get; set; }
        [Column("DRIVERID")]
        [StringLength(100)]
        public string Driverid { get; set; }
        [Column("TIPAMOUNT", TypeName = "NUMBER(10,2)")]
        public decimal? Tipamount { get; set; }
        [Column("TIPDATETIME", TypeName = "DATE")]
        public DateTime? Tipdatetime { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
    }
}
