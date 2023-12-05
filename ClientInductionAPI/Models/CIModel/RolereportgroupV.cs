using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class RolereportgroupV
    {
        [Column("ROLEREPORTGROUPGUID")]
        [StringLength(36)]
        public string Rolereportgroupguid { get; set; }
        [Column("ROLEGUID")]
        [StringLength(36)]
        public string Roleguid { get; set; }
        [Column("REPORTGROUPGUID")]
        [StringLength(36)]
        public string Reportgroupguid { get; set; }
        [Required]
        [Column("ROLENAME")]
        [StringLength(200)]
        public string Rolename { get; set; }
        [Required]
        [Column("ROLEQUICKACCESSCODE")]
        [StringLength(100)]
        public string Rolequickaccesscode { get; set; }
        [Column("REPORTGROUPNAME")]
        [StringLength(100)]
        public string Reportgroupname { get; set; }
    }
}
