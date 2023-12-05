using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("BLACKLIST")]
    public partial class Blacklist
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("PERSONMASTERGUID")]
        [StringLength(36)]
        public string Personmasterguid { get; set; }
        [Column("BLACKLISTDATE", TypeName = "DATE")]
        public DateTime Blacklistdate { get; set; }
        [Column("COMMENTS")]
        [StringLength(1000)]
        public string Comments { get; set; }
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
        [Column("USERARCHIVED")]
        [StringLength(36)]
        public string Userarchived { get; set; }
        [Column("DATEARCHIVED", TypeName = "DATE")]
        public DateTime? Datearchived { get; set; }
        [Column("ORACLEENTITYNAME")]
        [StringLength(1000)]
        public string Oracleentityname { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(100)]
        public string Oracleentityid { get; set; }
        [Column("OBJECTVERSIONNO")]
        public byte? Objectversionno { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
    }
}
