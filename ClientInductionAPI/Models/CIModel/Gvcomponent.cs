using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("GVCOMPONENT")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "GVCOMPONENT_GUID_OVN", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_GVCOMPONENT_PKGUID", IsUnique = true)]
    public partial class Gvcomponent
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("GROUPVARIANTGUID")]
        [StringLength(36)]
        public string Groupvariantguid { get; set; }
        [Column("CYCLEMASTERGUID")]
        [StringLength(36)]
        public string Cyclemasterguid { get; set; }
        [Column("TRANSACTIONTYPEGUID")]
        [StringLength(36)]
        public string Transactiontypeguid { get; set; }
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
        [Column("VALUEAMOUNT")]
        public string Valueamount { get; set; }
        [Column("FREQUENCYMASTERGUID")]
        [StringLength(36)]
        public string Frequencymasterguid { get; set; }
        [Column("IMPACTEDBYGVCHANGE")]
        [StringLength(1)]
        public string Impactedbygvchange { get; set; }
        [Column("NAME")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("QUICKACCESSCODE")]
        [StringLength(50)]
        public string Quickaccesscode { get; set; }
        [Column("VALUETYPE")]
        [StringLength(30)]
        public string Valuetype { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("CAPITALRECOFLAG")]
        [StringLength(10)]
        public string Capitalrecoflag { get; set; }
        [Column("CAPITALRECODAYS")]
        [StringLength(10)]
        public string Capitalrecodays { get; set; }
    }
}
