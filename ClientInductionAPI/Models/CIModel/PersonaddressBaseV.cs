using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class PersonaddressBaseV
    {
        [Required]
        [Column("ADDR_GUID")]
        [StringLength(36)]
        public string AddrGuid { get; set; }
        [Required]
        [Column("ADDR_PERS_GUID")]
        [StringLength(36)]
        public string AddrPersGuid { get; set; }
        [Column("ADDR_TYPE_CODE")]
        [StringLength(25)]
        public string AddrTypeCode { get; set; }
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
        [Column("CITY")]
        [StringLength(255)]
        public string City { get; set; }
        [Column("PINCODE")]
        [StringLength(10)]
        public string Pincode { get; set; }
        [Column("COUNTRY")]
        [StringLength(200)]
        public string Country { get; set; }
        [Column("STATE")]
        [StringLength(255)]
        public string State { get; set; }
        [Column("ADDR_OBJ_VER_NO")]
        public int? AddrObjVerNo { get; set; }
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
    }
}
