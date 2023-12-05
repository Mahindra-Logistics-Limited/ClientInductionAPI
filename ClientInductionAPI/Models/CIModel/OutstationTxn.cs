using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("OUTSTATION_TXN")]
    public partial class OutstationTxn
    {
        [Key]
        [Column("GUID")]
        [StringLength(32)]
        public string Guid { get; set; }
        [Required]
        [Column("SERVICEPROVIDER")]
        [StringLength(32)]
        public string Serviceprovider { get; set; }
        [Required]
        [Column("TRANSACTIONTYPE")]
        [StringLength(32)]
        public string Transactiontype { get; set; }
        [Required]
        [Column("JOBID")]
        [StringLength(32)]
        public string Jobid { get; set; }
        [Column("AMOUNT", TypeName = "NUMBER(12,2)")]
        public decimal Amount { get; set; }
        [Column("MERUPAYMENTID")]
        [StringLength(32)]
        public string Merupaymentid { get; set; }
        [Column("TRANSACTIONID")]
        public long? Transactionid { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("MANTHANTRANSACTIONDATE", TypeName = "DATE")]
        public DateTime? Manthantransactiondate { get; set; }
    }
}
