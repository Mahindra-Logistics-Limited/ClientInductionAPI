using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("XMERU_WR_VOUCHERS_STAGE")]
    public partial class XmeruWrVouchersStage
    {
        [Key]
        [Column("ESTIMATION_ID")]
        public long EstimationId { get; set; }
        [Required]
        [Column("VOUCHER_NUM")]
        [StringLength(30)]
        public string VoucherNum { get; set; }
        [Required]
        [Column("VOUCHER_CATEGORY")]
        [StringLength(50)]
        public string VoucherCategory { get; set; }
        [Column("VOUCHER_AMOUNT", TypeName = "NUMBER")]
        public decimal VoucherAmount { get; set; }
        [Column("VOUCHER_DATE", TypeName = "DATE")]
        public DateTime VoucherDate { get; set; }
        [Column("VOUCHER_ORG_ID", TypeName = "NUMBER")]
        public decimal VoucherOrgId { get; set; }
        [Column("REQUESTOR_PERS_ID", TypeName = "NUMBER")]
        public decimal RequestorPersId { get; set; }
        [Column("APPR_SUBMIT_DATE", TypeName = "DATE")]
        public DateTime? ApprSubmitDate { get; set; }
        [Column("FINAL_APPR_PERS_ID")]
        public long? FinalApprPersId { get; set; }
        [Column("FINAL_APPR_DATE", TypeName = "DATE")]
        public DateTime? FinalApprDate { get; set; }
        [Column("REQUESTOR_COMMENTS")]
        [StringLength(350)]
        public string RequestorComments { get; set; }
        [Column("APPROVER_COMMENTS")]
        [StringLength(350)]
        public string ApproverComments { get; set; }
        [Column("CREATION_DATE", TypeName = "DATE")]
        public DateTime CreationDate { get; set; }
        [Column("CREATED_BY", TypeName = "NUMBER")]
        public decimal CreatedBy { get; set; }
        [Column("LAST_UPDATE_DATE", TypeName = "DATE")]
        public DateTime LastUpdateDate { get; set; }
        [Column("LAST_UPDATED_BY", TypeName = "NUMBER")]
        public decimal LastUpdatedBy { get; set; }
        [Column("LAST_UPDATE_LOGIN")]
        public long? LastUpdateLogin { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("APPR_LEVEL", TypeName = "NUMBER")]
        public decimal? ApprLevel { get; set; }
        [Column("ERR_MSG")]
        [StringLength(250)]
        public string ErrMsg { get; set; }
        [Column("WF_ITEM_KEY")]
        [StringLength(240)]
        public string WfItemKey { get; set; }
        [Column("WF_ITEM_TYPE")]
        [StringLength(10)]
        public string WfItemType { get; set; }
        [Column("FORWARDED_TO")]
        [StringLength(50)]
        public string ForwardedTo { get; set; }
        [Column("ORIG_SYSTEM")]
        [StringLength(50)]
        public string OrigSystem { get; set; }
        [Column("ORIG_SYSTEM_REF")]
        [StringLength(50)]
        public string OrigSystemRef { get; set; }
        [Column("ORIG_SYS_ATTACH_FILE_NAME")]
        [StringLength(100)]
        public string OrigSysAttachFileName { get; set; }
        [Column("ORIG_SYS_ATTACH_FILE_TYPE")]
        [StringLength(256)]
        public string OrigSysAttachFileType { get; set; }
        [Column("STATUS_CODE", TypeName = "NUMBER")]
        public decimal? StatusCode { get; set; }
        [Column("WR_ID", TypeName = "NUMBER")]
        public decimal? WrId { get; set; }
        [Column("VEHICLE_NUM")]
        [StringLength(100)]
        public string VehicleNum { get; set; }
        [Column("WORK_SHOP")]
        [StringLength(250)]
        public string WorkShop { get; set; }
        [Column("WR_TYPE")]
        [StringLength(50)]
        public string WrType { get; set; }
        [Column("DOCUMENT_READY")]
        [StringLength(2)]
        public string DocumentReady { get; set; }
    }
}
