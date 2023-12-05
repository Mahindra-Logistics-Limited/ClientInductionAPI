using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class AnswersBaseV
    {
        [Column("ANSWERTYPEMAPPINGGUID")]
        [StringLength(36)]
        public string Answertypemappingguid { get; set; }
        [Required]
        [Column("ANSWERTYPEMASTERGUID")]
        [StringLength(36)]
        public string Answertypemasterguid { get; set; }
        [Required]
        [Column("ANSWERMASTERGUID")]
        [StringLength(36)]
        public string Answermasterguid { get; set; }
        [Column("ANSWERSERIALNUMBER")]
        public short? Answerserialnumber { get; set; }
        [Column("MAPPINGDESCRIPTION")]
        [StringLength(2000)]
        public string Mappingdescription { get; set; }
        [Column("MAPPINGQUICKACCESSCODE")]
        [StringLength(25)]
        public string Mappingquickaccesscode { get; set; }
        [Column("MAPPINGCOMMENTS")]
        [StringLength(2000)]
        public string Mappingcomments { get; set; }
        [Column("MAPPINGDISABLED")]
        public bool? Mappingdisabled { get; set; }
        [Column("MAPPINGORACLEENTITYNAME")]
        [StringLength(1000)]
        public string Mappingoracleentityname { get; set; }
        [Column("MAPPINGORACLEENTITYID")]
        [StringLength(1000)]
        public string Mappingoracleentityid { get; set; }
        [Column("MAPPINGOBJECTVERSIONNO")]
        public byte? Mappingobjectversionno { get; set; }
        [Column("MAPPINGPKGUID")]
        [StringLength(36)]
        public string Mappingpkguid { get; set; }
        [Required]
        [Column("ANSWERTYPENAME")]
        [StringLength(255)]
        public string Answertypename { get; set; }
        [Column("ANSWERTYPEDESCRIPTION")]
        [StringLength(2000)]
        public string Answertypedescription { get; set; }
        [Required]
        [Column("ANSWERTYPEQUICKACCESSCODE")]
        [StringLength(25)]
        public string Answertypequickaccesscode { get; set; }
        [Column("ANSWERTYPECOMMENTS")]
        [StringLength(2000)]
        public string Answertypecomments { get; set; }
        [Column("ANSWERTYPEDISABLED")]
        public bool? Answertypedisabled { get; set; }
        [Column("ANSWERTYPEORACLEENTITYNAME")]
        [StringLength(1000)]
        public string Answertypeoracleentityname { get; set; }
        [Column("ANSWERTYPEORACLEENTITYID")]
        [StringLength(1000)]
        public string Answertypeoracleentityid { get; set; }
        [Column("ANSWERTYPEOBJECTVERSIONNO")]
        public byte? Answertypeobjectversionno { get; set; }
        [Column("ANSWERTYPEPKGUID")]
        [StringLength(36)]
        public string Answertypepkguid { get; set; }
        [Required]
        [Column("ANSWERNAME")]
        [StringLength(255)]
        public string Answername { get; set; }
        [Column("ANSWERDESCRIPTION")]
        [StringLength(2000)]
        public string Answerdescription { get; set; }
        [Required]
        [Column("ANSWERQUICKACCESSCODE")]
        [StringLength(25)]
        public string Answerquickaccesscode { get; set; }
        [Column("ANSWERCOMMENTS")]
        [StringLength(2000)]
        public string Answercomments { get; set; }
        [Column("ANSWERDISABLED")]
        public bool? Answerdisabled { get; set; }
        [Column("ANSWERORACLEENTITYNAME")]
        [StringLength(1000)]
        public string Answeroracleentityname { get; set; }
        [Column("ANSWERORACLEENTITYID")]
        [StringLength(1000)]
        public string Answeroracleentityid { get; set; }
        [Column("ANSWEROBJECTVERSIONNO")]
        public byte? Answerobjectversionno { get; set; }
        [Column("ANSWERPKGUID")]
        [StringLength(36)]
        public string Answerpkguid { get; set; }
        [Column("QUESTIONBANKMASTERGUID")]
        [StringLength(36)]
        public string Questionbankmasterguid { get; set; }
        [Column("QUESTIONBANKMASTERNAME")]
        [StringLength(255)]
        public string Questionbankmastername { get; set; }
        [Required]
        [Column("QUESTIONBANKCATEGORYMASTERGUID")]
        [StringLength(36)]
        public string Questionbankcategorymasterguid { get; set; }
        [Required]
        [Column("INSPECTIONTYPEMASTERGUID")]
        [StringLength(36)]
        public string Inspectiontypemasterguid { get; set; }
        [Column("DEFAULTANSWERMASTERGUID")]
        [StringLength(36)]
        public string Defaultanswermasterguid { get; set; }
        [Column("QUESTIONBANKDESCRIPTION")]
        [StringLength(2000)]
        public string Questionbankdescription { get; set; }
        [Column("QUESTIONBANKQUICKACCESSCODE")]
        [StringLength(25)]
        public string Questionbankquickaccesscode { get; set; }
        [Column("QUESTIONBANKCOMMENTS")]
        [StringLength(2000)]
        public string Questionbankcomments { get; set; }
        [Column("QUESTIONBANKDISABLED")]
        public bool? Questionbankdisabled { get; set; }
        [Column("QUESTIONBANKORACLEENTITYNAME")]
        [StringLength(1000)]
        public string Questionbankoracleentityname { get; set; }
        [Column("QUESTIONBANKORACLEENTITYID")]
        [StringLength(1000)]
        public string Questionbankoracleentityid { get; set; }
        [Column("QUESTIONBANKOBJECTVERSIONNO")]
        public byte? Questionbankobjectversionno { get; set; }
        [Column("QUESTIONBANKPKGUID")]
        [StringLength(36)]
        public string Questionbankpkguid { get; set; }
        [Required]
        [Column("QBANK_CAT_NAME")]
        [StringLength(255)]
        public string QbankCatName { get; set; }
        [Column("QBANK_CAT_DESCRIPTION")]
        [StringLength(2000)]
        public string QbankCatDescription { get; set; }
        [Column("QBANK_CAT_QUICKACCESSCODE")]
        [StringLength(25)]
        public string QbankCatQuickaccesscode { get; set; }
        [Column("QBANK_CAT_COMMENTS")]
        [StringLength(2000)]
        public string QbankCatComments { get; set; }
        [Column("QBANK_CAT_DISABLED")]
        public bool? QbankCatDisabled { get; set; }
        [Column("QBANK_CAT_ORACLEENTITYNAME")]
        [StringLength(1000)]
        public string QbankCatOracleentityname { get; set; }
        [Column("QBANK_CAT_ORACLEENTITYID")]
        [StringLength(1000)]
        public string QbankCatOracleentityid { get; set; }
        [Column("QBANK_CAT_OBJECTVERSIONNO")]
        public byte? QbankCatObjectversionno { get; set; }
        [Column("QBANK_CAT_PKGUID")]
        [StringLength(36)]
        public string QbankCatPkguid { get; set; }
        [Required]
        [Column("INSPECTIONTYPENAME")]
        [StringLength(255)]
        public string Inspectiontypename { get; set; }
        [Column("INSPECTIONTYPEDESCRIPTION")]
        [StringLength(2000)]
        public string Inspectiontypedescription { get; set; }
        [Column("INSPECTIONTYPEQUICKACCESSCODE")]
        [StringLength(25)]
        public string Inspectiontypequickaccesscode { get; set; }
        [Column("INSPECTIONTYPECOMMENTS")]
        [StringLength(2000)]
        public string Inspectiontypecomments { get; set; }
        [Column("INSPECTIONTYPEDISABLED")]
        public bool? Inspectiontypedisabled { get; set; }
        [Column("INSPECTIONTYPEORACLEENTITYNAME")]
        [StringLength(1000)]
        public string Inspectiontypeoracleentityname { get; set; }
        [Column("INSPECTIONTYPEORACLEENTITYID")]
        [StringLength(1000)]
        public string Inspectiontypeoracleentityid { get; set; }
        [Column("INSPECTIONTYPEOBJECTVERSIONNO")]
        public byte? Inspectiontypeobjectversionno { get; set; }
        [Column("INSPECTIONTYPEPKGUID")]
        [StringLength(36)]
        public string Inspectiontypepkguid { get; set; }
    }
}
