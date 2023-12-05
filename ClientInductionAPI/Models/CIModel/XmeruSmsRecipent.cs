using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("XMERU_SMS_RECIPENTS")]
    public partial class XmeruSmsRecipent
    {
        [Column("SEQ_ID", TypeName = "NUMBER")]
        public decimal? SeqId { get; set; }
        [Column("RECIPIENT_NAME")]
        [StringLength(100)]
        public string RecipientName { get; set; }
        [Required]
        [Column("PHONE_NO")]
        [StringLength(12)]
        public string PhoneNo { get; set; }
        [Column("CONST_PRE_TEXT")]
        [StringLength(100)]
        public string ConstPreText { get; set; }
        [Column("CONST_POST_TEXT")]
        [StringLength(100)]
        public string ConstPostText { get; set; }
        [Column("ENABLED_FLAG")]
        public bool? EnabledFlag { get; set; }
        [Column("RECIPENTSTYPE")]
        [StringLength(100)]
        public string Recipentstype { get; set; }
    }
}
