using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TEMPLATEPARAMETER")]
    public partial class Templateparameter
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("TEMPLATEMASTERGUID")]
        [StringLength(36)]
        public string Templatemasterguid { get; set; }
        [Column("PARAMETERFIELDID", TypeName = "NUMBER(38)")]
        public decimal? Parameterfieldid { get; set; }
        [Column("DISPLAYNAME")]
        [StringLength(100)]
        public string Displayname { get; set; }
    }
}
