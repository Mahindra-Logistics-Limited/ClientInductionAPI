using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisComplaintV
    {
        [Required]
        [Column("COMPLAINTID")]
        [StringLength(11)]
        public string Complaintid { get; set; }
        [Column("COMPLAINTDATE", TypeName = "DATE")]
        public DateTime Complaintdate { get; set; }
        [Required]
        [Column("COMPLAINTINCOMMINGCATEGORY")]
        [StringLength(255)]
        public string Complaintincommingcategory { get; set; }
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("DRIVERID")]
        [StringLength(1000)]
        public string Driverid { get; set; }
        [Required]
        [Column("CATEGORYLEVEL")]
        [StringLength(25)]
        public string Categorylevel { get; set; }
        [Column("CARREGNNO")]
        [StringLength(255)]
        public string Carregnno { get; set; }
        [Column("ACTION", TypeName = "NUMBER")]
        public decimal? Action { get; set; }
    }
}
