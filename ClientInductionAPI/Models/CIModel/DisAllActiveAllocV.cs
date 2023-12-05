using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisAllActiveAllocV
    {
        [Required]
        [Column("PERSONID")]
        [StringLength(1000)]
        public string Personid { get; set; }
        [Column("NAME")]
        [StringLength(520)]
        public string Name { get; set; }
        [Column("PERSONROLE")]
        [StringLength(3)]
        public string Personrole { get; set; }
        [Column("CARNO")]
        [StringLength(255)]
        public string Carno { get; set; }
        [Required]
        [Column("SPPERSONMASTERGUID")]
        [StringLength(36)]
        public string Sppersonmasterguid { get; set; }
        [Required]
        [Column("SERVICEPROVIDERGUID")]
        [StringLength(36)]
        public string Serviceproviderguid { get; set; }
        [Required]
        [Column("CARALLOCATIONGUID")]
        [StringLength(36)]
        public string Carallocationguid { get; set; }
        [Required]
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("CONTACTNO")]
        [StringLength(255)]
        public string Contactno { get; set; }
    }
}
