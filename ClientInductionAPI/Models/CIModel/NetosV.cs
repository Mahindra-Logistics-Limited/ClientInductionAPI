using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class NetosV
    {
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("LOCKBAL", TypeName = "NUMBER")]
        public decimal? Lockbal { get; set; }
        [Column("LOCKLIMIT", TypeName = "NUMBER")]
        public decimal? Locklimit { get; set; }
        [Column("NET_OS", TypeName = "NUMBER")]
        public decimal? NetOs { get; set; }
        [Column("NET_OS_DUE", TypeName = "NUMBER")]
        public decimal? NetOsDue { get; set; }
    }
}
