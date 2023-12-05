using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("LOCKREASONMASTER")]
    public partial class Lockreasonmaster
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("LOCKSTATUS")]
        [StringLength(6)]
        public string Lockstatus { get; set; }
        [Column("REASON")]
        [StringLength(1000)]
        public string Reason { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("DISABLED")]
        public bool? Disabled { get; set; }
    }
}
