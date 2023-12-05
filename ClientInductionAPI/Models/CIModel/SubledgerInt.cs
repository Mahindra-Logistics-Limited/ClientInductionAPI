using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SUBLEDGER_INT")]
    public partial class SubledgerInt
    {
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("SEGMENT1")]
        [StringLength(25)]
        public string Segment1 { get; set; }
        [Column("SEGMENT4")]
        [StringLength(25)]
        public string Segment4 { get; set; }
        [Column("SEGMENT6")]
        [StringLength(25)]
        public string Segment6 { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("BILLSITEUSEID")]
        [StringLength(36)]
        public string Billsiteuseid { get; set; }
        [Column("COUPONAMOUNT", TypeName = "NUMBER(10,2)")]
        public decimal? Couponamount { get; set; }
        [Column("ACCRUALCREDIT", TypeName = "NUMBER(10,2)")]
        public decimal? Accrualcredit { get; set; }
        [Column("ACCRUALDEBIT", TypeName = "NUMBER(10,2)")]
        public decimal? Accrualdebit { get; set; }
        [Column("TOTALCM", TypeName = "NUMBER(10,2)")]
        public decimal? Totalcm { get; set; }
        [Column("SPSERVICECHARGE", TypeName = "NUMBER(10,2)")]
        public decimal? Spservicecharge { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("STATUS")]
        [StringLength(36)]
        public string Status { get; set; }
        [Column("GROUPID")]
        [StringLength(50)]
        public string Groupid { get; set; }
        [Column("CAR_REGN_NO")]
        [StringLength(30)]
        public string CarRegnNo { get; set; }
        [Column("SPID")]
        [StringLength(36)]
        public string Spid { get; set; }
        [Column("CITYCODE")]
        [StringLength(50)]
        public string Citycode { get; set; }
        [Column("TOTALTRIP", TypeName = "NUMBER")]
        public decimal? Totaltrip { get; set; }
    }
}
