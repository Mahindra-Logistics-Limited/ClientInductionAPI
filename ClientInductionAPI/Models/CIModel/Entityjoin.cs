using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("ENTITYJOINS")]
    public partial class Entityjoin
    {
        [Column("ENTITYJOINID", TypeName = "NUMBER")]
        public decimal? Entityjoinid { get; set; }
        [Column("LEFTENTITYID")]
        [StringLength(36)]
        public string Leftentityid { get; set; }
        [Column("RIGHTENTITYID")]
        [StringLength(36)]
        public string Rightentityid { get; set; }
        [Column("JOINTEXT")]
        [StringLength(1000)]
        public string Jointext { get; set; }
        [Column("LEFTCOLUMNID", TypeName = "NUMBER")]
        public decimal? Leftcolumnid { get; set; }
        [Column("OPERATOR")]
        [StringLength(100)]
        public string Operator { get; set; }
        [Column("RIGHTCOLUMN1ID", TypeName = "NUMBER")]
        public decimal? Rightcolumn1id { get; set; }
        [Column("RIGHTCOLUMN2ID", TypeName = "NUMBER")]
        public decimal? Rightcolumn2id { get; set; }
    }
}
