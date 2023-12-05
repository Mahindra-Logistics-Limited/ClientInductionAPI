using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TEST1")]
    public partial class Test1
    {
        [Column("NAME")]
        [StringLength(20)]
        public string Name { get; set; }
    }
}
