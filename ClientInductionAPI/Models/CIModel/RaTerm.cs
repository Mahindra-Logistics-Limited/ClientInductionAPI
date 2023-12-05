using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("RA_TERMS")]
    public partial class RaTerm
    {
        [Column("TERM_ID", TypeName = "NUMBER")]
        public decimal? TermId { get; set; }
        [Column("NAME")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(150)]
        public string Description { get; set; }
        [Column("PRINTING_LEAD_DAYS", TypeName = "NUMBER")]
        public decimal? PrintingLeadDays { get; set; }
        [Column("LAST_UPDATE_DATE", TypeName = "DATE")]
        public DateTime? LastUpdateDate { get; set; }
        [Column("CREATION_DATE", TypeName = "DATE")]
        public DateTime? CreationDate { get; set; }
    }
}
