using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("LOCK_EXECUTION_LOG")]
    public partial class LockExecutionLog
    {
        [Column("PRCEDURE_NAME")]
        [StringLength(36)]
        public string PrcedureName { get; set; }
        [Column("EX_TIME", TypeName = "DATE")]
        public DateTime? ExTime { get; set; }
        [Column("NEXT_EX_TIME", TypeName = "DATE")]
        public DateTime? NextExTime { get; set; }
        [Column("LOG_ID", TypeName = "NUMBER")]
        public decimal? LogId { get; set; }
        [Column("STATUS")]
        [StringLength(36)]
        public string Status { get; set; }
        [Column("BRANCH_GUID")]
        [StringLength(36)]
        public string BranchGuid { get; set; }
    }
}
