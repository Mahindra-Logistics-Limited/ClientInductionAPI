using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("DIS_AUTHORISE_DEVICES")]
    [Index(nameof(Pkguid), Name = "HW_AUTH_DEV_UK", IsUnique = true)]
    [Index(nameof(Carguid), Name = "PRA_CAR_GUID_IND")]
    public partial class DisAuthoriseDevice
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("PRAGATIDEVICEID")]
        [StringLength(250)]
        public string Pragatideviceid { get; set; }
        [Column("HWDEVICEID")]
        [StringLength(250)]
        public string Hwdeviceid { get; set; }
        [Column("CARGUID")]
        [StringLength(36)]
        public string Carguid { get; set; }
        [Column("FCMTOKEN")]
        [StringLength(1000)]
        public string Fcmtoken { get; set; }
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
        [Column("DEVICE_IMEI")]
        [StringLength(250)]
        public string DeviceImei { get; set; }
    }
}
