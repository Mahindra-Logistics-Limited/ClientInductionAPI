using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SCHPARAMETER")]
    public partial class Schparameter
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("SCHPROGRAMGUID")]
        [StringLength(36)]
        public string Schprogramguid { get; set; }
        [Column("PARAMETERNAME")]
        [StringLength(100)]
        public string Parametername { get; set; }
        [Column("DATATYPE")]
        [StringLength(100)]
        public string Datatype { get; set; }
        [Column("OPTIONAL", TypeName = "NUMBER")]
        public decimal? Optional { get; set; }
        [Column("VALUESETTYPE")]
        [StringLength(1000)]
        public string Valuesettype { get; set; }
        [Column("SEQUENCE", TypeName = "NUMBER")]
        public decimal? Sequence { get; set; }
        [Column("DIRECTION")]
        [StringLength(10)]
        public string Direction { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
    }
}
