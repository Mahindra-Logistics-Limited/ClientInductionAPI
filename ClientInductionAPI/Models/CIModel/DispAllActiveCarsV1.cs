using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DispAllActiveCarsV1
    {
        [Column("CARNO")]
        [StringLength(255)]
        public string Carno { get; set; }
        [Column("OWNERSHIPTYPE")]
        [StringLength(255)]
        public string Ownershiptype { get; set; }
        [Required]
        [Column("MODEL_NAME")]
        [StringLength(200)]
        public string ModelName { get; set; }
        [Required]
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("MANTHANCITYID")]
        public byte? Manthancityid { get; set; }
        [Column("MANTHANBRANDID")]
        public byte? Manthanbrandid { get; set; }
        [Column("ISLBO", TypeName = "NUMBER")]
        public decimal? Islbo { get; set; }
        [Column("ISCMP", TypeName = "NUMBER")]
        public decimal? Iscmp { get; set; }
    }
}
