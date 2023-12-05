using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("LOCKEXCEPTION")]
    [Index(nameof(Carmasterguid), Name = "CARMASTERGUID_IND")]
    [Index(nameof(Guid), Name = "LOCKEXCEPTION_GUID_OVN", IsUnique = true)]
    [Index(nameof(Locktypemasterguid), Name = "LOCKTYPEMASTERGUID_IND")]
    [Index(nameof(Pkguid), Name = "XMERU_LOCKEXCEPTION_PKGUID", IsUnique = true)]
    public partial class Lockexception
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("LOCKTYPEMASTERGUID")]
        [StringLength(36)]
        public string Locktypemasterguid { get; set; }
        [Column("STARTDATE", TypeName = "DATE")]
        public DateTime? Startdate { get; set; }
        [Column("ENDDATE", TypeName = "DATE")]
        public DateTime? Enddate { get; set; }
        [Column("LOCKREFERENCE")]
        [StringLength(36)]
        public string Lockreference { get; set; }
        [Column("SOURCEENTITY")]
        [StringLength(36)]
        public string Sourceentity { get; set; }
        [Column("LOCKDETAILS")]
        [StringLength(1000)]
        public string Lockdetails { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("LOCKEXCEPTIONID", TypeName = "NUMBER")]
        public decimal? Lockexceptionid { get; set; }
        [Column("LOCKGUID")]
        [StringLength(36)]
        public string Lockguid { get; set; }
    }
}
