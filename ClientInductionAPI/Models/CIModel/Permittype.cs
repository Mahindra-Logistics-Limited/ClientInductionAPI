using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("PERMITTYPE")]
    public partial class Permittype
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(100)]
        public string Description { get; set; }
        [Column("QUICKACCESSCODE")]
        [StringLength(50)]
        public string Quickaccesscode { get; set; }
        [Column("DISABLED")]
        public bool? Disabled { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("SEQUENCENO", TypeName = "NUMBER")]
        public decimal? Sequenceno { get; set; }
    }
}
