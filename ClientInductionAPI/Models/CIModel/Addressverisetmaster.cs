using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("ADDRESSVERISETMASTER")]
    public partial class Addressverisetmaster
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("SETID")]
        public int? Setid { get; set; }
        [Column("STARTDATE", TypeName = "DATE")]
        public DateTime? Startdate { get; set; }
        [Column("LIVEFLAG")]
        [StringLength(5)]
        public string Liveflag { get; set; }
        [Column("LEGALENTITY")]
        [StringLength(25)]
        public string Legalentity { get; set; }
        [Column("BRANCH")]
        [StringLength(100)]
        public string Branch { get; set; }
        [Column("MODEL")]
        [StringLength(25)]
        public string Model { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
    }
}
