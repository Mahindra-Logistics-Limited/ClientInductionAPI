using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("AR_RECEIPT_METHOD_ACCOUNTS_ALL")]
    public partial class ArReceiptMethodAccountsAll
    {
        [Column("RECEIPT_METHOD_ID", TypeName = "NUMBER")]
        public decimal? ReceiptMethodId { get; set; }
        [Column("CREATION_DATE", TypeName = "DATE")]
        public DateTime? CreationDate { get; set; }
        [Column("ATTRIBUTE1")]
        [StringLength(40)]
        public string Attribute1 { get; set; }
        [Column("ORG_ID", TypeName = "NUMBER")]
        public decimal? OrgId { get; set; }
        [Column("LEGALENTITY")]
        [StringLength(20)]
        public string Legalentity { get; set; }
        [Column("BRANCH_CODE")]
        [StringLength(20)]
        public string BranchCode { get; set; }
    }
}
