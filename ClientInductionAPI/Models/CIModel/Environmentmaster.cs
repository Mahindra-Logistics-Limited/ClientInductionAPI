using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("ENVIRONMENTMASTER")]
    public partial class Environmentmaster
    {
        [Column("VARIABLE")]
        [StringLength(100)]
        public string Variable { get; set; }
        [Column("VALUE")]
        [StringLength(2000)]
        public string Value { get; set; }
    }
}
