using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisAllocatedCarsV
    {
        [Required]
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("SPNAME")]
        [StringLength(520)]
        public string Spname { get; set; }
        [Column("PERSONROLE")]
        [StringLength(3)]
        public string Personrole { get; set; }
        [Column("GENDER")]
        [StringLength(10)]
        public string Gender { get; set; }
        [Column("DOB", TypeName = "DATE")]
        public DateTime Dob { get; set; }
        [Required]
        [Column("SPPERSONMASTERGUID")]
        [StringLength(36)]
        public string Sppersonmasterguid { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("CONTACTNO")]
        [StringLength(255)]
        public string Contactno { get; set; }
    }
}
