using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SAPCONFIG")]
    public partial class Sapconfig
    {
        [Column("COMPANYCODE")]
        [StringLength(4)]
        public string Companycode { get; set; }
        [Column("CURRENCY")]
        [StringLength(5)]
        public string Currency { get; set; }
        [Column("SECTIONCODE")]
        [StringLength(4)]
        public string Sectioncode { get; set; }
        [Column("NARRATION")]
        [StringLength(50)]
        public string Narration { get; set; }
        [Column("BASETRANSACTIONTYPE")]
        [StringLength(12)]
        public string Basetransactiontype { get; set; }
        [Column("SHOWINSTATEMENTYESGLCODE")]
        [StringLength(10)]
        public string Showinstatementyesglcode { get; set; }
        [Column("SHOWINSTATEMENTYESGLNAME")]
        [StringLength(100)]
        public string Showinstatementyesglname { get; set; }
        [Column("SHOWINSTATEMENTNOGLCODE")]
        [StringLength(10)]
        public string Showinstatementnoglcode { get; set; }
        [Column("SHOWINSTATEMENTNOGLNAME")]
        [StringLength(100)]
        public string Showinstatementnoglname { get; set; }
    }
}
