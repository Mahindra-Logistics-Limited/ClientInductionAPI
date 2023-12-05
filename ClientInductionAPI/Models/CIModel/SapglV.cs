using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class SapglV
    {
        [Column("TRANSACTION_DATE")]
        [StringLength(10)]
        public string TransactionDate { get; set; }
        [Column("BUSINESS_PLACE")]
        [StringLength(4)]
        public string BusinessPlace { get; set; }
        [Column("TRANSACTION_CLASS")]
        [StringLength(255)]
        public string TransactionClass { get; set; }
        [Column("TRANSACTION_TYPE")]
        [StringLength(255)]
        public string TransactionType { get; set; }
        [Column("GL_CODE")]
        [StringLength(20)]
        public string GlCode { get; set; }
        [Column("TOTAL")]
        [StringLength(15)]
        public string Total { get; set; }
        [Column("INERNAL_ORDER")]
        [StringLength(20)]
        public string InernalOrder { get; set; }
        [Column("BASE_TRANSACTION_DATE")]
        [StringLength(8)]
        public string BaseTransactionDate { get; set; }
        [Column("CITY_CODE")]
        [StringLength(3)]
        public string CityCode { get; set; }
        [Column("SHOWINSTATEMENT")]
        [StringLength(3)]
        public string Showinstatement { get; set; }
        [Column("TRANS_ACTUALDATEFORMAT", TypeName = "DATE")]
        public DateTime? TransActualdateformat { get; set; }
        [Column("TXNCLASSSEQNO", TypeName = "NUMBER")]
        public decimal? Txnclassseqno { get; set; }
        [Column("PROFITCENTER")]
        [StringLength(20)]
        public string Profitcenter { get; set; }
        [Column("COSTCENTER")]
        [StringLength(20)]
        public string Costcenter { get; set; }
        [Column("ISBALANCESHEET", TypeName = "NUMBER")]
        public decimal? Isbalancesheet { get; set; }
        [Column("SHOWCOSTCENTER", TypeName = "NUMBER")]
        public decimal? Showcostcenter { get; set; }
        [Column("DOCUMENTTYPE")]
        [StringLength(2)]
        public string Documenttype { get; set; }
    }
}
