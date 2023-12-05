using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DocTypCatEntV
    {
        [Required]
        [Column("DOCUMENTTYPECATEGORYGUID")]
        [StringLength(36)]
        public string Documenttypecategoryguid { get; set; }
        [Required]
        [Column("DOCUMENTCATEGORYMASTERGUID")]
        [StringLength(36)]
        public string Documentcategorymasterguid { get; set; }
        [Required]
        [Column("DOCUMENTTYPEENTITYGUID")]
        [StringLength(36)]
        public string Documenttypeentityguid { get; set; }
    }
}
