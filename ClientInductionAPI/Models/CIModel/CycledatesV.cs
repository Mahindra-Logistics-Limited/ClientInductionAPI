using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CycledatesV
    {
        [Column("CYCLEDT", TypeName = "DATE")]
        public DateTime? Cycledt { get; set; }
        [Column("QUICKACCESSCODE")]
        [StringLength(25)]
        public string Quickaccesscode { get; set; }
        [Column("NAME")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("CYCLEMASTERGUID")]
        [StringLength(36)]
        public string Cyclemasterguid { get; set; }
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
    }
}
