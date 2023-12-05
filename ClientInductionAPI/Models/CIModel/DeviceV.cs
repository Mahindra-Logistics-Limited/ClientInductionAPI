using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DeviceV
    {
        [Column("DEV_GUID")]
        [StringLength(36)]
        public string DevGuid { get; set; }
        [Column("DEV_ID")]
        [StringLength(50)]
        public string DevId { get; set; }
        [Column("EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Effectivestartdate { get; set; }
        [Column("EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Effectiveenddate { get; set; }
        [Column("DEV_TYPE_CODE")]
        [StringLength(25)]
        public string DevTypeCode { get; set; }
        [Column("DEV_TYPE_NAME")]
        [StringLength(255)]
        public string DevTypeName { get; set; }
        [Column("DEV_SERIAL_NO")]
        [StringLength(255)]
        public string DevSerialNo { get; set; }
        [Column("DEV_MOB_NO")]
        [StringLength(20)]
        public string DevMobNo { get; set; }
        [Column("DEV_STATUS_CODE")]
        [StringLength(25)]
        public string DevStatusCode { get; set; }
        [Column("DEV_STATUS_NAME")]
        [StringLength(200)]
        public string DevStatusName { get; set; }
        [Column("DEV_MAKE")]
        [StringLength(255)]
        public string DevMake { get; set; }
        [Column("DEV_MAKE_CODE")]
        [StringLength(25)]
        public string DevMakeCode { get; set; }
        [Column("DEV_MODEL")]
        [StringLength(255)]
        public string DevModel { get; set; }
        [Column("DEV_MODELCODE")]
        [StringLength(25)]
        public string DevModelcode { get; set; }
        [Column("DEV_OWNER")]
        [StringLength(255)]
        public string DevOwner { get; set; }
        [Column("DEV_OWNER_SPID")]
        [StringLength(1000)]
        public string DevOwnerSpid { get; set; }
        [Column("DEV_OWNER_SPNAME")]
        [StringLength(767)]
        public string DevOwnerSpname { get; set; }
        [Column("DEV_OWNER_SP_STATUS")]
        [StringLength(25)]
        public string DevOwnerSpStatus { get; set; }
        [Column("DEV_LOC")]
        [StringLength(255)]
        public string DevLoc { get; set; }
        [Column("DEV_OBJ_VER_NO")]
        public int? DevObjVerNo { get; set; }
        [Column("DEV_PKGUID")]
        [StringLength(36)]
        public string DevPkguid { get; set; }
        [Column("SEC_GUID")]
        [StringLength(36)]
        public string SecGuid { get; set; }
        [Column("LEBRANCH_GUID")]
        [StringLength(36)]
        public string LebranchGuid { get; set; }
    }
}
