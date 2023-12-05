using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisSpSiteBalHistV
    {
        [Required]
        [Column("SP_PERSON_ID")]
        [StringLength(1000)]
        public string SpPersonId { get; set; }
        [Required]
        [Column("SP_PER_GUID")]
        [StringLength(36)]
        public string SpPerGuid { get; set; }
        [Column("SITENAME")]
        [StringLength(100)]
        public string Sitename { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("BALANCE_DATE", TypeName = "DATE")]
        public DateTime? BalanceDate { get; set; }
        [Column("DEPOSIT_OS", TypeName = "NUMBER")]
        public decimal? DepositOs { get; set; }
        [Column("NET_OS", TypeName = "NUMBER")]
        public decimal? NetOs { get; set; }
        [Column("NET_OS_DUE", TypeName = "NUMBER")]
        public decimal? NetOsDue { get; set; }
    }
}
