using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SEARCHTEMPLATEQUERIES")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "SEARCHTEMPLATEQUERIES_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_SEARCHTEMPLATEQUERIES_PK", IsUnique = true)]
    public partial class Searchtemplatequery
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("SEARCHTEMPLATEMASTERGUID")]
        [StringLength(36)]
        public string Searchtemplatemasterguid { get; set; }
        [Column("QUERYGROUPCLAUSE")]
        [StringLength(1000)]
        public string Querygroupclause { get; set; }
        [Column("QUERYHAVECLAUSE")]
        [StringLength(1000)]
        public string Queryhaveclause { get; set; }
        [Column("QUERYVIEWNAME")]
        [StringLength(50)]
        public string Queryviewname { get; set; }
        [Column("QUERYVIEWTEXT")]
        [StringLength(1000)]
        public string Queryviewtext { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Effectiveenddate { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
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
        [Column("QUERYNAME")]
        [StringLength(100)]
        public string Queryname { get; set; }
        [Column("QUERYDESCRIPTION")]
        [StringLength(1000)]
        public string Querydescription { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("QUERYTYPE")]
        [StringLength(100)]
        public string Querytype { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
    }
}
