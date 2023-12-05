using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("XMERU_BAL_CORRECTION_LOG")]
    public partial class XmeruBalCorrectionLog
    {
        [Column("LOG_ID", TypeName = "NUMBER")]
        public decimal? LogId { get; set; }
        [Column("SP_PERSON_ID")]
        [StringLength(20)]
        public string SpPersonId { get; set; }
        [Column("SITE_NAME")]
        [StringLength(20)]
        public string SiteName { get; set; }
        [Column("SP_GUID")]
        [StringLength(36)]
        public string SpGuid { get; set; }
        [Column("SPSITE_GUID")]
        [StringLength(36)]
        public string SpsiteGuid { get; set; }
        [Column("CREATED_DATE", TypeName = "DATE")]
        public DateTime? CreatedDate { get; set; }
        [Column("CREATED_BY")]
        [StringLength(36)]
        public string CreatedBy { get; set; }
        [Column("UPDATED_DATE", TypeName = "DATE")]
        public DateTime? UpdatedDate { get; set; }
        [Column("UPDATED_BY")]
        [StringLength(36)]
        public string UpdatedBy { get; set; }
        [Column("RECORD_STATUS")]
        [StringLength(20)]
        public string RecordStatus { get; set; }
        [Column("PROCESSING_TYPE")]
        [StringLength(20)]
        public string ProcessingType { get; set; }
    }
}
