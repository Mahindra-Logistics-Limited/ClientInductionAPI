using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("MANUAL_CREDITLIMIT_DETAILS")]
    public partial class ManualCreditlimitDetail
    {
        [Column("SPID")]
        [StringLength(20)]
        public string Spid { get; set; }
        [Column("SITENAME")]
        [StringLength(30)]
        public string Sitename { get; set; }
        [Column("CREDITLIMIT_AMOUNT", TypeName = "NUMBER")]
        public decimal? CreditlimitAmount { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("REMARK")]
        [StringLength(2000)]
        public string Remark { get; set; }
        [Column("REQUEST_ID", TypeName = "NUMBER")]
        public decimal? RequestId { get; set; }
    }
}
