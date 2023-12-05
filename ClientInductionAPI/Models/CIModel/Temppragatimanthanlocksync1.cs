using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TEMPPRAGATIMANTHANLOCKSYNC1")]
    public partial class Temppragatimanthanlocksync1
    {
        [Column("CAB_NO")]
        [StringLength(10)]
        public string CabNo { get; set; }
        [Column("LOCKACTION")]
        [StringLength(20)]
        public string Lockaction { get; set; }
        [Column("STATUS", TypeName = "NUMBER(38)")]
        public decimal? Status { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
    }
}
