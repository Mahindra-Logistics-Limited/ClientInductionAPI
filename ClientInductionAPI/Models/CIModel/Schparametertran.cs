using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SCHPARAMETERTRAN")]
    public partial class Schparametertran
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("REQUESTID")]
        [StringLength(36)]
        public string Requestid { get; set; }
        [Column("SCHPROGRAMGUID")]
        [StringLength(36)]
        public string Schprogramguid { get; set; }
        [Column("SCHPARAMETERGUID")]
        [StringLength(36)]
        public string Schparameterguid { get; set; }
        [Column("VALUE")]
        [StringLength(255)]
        public string Value { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
    }
}
