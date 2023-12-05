using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CarDeviceV
    {
        [Required]
        [Column("CAR_DEV_GUID")]
        [StringLength(36)]
        public string CarDevGuid { get; set; }
        [Required]
        [Column("CAR_GUID")]
        [StringLength(36)]
        public string CarGuid { get; set; }
        [Column("CAR_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? CarEffectivestartdate { get; set; }
        [Column("CAR_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? CarEffectiveenddate { get; set; }
        [Column("CAR_CHASSISNO")]
        [StringLength(255)]
        public string CarChassisno { get; set; }
        [Column("CAR_REGN_DATE", TypeName = "DATE")]
        public DateTime? CarRegnDate { get; set; }
        [Column("CAR_OBJ_VER_NO")]
        public byte? CarObjVerNo { get; set; }
        [Column("CAR_DEFRRED_DOC_CHECK_FLAG")]
        [StringLength(1)]
        public string CarDefrredDocCheckFlag { get; set; }
        [Column("CAR_PKGUID")]
        [StringLength(36)]
        public string CarPkguid { get; set; }
        [Column("CAR_STATUS_NAME")]
        [StringLength(200)]
        public string CarStatusName { get; set; }
        [Column("SPGUID")]
        [StringLength(36)]
        public string Spguid { get; set; }
        [Column("CAR_OWNER_SPID")]
        [StringLength(1000)]
        public string CarOwnerSpid { get; set; }
        [Column("CAR_OWNER_SPNAME")]
        [StringLength(767)]
        public string CarOwnerSpname { get; set; }
        [Column("CAR_OWNER_SP_STATUS")]
        [StringLength(25)]
        public string CarOwnerSpStatus { get; set; }
        [Column("SP_DEFRRED_DOC_CHECK_FLAG")]
        [StringLength(1)]
        public string SpDefrredDocCheckFlag { get; set; }
        [Column("SP_PKGUID")]
        [StringLength(36)]
        public string SpPkguid { get; set; }
        [Required]
        [Column("CAR_SEC_GUID")]
        [StringLength(36)]
        public string CarSecGuid { get; set; }
        [Required]
        [Column("CAR_LE_BRANCH_GUID")]
        [StringLength(36)]
        public string CarLeBranchGuid { get; set; }
        [Required]
        [Column("DEV_GUID")]
        [StringLength(36)]
        public string DevGuid { get; set; }
        [Column("DEV_PKGUID")]
        [StringLength(36)]
        public string DevPkguid { get; set; }
        [Column("CAR_REGN_NO")]
        [StringLength(255)]
        public string CarRegnNo { get; set; }
        [Column("CAR_STATUS_CODE")]
        [StringLength(25)]
        public string CarStatusCode { get; set; }
        [Column("DEV_ID")]
        [StringLength(50)]
        public string DevId { get; set; }
        [Required]
        [Column("DEV_TYPE_CODE")]
        [StringLength(25)]
        public string DevTypeCode { get; set; }
        [Column("DEV_SERIAL_NO")]
        [StringLength(255)]
        public string DevSerialNo { get; set; }
        [Column("DEV_MOB_NO")]
        [StringLength(20)]
        public string DevMobNo { get; set; }
        [Column("DEV_STATUS_CODE")]
        [StringLength(25)]
        public string DevStatusCode { get; set; }
        [Column("CAR_DEV_OBJ_VER_NO")]
        public int? CarDevObjVerNo { get; set; }
        [Column("CARDEV_STATUS_CODE")]
        [StringLength(25)]
        public string CardevStatusCode { get; set; }
    }
}
