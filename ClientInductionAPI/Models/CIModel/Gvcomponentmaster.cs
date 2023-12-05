using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("GVCOMPONENTMASTER")]
    public partial class Gvcomponentmaster
    {
        [Required]
        [Column("QUICKACCESSCODE")]
        [StringLength(36)]
        public string Quickaccesscode { get; set; }
    }
}
