using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class PersonRatingV
    {
        [Column("RATINGGUID")]
        [StringLength(36)]
        public string Ratingguid { get; set; }
        [Required]
        [Column("DRIVERMASTERGUID")]
        [StringLength(36)]
        public string Drivermasterguid { get; set; }
        [Column("RATINGDATE", TypeName = "DATE")]
        public DateTime Ratingdate { get; set; }
        [Column("ABSOLUTERATING", TypeName = "NUMBER(3,1)")]
        public decimal Absoluterating { get; set; }
        [Required]
        [Column("PERSONMASTERGUID")]
        [StringLength(36)]
        public string Personmasterguid { get; set; }
    }
}
