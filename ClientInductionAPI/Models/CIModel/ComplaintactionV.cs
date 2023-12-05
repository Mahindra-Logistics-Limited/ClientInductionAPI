using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class ComplaintactionV
    {
        [Required]
        [Column("ACTION_GUID")]
        [StringLength(36)]
        public string ActionGuid { get; set; }
        [Required]
        [Column("ACTION_NAME")]
        [StringLength(255)]
        public string ActionName { get; set; }
        [Column("DISABLED")]
        public bool? Disabled { get; set; }
        [Column("BRANCH_GUID")]
        [StringLength(36)]
        public string BranchGuid { get; set; }
        [Column("BRANCHNAME")]
        [StringLength(200)]
        public string Branchname { get; set; }
    }
}
