using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class UserrolesecurityV
    {
        [Required]
        [Column("USERMASTERGUID")]
        [StringLength(36)]
        public string Usermasterguid { get; set; }
        [Required]
        [Column("LOGINNAME")]
        [StringLength(2000)]
        public string Loginname { get; set; }
        [Required]
        [Column("ROLEMASTERGUID")]
        [StringLength(36)]
        public string Rolemasterguid { get; set; }
        [Required]
        [Column("ROLENAME")]
        [StringLength(100)]
        public string Rolename { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("SECURITYCODE")]
        [StringLength(200)]
        public string Securitycode { get; set; }
    }
}
