using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("DISAPIMESSAGEMASTER")]
    [Index(nameof(Apimasterguid), nameof(Messagenumber), Name = "ST_API_PK", IsUnique = true)]
    public partial class Disapimessagemaster
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("STATUSCODE")]
        [StringLength(36)]
        public string Statuscode { get; set; }
        [Column("STATUS")]
        [StringLength(250)]
        public string Status { get; set; }
        [Required]
        [Column("APIMASTERGUID")]
        [StringLength(36)]
        public string Apimasterguid { get; set; }
        [Column("MESSAGENUMBER")]
        [StringLength(36)]
        public string Messagenumber { get; set; }
        [Column("MESSAGE")]
        public string Message { get; set; }
        [Required]
        [Column("DISABLED")]
        [StringLength(1)]
        public string Disabled { get; set; }
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
        [Column("OBJECTVERSIONNO")]
        [StringLength(100)]
        public string Objectversionno { get; set; }
        [Required]
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }

        [ForeignKey(nameof(Apimasterguid))]
        public virtual Disapimaster Apimastergu { get; set; }
    }
}
