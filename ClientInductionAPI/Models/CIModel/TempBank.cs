using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TEMP_BANK")]
    public partial class TempBank
    {
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("BANKACCOUNTNO")]
        [StringLength(250)]
        public string Bankaccountno { get; set; }
        [Column("BANKBENEFICIARYNAME")]
        [StringLength(250)]
        public string Bankbeneficiaryname { get; set; }
        [Column("BANKIFSCCODE")]
        [StringLength(250)]
        public string Bankifsccode { get; set; }
        [Column("STATUS")]
        [StringLength(20)]
        public string Status { get; set; }
        [Column("AMOUNT", TypeName = "NUMBER")]
        public decimal? Amount { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("AUTHOR_LAST_PUBLISHED", TypeName = "DATE")]
        public DateTime? AuthorLastPublished { get; set; }
    }
}
