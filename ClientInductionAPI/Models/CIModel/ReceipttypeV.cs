using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class ReceipttypeV
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("NAME")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("QUICKACCESSCODE")]
        [StringLength(60)]
        public string Quickaccesscode { get; set; }
        [Column("ORG_ID", TypeName = "NUMBER")]
        public decimal? OrgId { get; set; }
        [Column("LEGALENTITY")]
        [StringLength(20)]
        public string Legalentity { get; set; }
        [Column("BRANCH_CODE")]
        [StringLength(20)]
        public string BranchCode { get; set; }
    }
}
