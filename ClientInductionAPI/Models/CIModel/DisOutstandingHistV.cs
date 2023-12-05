using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisOutstandingHistV
    {
        [Column("REGISTRATIONNO")]
        [StringLength(255)]
        public string Registrationno { get; set; }
        [Required]
        [Column("PERSONID")]
        [StringLength(1000)]
        public string Personid { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("BALANCE_DATE", TypeName = "DATE")]
        public DateTime? BalanceDate { get; set; }
        [Column("DEPOSIT_OS", TypeName = "NUMBER")]
        public decimal? DepositOs { get; set; }
        [Column("SUBSCRIPTIO_DM_OS", TypeName = "NUMBER")]
        public decimal? SubscriptioDmOs { get; set; }
        [Column("TOTAL_OS", TypeName = "NUMBER")]
        public decimal? TotalOs { get; set; }
        [Column("DEPOSIT_DUE", TypeName = "NUMBER")]
        public decimal? DepositDue { get; set; }
        [Column("SUBSCRIPTIO_DM_DUE", TypeName = "NUMBER")]
        public decimal? SubscriptioDmDue { get; set; }
        [Column("TOTAL_DUE", TypeName = "NUMBER")]
        public decimal? TotalDue { get; set; }
    }
}
