using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("BBMPARAMETER")]
    [Index(nameof(Guid), nameof(Objectversionno), Name = "BBMPARAMETER_GUID_OVN", IsUnique = true)]
    [Index(nameof(Parametermasterguid), nameof(Securitycombinationguid), Name = "BBM_PARAM_IDX", IsUnique = true)]
    [Index(nameof(Pkguid), Name = "XMERU_BBMPARAMETER_PKGUID", IsUnique = true)]
    public partial class Bbmparameter
    {
        [Required]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("PARAMETERMASTERGUID")]
        [StringLength(36)]
        public string Parametermasterguid { get; set; }
        [Column("PARAMETERVALUE")]
        [StringLength(20)]
        public string Parametervalue { get; set; }
        [Column("UNITMASTERGUID")]
        [StringLength(36)]
        public string Unitmasterguid { get; set; }
        [Column("DISABLED")]
        public bool? Disabled { get; set; }
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
        [Column("TRANSACTIONTYPEGUID")]
        [StringLength(36)]
        public string Transactiontypeguid { get; set; }
        [Column("PKGUID")]
        [StringLength(36)]
        public string Pkguid { get; set; }
        [Column("BRAND_GUID")]
        [StringLength(36)]
        public string BrandGuid { get; set; }
        [Column("MODEL_GUID")]
        [StringLength(36)]
        public string ModelGuid { get; set; }
        [Column("BRANCH_GUID")]
        [StringLength(36)]
        public string BranchGuid { get; set; }
        [Column("LE_GUID")]
        [StringLength(36)]
        public string LeGuid { get; set; }
    }
}
