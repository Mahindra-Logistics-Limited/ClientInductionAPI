using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("DIS_OTP_TBL")]
    [Index(nameof(Mobileno), nameof(Otp), Name = "OTP_MO_OTP_IND")]
    [Index(nameof(Personguid), Name = "OTP_PER_IND")]
    public partial class DisOtpTbl
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("MOBILENO", TypeName = "NUMBER")]
        public decimal? Mobileno { get; set; }
        [Column("OTP", TypeName = "NUMBER")]
        public decimal? Otp { get; set; }
        [Column("PERSONGUID")]
        [StringLength(36)]
        public string Personguid { get; set; }
        [Column("DISABLED", TypeName = "NUMBER")]
        public decimal? Disabled { get; set; }
        [Required]
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
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
        [Column("ATTRIBUTE1")]
        [StringLength(100)]
        public string Attribute1 { get; set; }
        [Column("ATTRIBUTE2")]
        [StringLength(100)]
        public string Attribute2 { get; set; }
        [Column("ATTRIBUTE3")]
        [StringLength(100)]
        public string Attribute3 { get; set; }
        [Column("ATTRIBUTE4")]
        [StringLength(100)]
        public string Attribute4 { get; set; }
        [Column("ATTRIBUTE5")]
        [StringLength(100)]
        public string Attribute5 { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
    }
}
