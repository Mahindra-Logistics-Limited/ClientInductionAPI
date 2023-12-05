using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("PERSONGREIVANCE")]
    public partial class Persongreivance
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("COMPLAINTID")]
        public int? Complaintid { get; set; }
        [Column("GREIVANCESCATEGORYGUID")]
        [StringLength(36)]
        public string Greivancescategoryguid { get; set; }
        [Column("COMPLAINTDETAILS")]
        [StringLength(100)]
        public string Complaintdetails { get; set; }
        [Column("PERSONGUID")]
        [StringLength(36)]
        public string Personguid { get; set; }
        [Column("ASSINGEDTO", TypeName = "NUMBER")]
        public decimal? Assingedto { get; set; }
        [Column("COMPLAINTDATE", TypeName = "DATE")]
        public DateTime? Complaintdate { get; set; }
        [Column("CLOSERDATE", TypeName = "DATE")]
        public DateTime? Closerdate { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("USERUPDATED")]
        [StringLength(36)]
        public string Userupdated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("USERDELETED")]
        [StringLength(36)]
        public string Userdeleted { get; set; }
        [Column("DATEDELETED", TypeName = "DATE")]
        public DateTime? Datedeleted { get; set; }
        [Column("USERARCHIVED")]
        [StringLength(36)]
        public string Userarchived { get; set; }
        [Column("DATEARCHIVED", TypeName = "DATE")]
        public DateTime? Datearchived { get; set; }
        [Column("ORACLEENTITYNAME")]
        [StringLength(100)]
        public string Oracleentityname { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(1000)]
        public string Oracleentityid { get; set; }
        [Column("OBJECTVERSIONNO")]
        public int? Objectversionno { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("CAR_GUID")]
        [StringLength(36)]
        public string CarGuid { get; set; }
        [Column("USERCRTOBJECTID")]
        [StringLength(100)]
        public string Usercrtobjectid { get; set; }
        [Column("CAMPAIGNID", TypeName = "NUMBER")]
        public decimal? Campaignid { get; set; }
        [Column("CRM_PUSH_GENERATED_TIME")]
        [StringLength(200)]
        public string CrmPushGeneratedTime { get; set; }
        [Column("SESSIONID")]
        [StringLength(100)]
        public string Sessionid { get; set; }
        [Column("QUEUEID", TypeName = "NUMBER")]
        public decimal? Queueid { get; set; }
        [Column("DSTPHONE")]
        [StringLength(100)]
        public string Dstphone { get; set; }
        [Column("LOCATION")]
        [StringLength(100)]
        public string Location { get; set; }
        [Column("USERID")]
        [StringLength(100)]
        public string Userid { get; set; }
        [Column("QUEUENAME")]
        [StringLength(50)]
        public string Queuename { get; set; }
        [Column("CRTOBJECTID")]
        [StringLength(50)]
        public string Crtobjectid { get; set; }
        [Column("CITY")]
        [StringLength(50)]
        public string City { get; set; }
        [Column("PHONE")]
        [StringLength(20)]
        public string Phone { get; set; }
        [Column("RESOLVEDETAILS")]
        [StringLength(1000)]
        public string Resolvedetails { get; set; }
    }
}
