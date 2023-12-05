using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SEARCHTEMPLATEWHERECLAUSE")]
    [Index(nameof(Guid), Name = "SEARCHTEMPLATEWHERE_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_SEARCHTEMPLATEWHERECL_PK", IsUnique = true)]
    public partial class Searchtemplatewhereclause
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("SEARCHTEMPLATEQUERIESGUID")]
        [StringLength(36)]
        public string Searchtemplatequeriesguid { get; set; }
        [Column("CLAUSETYPE")]
        [StringLength(100)]
        public string Clausetype { get; set; }
        [Column("LEFTTEMPLATEENTITYID")]
        [StringLength(36)]
        public string Lefttemplateentityid { get; set; }
        [Column("LEFTENTITYCOLUMNID")]
        [StringLength(36)]
        public string Leftentitycolumnid { get; set; }
        [Column("OPERATOR")]
        [StringLength(10)]
        public string Operator { get; set; }
        [Column("RIGHTSIDETYPE")]
        [StringLength(200)]
        public string Rightsidetype { get; set; }
        [Column("RIGHTTEMPLATEENTITYID")]
        [StringLength(36)]
        public string Righttemplateentityid { get; set; }
        [Column("RIGHTENTITYCOLUMNID", TypeName = "NUMBER")]
        public decimal? Rightentitycolumnid { get; set; }
        [Column("RIGHTCONSTANTTEXT")]
        [StringLength(100)]
        public string Rightconstanttext { get; set; }
        [Column("RIGHTCONSTANTNO", TypeName = "NUMBER")]
        public decimal? Rightconstantno { get; set; }
        [Column("RIGHTCONSTANTDATE", TypeName = "DATE")]
        public DateTime? Rightconstantdate { get; set; }
        [Column("LEFTPREBRACKETS")]
        [StringLength(10)]
        public string Leftprebrackets { get; set; }
        [Column("RIGHTPOSTBRACKETS")]
        [StringLength(10)]
        public string Rightpostbrackets { get; set; }
        [Column("CONDITIONANDOR")]
        [StringLength(10)]
        public string Conditionandor { get; set; }
        [Column("CONDITIONANDORPOSTBRACKETS")]
        [StringLength(10)]
        public string Conditionandorpostbrackets { get; set; }
        [Column("EXISTQUERYLINKID")]
        [StringLength(36)]
        public string Existquerylinkid { get; set; }
        [Column("RIGHTSYSDATEFLAG")]
        [StringLength(1)]
        public string Rightsysdateflag { get; set; }
        [Column("FILTERORDER", TypeName = "NUMBER")]
        public decimal? Filterorder { get; set; }
        [Column("LEFTPOSTCOLUMNTEXT")]
        [StringLength(100)]
        public string Leftpostcolumntext { get; set; }
        [Column("RIGHTPRECOLUMNTEXT")]
        [StringLength(100)]
        public string Rightprecolumntext { get; set; }
        [Column("LEFTPRECOLUMNTEXT")]
        [StringLength(100)]
        public string Leftprecolumntext { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
    }
}
