using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class RoleActionV
    {
        [Required]
        [Column("ROLEGUID")]
        [StringLength(36)]
        public string Roleguid { get; set; }
        [Required]
        [Column("ROLENAME")]
        [StringLength(100)]
        public string Rolename { get; set; }
        [Column("PAGENAME")]
        [StringLength(100)]
        public string Pagename { get; set; }
        [Column("PAGEACTIONS")]
        public string Pageactions { get; set; }
    }
}
