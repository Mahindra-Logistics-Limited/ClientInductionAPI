using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("ROLEREPORTGROUP")]
    public partial class Rolereportgroup
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("ROLEGUID")]
        [StringLength(36)]
        public string Roleguid { get; set; }
        [Column("REPORTGROUPGUID")]
        [StringLength(36)]
        public string Reportgroupguid { get; set; }
    }
}
