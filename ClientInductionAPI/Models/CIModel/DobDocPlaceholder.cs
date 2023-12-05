using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("DOB_DOC_PLACEHOLDER")]
    public partial class DobDocPlaceholder
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("DOCUMENTTYPEENTITYGUID")]
        [StringLength(100)]
        public string Documenttypeentityguid { get; set; }
        [Column("CONTROLID")]
        [StringLength(20)]
        public string Controlid { get; set; }
        [Column("CONTROLTYPE")]
        [StringLength(20)]
        public string Controltype { get; set; }
        [Column("PLACEHOLDER")]
        [StringLength(250)]
        public string Placeholder { get; set; }
        [Column("REQUIRED")]
        [StringLength(20)]
        public string Required { get; set; }
        [Column("SEQUENCENO", TypeName = "NUMBER")]
        public decimal? Sequenceno { get; set; }
        [Column("PRETEXT")]
        [StringLength(20)]
        public string Pretext { get; set; }
        [Column("POSTTEXTDBFIELD")]
        [StringLength(20)]
        public string Posttextdbfield { get; set; }
        [Column("VALUE")]
        [StringLength(45)]
        public string Value { get; set; }
    }
}
