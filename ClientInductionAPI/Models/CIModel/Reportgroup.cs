using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("REPORTGROUP")]
    [Index(nameof(Guid), Name = "REPORTGROUP_GUID_OVN", IsUnique = true)]
    public partial class Reportgroup
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("REPORTGROUPNAME")]
        [StringLength(100)]
        public string Reportgroupname { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(100)]
        public string Description { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("USERUPDATED")]
        [StringLength(36)]
        public string Userupdated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
    }
}
