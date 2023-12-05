using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class PersonlistV
    {
        [Column("PERS_GUID")]
        [StringLength(36)]
        public string PersGuid { get; set; }
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
        [Column("PERS_GENDER")]
        [StringLength(10)]
        public string PersGender { get; set; }
        [Column("PERS_DOB", TypeName = "DATE")]
        public DateTime? PersDob { get; set; }
        [Column("PERS_BIOID")]
        [StringLength(255)]
        public string PersBioid { get; set; }
        [Column("PERS_DSEFLAG")]
        public bool? PersDseflag { get; set; }
        [Column("PERS_SPFLAG")]
        public bool? PersSpflag { get; set; }
        [Column("PERS_DRIVERFLAG")]
        public bool? PersDriverflag { get; set; }
        [Column("PERS_STATUS_CODE")]
        [StringLength(25)]
        public string PersStatusCode { get; set; }
        [Column("PERS_OBJ_VER_NO")]
        public int? PersObjVerNo { get; set; }
        [Column("PERS_DISABLED")]
        public bool? PersDisabled { get; set; }
        [Column("PERS_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? PersEffectivestartdate { get; set; }
        [Column("PERS_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? PersEffectiveenddate { get; set; }
        [Column("STATUS_ENT_GUID")]
        [StringLength(36)]
        public string StatusEntGuid { get; set; }
        [Column("STATUS_ENT_STSGUID")]
        [StringLength(36)]
        public string StatusEntStsguid { get; set; }
        [Column("STATUS_ENT_ENTGUID")]
        [StringLength(36)]
        public string StatusEntEntguid { get; set; }
        [Column("STATUS_ENT_OBJ_VER_NO")]
        public int? StatusEntObjVerNo { get; set; }
        [Column("STATUS_NAME")]
        [StringLength(200)]
        public string StatusName { get; set; }
        [Column("STATUS_DESC")]
        [StringLength(1000)]
        public string StatusDesc { get; set; }
        [Column("ENTITY_CODE")]
        [StringLength(50)]
        public string EntityCode { get; set; }
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
        [Column("DRIVER_STATUS")]
        [StringLength(25)]
        public string DriverStatus { get; set; }
        [Column("DRIVER_STATUS_NAME")]
        [StringLength(200)]
        public string DriverStatusName { get; set; }
        [Column("SP_STATUS")]
        [StringLength(25)]
        public string SpStatus { get; set; }
        [Column("SP_STATUS_NAME")]
        [StringLength(200)]
        public string SpStatusName { get; set; }
    }
}
