using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TEST")]
    public partial class Test
    {
        [Column("ID", TypeName = "NUMBER")]
        public decimal? Id { get; set; }
        [Column("LARGEDATA", TypeName = "CLOB")]
        public string Largedata { get; set; }
    }
}
