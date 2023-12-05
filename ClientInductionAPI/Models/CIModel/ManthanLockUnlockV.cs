using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class ManthanLockUnlockV
    {
        [Column("CABREGISTRATIONNO")]
        [StringLength(255)]
        public string Cabregistrationno { get; set; }
        [Column("LOCKUNLOCKID", TypeName = "NUMBER")]
        public decimal? Lockunlockid { get; set; }
        [Column("LOCKUNLOCKBIT", TypeName = "NUMBER")]
        public decimal? Lockunlockbit { get; set; }
        [Column("DONEBY")]
        [StringLength(8)]
        public string Doneby { get; set; }
        [Column("REASON")]
        [StringLength(25)]
        public string Reason { get; set; }
    }
}
