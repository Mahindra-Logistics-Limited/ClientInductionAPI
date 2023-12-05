using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("XMERU_WFL_TRANSACTION")]
    public partial class XmeruWflTransaction
    {
        [Column("TRANSACTION_ID", TypeName = "NUMBER")]
        public decimal? TransactionId { get; set; }
        [Column("TRANSACTION_NUM")]
        [StringLength(30)]
        public string TransactionNum { get; set; }
        [Column("DOC_ORG_ID", TypeName = "NUMBER")]
        public decimal? DocOrgId { get; set; }
        [Column("TRANSACTION_TYPE")]
        [StringLength(30)]
        public string TransactionType { get; set; }
        [Column("APPROVAL_REQ")]
        [StringLength(1)]
        public string ApprovalReq { get; set; }
        [Column("NO_OF_APPROVALS", TypeName = "NUMBER")]
        public decimal? NoOfApprovals { get; set; }
        [Column("URL")]
        [StringLength(100)]
        public string Url { get; set; }
        [Column("NARRATION")]
        [StringLength(500)]
        public string Narration { get; set; }
        [Column("ATTRIBUTE1")]
        [StringLength(500)]
        public string Attribute1 { get; set; }
        [Column("ATTRIBUTE2")]
        [StringLength(500)]
        public string Attribute2 { get; set; }
        [Column("CREATION_DATE", TypeName = "DATE")]
        public DateTime CreationDate { get; set; }
        [Column("CREATED_BY", TypeName = "NUMBER")]
        public decimal CreatedBy { get; set; }
        [Column("LAST_UPDATE_DATE", TypeName = "DATE")]
        public DateTime? LastUpdateDate { get; set; }
        [Column("LAST_UPDATED_BY", TypeName = "NUMBER")]
        public decimal? LastUpdatedBy { get; set; }
        [Column("LAST_UPDATE_LOGIN")]
        public long? LastUpdateLogin { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("FORWARDED_TO")]
        [StringLength(30)]
        public string ForwardedTo { get; set; }
        [Column("STATUS_CODE")]
        [StringLength(30)]
        public string StatusCode { get; set; }
        [Column("APPR_LEVEL")]
        [StringLength(30)]
        public string ApprLevel { get; set; }
        [Column("FINAL_APPR_PERS_ID", TypeName = "NUMBER")]
        public decimal? FinalApprPersId { get; set; }
        [Column("FINAL_APPR_DATE", TypeName = "DATE")]
        public DateTime? FinalApprDate { get; set; }
        [Column("WF_ITEM_TYPE")]
        [StringLength(30)]
        public string WfItemType { get; set; }
        [Column("WF_ITEM_KEY")]
        [StringLength(30)]
        public string WfItemKey { get; set; }
        [Column("TRANSACTION_SOURCE")]
        [StringLength(100)]
        public string TransactionSource { get; set; }
        [Column("TRANSACTION_SOURCE_REFE")]
        [StringLength(50)]
        public string TransactionSourceRefe { get; set; }
    }
}
