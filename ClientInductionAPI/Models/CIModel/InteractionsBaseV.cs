using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class InteractionsBaseV
    {
        [Column("INTERACTIONGUID")]
        [StringLength(36)]
        public string Interactionguid { get; set; }
        [Required]
        [Column("INTERACTIONTYPE")]
        [StringLength(255)]
        public string Interactiontype { get; set; }
        [Column("INTERACTIONDATETIME", TypeName = "DATE")]
        public DateTime Interactiondatetime { get; set; }
        [Column("INTERACTIONREMARKS")]
        [StringLength(255)]
        public string Interactionremarks { get; set; }
        [Required]
        [Column("INTERACTIONRESULT")]
        [StringLength(20)]
        public string Interactionresult { get; set; }
        [Required]
        [Column("LEADMASTERGUID")]
        [StringLength(36)]
        public string Leadmasterguid { get; set; }
        [Column("INTERACTIONORACLEENTITYNAME")]
        [StringLength(100)]
        public string Interactionoracleentityname { get; set; }
        [Column("INTERACTIONORACLEENTITYID")]
        [StringLength(1000)]
        public string Interactionoracleentityid { get; set; }
        [Column("INTERACTIONOBJECTVERSIONNO")]
        public byte? Interactionobjectversionno { get; set; }
        [Column("INTERACTIONPKGUID")]
        [StringLength(36)]
        public string Interactionpkguid { get; set; }
        [Required]
        [Column("LEADCONTACTNO")]
        [StringLength(20)]
        public string Leadcontactno { get; set; }
        [Column("LEADTITLE")]
        [StringLength(10)]
        public string Leadtitle { get; set; }
        [Column("LEADFIRSTNAME")]
        [StringLength(50)]
        public string Leadfirstname { get; set; }
        [Column("LEADMIDDLENAME")]
        [StringLength(50)]
        public string Leadmiddlename { get; set; }
        [Column("LEADLASTNAME")]
        [StringLength(50)]
        public string Leadlastname { get; set; }
        [Column("LEADSOURCEGUID")]
        [StringLength(36)]
        public string Leadsourceguid { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("PROBABILITY")]
        [StringLength(20)]
        public string Probability { get; set; }
        [Column("LEADBIOMETRICID")]
        [StringLength(255)]
        public string Leadbiometricid { get; set; }
        [Column("PERSONGUID")]
        [StringLength(36)]
        public string Personguid { get; set; }
        [Column("SALESREPPERSONID")]
        [StringLength(255)]
        public string Salesreppersonid { get; set; }
        [Column("BACKOFFICEPERSONID")]
        [StringLength(255)]
        public string Backofficepersonid { get; set; }
        [Column("LEADEFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime Leadeffectivestartdate { get; set; }
        [Column("LEADEFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime Leadeffectiveenddate { get; set; }
        [Required]
        [Column("LEADUSERCREATED")]
        [StringLength(36)]
        public string Leadusercreated { get; set; }
        [Column("LEADORACLEENTITYNAME")]
        [StringLength(100)]
        public string Leadoracleentityname { get; set; }
        [Column("LEADORACLEENTITYID")]
        [StringLength(1000)]
        public string Leadoracleentityid { get; set; }
        [Column("LEADOBJECTVERSIONNO")]
        public byte? Leadobjectversionno { get; set; }
        [Column("CONTACTSUBTYPEGUID")]
        [StringLength(36)]
        public string Contactsubtypeguid { get; set; }
        [Column("LEADCOUNTRYCODEGUID")]
        [StringLength(36)]
        public string Leadcountrycodeguid { get; set; }
        [Column("LEADPKGUID")]
        [StringLength(36)]
        public string Leadpkguid { get; set; }
        [Required]
        [Column("USEREMAIL")]
        [StringLength(2000)]
        public string Useremail { get; set; }
        [Required]
        [Column("USERFIRSTNAME")]
        [StringLength(2000)]
        public string Userfirstname { get; set; }
        [Required]
        [Column("USERLASTNAME")]
        [StringLength(2000)]
        public string Userlastname { get; set; }
        [Required]
        [Column("USERCONTACTNUMBER")]
        [StringLength(2000)]
        public string Usercontactnumber { get; set; }
        [Required]
        [Column("USERALLOWDOMAINLOGIN")]
        [StringLength(1)]
        public string Userallowdomainlogin { get; set; }
        [Required]
        [Column("USERDOMAINLOGINNAME")]
        [StringLength(2000)]
        public string Userdomainloginname { get; set; }
        [Column("USEREFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime Usereffectivestartdate { get; set; }
        [Column("USEREFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime Usereffectiveenddate { get; set; }
        [Column("USERLOGINATTEMPTS")]
        [StringLength(20)]
        public string Userloginattempts { get; set; }
        [Column("USERCULTURE")]
        [StringLength(2000)]
        public string Userculture { get; set; }
        [Column("USERTHEME")]
        [StringLength(2000)]
        public string Usertheme { get; set; }
        [Column("USERDISABLED")]
        public bool? Userdisabled { get; set; }
        [Required]
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("USERLASTLOGIN", TypeName = "DATE")]
        public DateTime? Userlastlogin { get; set; }
        [Column("USERFAILEDLOGINATTEMPTS")]
        [StringLength(20)]
        public string Userfailedloginattempts { get; set; }
        [Column("USERORACLEENTITYNAME")]
        [StringLength(100)]
        public string Useroracleentityname { get; set; }
        [Column("USERORACLEENTITYID")]
        [StringLength(1000)]
        public string Useroracleentityid { get; set; }
        [Column("USERORACLEUSERID")]
        [StringLength(30)]
        public string Useroracleuserid { get; set; }
        [Column("USEROBJECTVERSIONNO")]
        public int? Userobjectversionno { get; set; }
        [Column("USERPKGUID")]
        [StringLength(36)]
        public string Userpkguid { get; set; }
        [Required]
        [Column("STATUS_ENT_STSGUID")]
        [StringLength(36)]
        public string StatusEntStsguid { get; set; }
        [Column("STATUS_ENT_ENTGUID")]
        [StringLength(36)]
        public string StatusEntEntguid { get; set; }
        [Column("STATUS_ENT_OBJ_VER_NO")]
        public int? StatusEntObjVerNo { get; set; }
        [Column("STATUS_CODE")]
        [StringLength(25)]
        public string StatusCode { get; set; }
        [Column("STATUS_NAME")]
        [StringLength(200)]
        public string StatusName { get; set; }
        [Column("STATUS_DESC")]
        [StringLength(1000)]
        public string StatusDesc { get; set; }
        [Column("ENTITY_CODE")]
        [StringLength(50)]
        public string EntityCode { get; set; }
    }
}
