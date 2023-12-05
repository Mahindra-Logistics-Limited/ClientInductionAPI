using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("DIS_REQUESTREASONMASTER")]
    public partial class DisRequestreasonmaster
    {
        [Key]
        [Column("REQUESTREASONNO", TypeName = "NUMBER")]
        public decimal Requestreasonno { get; set; }
        [Key]
        [Column("SERVICETYPENO", TypeName = "NUMBER")]
        public decimal Servicetypeno { get; set; }
        [Column("REASON")]
        [StringLength(100)]
        public string Reason { get; set; }
        [Column("DETAILS")]
        [StringLength(1000)]
        public string Details { get; set; }
        [Column("DISABLED", TypeName = "NUMBER")]
        public decimal? Disabled { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
    }
}
