using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisAllActiveSpV
    {
        [Required]
        [Column("PERSONID")]
        [StringLength(1000)]
        public string Personid { get; set; }
        [Column("NAME")]
        [StringLength(520)]
        public string Name { get; set; }
        [Column("GENDER")]
        [StringLength(10)]
        public string Gender { get; set; }
        [Column("DOB", TypeName = "DATE")]
        public DateTime Dob { get; set; }
        [Column("PERSONROLE")]
        [StringLength(3)]
        public string Personrole { get; set; }
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("CONTACTNO")]
        [StringLength(255)]
        public string Contactno { get; set; }
    }
}
