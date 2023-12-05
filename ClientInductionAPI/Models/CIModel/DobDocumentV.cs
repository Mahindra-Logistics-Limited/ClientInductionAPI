using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DobDocumentV
    {
        [Column("DOCUMENTTYPEENTITYGUID")]
        [StringLength(36)]
        public string Documenttypeentityguid { get; set; }
        [Required]
        [Column("DOCUMENTTYPEMASTERNAME")]
        [StringLength(255)]
        public string Documenttypemastername { get; set; }
        [Column("CATEGORY")]
        [StringLength(1)]
        public string Category { get; set; }
        [Column("ENTITY")]
        [StringLength(20)]
        public string Entity { get; set; }
        [Column("SETID", TypeName = "NUMBER")]
        public decimal? Setid { get; set; }
        [Column("ONLYFORSECONDOWNER", TypeName = "NUMBER")]
        public decimal? Onlyforsecondowner { get; set; }
    }
}
