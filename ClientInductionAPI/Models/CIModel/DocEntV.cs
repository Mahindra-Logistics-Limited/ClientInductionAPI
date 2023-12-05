using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DocEntV
    {
        [Required]
        [Column("DOCUMENTTYPEENTITYGUID")]
        [StringLength(36)]
        public string Documenttypeentityguid { get; set; }
        [Required]
        [Column("DOCUMENTTYPEMASTERNAME")]
        [StringLength(255)]
        public string Documenttypemastername { get; set; }
        [Column("QUICKACCESSCODE")]
        [StringLength(50)]
        public string Quickaccesscode { get; set; }
    }
}
