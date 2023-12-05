using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("DIS_SMSEVENTDATA")]
    public partial class DisSmseventdatum
    {
        [Column("EVENT_ID", TypeName = "NUMBER")]
        public decimal? EventId { get; set; }
        [Column("EVENT_CODE")]
        [StringLength(100)]
        public string EventCode { get; set; }
        [Column("PARAM_STRING")]
        public string ParamString { get; set; }
        [Column("PROCESSED_STATUS")]
        [StringLength(10)]
        public string ProcessedStatus { get; set; }
        [Column("CREATION_DATE", TypeName = "DATE")]
        public DateTime? CreationDate { get; set; }
        [Column("PROCESSED_DATE", TypeName = "DATE")]
        public DateTime? ProcessedDate { get; set; }
        [Column("PROCESSED_RESULT")]
        [StringLength(1000)]
        public string ProcessedResult { get; set; }
        [Column("SMSTYPE")]
        [StringLength(36)]
        public string Smstype { get; set; }
    }
}
