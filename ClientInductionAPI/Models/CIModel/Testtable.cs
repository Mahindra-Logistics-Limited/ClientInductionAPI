using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TESTTABLE")]
    public partial class Testtable
    {
        [Column("TESTNAME")]
        [StringLength(20)]
        public string Testname { get; set; }
        [Column("VALUE")]
        [StringLength(20)]
        public string Value { get; set; }
    }
}
