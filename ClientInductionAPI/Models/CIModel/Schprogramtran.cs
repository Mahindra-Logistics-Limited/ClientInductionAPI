using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SCHPROGRAMTRAN")]
    public partial class Schprogramtran
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("REQUESTID")]
        [StringLength(36)]
        public string Requestid { get; set; }
        [Column("SCHPROGRAMGUID")]
        [StringLength(36)]
        public string Schprogramguid { get; set; }
        [Column("SCHEDULETIME", TypeName = "DATE")]
        public DateTime? Scheduletime { get; set; }
        [Column("ACTUALSTARTTIME", TypeName = "DATE")]
        public DateTime? Actualstarttime { get; set; }
        [Column("ACTUALENDTIME", TypeName = "DATE")]
        public DateTime? Actualendtime { get; set; }
        [Column("CANCELLED", TypeName = "NUMBER")]
        public decimal? Cancelled { get; set; }
        [Column("AUTOSCHEDULE", TypeName = "NUMBER")]
        public decimal? Autoschedule { get; set; }
        [Column("PHASE")]
        [StringLength(36)]
        public string Phase { get; set; }
        [Column("STATUS")]
        [StringLength(36)]
        public string Status { get; set; }
        [Column("DURATION", TypeName = "NUMBER")]
        public decimal? Duration { get; set; }
        [Column("DURATIONTYPE")]
        [StringLength(50)]
        public string Durationtype { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("SCHEDULEENDTIME", TypeName = "DATE")]
        public DateTime? Scheduleendtime { get; set; }
        [Column("NEXTREQUESTID")]
        [StringLength(36)]
        public string Nextrequestid { get; set; }
    }
}
