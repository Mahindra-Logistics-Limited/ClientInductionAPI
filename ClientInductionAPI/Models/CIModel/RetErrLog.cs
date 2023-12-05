using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("RET_ERR_LOG")]
    public partial class RetErrLog
    {
        [Column("SEQ_ID", TypeName = "NUMBER")]
        public decimal? SeqId { get; set; }
        [Column("EVENT_ID", TypeName = "NUMBER")]
        public decimal? EventId { get; set; }
        [Column("JOB_ID", TypeName = "NUMBER")]
        public decimal? JobId { get; set; }
        [Column("WORKFLOW_ID", TypeName = "NUMBER")]
        public decimal? WorkflowId { get; set; }
        [Column("WORKFLOW_ACTION_ID", TypeName = "NUMBER")]
        public decimal? WorkflowActionId { get; set; }
        [Column("ERROR_TEXT")]
        [StringLength(200)]
        public string ErrorText { get; set; }
        [Column("XML_TEXT")]
        [StringLength(1000)]
        public string XmlText { get; set; }
        [Column("CREATED_DATE", TypeName = "DATE")]
        public DateTime? CreatedDate { get; set; }
    }
}
