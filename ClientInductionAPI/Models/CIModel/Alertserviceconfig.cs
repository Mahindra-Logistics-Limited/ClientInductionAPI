using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("ALERTSERVICECONFIG")]
    public partial class Alertserviceconfig
    {
        [Key]
        [Column("GUID")]
        [StringLength(32)]
        public string Guid { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(300)]
        public string Name { get; set; }
        [Required]
        [Column("QUERY")]
        [StringLength(3000)]
        public string Query { get; set; }
        [Required]
        [Column("MOBILENUMBERS")]
        [StringLength(300)]
        public string Mobilenumbers { get; set; }
        [Column("DURATION", TypeName = "NUMBER")]
        public decimal Duration { get; set; }
        [Column("LASTEXECUTIONTIME", TypeName = "DATE")]
        public DateTime? Lastexecutiontime { get; set; }
        [Column("CREATEDDATE", TypeName = "DATE")]
        public DateTime? Createddate { get; set; }
        [Column("UPDATEDDATE", TypeName = "DATE")]
        public DateTime? Updateddate { get; set; }
        [Column("DISABLED")]
        public bool? Disabled { get; set; }
    }
}
