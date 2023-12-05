using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("XMERU_EMI_BAL_UPDATE_TRACKING")]
    [Index(nameof(Siteguid), nameof(TxnTypeId), nameof(EffectiveDate), nameof(EmiStartDate), Name = "XMERU_EMI_BAL_UPDT_SITE_TYP_DT")]
    public partial class XmeruEmiBalUpdateTracking
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("TXN_TYPE_ID", TypeName = "NUMBER")]
        public decimal? TxnTypeId { get; set; }
        [Column("EFFECTIVE_DATE", TypeName = "DATE")]
        public DateTime? EffectiveDate { get; set; }
        [Column("CREATED_DATE", TypeName = "DATE")]
        public DateTime? CreatedDate { get; set; }
        [Column("CREATED_BY", TypeName = "NUMBER")]
        public decimal? CreatedBy { get; set; }
        [Column("UPDATED_DATE", TypeName = "DATE")]
        public DateTime? UpdatedDate { get; set; }
        [Column("UPDATED_BY", TypeName = "NUMBER")]
        public decimal? UpdatedBy { get; set; }
        [Column("EMI_START_DATE", TypeName = "DATE")]
        public DateTime? EmiStartDate { get; set; }
    }
}
