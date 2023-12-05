using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("XMERU_MAX_EMP_NO")]
    public partial class XmeruMaxEmpNo
    {
        [Column("HR_LEGAL_ENTITY")]
        [StringLength(20)]
        public string HrLegalEntity { get; set; }
        [Column("MAX_EMP_NO", TypeName = "NUMBER")]
        public decimal? MaxEmpNo { get; set; }
    }
}
