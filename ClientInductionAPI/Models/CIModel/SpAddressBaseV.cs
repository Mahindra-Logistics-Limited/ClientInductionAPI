using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class SpAddressBaseV
    {
        [Required]
        [Column("SPGUID")]
        [StringLength(36)]
        public string Spguid { get; set; }
        [Required]
        [Column("PERSONGUID")]
        [StringLength(36)]
        public string Personguid { get; set; }
        [Required]
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Required]
        [Column("SP_FNAME")]
        [StringLength(255)]
        public string SpFname { get; set; }
        [Column("SP_MNAME")]
        [StringLength(255)]
        public string SpMname { get; set; }
        [Required]
        [Column("SP_LNAME")]
        [StringLength(255)]
        public string SpLname { get; set; }
        [Required]
        [Column("SP_BIOID")]
        [StringLength(255)]
        public string SpBioid { get; set; }
        [Column("DSEFLAG")]
        public bool? Dseflag { get; set; }
        [Column("SPFLAG")]
        public bool? Spflag { get; set; }
        [Column("DRIVERFLAG")]
        public bool? Driverflag { get; set; }
        [Column("CUST_ID")]
        [StringLength(255)]
        public string CustId { get; set; }
        [Column("SP_PKGUID")]
        [StringLength(36)]
        public string SpPkguid { get; set; }
        [Column("SP_STATUS")]
        [StringLength(25)]
        public string SpStatus { get; set; }
        [Column("PERS_STATUS")]
        [StringLength(25)]
        public string PersStatus { get; set; }
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
        [Column("PERSONID")]
        [StringLength(1000)]
        public string Personid { get; set; }
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
