using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisSpTxnV
    {
        [Column("COMMENTS")]
        [StringLength(2000)]
        public string Comments { get; set; }
        [Column("TXN_ID", TypeName = "NUMBER")]
        public decimal? TxnId { get; set; }
        [Column("TXN_NO")]
        [StringLength(100)]
        public string TxnNo { get; set; }
        [Column("INSTALLMENT", TypeName = "NUMBER")]
        public decimal? Installment { get; set; }
        [Column("TXN_AMOUNT", TypeName = "NUMBER")]
        public decimal? TxnAmount { get; set; }
        [Column("TXN_DATE", TypeName = "DATE")]
        public DateTime? TxnDate { get; set; }
        [Column("DUE_DATE", TypeName = "DATE")]
        public DateTime? DueDate { get; set; }
        [Column("SP_PERSON_ID")]
        [StringLength(1000)]
        public string SpPersonId { get; set; }
        [Column("SP_GUID")]
        [StringLength(36)]
        public string SpGuid { get; set; }
        [Column("PERSON_GUID")]
        [StringLength(36)]
        public string PersonGuid { get; set; }
        [Column("SITE_GUID")]
        [StringLength(36)]
        public string SiteGuid { get; set; }
        [Column("SITENAME")]
        [StringLength(100)]
        public string Sitename { get; set; }
        [Column("REGISTRATIONNO")]
        [StringLength(255)]
        public string Registrationno { get; set; }
        [Column("CAR_GUID")]
        [StringLength(36)]
        public string CarGuid { get; set; }
        [Column("TXN_TYPE_GUID")]
        [StringLength(36)]
        public string TxnTypeGuid { get; set; }
        [Column("TXN_CLASS_GUID")]
        [StringLength(36)]
        public string TxnClassGuid { get; set; }
        [Column("TXN_TYPE")]
        [StringLength(255)]
        public string TxnType { get; set; }
        [Column("TXN_CLASS")]
        [StringLength(255)]
        public string TxnClass { get; set; }
        [Column("CUST_TRX_ID", TypeName = "NUMBER")]
        public decimal? CustTrxId { get; set; }
        [Column("IMMEDIATEPAYTERMFLAG")]
        [StringLength(1)]
        public string Immediatepaytermflag { get; set; }
    }
}
