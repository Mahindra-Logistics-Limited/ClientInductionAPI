using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("RAZOR_PAY_TXN")]
    [Index(nameof(Paymentrefid), Name = "UNIQUE_PAYMENTREFID", IsUnique = true)]
    public partial class RazorPayTxn
    {
        [Key]
        [Column("MERUPAYMENTID")]
        [StringLength(300)]
        public string Merupaymentid { get; set; }
        [Required]
        [Column("CARNO")]
        [StringLength(50)]
        public string Carno { get; set; }
        [Required]
        [Column("SPID")]
        [StringLength(50)]
        public string Spid { get; set; }
        [Column("AMOUNT", TypeName = "NUMBER(10,4)")]
        public decimal Amount { get; set; }
        [Required]
        [Column("PAYMENTREFID")]
        [StringLength(500)]
        public string Paymentrefid { get; set; }
        [Column("PAYMENTMETTYPE")]
        [StringLength(255)]
        public string Paymentmettype { get; set; }
        [Required]
        [Column("PAYMENTNAME")]
        [StringLength(255)]
        public string Paymentname { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("PRAGATITTXNID")]
        [StringLength(36)]
        public string Pragatittxnid { get; set; }
        [Column("TRANSACTIONDATE", TypeName = "DATE")]
        public DateTime? Transactiondate { get; set; }
        [Column("PRAGATISTATUS")]
        [StringLength(50)]
        public string Pragatistatus { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
    }
}
