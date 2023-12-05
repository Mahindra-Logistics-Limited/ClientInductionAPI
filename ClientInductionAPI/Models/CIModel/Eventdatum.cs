using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("EVENTDATA")]
    public partial class Eventdatum
    {
        [Column("P_EVENT_ID", TypeName = "NUMBER")]
        public decimal? PEventId { get; set; }
        [Column("P_EVENT_CODE")]
        [StringLength(100)]
        public string PEventCode { get; set; }
        [Column("P_PARAM_STRING")]
        [StringLength(100)]
        public string PParamString { get; set; }
        [Column("PROCESSED_STATUS")]
        [StringLength(20)]
        public string ProcessedStatus { get; set; }
        [Column("CREATION_DATE", TypeName = "DATE")]
        public DateTime? CreationDate { get; set; }
        [Column("PROCESSED_DATE", TypeName = "DATE")]
        public DateTime? ProcessedDate { get; set; }
        [Column("PROCESSED_RESULT")]
        [StringLength(300)]
        public string ProcessedResult { get; set; }
        [Column("SOURCE")]
        [StringLength(50)]
        public string Source { get; set; }
        [Column("UPDATED_DATE", TypeName = "DATE")]
        public DateTime? UpdatedDate { get; set; }
        [Column("RETRY", TypeName = "NUMBER")]
        public decimal? Retry { get; set; }
    }
}
