using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SMS_MISS_DOC_REPORT_TEMP")]
    public partial class SmsMissDocReportTemp
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("PERSONID")]
        [StringLength(100)]
        public string Personid { get; set; }
        [Column("CAR_NO")]
        [StringLength(100)]
        public string CarNo { get; set; }
        [Column("ENTITY_TYPE")]
        [StringLength(30)]
        public string EntityType { get; set; }
        [Column("DOCUMENT_NAME")]
        [StringLength(100)]
        public string DocumentName { get; set; }
        [Column("EXPIREDDATE", TypeName = "DATE")]
        public DateTime? Expireddate { get; set; }
        [Column("SMS_STRING")]
        public string SmsString { get; set; }
        [Column("ENTITY_DOC_TYPE")]
        [StringLength(20)]
        public string EntityDocType { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("ENTITY_ID")]
        [StringLength(30)]
        public string EntityId { get; set; }
    }
}
