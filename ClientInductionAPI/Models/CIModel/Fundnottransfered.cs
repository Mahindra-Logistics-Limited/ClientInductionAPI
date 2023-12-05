using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("FUNDNOTTRANSFERED")]
    [Index(nameof(Guid), Name = "FUNDNOTTRANSFERED_PK", IsUnique = true)]
    public partial class Fundnottransfered
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("SITE")]
        [StringLength(255)]
        public string Site { get; set; }
        [Column("SMSTEXT")]
        [StringLength(1500)]
        public string Smstext { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
    }
}
