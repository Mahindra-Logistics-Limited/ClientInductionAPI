using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("ADDRVERICONFIG")]
    public partial class Addrvericonfig
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("SMSDAY")]
        public int? Smsday { get; set; }
        [Column("CYCLE2DAY")]
        public int? Cycle2day { get; set; }
        [Column("LOCKDAY")]
        public int? Lockday { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
    }
}
