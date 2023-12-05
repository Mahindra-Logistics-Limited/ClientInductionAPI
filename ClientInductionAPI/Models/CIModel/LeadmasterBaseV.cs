using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class LeadmasterBaseV
    {
        [Column("LEADMASTERGUID")]
        [StringLength(36)]
        public string Leadmasterguid { get; set; }
        [Required]
        [Column("CONTACTNO")]
        [StringLength(20)]
        public string Contactno { get; set; }
        [Column("LEAD_FULLNAME")]
        [StringLength(160)]
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
        [Required]
        [Column("LEAD_STATUS_ENT_STSGUID")]
        [StringLength(36)]
        public string LeadStatusEntStsguid { get; set; }
        [Column("LEAD_STATUS_ENT_ENTGUID")]
        [StringLength(36)]
        public string LeadStatusEntEntguid { get; set; }
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
        [Required]
        [Column("USERGUID")]
        [StringLength(36)]
        public string Userguid { get; set; }
        [Required]
        [Column("EMAIL")]
        [StringLength(2000)]
        public string Email { get; set; }
        [Column("LOGIN_FULLNAME")]
        public string LoginFullname { get; set; }
        [Column("USER_PKGUID")]
        [StringLength(36)]
        public string UserPkguid { get; set; }
        [Column("USER_ID")]
        [StringLength(2000)]
        public string UserId { get; set; }
        [Column("USER_NAME")]
        [StringLength(2000)]
        public string UserName { get; set; }
        [Column("EMPLOYEE_ID")]
        [StringLength(2000)]
        public string EmployeeId { get; set; }
        [Required]
        [Column("EMAIL_ADDRESS")]
        [StringLength(2000)]
        public string EmailAddress { get; set; }
        [Column("PERSON_ID", TypeName = "NUMBER")]
        public decimal? PersonId { get; set; }
        [Column("FULL_NAME")]
        public string FullName { get; set; }
    }
}
