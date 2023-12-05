using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("XMERU_TXN_TBL")]
    public partial class XmeruTxnTbl
    {
        [Column("EXECUTION_GUID")]
        [StringLength(36)]
        public string ExecutionGuid { get; set; }
        [Column("SR_NO", TypeName = "NUMBER")]
        public decimal? SrNo { get; set; }
        [Column("TXN_AMOUNT", TypeName = "NUMBER")]
        public decimal? TxnAmount { get; set; }
        [Column("TXN_TYPE")]
        [StringLength(36)]
        public string TxnType { get; set; }
        [Column("TXN_DATE", TypeName = "DATE")]
        public DateTime? TxnDate { get; set; }
        [Column("SPID")]
        [StringLength(20)]
        public string Spid { get; set; }
        [Column("SITENAME")]
        [StringLength(30)]
        public string Sitename { get; set; }
        [Column("COMMENTS")]
        [StringLength(1000)]
        public string Comments { get; set; }
        [Column("USERGUID")]
        [StringLength(36)]
        public string Userguid { get; set; }
        [Column("ROLEGUID")]
        [StringLength(36)]
        public string Roleguid { get; set; }
        [Column("SEC_GUID")]
        [StringLength(36)]
        public string SecGuid { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("CARGUID")]
        [StringLength(36)]
        public string Carguid { get; set; }
        [Column("SPGUID")]
        [StringLength(36)]
        public string Spguid { get; set; }
        [Column("TRX_NUM", TypeName = "NUMBER")]
        public decimal? TrxNum { get; set; }
        [Column("TRX_ID", TypeName = "NUMBER")]
        public decimal? TrxId { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("ERRORMSG")]
        public string Errormsg { get; set; }
        [Column("TXN_TYPE_NAME")]
        public string TxnTypeName { get; set; }
        [Column("SIGNINDICATOR", TypeName = "NUMBER")]
        public decimal? Signindicator { get; set; }
        [Column("REQUESTID")]
        public int? Requestid { get; set; }
        [Column("CLIENTID")]
        [StringLength(20)]
        public string Clientid { get; set; }
        [Column("TRIPID")]
        [StringLength(20)]
        public string Tripid { get; set; }
    }
}
