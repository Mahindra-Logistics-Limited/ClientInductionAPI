using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TRIPDATA1_ARCHIVE_NEW")]
    public partial class Tripdata1ArchiveNew
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("TRIPID")]
        [StringLength(36)]
        public string Tripid { get; set; }
        [Column("ENDTRIPDATE", TypeName = "DATE")]
        public DateTime? Endtripdate { get; set; }
        [Column("SERVICEPROVIDERGUID")]
        [StringLength(36)]
        public string Serviceproviderguid { get; set; }
        [Column("CARREGISTRATIONNO")]
        [StringLength(36)]
        public string Carregistrationno { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("DRIVERMASTERGUID")]
        [StringLength(36)]
        public string Drivermasterguid { get; set; }
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
        [Column("OBJECTVERSIONNO", TypeName = "NUMBER")]
        public decimal? Objectversionno { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("SP_ID", TypeName = "NUMBER")]
        public decimal? SpId { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("TRIPRECEIVEDDATE", TypeName = "DATE")]
        public DateTime? Tripreceiveddate { get; set; }
        [Column("CROSSSELLINGFARE", TypeName = "NUMBER")]
        public decimal? Crosssellingfare { get; set; }
        [Column("SP_PCT", TypeName = "NUMBER(10,2)")]
        public decimal? SpPct { get; set; }
        [Column("CALCULATED_PCT_FLAG")]
        [StringLength(5)]
        public string CalculatedPctFlag { get; set; }
        [Column("GVNAME")]
        [StringLength(300)]
        public string Gvname { get; set; }
    }
}
