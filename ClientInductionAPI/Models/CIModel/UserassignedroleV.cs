using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class UserassignedroleV
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("NAME")]
        [StringLength(200)]
        public string Name { get; set; }
        [Required]
        [Column("USERMASTERGUID")]
        [StringLength(36)]
        public string Usermasterguid { get; set; }
        [Required]
        [Column("USERROLEGUID")]
        [StringLength(36)]
        public string Userroleguid { get; set; }
        [Required]
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("DISABLED")]
        public bool? Disabled { get; set; }
    }
}
