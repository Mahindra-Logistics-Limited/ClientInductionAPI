using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DevicemodelBaseV
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
        [Column("DEVICETYPEMASTERGUID")]
        [StringLength(36)]
        public string Devicetypemasterguid { get; set; }
        [Column("MAKEMASTERPKGUID")]
        [StringLength(36)]
        public string Makemasterpkguid { get; set; }
        [Required]
        [Column("MODELGUID")]
        [StringLength(36)]
        public string Modelguid { get; set; }
        [Column("MODELNAME")]
        [StringLength(255)]
        public string Modelname { get; set; }
        [Column("MODELDESCRIPTION")]
        [StringLength(2000)]
        public string Modeldescription { get; set; }
        [Column("MODELQUICKACCESSCODE")]
        [StringLength(25)]
        public string Modelquickaccesscode { get; set; }
        [Column("MODELCOMMENTS")]
        [StringLength(2000)]
        public string Modelcomments { get; set; }
        [Column("MODELDISABLED")]
        public bool? Modeldisabled { get; set; }
        [Column("MODELORACLEENTITYNAME")]
        [StringLength(100)]
        public string Modeloracleentityname { get; set; }
        [Column("MODELORACLEENTITYID")]
        [StringLength(1000)]
        public string Modeloracleentityid { get; set; }
        [Column("MODELOBJECTVERSIONNO")]
        public int? Modelobjectversionno { get; set; }
        [Column("MODELPKGUID")]
        [StringLength(36)]
        public string Modelpkguid { get; set; }
    }
}
