using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("FAQMASTER")]
    public partial class Faqmaster
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("FAQGROUPMASTERGUID")]
        [StringLength(36)]
        public string Faqgroupmasterguid { get; set; }
        [Column("QUESTION")]
        [StringLength(1000)]
        public string Question { get; set; }
        [Column("ANSWERE")]
        [StringLength(1000)]
        public string Answere { get; set; }
        [Column("ISACTIVE", TypeName = "NUMBER(38)")]
        public decimal? Isactive { get; set; }
        [Column("QUICKACCESSCODE")]
        [StringLength(100)]
        public string Quickaccesscode { get; set; }
    }
}
