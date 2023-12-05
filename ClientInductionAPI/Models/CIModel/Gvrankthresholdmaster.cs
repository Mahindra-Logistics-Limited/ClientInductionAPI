using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("GVRANKTHRESHOLDMASTER")]
    public partial class Gvrankthresholdmaster
    {
        [Required]
        [Column("GVNAME")]
        [StringLength(300)]
        public string Gvname { get; set; }
        [Column("RANK", TypeName = "NUMBER")]
        public decimal Rank { get; set; }
        [Column("THRESHOLD", TypeName = "NUMBER")]
        public decimal Threshold { get; set; }
    }
}
