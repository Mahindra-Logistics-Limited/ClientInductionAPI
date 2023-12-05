using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("PHOTOGRAPHINSERT_STG")]
    public partial class PhotographinsertStg
    {
        [Column("PERSONID")]
        [StringLength(20)]
        public string Personid { get; set; }
        [Column("STATUS")]
        [StringLength(20)]
        public string Status { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
    }
}
