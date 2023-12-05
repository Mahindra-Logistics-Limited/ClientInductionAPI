using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("CORPORATETRIPREQUEST")]
    public partial class Corporatetriprequest
    {
        [Key]
        [Column("VOUCHER_ID")]
        [StringLength(36)]
        public string VoucherId { get; set; }
        [Column("JOB_ID")]
        [StringLength(36)]
        public string JobId { get; set; }
        [Column("URL")]
        [StringLength(250)]
        public string Url { get; set; }
        [Column("CAPTURED_TIME")]
        [StringLength(36)]
        public string CapturedTime { get; set; }
        [Column("SOURCE")]
        [StringLength(36)]
        public string Source { get; set; }
    }
}
