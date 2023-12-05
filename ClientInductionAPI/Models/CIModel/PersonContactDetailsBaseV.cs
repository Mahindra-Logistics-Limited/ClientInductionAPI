using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class PersonContactDetailsBaseV
    {
        [Required]
        [Column("PERSONCONTACTGUID")]
        [StringLength(36)]
        public string Personcontactguid { get; set; }
        [Required]
        [Column("CONTACTSUBTYPEGUID")]
        [StringLength(36)]
        public string Contactsubtypeguid { get; set; }
        [Required]
        [Column("PERSONMASTERGUID")]
        [StringLength(36)]
        public string Personmasterguid { get; set; }
        [Column("PRIMARYFLAG")]
        public bool? Primaryflag { get; set; }
        [Column("ADDRESSLINE1")]
        [StringLength(255)]
        public string Addressline1 { get; set; }
        [Column("ADDRESSLINE2")]
        [StringLength(255)]
        public string Addressline2 { get; set; }
        [Column("COUNTRYMASTERGUID")]
        [StringLength(36)]
        public string Countrymasterguid { get; set; }
        [Column("STATEMASTERGUID")]
        [StringLength(36)]
        public string Statemasterguid { get; set; }
        [Column("CITYNAME")]
        [StringLength(255)]
        public string Cityname { get; set; }
        [Column("COUNTRYCODEGUID")]
        [StringLength(36)]
        public string Countrycodeguid { get; set; }
        [Column("CONTACTNO")]
        [StringLength(255)]
        public string Contactno { get; set; }
        [Column("EMAILID")]
        [StringLength(255)]
        public string Emailid { get; set; }
        [Column("DISABLED")]
        public bool? Disabled { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Effectiveenddate { get; set; }
        [Column("ORACLEENTITYNAME")]
        [StringLength(1000)]
        public string Oracleentityname { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(1000)]
        public string Oracleentityid { get; set; }
        [Column("OBJECTVERSIONNO")]
        public int? Objectversionno { get; set; }
        [Column("PINCODE")]
        [StringLength(10)]
        public string Pincode { get; set; }
        [Column("PERSONCONTACTPKGUID")]
        [StringLength(36)]
        public string Personcontactpkguid { get; set; }
        [Required]
        [Column("CONTACTTYPEMASTERGUID")]
        [StringLength(36)]
        public string Contacttypemasterguid { get; set; }
        [Required]
        [Column("SUBTYPENAME")]
        [StringLength(255)]
        public string Subtypename { get; set; }
        [Column("SUBTYPEDESCRIPTION")]
        [StringLength(1000)]
        public string Subtypedescription { get; set; }
        [Column("SUBTYPEQUICKACCESSCODE")]
        [StringLength(25)]
        public string Subtypequickaccesscode { get; set; }
        [Column("SUBTYPECOMMENTS")]
        [StringLength(1000)]
        public string Subtypecomments { get; set; }
        [Column("SUBTYPEDISABLED")]
        public bool? Subtypedisabled { get; set; }
        [Column("SUBTYPEORACLEENTITYNAME")]
        [StringLength(100)]
        public string Subtypeoracleentityname { get; set; }
        [Column("SUBTYPEORACLEENTITYID")]
        [StringLength(1000)]
        public string Subtypeoracleentityid { get; set; }
        [Column("SUBTYPEOBJECTVERSIONNO")]
        public int? Subtypeobjectversionno { get; set; }
        [Column("SUBTYPEPKGUID")]
        [StringLength(36)]
        public string Subtypepkguid { get; set; }
        [Required]
        [Column("TYPEMASTERNAME")]
        [StringLength(255)]
        public string Typemastername { get; set; }
        [Column("TYPEMASTERDESCRIPTION")]
        [StringLength(1000)]
        public string Typemasterdescription { get; set; }
        [Column("TYPEMASTERQUICKACCESSCODE")]
        [StringLength(25)]
        public string Typemasterquickaccesscode { get; set; }
        [Column("TYPEMASTERCOMMENTS")]
        [StringLength(1000)]
        public string Typemastercomments { get; set; }
        [Column("TYPEMASTERDISABLED")]
        public bool? Typemasterdisabled { get; set; }
        [Column("TYPEMASTERORACLEENTITYNAME")]
        [StringLength(100)]
        public string Typemasteroracleentityname { get; set; }
        [Column("TYPEMASTERORACLEENTITYID")]
        [StringLength(1000)]
        public string Typemasteroracleentityid { get; set; }
        [Column("TYPEMASTEROBJECTVERSIONNO")]
        public int? Typemasterobjectversionno { get; set; }
        [Column("TYPEMASTERPKGUID")]
        [StringLength(36)]
        public string Typemasterpkguid { get; set; }
    }
}
