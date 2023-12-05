using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class ManthanCarOffRoad
    {
        [Column("CABREGISTRATIONNO")]
        [StringLength(255)]
        public string Cabregistrationno { get; set; }
    }
}
