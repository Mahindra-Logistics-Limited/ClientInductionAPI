using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class FaqV
    {
        [Column("FAQMASTERGUID")]
        [StringLength(36)]
        public string Faqmasterguid { get; set; }
        [Column("ANSWERE")]
        [StringLength(1000)]
        public string Answere { get; set; }
        [Column("FAQGROUPMASTERGUID")]
        [StringLength(36)]
        public string Faqgroupmasterguid { get; set; }
        [Column("ISACTIVE", TypeName = "NUMBER(38)")]
        public decimal? Isactive { get; set; }
        [Column("QUESTION")]
        [StringLength(1000)]
        public string Question { get; set; }
        [Column("FAQMASTERQUICKACCESSCODE")]
        [StringLength(100)]
        public string Faqmasterquickaccesscode { get; set; }
        [Column("FAQGROUPHEADING")]
        [StringLength(1000)]
        public string Faqgroupheading { get; set; }
        [Column("FAQGROUPISACTIVE", TypeName = "NUMBER(38)")]
        public decimal? Faqgroupisactive { get; set; }
        [Column("FAQGROUPNAME")]
        [StringLength(1000)]
        public string Faqgroupname { get; set; }
        [Column("FAQGROUPQUICKACCESSCODE")]
        [StringLength(100)]
        public string Faqgroupquickaccesscode { get; set; }
    }
}
