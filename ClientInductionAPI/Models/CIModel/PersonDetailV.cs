using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class PersonDetailV
    {
        [Required]
        [Column("PERS_GUID")]
        [StringLength(36)]
        public string PersGuid { get; set; }
        [Required]
        [Column("PERSONID")]
        [StringLength(1000)]
        public string Personid { get; set; }
        [Required]
        [Column("PERS_TITLE")]
        [StringLength(10)]
        public string PersTitle { get; set; }
        [Required]
        [Column("PERS_FNAME")]
        [StringLength(255)]
        public string PersFname { get; set; }
        [Column("PERS_MNAME")]
        [StringLength(255)]
        public string PersMname { get; set; }
        [Required]
        [Column("PERS_LNAME")]
        [StringLength(255)]
        public string PersLname { get; set; }
        [Column("PERS_GENDER")]
        [StringLength(10)]
        public string PersGender { get; set; }
        [Column("PERS_DOB", TypeName = "DATE")]
        public DateTime PersDob { get; set; }
        [Required]
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
        [Required]
        [Column("ADDR_TYPE_NAME")]
        [StringLength(255)]
        public string AddrTypeName { get; set; }
        [Column("ADDR_LINE1")]
        [StringLength(255)]
        public string AddrLine1 { get; set; }
        [Column("ADDR_LINE2")]
        [StringLength(255)]
        public string AddrLine2 { get; set; }
        [Column("COUNTRY")]
        [StringLength(200)]
        public string Country { get; set; }
        [Column("STATE")]
        [StringLength(255)]
        public string State { get; set; }
        [Required]
        [Column("PHONE_GUID")]
        [StringLength(36)]
        public string PhoneGuid { get; set; }
        [Required]
        [Column("PHONE_PERS_GUID")]
        [StringLength(36)]
        public string PhonePersGuid { get; set; }
        [Column("PHONE_TYPE_CODE")]
        [StringLength(25)]
        public string PhoneTypeCode { get; set; }
        [Required]
        [Column("PHONE_TYPE_NAME")]
        [StringLength(255)]
        public string PhoneTypeName { get; set; }
        [Column("PHONE_NO")]
        [StringLength(255)]
        public string PhoneNo { get; set; }
    }
}
