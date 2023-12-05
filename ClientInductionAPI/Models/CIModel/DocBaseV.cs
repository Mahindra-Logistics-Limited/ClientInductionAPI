using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DocBaseV
    {
        [Required]
        [Column("DOC_TYPE_EN_GUID")]
        [StringLength(36)]
        public string DocTypeEnGuid { get; set; }
        [Column("DOCUMENTTYPEMASTERGUID")]
        [StringLength(36)]
        public string Documenttypemasterguid { get; set; }
        [Column("ENTITYMASTERGUID")]
        [StringLength(36)]
        public string Entitymasterguid { get; set; }
        [Column("DOC_TYPE_EN_DESCRIPTION")]
        [StringLength(1000)]
        public string DocTypeEnDescription { get; set; }
        [Column("DOC_TYPE_EN_QUICKACCESSCODE")]
        [StringLength(25)]
        public string DocTypeEnQuickaccesscode { get; set; }
        [Column("DOC_TYPE_EN_COMMENTS")]
        [StringLength(1000)]
        public string DocTypeEnComments { get; set; }
        [Column("DOC_TYPE_EN_DISABLED")]
        public bool? DocTypeEnDisabled { get; set; }
        [Column("DOC_TYPE_EN_ORACLEENTITYNAME")]
        [StringLength(100)]
        public string DocTypeEnOracleentityname { get; set; }
        [Column("DOC_TYPE_EN_ORACLEENTITYID")]
        [StringLength(1000)]
        public string DocTypeEnOracleentityid { get; set; }
        [Column("DOC_TYPE_EN_OBJECTVERSIONNO")]
        public int? DocTypeEnObjectversionno { get; set; }
        [Column("DOC_TYPE_EN_PKGUID")]
        [StringLength(36)]
        public string DocTypeEnPkguid { get; set; }
        [Required]
        [Column("DOC_TYPE_M_NAME")]
        [StringLength(255)]
        public string DocTypeMName { get; set; }
        [Column("DOC_TYPE_M_DESCRIPTION")]
        [StringLength(1000)]
        public string DocTypeMDescription { get; set; }
        [Column("DOC_TYPE_M_QUICKACCESSCODE")]
        [StringLength(25)]
        public string DocTypeMQuickaccesscode { get; set; }
        [Column("DOC_TYPE_M_COMMENTS")]
        [StringLength(1000)]
        public string DocTypeMComments { get; set; }
        [Column("DOC_TYPE_M_DISABLED")]
        public bool? DocTypeMDisabled { get; set; }
        [Column("DOC_TYPE_M_ORACLEENTITYNAME")]
        [StringLength(100)]
        public string DocTypeMOracleentityname { get; set; }
        [Column("DOC_TYPE_M_ORACLEENTITYID")]
        [StringLength(1000)]
        public string DocTypeMOracleentityid { get; set; }
        [Column("DOC_TYPE_M_OBJECTVERSIONNO")]
        public int? DocTypeMObjectversionno { get; set; }
        [Column("DOC_TYPE_M_REGULAREXPRESSION")]
        [StringLength(100)]
        public string DocTypeMRegularexpression { get; set; }
        [Column("DOC_TYPE_M_PKGUID")]
        [StringLength(36)]
        public string DocTypeMPkguid { get; set; }
        [Column("RENEWALDAYS")]
        public int? Renewaldays { get; set; }
        [Column("ESCALATIONDAYS")]
        public int? Escalationdays { get; set; }
        [Required]
        [Column("EN_TYPE_NAME")]
        [StringLength(255)]
        public string EnTypeName { get; set; }
        [Column("EN_TYPE_DESCRIPTION")]
        [StringLength(100)]
        public string EnTypeDescription { get; set; }
        [Column("EN_TYPE_QUICKACCESSCODE")]
        [StringLength(50)]
        public string EnTypeQuickaccesscode { get; set; }
        [Column("EN_TYPE_COMMENTS")]
        [StringLength(100)]
        public string EnTypeComments { get; set; }
        [Column("EN_TYPE_DISABLED")]
        public bool? EnTypeDisabled { get; set; }
        [Column("EN_TYPE_ORACLEENTITYNAME")]
        [StringLength(100)]
        public string EnTypeOracleentityname { get; set; }
        [Column("EN_TYPE_ORACLEENTITYID")]
        [StringLength(1000)]
        public string EnTypeOracleentityid { get; set; }
        [Column("EN_TYPE_OBJECTVERSIONNO")]
        public int? EnTypeObjectversionno { get; set; }
        [Column("EN_TYPE_PKGUID")]
        [StringLength(36)]
        public string EnTypePkguid { get; set; }
    }
}
