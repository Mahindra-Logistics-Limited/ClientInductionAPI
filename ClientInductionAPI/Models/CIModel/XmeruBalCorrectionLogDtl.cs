using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("XMERU_BAL_CORRECTION_LOG_DTL")]
    public partial class XmeruBalCorrectionLogDtl
    {
        [Key]
        [Column("LOG_CORR_DTL_ID", TypeName = "NUMBER")]
        public decimal LogCorrDtlId { get; set; }
        [Column("SP_PERSON_ID")]
        [StringLength(20)]
        public string SpPersonId { get; set; }
        [Column("SITE_NAME")]
        [StringLength(20)]
        public string SiteName { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("ACTION_ON")]
        [StringLength(10)]
        public string ActionOn { get; set; }
        [Column("DT", TypeName = "DATE")]
        public DateTime? Dt { get; set; }
        [Column("DEP_DUE_CHANGED", TypeName = "NUMBER(10,2)")]
        public decimal? DepDueChanged { get; set; }
        [Column("DM_DUE_CHANGED", TypeName = "NUMBER(10,2)")]
        public decimal? DmDueChanged { get; set; }
    }
}
