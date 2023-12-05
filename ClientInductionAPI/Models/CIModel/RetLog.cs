using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("RET_LOG")]
    public partial class RetLog
    {
        [Column("SEQ_ID", TypeName = "NUMBER")]
        public decimal? SeqId { get; set; }
        [Column("JOB_ID", TypeName = "NUMBER")]
        public decimal? JobId { get; set; }
        [Column("RESULT")]
        [StringLength(1000)]
        public string Result { get; set; }
        [Column("P_SUCCESSFUL")]
        [StringLength(10)]
        public string PSuccessful { get; set; }
        [Column("EVENT_ID", TypeName = "NUMBER")]
        public decimal? EventId { get; set; }
        [Column("CREATED_DATE", TypeName = "DATE")]
        public DateTime? CreatedDate { get; set; }
    }
}
