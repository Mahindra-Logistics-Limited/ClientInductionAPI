using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("EMI_MASTER")]
    [Index(nameof(Siteguid), nameof(EmiStartsate), nameof(TxnType), Name = "XMERU_EMIMAST_SITE_TYP_DT")]
    public partial class EmiMaster
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("EMI_AMT", TypeName = "NUMBER(10,2)")]
        public decimal? EmiAmt { get; set; }
        [Column("EMI_STARTSATE", TypeName = "DATE")]
        public DateTime? EmiStartsate { get; set; }
        [Column("EMI_ENDDATE", TypeName = "DATE")]
        public DateTime? EmiEnddate { get; set; }
        [Column("UPDATED_DATE", TypeName = "DATE")]
        public DateTime? UpdatedDate { get; set; }
        [Column("DISABLED", TypeName = "NUMBER")]
        public decimal? Disabled { get; set; }
        [Column("TXN_TYPE")]
        [StringLength(50)]
        public string TxnType { get; set; }
        [Column("TXN_CLASS")]
        [StringLength(20)]
        public string TxnClass { get; set; }
    }
}
