using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class ManthanDriverDetachedV
    {
        [Required]
        [Column("CARDRIVERGUID")]
        [StringLength(36)]
        public string Cardriverguid { get; set; }
        [Column("CABREGISTRATIONNO")]
        [StringLength(255)]
        public string Cabregistrationno { get; set; }
        [Required]
        [Column("DRIVERID")]
        [StringLength(1000)]
        public string Driverid { get; set; }
    }
}
