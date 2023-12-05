using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("CLIENTMAP")]
    public partial class Clientmap
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("CLIENTID")]
        [StringLength(20)]
        public string Clientid { get; set; }
        [Column("CLIENTNAME")]
        [StringLength(100)]
        public string Clientname { get; set; }
        [Column("BRANCHGUID")]
        [StringLength(36)]
        public string Branchguid { get; set; }
        [Column("ISACTIVE", TypeName = "NUMBER")]
        public decimal? Isactive { get; set; }
    }
}
