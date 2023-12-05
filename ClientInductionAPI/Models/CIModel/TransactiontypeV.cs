using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class TransactiontypeV
    {
        [Required]
        [Column("TRANSACTIONTYPEGUID")]
        [StringLength(36)]
        public string Transactiontypeguid { get; set; }
        [Column("TYPENAME")]
        [StringLength(255)]
        public string Typename { get; set; }
        [Column("TYPEDESCRIPTION")]
        [StringLength(2000)]
        public string Typedescription { get; set; }
        [Column("TYPEQUICKACCESSCODE")]
        [StringLength(60)]
        public string Typequickaccesscode { get; set; }
        [Column("TYPETRANSACTIONCLASSGUID")]
        [StringLength(36)]
        public string Typetransactionclassguid { get; set; }
        [Column("TYPECONTRATRANSTYPEGUID")]
        [StringLength(36)]
        public string Typecontratranstypeguid { get; set; }
        [Column("TYPEADJUSTMENTTRANSTYPEGUID")]
        [StringLength(36)]
        public string Typeadjustmenttranstypeguid { get; set; }
        [Column("TYPEDISABLED")]
        public bool? Typedisabled { get; set; }
        [Column("TYPEORACLEENTITYNAME")]
        [StringLength(1000)]
        public string Typeoracleentityname { get; set; }
        [Column("TYPEORACLEENTITYID")]
        [StringLength(100)]
        public string Typeoracleentityid { get; set; }
        [Column("TYPEORACLEENTITYTYPE")]
        [StringLength(1000)]
        public string Typeoracleentitytype { get; set; }
        [Column("TYPEOBJECTVERSIONNO")]
        public byte? Typeobjectversionno { get; set; }
        [Column("TYPETDSTRXTYPEGUID")]
        [StringLength(36)]
        public string Typetdstrxtypeguid { get; set; }
        [Column("TYPEPKGUID")]
        [StringLength(36)]
        public string Typepkguid { get; set; }
        [Column("CLASSNAME")]
        [StringLength(255)]
        public string Classname { get; set; }
        [Column("CLASSDESCRIPTION")]
        [StringLength(2000)]
        public string Classdescription { get; set; }
        [Column("CLASSQUICKACCESSCODE")]
        [StringLength(25)]
        public string Classquickaccesscode { get; set; }
        [Column("CLASSCOMMENTS")]
        [StringLength(2000)]
        public string Classcomments { get; set; }
        [Column("CLASSDISABLED")]
        public bool? Classdisabled { get; set; }
        [Column("CLASSORACLEENTITYNAME")]
        [StringLength(100)]
        public string Classoracleentityname { get; set; }
        [Column("CLASSORACLEENTITYID")]
        [StringLength(100)]
        public string Classoracleentityid { get; set; }
        [Column("CLASSORACLEENTITYTYPE")]
        [StringLength(30)]
        public string Classoracleentitytype { get; set; }
        [Column("CLASSOBJECTVERSIONNO", TypeName = "NUMBER")]
        public decimal? Classobjectversionno { get; set; }
        [Column("CLASSSIGNINDICATOR")]
        [StringLength(36)]
        public string Classsignindicator { get; set; }
        [Column("CLASSPKGUID")]
        [StringLength(36)]
        public string Classpkguid { get; set; }
    }
}
