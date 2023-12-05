using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class LeadBaseV
    {
        [Column("LEADMASTERGUID")]
        [StringLength(36)]
        public string Leadmasterguid { get; set; }
        [Required]
        [Column("CONTACTNO")]
        [StringLength(20)]
        public string Contactno { get; set; }
        [Column("LEAD_FULLNAME")]
        [StringLength(163)]
        public string LeadFullname { get; set; }
        [Column("LEADSOURCEGUID")]
        [StringLength(36)]
        public string Leadsourceguid { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("PROBABILITY")]
        [StringLength(20)]
        public string Probability { get; set; }
        [Column("BIOMETRICID")]
        [StringLength(255)]
        public string Biometricid { get; set; }
        [Column("PERSONGUID")]
        [StringLength(36)]
        public string Personguid { get; set; }
        [Column("SALESREPPERSONID")]
        [StringLength(255)]
        public string Salesreppersonid { get; set; }
        [Column("BACKOFFICEPERSONID")]
        [StringLength(255)]
        public string Backofficepersonid { get; set; }
        [Column("CONTACTSUBTYPEGUID")]
        [StringLength(36)]
        public string Contactsubtypeguid { get; set; }
        [Column("COUNTRYCODEGUID")]
        [StringLength(36)]
        public string Countrycodeguid { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("GENDER")]
        [StringLength(36)]
        public string Gender { get; set; }
        [Column("LEBRANCH_GUID")]
        [StringLength(36)]
        public string LebranchGuid { get; set; }
        [Required]
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Required]
        [Column("LEAD_STATUS_ENT_STSGUID")]
        [StringLength(36)]
        public string LeadStatusEntStsguid { get; set; }
        [Column("STATUS_ENT_OBJ_VER_NO")]
        public int? StatusEntObjVerNo { get; set; }
        [Column("LEAD_STATUS_CODE")]
        [StringLength(25)]
        public string LeadStatusCode { get; set; }
        [Column("LEAD_STATUS_NAME")]
        [StringLength(200)]
        public string LeadStatusName { get; set; }
        [Column("LEAD_STATUS_DESC")]
        [StringLength(1000)]
        public string LeadStatusDesc { get; set; }
        [Column("LEAD_ENTITY_CODE")]
        [StringLength(50)]
        public string LeadEntityCode { get; set; }
        [Column("SOURCE_NAME")]
        [StringLength(255)]
        public string SourceName { get; set; }
        [Column("SOURCE_QUICKACCESSCODE")]
        [StringLength(25)]
        public string SourceQuickaccesscode { get; set; }
        [Column("SOURCE_DESCRIPTION")]
        [StringLength(255)]
        public string SourceDescription { get; set; }
        [Column("SOURCE_COMMENTS")]
        [StringLength(255)]
        public string SourceComments { get; set; }
        [Column("SOURCE_ORACLEENTITYNAME")]
        [StringLength(100)]
        public string SourceOracleentityname { get; set; }
        [Column("SOURCE_ORACLEENTITYID")]
        [StringLength(1000)]
        public string SourceOracleentityid { get; set; }
        [Column("SOURCE_PKGUID")]
        [StringLength(36)]
        public string SourcePkguid { get; set; }
        [Column("PERSON_TYPE")]
        [StringLength(8)]
        public string PersonType { get; set; }
        [Column("BACKOFFICE_PERSON_ID")]
        [StringLength(2000)]
        public string BackofficePersonId1 { get; set; }
        [Column("BACKOFFICE_EMPLOYEE_NUMBER")]
        [StringLength(2000)]
        public string BackofficeEmployeeNumber { get; set; }
        [Column("NPW_NUMBER")]
        [StringLength(2000)]
        public string NpwNumber { get; set; }
        [Column("BACKOFFICE_PERSON_NAME")]
        public string BackofficePersonName { get; set; }
        [Column("POSITION_NAME")]
        [StringLength(2000)]
        public string PositionName { get; set; }
    }
}
