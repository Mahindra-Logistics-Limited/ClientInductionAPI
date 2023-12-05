using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("DOB_CONFIG_TBL")]
    public partial class DobConfigTbl
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("CITYCODE")]
        [StringLength(25)]
        public string Citycode { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("PERSON_ID")]
        public int PersonId { get; set; }
        [Column("DRIVERSMS1STLINE")]
        [StringLength(100)]
        public string Driversms1stline { get; set; }
        [Column("DRIVERSMS2NDLINE")]
        [StringLength(100)]
        public string Driversms2ndline { get; set; }
        [Column("DRIVERSMS3RDLINE")]
        [StringLength(100)]
        public string Driversms3rdline { get; set; }
        [Column("DRIVERSMS4RTLINE")]
        [StringLength(100)]
        public string Driversms4rtline { get; set; }
        [Column("DRIVERSMS5THLINE")]
        [StringLength(100)]
        public string Driversms5thline { get; set; }
        [Column("DRIVERSMS6THLINE")]
        [StringLength(100)]
        public string Driversms6thline { get; set; }
        [Column("DRIVERSMS7THLINE")]
        [StringLength(100)]
        public string Driversms7thline { get; set; }
        [Column("DRIVERSMS8THLINE")]
        [StringLength(100)]
        public string Driversms8thline { get; set; }
        [Column("SPSMS1STLINE")]
        [StringLength(100)]
        public string Spsms1stline { get; set; }
        [Column("SPSMS2NDLINE")]
        [StringLength(100)]
        public string Spsms2ndline { get; set; }
        [Column("SPSMS3RDLINE")]
        [StringLength(100)]
        public string Spsms3rdline { get; set; }
        [Column("SPSMS4RTLINE")]
        [StringLength(100)]
        public string Spsms4rtline { get; set; }
        [Column("SPSMS5THLINE")]
        [StringLength(100)]
        public string Spsms5thline { get; set; }
        [Column("SPSMS6THLINE")]
        [StringLength(100)]
        public string Spsms6thline { get; set; }
        [Column("SPSMS7THLINE")]
        [StringLength(100)]
        public string Spsms7thline { get; set; }
        [Column("SPSMS8THLINE")]
        [StringLength(100)]
        public string Spsms8thline { get; set; }
        [Column("SPSMS9THLINE")]
        [StringLength(100)]
        public string Spsms9thline { get; set; }
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
    }
}
