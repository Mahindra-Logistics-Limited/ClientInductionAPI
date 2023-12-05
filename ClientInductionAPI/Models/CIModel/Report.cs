using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("REPORTS")]
    public partial class Report
    {
        [Column("REP_GUID")]
        [StringLength(36)]
        public string RepGuid { get; set; }
        [Column("REP_GROUP_ID")]
        [StringLength(36)]
        public string RepGroupId { get; set; }
        [Column("REP_CODE")]
        [StringLength(100)]
        public string RepCode { get; set; }
        [Column("REP_NAME")]
        [StringLength(200)]
        public string RepName { get; set; }
        [Column("SECURITY_ENABLE_FLAG")]
        public bool? SecurityEnableFlag { get; set; }
        [Column("MAIN_QUERY_TEXT", TypeName = "LONG")]
        public string MainQueryText { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("USERUPDATED")]
        [StringLength(36)]
        public string Userupdated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
    }
}
