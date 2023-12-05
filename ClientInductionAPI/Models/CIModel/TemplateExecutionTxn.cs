using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TEMPLATE_EXECUTION_TXN")]
    public partial class TemplateExecutionTxn
    {
        [Column("TEMPLATE_EXECUTION_ID")]
        [StringLength(36)]
        public string TemplateExecutionId { get; set; }
        [Column("SPSITEGUID")]
        [StringLength(36)]
        public string Spsiteguid { get; set; }
        [Column("TXN_TYPE_GUID")]
        [StringLength(36)]
        public string TxnTypeGuid { get; set; }
        [Column("AMMOUNT", TypeName = "NUMBER")]
        public decimal? Ammount { get; set; }
        [Column("TXN_DATE")]
        [StringLength(30)]
        public string TxnDate { get; set; }
    }
}
