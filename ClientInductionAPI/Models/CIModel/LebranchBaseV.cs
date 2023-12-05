using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class LebranchBaseV
    {
        [Required]
        [Column("LEBRANCH_GUID")]
        [StringLength(36)]
        public string LebranchGuid { get; set; }
        [Required]
        [Column("LE_GUID")]
        [StringLength(36)]
        public string LeGuid { get; set; }
        [Required]
        [Column("LE_NAME")]
        [StringLength(200)]
        public string LeName { get; set; }
        [Column("LE_CODE")]
        [StringLength(200)]
        public string LeCode { get; set; }
        [Required]
        [Column("BRANCH_GUID")]
        [StringLength(36)]
        public string BranchGuid { get; set; }
        [Required]
        [Column("BRANCH_NAME")]
        [StringLength(200)]
        public string BranchName { get; set; }
        [Column("BRANCH_CODE")]
        [StringLength(100)]
        public string BranchCode { get; set; }
        [Column("ORG_ID")]
        public byte? OrgId { get; set; }
        [Column("GL_SEGMENT1")]
        [StringLength(1000)]
        public string GlSegment1 { get; set; }
        [Column("LEB_OBJ_VER_NO")]
        public int? LebObjVerNo { get; set; }
    }
}
