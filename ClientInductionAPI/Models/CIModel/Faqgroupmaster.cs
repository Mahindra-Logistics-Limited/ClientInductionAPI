using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("FAQGROUPMASTER")]
    public partial class Faqgroupmaster
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("NAME")]
        [StringLength(1000)]
        public string Name { get; set; }
        [Column("HEADING")]
        [StringLength(1000)]
        public string Heading { get; set; }
        [Column("ISACTIVE", TypeName = "NUMBER(38)")]
        public decimal? Isactive { get; set; }
        [Column("QUICKACCESSCODE")]
        [StringLength(100)]
        public string Quickaccesscode { get; set; }
    }
}
