using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TEMPLATEQUERYCORRELATEDCOLUMNS")]
    public partial class Templatequerycorrelatedcolumn
    {
        [Column("QUERYCORRELATIONID")]
        [StringLength(36)]
        public string Querycorrelationid { get; set; }
        [Column("TEMPLATEMAINQUERYID")]
        [StringLength(36)]
        public string Templatemainqueryid { get; set; }
        [Column("TEMPLATESUBQUERYID")]
        [StringLength(36)]
        public string Templatesubqueryid { get; set; }
        [Column("MAINQUERYTEMPLATEENTITYID")]
        [StringLength(36)]
        public string Mainquerytemplateentityid { get; set; }
        [Column("MAINQUERYENTITYCOLUMNID")]
        [StringLength(36)]
        public string Mainqueryentitycolumnid { get; set; }
        [Column("SUBQUERYTEMPLATEENTITYID")]
        [StringLength(36)]
        public string Subquerytemplateentityid { get; set; }
        [Column("SUBQUERYENTITYCOLUMNID")]
        [StringLength(36)]
        public string Subqueryentitycolumnid { get; set; }
    }
}
