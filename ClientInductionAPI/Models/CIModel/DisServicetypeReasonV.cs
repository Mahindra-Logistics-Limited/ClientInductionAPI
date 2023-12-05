using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisServicetypeReasonV
    {
        [Column("SERVICETYPENO", TypeName = "NUMBER")]
        public decimal Servicetypeno { get; set; }
        [Column("SERVICETYPENAME")]
        [StringLength(100)]
        public string Servicetypename { get; set; }
        [Column("REQUESTREASONNO", TypeName = "NUMBER")]
        public decimal Requestreasonno { get; set; }
        [Column("REASON")]
        [StringLength(100)]
        public string Reason { get; set; }
        [Column("REASONDETAILS")]
        [StringLength(1000)]
        public string Reasondetails { get; set; }
    }
}
