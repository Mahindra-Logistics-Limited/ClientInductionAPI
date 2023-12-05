using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SCHPROGRAMS")]
    public partial class Schprogram
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("NAME")]
        [StringLength(1000)]
        public string Name { get; set; }
        [Column("PROCEDURENAME")]
        [StringLength(1000)]
        public string Procedurename { get; set; }
        [Column("DISABLED", TypeName = "NUMBER")]
        public decimal? Disabled { get; set; }
        [Column("PRIORITY", TypeName = "NUMBER")]
        public decimal? Priority { get; set; }
        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("PROGRAMTYPE")]
        [StringLength(20)]
        public string Programtype { get; set; }
        [Column("EMAIL_CC")]
        public string EmailCc { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("DATEUPDATE")]
        [StringLength(36)]
        public string Dateupdate { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(1000)]
        public string Description { get; set; }
    }
}
