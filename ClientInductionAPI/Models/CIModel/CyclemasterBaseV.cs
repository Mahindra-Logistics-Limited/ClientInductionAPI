using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CyclemasterBaseV
    {
        [Required]
        [Column("CYCLEMASTERGUID")]
        [StringLength(36)]
        public string Cyclemasterguid { get; set; }
        [Column("CYCLEMASTERNAME")]
        [StringLength(255)]
        public string Cyclemastername { get; set; }
        [Column("CYCLEMASTERDESCRIPTION")]
        [StringLength(2000)]
        public string Cyclemasterdescription { get; set; }
        [Column("CYCLEMASTERQUICKACCESSCODE")]
        [StringLength(25)]
        public string Cyclemasterquickaccesscode { get; set; }
        [Column("CYCLEMASTERCOMMENTS")]
        [StringLength(2000)]
        public string Cyclemastercomments { get; set; }
        [Column("CYCLEMASTERDISABLED")]
        public bool? Cyclemasterdisabled { get; set; }
        [Column("CYCLEMASTERORACLEENTITYNAME")]
        [StringLength(1000)]
        public string Cyclemasteroracleentityname { get; set; }
        [Column("CYCLEMASTERORACLEENTITYID")]
        [StringLength(1000)]
        public string Cyclemasteroracleentityid { get; set; }
        [Column("CYCLEMASTERORACLEENTITYTYPE")]
        [StringLength(1000)]
        public string Cyclemasteroracleentitytype { get; set; }
        [Column("CYCLEMASTEROBJECTVERSIONNO")]
        [StringLength(100)]
        public string Cyclemasterobjectversionno { get; set; }
        [Column("CYCLEMASTERCYCLEDURATION", TypeName = "NUMBER")]
        public decimal? Cyclemastercycleduration { get; set; }
        [Column("CYCLEMASTERPKGUID")]
        [StringLength(36)]
        public string Cyclemasterpkguid { get; set; }
        [Required]
        [Column("CYCLEDAYGUID")]
        [StringLength(36)]
        public string Cycledayguid { get; set; }
        [Column("CYCLEDAYNAME")]
        [StringLength(255)]
        public string Cycledayname { get; set; }
        [Column("CYCLEDAYDESCRIPTION")]
        [StringLength(2000)]
        public string Cycledaydescription { get; set; }
        [Column("CYCLEDAYQUICKACCESSCODE")]
        [StringLength(25)]
        public string Cycledayquickaccesscode { get; set; }
        [Column("CYCLEDAYCOMMENTS")]
        [StringLength(2000)]
        public string Cycledaycomments { get; set; }
        [Column("CYCLEDAYDISABLED")]
        public bool? Cycledaydisabled { get; set; }
        [Column("CYCLEDAYORACLEENTITYNAME")]
        [StringLength(1000)]
        public string Cycledayoracleentityname { get; set; }
        [Column("CYCLEDAYORACLEENTITYID")]
        [StringLength(1000)]
        public string Cycledayoracleentityid { get; set; }
        [Column("CYCLEDAYORACLEENTITYTYPE")]
        [StringLength(1000)]
        public string Cycledayoracleentitytype { get; set; }
        [Column("CYCLEDAYOBJECTVERSIONNO")]
        [StringLength(100)]
        public string Cycledayobjectversionno { get; set; }
        [Column("CYCLEDAYPKGUID")]
        [StringLength(36)]
        public string Cycledaypkguid { get; set; }
    }
}
