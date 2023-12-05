using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DevicemakemasterBaseV
    {
        [Required]
        [Column("MAKEMASTERGUID")]
        [StringLength(36)]
        public string Makemasterguid { get; set; }
        [Required]
        [Column("MAKEMASTERNAME")]
        [StringLength(255)]
        public string Makemastername { get; set; }
        [Column("MAKEMASTERDESCRIPTION")]
        [StringLength(2000)]
        public string Makemasterdescription { get; set; }
        [Column("MAKEMASTERQUICKACCESSCODE")]
        [StringLength(25)]
        public string Makemasterquickaccesscode { get; set; }
        [Column("MAKEMASTERCOMMENTS")]
        [StringLength(2000)]
        public string Makemastercomments { get; set; }
        [Column("MAKEMASTERDISABLED")]
        public bool? Makemasterdisabled { get; set; }
        [Column("MAKEMASTERORACLEENTITYNAME")]
        [StringLength(100)]
        public string Makemasteroracleentityname { get; set; }
        [Column("MAKEMASTERORACLEENTITYID")]
        [StringLength(1000)]
        public string Makemasteroracleentityid { get; set; }
        [Column("MAKEMASTEROBJECTVERSIONNO")]
        public int? Makemasterobjectversionno { get; set; }
        [Column("MAKEMASTERPKGUID")]
        [StringLength(36)]
        public string Makemasterpkguid { get; set; }
        [Required]
        [Column("DEVICETYPEMASTERGUID")]
        [StringLength(36)]
        public string Devicetypemasterguid { get; set; }
        [Required]
        [Column("DEVICETYPENAME")]
        [StringLength(255)]
        public string Devicetypename { get; set; }
        [Column("DEVICETYPEDESCRIPTION")]
        [StringLength(2000)]
        public string Devicetypedescription { get; set; }
        [Required]
        [Column("DEVICETYPEQUICKACCESSCODE")]
        [StringLength(25)]
        public string Devicetypequickaccesscode { get; set; }
        [Column("DEVICETYPECOMMENTS")]
        [StringLength(2000)]
        public string Devicetypecomments { get; set; }
        [Column("DEVICETYPEDISABLED")]
        public bool? Devicetypedisabled { get; set; }
        [Column("DEVICETYPEORACLEENTITYNAME")]
        [StringLength(100)]
        public string Devicetypeoracleentityname { get; set; }
        [Column("DEVICETYPEORACLEENTITYID")]
        [StringLength(1000)]
        public string Devicetypeoracleentityid { get; set; }
        [Column("DEVICETYPEOBJECTVERSIONNO")]
        public int? Devicetypeobjectversionno { get; set; }
        [Column("DEVICETYPEREGULAREXPRESSION")]
        [StringLength(100)]
        public string Devicetyperegularexpression { get; set; }
        [Column("DEVICETYPEPKGUID")]
        [StringLength(36)]
        public string Devicetypepkguid { get; set; }
    }
}
