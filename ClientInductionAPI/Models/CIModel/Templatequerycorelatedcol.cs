using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TEMPLATEQUERYCORELATEDCOLS")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "TEMPLATEQUERYCORELAT_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_TEMPLATEQUERYCORELA_PK", IsUnique = true)]
    public partial class Templatequerycorelatedcol
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("TEMPLATEMAINQUERYID", TypeName = "NUMBER")]
        public decimal? Templatemainqueryid { get; set; }
        [Column("TEMPLATESUBQUERYID", TypeName = "NUMBER")]
        public decimal? Templatesubqueryid { get; set; }
        [Column("MAINQUERYTEMPLATEENTITYID", TypeName = "NUMBER")]
        public decimal? Mainquerytemplateentityid { get; set; }
        [Column("MAINQUERYENTITYCOLUMNID", TypeName = "NUMBER")]
        public decimal? Mainqueryentitycolumnid { get; set; }
        [Column("SUBQUERYTEMPLATEENTITYID", TypeName = "NUMBER")]
        public decimal? Subquerytemplateentityid { get; set; }
        [Column("SUBQUERYENTITYCOLUMNID", TypeName = "NUMBER")]
        public decimal? Subqueryentitycolumnid { get; set; }
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
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
    }
}
