using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("CARALLOCATION")]
    [Index(nameof(Spsitemasterguid), Name = "ALLOC_SITE_IDX")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "CARALLOCATION_GUID_OVN", IsUnique = true)]
    [Index(nameof(Carmasterguid), Name = "XMERU_ALLOC_CAR_IDX")]
    [Index(nameof(Serviceproviderguid), Name = "XMERU_ALLOC_SP_IDX")]
    [Index(nameof(Carmasterpkguid), Name = "XMERU_CARALLC_CARPK_IND")]
    [Index(nameof(Serviceproviderpkguid), Name = "XMERU_CARALLC_SPPK_IND")]
    [Index(nameof(Pkguid), Name = "XMERU_CARALLOCATION_PKGUID", IsUnique = true)]
    public partial class Carallocation
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("SERVICEPROVIDERGUID")]
        [StringLength(36)]
        public string Serviceproviderguid { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Effectiveenddate { get; set; }
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
        [StringLength(100)]
        public string Oracleentityname { get; set; }
        [Column("ORACLEENTITYID")]
        [StringLength(1000)]
        public string Oracleentityid { get; set; }
        [Column("OBJECTVERSIONNO")]
        public byte? Objectversionno { get; set; }
        [Column("SPSITEMASTERGUID")]
        [StringLength(36)]
        public string Spsitemasterguid { get; set; }
        [Column("ALLOCATIONSTARTDATE", TypeName = "DATE")]
        public DateTime? Allocationstartdate { get; set; }
        [Column("ALLOCATIONENDDATE", TypeName = "DATE")]
        public DateTime? Allocationenddate { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("CARMASTERPKGUID")]
        [StringLength(36)]
        public string Carmasterpkguid { get; set; }
        [Column("SERVICEPROVIDERPKGUID")]
        [StringLength(36)]
        public string Serviceproviderpkguid { get; set; }
    }
}
