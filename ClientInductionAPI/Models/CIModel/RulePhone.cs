using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class RulePhone
    {
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
        [Column("PHONE_OBJ_VER_NO")]
        public int? PhoneObjVerNo { get; set; }
        [Column("PRIMARYFLAG")]
        public bool? Primaryflag { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Effectiveenddate { get; set; }
        [Required]
        [Column("PERSONID")]
        [StringLength(1000)]
        public string Personid { get; set; }
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
        [Column("COUNTRYMASTERGUID")]
        [StringLength(36)]
        public string Countrymasterguid { get; set; }
        [Required]
        [Column("COUNTRYNAME")]
        [StringLength(200)]
        public string Countryname { get; set; }
        [Column("COUNTRYCODE")]
        [StringLength(5)]
        public string Countrycode { get; set; }
    }
}
