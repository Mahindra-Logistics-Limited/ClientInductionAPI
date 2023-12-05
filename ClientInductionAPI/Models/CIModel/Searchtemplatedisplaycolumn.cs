using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SEARCHTEMPLATEDISPLAYCOLUMNS")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "SEARCHTEMPLATEDISPLAY_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_SEARCHTEMPLATEDISPLA_PK", IsUnique = true)]
    public partial class Searchtemplatedisplaycolumn
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("TEMPLATEQUERYCORELATEDCOLSGUID", TypeName = "NUMBER")]
        public decimal? Templatequerycorelatedcolsguid { get; set; }
        [Column("SEARCHTEMPLATEENTITIESGUID")]
        [StringLength(36)]
        public string Searchtemplateentitiesguid { get; set; }
        [Column("ENTITYCOLUMNID", TypeName = "NUMBER")]
        public decimal? Entitycolumnid { get; set; }
        [Column("COLUMNDISPLAYNAME")]
        [StringLength(50)]
        public string Columndisplayname { get; set; }
        [Column("AGGREGATEFUNCTION")]
        [StringLength(100)]
        public string Aggregatefunction { get; set; }
        [Column("AGGREGATEFILTEROPERATOR")]
        [StringLength(10)]
        public string Aggregatefilteroperator { get; set; }
        [Column("AGGREGATEFILTERVALUETYPE")]
        [StringLength(100)]
        public string Aggregatefiltervaluetype { get; set; }
        [Column("AGGREGATEFILTERVALUETEXT")]
        [StringLength(100)]
        public string Aggregatefiltervaluetext { get; set; }
        [Column("AGGREGATEFILTERVALUENO", TypeName = "NUMBER")]
        public decimal? Aggregatefiltervalueno { get; set; }
        [Column("AGGREGATEFILTERVALUEDATE", TypeName = "DATE")]
        public DateTime? Aggregatefiltervaluedate { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime Effectiveenddate { get; set; }
        [Required]
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("USERUPDATED")]
        [StringLength(36)]
        public string Userupdated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("USERDELETED")]
        [StringLength(36)]
        public string Userdeleted { get; set; }
        [Column("DATEDELETED", TypeName = "DATE")]
        public DateTime? Datedeleted { get; set; }
        [Column("USERARCHIVED")]
        [StringLength(36)]
        public string Userarchived { get; set; }
        [Column("DATEARCHIVED", TypeName = "DATE")]
        public DateTime? Datearchived { get; set; }
        [Column("ORACLEENTITYNAME")]
        [StringLength(100)]
        public string Oracleentityname { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(1000)]
        public string Oracleentityid { get; set; }
        [Column("OBJECTVERSIONNO")]
        public byte? Objectversionno { get; set; }
        [Column("SEARCHTEMPLATEQUERIESGUID")]
        [StringLength(36)]
        public string Searchtemplatequeriesguid { get; set; }
        [Column("SITEGUIDFLAG")]
        [StringLength(1)]
        public string Siteguidflag { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
    }
}
