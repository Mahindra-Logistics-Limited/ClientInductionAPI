using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TRANSACTIONMASTER")]
    public partial class Transactionmaster
    {
        [Column("TRANSACTIONID", TypeName = "NUMBER")]
        public decimal Transactionid { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("TRANSACTIONSOURCEGUID")]
        [StringLength(36)]
        public string Transactionsourceguid { get; set; }
        [Column("TRANSACTIONTYPEGUID")]
        [StringLength(36)]
        public string Transactiontypeguid { get; set; }
        [Column("SPSITEMASTERGUID")]
        [StringLength(36)]
        public string Spsitemasterguid { get; set; }
        [Column("CURRENCYCODE")]
        [StringLength(5)]
        public string Currencycode { get; set; }
        [Column("AMOUNT", TypeName = "NUMBER(12,2)")]
        public decimal? Amount { get; set; }
        [Column("TRANSACTIONDATE", TypeName = "DATE")]
        public DateTime? Transactiondate { get; set; }
        [Column("GLDATE", TypeName = "DATE")]
        public DateTime? Gldate { get; set; }
        [Column("COMPLETEFLAG")]
        public bool? Completeflag { get; set; }
        [Column("TRANSACTIONNO")]
        [StringLength(100)]
        public string Transactionno { get; set; }
        [Column("ENTITYMASTERGUID")]
        [StringLength(36)]
        public string Entitymasterguid { get; set; }
        [Column("VALIDITYSTARTDATE", TypeName = "DATE")]
        public DateTime? Validitystartdate { get; set; }
        [Column("VALIDITYENDDATE", TypeName = "DATE")]
        public DateTime? Validityenddate { get; set; }
        [Column("SOURCEENTITYGUID")]
        [StringLength(36)]
        public string Sourceentityguid { get; set; }
        [Column("SOURCETRANSACTIONID")]
        [StringLength(36)]
        public string Sourcetransactionid { get; set; }
        [Column("ORIGINALTRANSACTIONID", TypeName = "NUMBER")]
        public decimal? Originaltransactionid { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("POSTEDDATE", TypeName = "DATE")]
        public DateTime? Posteddate { get; set; }
        [Required]
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("USERUPDATED")]
        [StringLength(36)]
        public string Userupdated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("USERDELETED")]
        [StringLength(36)]
        public string Userdeleted { get; set; }
        [Column("DATEDELETED", TypeName = "DATE")]
        public DateTime? Datedeleted { get; set; }
        [Column("USERARCHIVED")]
        [StringLength(36)]
        public string Userarchived { get; set; }
        [Column("DATEARCHIVED", TypeName = "DATE")]
        public DateTime? Datearchived { get; set; }
        [Column("ORACLEENTITYNAME")]
        [StringLength(100)]
        public string Oracleentityname { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(1000)]
        public string Oracleentityid { get; set; }
        [Column("OBJECTVERSIONNO")]
        public int? Objectversionno { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("STBASEAMOUNT", TypeName = "NUMBER(12,2)")]
        public decimal? Stbaseamount { get; set; }
        [Column("STCESSAMOUNT", TypeName = "NUMBER(12,2)")]
        public decimal? Stcessamount { get; set; }
        [Column("STHIGHEDUCESSAMOUNT", TypeName = "NUMBER(12,2)")]
        public decimal? Sthigheducessamount { get; set; }
        [Column("GVCOMPONENTGUID")]
        [StringLength(36)]
        public string Gvcomponentguid { get; set; }
        [Column("FULLYREVERSEDFLAG")]
        [StringLength(1)]
        public string Fullyreversedflag { get; set; }
        [Column("IMMEDIATEPAYTERMFLAG")]
        [StringLength(1)]
        public string Immediatepaytermflag { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("COMMENTS")]
        [StringLength(2000)]
        public string Comments { get; set; }
        [Column("UNIT", TypeName = "NUMBER")]
        public decimal? Unit { get; set; }
        [Column("PRICE", TypeName = "NUMBER")]
        public decimal? Price { get; set; }
        [Column("TENURE", TypeName = "NUMBER")]
        public decimal? Tenure { get; set; }
        [Column("AVOIDTRANSACTIONTYPE")]
        public bool? Avoidtransactiontype { get; set; }
    }
}
