using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("RULE_BACKUP")]
    public partial class RuleBackup
    {
        [Column("ENTITY")]
        [StringLength(10)]
        public string Entity { get; set; }
        [Column("RULE_NAME")]
        [StringLength(100)]
        public string RuleName { get; set; }
        [Column("VIEW_NAME")]
        [StringLength(30)]
        public string ViewName { get; set; }
        [Column("VIEW_COL")]
        [StringLength(50)]
        public string ViewCol { get; set; }
        [Column("ENABLED_FLAG")]
        [StringLength(1)]
        public string EnabledFlag { get; set; }
        [Column("LEBRANCH_GUID")]
        [StringLength(36)]
        public string LebranchGuid { get; set; }
        [Column("SECURITY_GUID")]
        [StringLength(36)]
        public string SecurityGuid { get; set; }
        [Column("RULE_DEFERRED_DAYS", TypeName = "NUMBER")]
        public decimal? RuleDeferredDays { get; set; }
        [Column("MODEL_GUID")]
        [StringLength(36)]
        public string ModelGuid { get; set; }
    }
}
