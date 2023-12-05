using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("CREDITBALANCELIMIT")]
    public partial class Creditbalancelimit
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("CAR_NO")]
        [StringLength(255)]
        public string CarNo { get; set; }
        [Column("AMOUNT", TypeName = "NUMBER(10,2)")]
        public decimal? Amount { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
    }
}
