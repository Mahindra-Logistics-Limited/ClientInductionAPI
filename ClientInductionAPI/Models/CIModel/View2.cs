using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class View2
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("FULL_NAME")]
        public string FullName { get; set; }
        [Column("PERSON_ID", TypeName = "NUMBER")]
        public decimal? PersonId { get; set; }
        [Required]
        [Column("POSITION_NAME")]
        [StringLength(200)]
        public string PositionName { get; set; }
    }
}
