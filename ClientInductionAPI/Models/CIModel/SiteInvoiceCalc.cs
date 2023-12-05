using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SITE_INVOICE_CALC")]
    public partial class SiteInvoiceCalc
    {
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("INVOICE_PROGRAMEXECUTION_GUID")]
        [StringLength(36)]
        public string InvoiceProgramexecutionGuid { get; set; }
        [Column("SUMMARY_A", TypeName = "NUMBER(10,2)")]
        public decimal? SummaryA { get; set; }
        [Column("SUMMARY_B", TypeName = "NUMBER(10,2)")]
        public decimal? SummaryB { get; set; }
        [Column("SUMMARY_C", TypeName = "NUMBER(10,2)")]
        public decimal? SummaryC { get; set; }
        [Column("SUMMARY_D", TypeName = "NUMBER(10,2)")]
        public decimal? SummaryD { get; set; }
        [Column("SPSHARE_PCT", TypeName = "NUMBER(10,2)")]
        public decimal? SpsharePct { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
    }
}
