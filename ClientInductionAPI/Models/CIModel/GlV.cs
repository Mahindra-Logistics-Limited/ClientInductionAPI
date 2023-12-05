using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class GlV
    {
        [Column("TRANSACTION_DATE", TypeName = "DATE")]
        public DateTime? TransactionDate { get; set; }
        [Column("LEGAL_ENTITY")]
        [StringLength(200)]
        public string LegalEntity { get; set; }
        [Column("CITY_NAME")]
        [StringLength(200)]
        public string CityName { get; set; }
        [Column("TRANSACTION_CLASS")]
        [StringLength(255)]
        public string TransactionClass { get; set; }
        [Column("TRANSACTION_TYPE")]
        [StringLength(255)]
        public string TransactionType { get; set; }
        [Column("GL_NAME")]
        [StringLength(250)]
        public string GlName { get; set; }
        [Column("GL_CODE", TypeName = "NUMBER")]
        public decimal? GlCode { get; set; }
        [Column("TOTAL", TypeName = "NUMBER")]
        public decimal? Total { get; set; }
    }
}
