using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CreditbalanceV
    {
        [Column("CAR_NO")]
        [StringLength(100)]
        public string CarNo { get; set; }
        [Required]
        [Column("SP_ID")]
        [StringLength(1000)]
        public string SpId { get; set; }
        [Column("MAX_LIMIT")]
        [StringLength(20)]
        public string MaxLimit { get; set; }
        [Column("MIN_LIMIT")]
        [StringLength(20)]
        public string MinLimit { get; set; }
        [Column("MULTIPLIER")]
        [StringLength(20)]
        public string Multiplier { get; set; }
        [Column("VALUE_MULTIPLIER")]
        [StringLength(20)]
        public string ValueMultiplier { get; set; }
        [Column("CURRENT_SET_LIMIT", TypeName = "NUMBER")]
        public decimal? CurrentSetLimit { get; set; }
    }
}
