using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class TripPhoneV
    {
        [Column("CONTACTNO")]
        [StringLength(255)]
        public string Contactno { get; set; }
        [Required]
        [Column("PERSONID")]
        [StringLength(1000)]
        public string Personid { get; set; }
        [Required]
        [Column("PERSONGUID")]
        [StringLength(36)]
        public string Personguid { get; set; }
        [Required]
        [Column("PERSONCONTACTGUID")]
        [StringLength(36)]
        public string Personcontactguid { get; set; }
        [Column("PERSONSTATUS")]
        [StringLength(25)]
        public string Personstatus { get; set; }
    }
}
