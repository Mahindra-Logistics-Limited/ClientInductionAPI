using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("DOC_ACTION")]
    [Index(nameof(Carguid), Name = "XMERU_DOC_ACT_CARGUID")]
    [Index(nameof(CarRegnNo), Name = "XMERU_DOC_ACT_CAR_REGN_NO")]
    [Index(nameof(Personguid), Name = "XMERU_DOC_ACT_PERSONGUID")]
    [Index(nameof(Personid), Name = "XMERU_DOC_ACT_PERSONID")]
    public partial class DocAction
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("DOCUMENTGUID")]
        [StringLength(36)]
        public string Documentguid { get; set; }
        [Column("DOCUMENTTYPE")]
        [StringLength(50)]
        public string Documenttype { get; set; }
        [Column("DOCUMENTCODE")]
        [StringLength(500)]
        public string Documentcode { get; set; }
        [Column("VALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? Validityenddate { get; set; }
        [Column("ACTION_CODE")]
        [StringLength(36)]
        public string ActionCode { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("PERSONID")]
        [StringLength(36)]
        public string Personid { get; set; }
        [Column("PERSONGUID")]
        [StringLength(36)]
        public string Personguid { get; set; }
        [Column("SPFLAG", TypeName = "NUMBER")]
        public decimal? Spflag { get; set; }
        [Column("DSEFLAG", TypeName = "NUMBER")]
        public decimal? Dseflag { get; set; }
        [Column("DRIVERFLAG", TypeName = "NUMBER")]
        public decimal? Driverflag { get; set; }
        [Column("CAR_REGN_NO")]
        [StringLength(36)]
        public string CarRegnNo { get; set; }
        [Column("CARGUID")]
        [StringLength(36)]
        public string Carguid { get; set; }
        [Column("SMSSTATUS")]
        [StringLength(10)]
        public string Smsstatus { get; set; }
    }
}
