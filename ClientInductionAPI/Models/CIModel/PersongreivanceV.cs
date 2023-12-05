using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class PersongreivanceV
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("COMPLAINTID")]
        public int? Complaintid { get; set; }
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
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("RESOLVEDETAILS")]
        [StringLength(1000)]
        public string Resolvedetails { get; set; }
        [Column("NAME")]
        [StringLength(200)]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(1000)]
        public string Description { get; set; }
        [Column("QUICKACCESSCODE")]
        [StringLength(25)]
        public string Quickaccesscode { get; set; }
        [Column("COMMENTS")]
        [StringLength(1000)]
        public string Comments { get; set; }
        [Column("DISABLED")]
        public bool? Disabled { get; set; }
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
        [Column("PERSONID")]
        [StringLength(1000)]
        public string Personid { get; set; }
        [Column("PERS_TITLE")]
        [StringLength(10)]
        public string PersTitle { get; set; }
        [Column("PERS_FNAME")]
        [StringLength(255)]
        public string PersFname { get; set; }
        [Column("PERS_MNAME")]
        [StringLength(255)]
        public string PersMname { get; set; }
        [Column("PERS_LNAME")]
        [StringLength(255)]
        public string PersLname { get; set; }
        [Column("MENTORID")]
        [StringLength(100)]
        public string Mentorid { get; set; }
        [Column("MENTOR_FULL_NAME")]
        public string MentorFullName { get; set; }
        [Column("PHONE_GUID")]
        [StringLength(36)]
        public string PhoneGuid { get; set; }
        [Column("PHONE_TYPE_CODE")]
        [StringLength(25)]
        public string PhoneTypeCode { get; set; }
        [Column("PHONE_TYPE_NAME")]
        [StringLength(255)]
        public string PhoneTypeName { get; set; }
        [Column("PHONE_NO")]
        [StringLength(255)]
        public string PhoneNo { get; set; }
        [Column("PHONE_OBJ_VER_NO")]
        public int? PhoneObjVerNo { get; set; }
        [Column("CAR_GUID")]
        [StringLength(36)]
        public string CarGuid { get; set; }
        [Column("CAR_REGN_NO")]
        [StringLength(255)]
        public string CarRegnNo { get; set; }
        [Column("CAR_SEC_GUID")]
        [StringLength(36)]
        public string CarSecGuid { get; set; }
        [Column("CAR_BRAND_CODE")]
        [StringLength(200)]
        public string CarBrandCode { get; set; }
        [Column("CAR_OP_MODEL_CODE")]
        [StringLength(200)]
        public string CarOpModelCode { get; set; }
    }
}
