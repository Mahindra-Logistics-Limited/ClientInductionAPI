using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("FTR_QACDCOFLEXI")]
    public partial class FtrQacdcoflexi
    {
        [Column("TRANSACTIONID", TypeName = "NUMBER")]
        public decimal? Transactionid { get; set; }
        [Column("TRANSACTIONTYPEID", TypeName = "NUMBER")]
        public decimal? Transactiontypeid { get; set; }
        [Column("TRANSACTIONAMOUNT", TypeName = "NUMBER")]
        public decimal? Transactionamount { get; set; }
        [Column("TRANSACTIONDATE", TypeName = "DATE")]
        public DateTime? Transactiondate { get; set; }
        [Column("USERNAME")]
        [StringLength(50)]
        public string Username { get; set; }
        [Column("ASSOCIATEID")]
        [StringLength(15)]
        public string Associateid { get; set; }
        [Column("CABREGISTRATIONNO")]
        [StringLength(30)]
        public string Cabregistrationno { get; set; }
        [Column("CITYID", TypeName = "NUMBER")]
        public decimal? Cityid { get; set; }
        [Column("ISDELETED", TypeName = "NUMBER")]
        public decimal? Isdeleted { get; set; }
        [Column("CITYNAME")]
        [StringLength(50)]
        public string Cityname { get; set; }
        [Column("TRANSACTIONTYPE")]
        [StringLength(50)]
        public string Transactiontype { get; set; }
        [Column("REMARKS")]
        [StringLength(250)]
        public string Remarks { get; set; }
        [Column("PAYMENTMODE")]
        [StringLength(50)]
        public string Paymentmode { get; set; }
        [Column("CHEQUENO")]
        [StringLength(20)]
        public string Chequeno { get; set; }
        [Column("BANKNAME")]
        [StringLength(70)]
        public string Bankname { get; set; }
        [Column("TRIP_ID", TypeName = "NUMBER")]
        public decimal? TripId { get; set; }
        [Column("TRANSREFNUMBER")]
        [StringLength(50)]
        public string Transrefnumber { get; set; }
        [Column("CHEQUESTATUS", TypeName = "NUMBER")]
        public decimal? Chequestatus { get; set; }
        [Column("ESCROWACID", TypeName = "NUMBER")]
        public decimal? Escrowacid { get; set; }
        [Column("CABTYPE")]
        [StringLength(50)]
        public string Cabtype { get; set; }
        [Column("TRANSACTIONSUBTYPE")]
        [StringLength(50)]
        public string Transactionsubtype { get; set; }
        [Column("TRANSACTIONSUBTYPEID", TypeName = "NUMBER")]
        public decimal? Transactionsubtypeid { get; set; }
        [Column("ASSOCIATENAME")]
        [StringLength(100)]
        public string Associatename { get; set; }
        [Column("CABID", TypeName = "NUMBER")]
        public decimal? Cabid { get; set; }
    }
}
