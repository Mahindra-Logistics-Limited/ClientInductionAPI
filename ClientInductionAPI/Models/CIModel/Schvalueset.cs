using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SCHVALUESET")]
    public partial class Schvalueset
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("SCHPARAMETERGUID")]
        [StringLength(36)]
        public string Schparameterguid { get; set; }
        [Column("VALUE")]
        public string Value { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
    }
}
