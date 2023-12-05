using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class TemplateexecutionV
    {
        [Column("TEMPLATEEXECUTIONSGUID")]
        [StringLength(36)]
        public string Templateexecutionsguid { get; set; }
        [Column("SEARCHTEMPLATEMASTERGUID")]
        [StringLength(36)]
        public string Searchtemplatemasterguid { get; set; }
        [Column("TEMPLATEEXECUTIONRESULT")]
        [StringLength(100)]
        public string Templateexecutionresult { get; set; }
        [Column("TEMPLATEEXECUTIONMESSAGE")]
        [StringLength(1000)]
        public string Templateexecutionmessage { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("TEMPLATENAME")]
        [StringLength(100)]
        public string Templatename { get; set; }
        [Required]
        [Column("LEBRANCH_GUID")]
        [StringLength(36)]
        public string LebranchGuid { get; set; }
        [Column("SEC_QUICKACCESSCODE")]
        [StringLength(200)]
        public string SecQuickaccesscode { get; set; }
    }
}
