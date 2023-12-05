using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("XMERU_GVUPLOAD_TBL")]
    [Index(nameof(Carguid), Name = "GV_CAR_IND")]
    [Index(nameof(Executionguid), nameof(SrNo), Name = "GV_EXECUT_SR_NO_IND", IsUnique = true)]
    [Index(nameof(Siteguid), Name = "GV_SITE_IND")]
    public partial class XmeruGvuploadTbl
    {
        [Column("EXECUTIONGUID")]
        [StringLength(36)]
        public string Executionguid { get; set; }
        [Column("SR_NO", TypeName = "NUMBER")]
        public decimal? SrNo { get; set; }
        [Column("SPID")]
        [StringLength(36)]
        public string Spid { get; set; }
        [Column("SITENAME")]
        [StringLength(36)]
        public string Sitename { get; set; }
        [Column("NEWGVNAME")]
        [StringLength(100)]
        public string Newgvname { get; set; }
        [Column("CAPITALRECOVERYPERIOD", TypeName = "NUMBER")]
        public decimal? Capitalrecoveryperiod { get; set; }
        [Column("STATUS")]
        [StringLength(36)]
        public string Status { get; set; }
        [Column("SPGUID")]
        [StringLength(36)]
        public string Spguid { get; set; }
        [Column("CARGUID")]
        [StringLength(36)]
        public string Carguid { get; set; }
        [Column("CAR_SECGUID")]
        [StringLength(36)]
        public string CarSecguid { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("NEWGVGUID")]
        [StringLength(36)]
        public string Newgvguid { get; set; }
        [Column("OLDGVGUID")]
        [StringLength(36)]
        public string Oldgvguid { get; set; }
        [Column("USERGUID")]
        [StringLength(36)]
        public string Userguid { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("USER_SEC_GUID")]
        [StringLength(36)]
        public string UserSecGuid { get; set; }
        [Column("ROLEGUID")]
        [StringLength(36)]
        public string Roleguid { get; set; }
        [Column("ERRORMSG")]
        public string Errormsg { get; set; }
        [Column("NEWGVSECURITY")]
        [StringLength(36)]
        public string Newgvsecurity { get; set; }
    }
}
