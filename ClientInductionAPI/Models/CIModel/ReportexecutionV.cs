using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class ReportexecutionV
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("REPORTGUID")]
        [StringLength(36)]
        public string Reportguid { get; set; }
        [Column("PARAMETERTEXTFIELD1")]
        [StringLength(100)]
        public string Parametertextfield1 { get; set; }
        [Column("PARAMETERTEXTFIELD2")]
        [StringLength(100)]
        public string Parametertextfield2 { get; set; }
        [Column("PARAMETERTEXTFIELD3")]
        [StringLength(100)]
        public string Parametertextfield3 { get; set; }
        [Column("PARAMETERTEXTFIELD4")]
        [StringLength(100)]
        public string Parametertextfield4 { get; set; }
        [Column("PARAMETERTEXTFIELD5")]
        [StringLength(100)]
        public string Parametertextfield5 { get; set; }
        [Column("PARAMETERNOFIELD1", TypeName = "NUMBER")]
        public decimal? Parameternofield1 { get; set; }
        [Column("PARAMETERNOFIELD2", TypeName = "NUMBER")]
        public decimal? Parameternofield2 { get; set; }
        [Column("PARAMETERNOFIELD3", TypeName = "NUMBER")]
        public decimal? Parameternofield3 { get; set; }
        [Column("PARAMETERNOFIELD4", TypeName = "NUMBER")]
        public decimal? Parameternofield4 { get; set; }
        [Column("PARAMETERNOFIELD5", TypeName = "NUMBER")]
        public decimal? Parameternofield5 { get; set; }
        [Column("PARAMETERDATEFIELD1", TypeName = "DATE")]
        public DateTime? Parameterdatefield1 { get; set; }
        [Column("PARAMETERDATEFIELD2", TypeName = "DATE")]
        public DateTime? Parameterdatefield2 { get; set; }
        [Column("PARAMETERDATEFIELD3", TypeName = "DATE")]
        public DateTime? Parameterdatefield3 { get; set; }
        [Column("PARAMETERDATEFIELD4", TypeName = "DATE")]
        public DateTime? Parameterdatefield4 { get; set; }
        [Column("PARAMETERDATEFIELD5", TypeName = "DATE")]
        public DateTime? Parameterdatefield5 { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
    }
}
