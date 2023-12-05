using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisTransactiontypeV
    {
        [Required]
        [Column("TRANSACTIONTYPEGUID")]
        [StringLength(36)]
        public string Transactiontypeguid { get; set; }
        [Column("TRANSACTIONTYPENAME")]
        [StringLength(255)]
        public string Transactiontypename { get; set; }
        [Column("TRANSACTIONTYPECODE")]
        [StringLength(60)]
        public string Transactiontypecode { get; set; }
        [Column("TRANSACTIONCLASSNAME")]
        [StringLength(255)]
        public string Transactionclassname { get; set; }
        [Column("TRANSACTIONCLASSCODE")]
        [StringLength(25)]
        public string Transactionclasscode { get; set; }
        [Column("SIGNINDICATOR")]
        [StringLength(36)]
        public string Signindicator { get; set; }
        [Column("TXNTYPE")]
        [StringLength(17)]
        public string Txntype { get; set; }
    }
}
