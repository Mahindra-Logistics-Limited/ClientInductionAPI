using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CarStatusAllocV
    {
        [Required]
        [Column("ALLOC_GUID")]
        [StringLength(36)]
        public string AllocGuid { get; set; }
        [Column("CARMASTERPKGUID")]
        [StringLength(36)]
        public string Carmasterpkguid { get; set; }
        [Column("SERVICEPROVIDERPKGUID")]
        [StringLength(36)]
        public string Serviceproviderpkguid { get; set; }
        [Required]
        [Column("CAR_GUID")]
        [StringLength(36)]
        public string CarGuid { get; set; }
        [Column("STATUSENTITYGUID")]
        [StringLength(36)]
        public string Statusentityguid { get; set; }
        [Column("CAR_REGNNO")]
        [StringLength(255)]
        public string CarRegnno { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("CHASSISNO")]
        [StringLength(255)]
        public string Chassisno { get; set; }
        [Column("ENGINENO")]
        [StringLength(100)]
        public string Engineno { get; set; }
        [Required]
        [Column("CAR_STATUS_ENT_STSGUID")]
        [StringLength(36)]
        public string CarStatusEntStsguid { get; set; }
        [Column("CAR_STATUS_ENT_ENTGUID")]
        [StringLength(36)]
        public string CarStatusEntEntguid { get; set; }
        [Column("CAR_STATUS_CODE")]
        [StringLength(25)]
        public string CarStatusCode { get; set; }
        [Column("CAR_STATUS_NAME")]
        [StringLength(200)]
        public string CarStatusName { get; set; }
        [Column("CAR_ENTITY_CODE")]
        [StringLength(50)]
        public string CarEntityCode { get; set; }
        [Column("SP_GUID")]
        [StringLength(36)]
        public string SpGuid { get; set; }
        [Column("SP_ID")]
        [StringLength(1000)]
        public string SpId { get; set; }
        [Column("SP_NAME")]
        [StringLength(767)]
        public string SpName { get; set; }
        [Column("DSEFLAG")]
        public bool? Dseflag { get; set; }
        [Column("SPFLAG")]
        public bool? Spflag { get; set; }
        [Column("DRIVERFLAG")]
        public bool? Driverflag { get; set; }
        [Column("ALLOC_ST_DATE", TypeName = "DATE")]
        public DateTime? AllocStDate { get; set; }
        [Column("ALLOC_END_DATE", TypeName = "DATE")]
        public DateTime? AllocEndDate { get; set; }
        [Column("ALLOC_STATUSENTITYGUID")]
        [StringLength(36)]
        public string AllocStatusentityguid { get; set; }
        [Column("ALLOC_PAY_SITE_GUID")]
        [StringLength(36)]
        public string AllocPaySiteGuid { get; set; }
        [Column("ALLOC_PAY_SITE_NAME")]
        [StringLength(100)]
        public string AllocPaySiteName { get; set; }
        [Required]
        [Column("ALLOC_STATUS_ENT_STSGUID")]
        [StringLength(36)]
        public string AllocStatusEntStsguid { get; set; }
        [Column("ALLOC_STATUS_ENT_ENTGUID")]
        [StringLength(36)]
        public string AllocStatusEntEntguid { get; set; }
        [Column("ALLOC_STATUS_CODE")]
        [StringLength(25)]
        public string AllocStatusCode { get; set; }
        [Column("ALLOC_STATUS_NAME")]
        [StringLength(200)]
        public string AllocStatusName { get; set; }
        [Column("ALLOC_ENTITY_CODE")]
        [StringLength(50)]
        public string AllocEntityCode { get; set; }
        [Required]
        [Column("LE_GUID")]
        [StringLength(36)]
        public string LeGuid { get; set; }
        [Column("BRAND_GUID")]
        [StringLength(36)]
        public string BrandGuid { get; set; }
        [Required]
        [Column("LEBRANCH_GUID")]
        [StringLength(36)]
        public string LebranchGuid { get; set; }
        [Column("ORG_ID")]
        public byte? OrgId { get; set; }
    }
}
