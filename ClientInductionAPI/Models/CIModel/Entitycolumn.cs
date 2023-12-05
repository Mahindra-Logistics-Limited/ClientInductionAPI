using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("ENTITYCOLUMNS")]
    public partial class Entitycolumn
    {
        [Column("ENTITYCOLUMNID", TypeName = "NUMBER(34)")]
        public decimal? Entitycolumnid { get; set; }
        [Column("COLUMNNAME")]
        [StringLength(100)]
        public string Columnname { get; set; }
        [Column("DATATYPE")]
        [StringLength(30)]
        public string Datatype { get; set; }
        [Column("ENTITYGUID")]
        [StringLength(36)]
        public string Entityguid { get; set; }
    }
}
