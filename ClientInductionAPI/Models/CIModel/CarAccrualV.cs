using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CarAccrualV
    {
        [Required]
        [Column("CAR_GUID")]
        [StringLength(36)]
        public string CarGuid { get; set; }
        [Column("CAR_REGN_NO")]
        [StringLength(255)]
        public string CarRegnNo { get; set; }
        [Column("CAR_REGN_DATE", TypeName = "DATE")]
        public DateTime? CarRegnDate { get; set; }
        [Column("CAR_STATUS_CODE")]
        [StringLength(25)]
        public string CarStatusCode { get; set; }
        [Column("CAR_STATUS_NAME")]
        [StringLength(200)]
        public string CarStatusName { get; set; }
        [Required]
        [Column("CAR_MAKE")]
        [StringLength(255)]
        public string CarMake { get; set; }
        [Column("CAR_MODEL")]
        [StringLength(255)]
        public string CarModel { get; set; }
        [Required]
        [Column("CAR_GVGUID")]
        [StringLength(36)]
        public string CarGvguid { get; set; }
        [Column("CAR_GVNAME")]
        [StringLength(255)]
        public string CarGvname { get; set; }
        [Required]
        [Column("GVC_GUID")]
        [StringLength(36)]
        public string GvcGuid { get; set; }
        [Column("GVC_CODE")]
        [StringLength(50)]
        public string GvcCode { get; set; }
        [Column("GVC_VALUETYPE")]
        [StringLength(30)]
        public string GvcValuetype { get; set; }
        [Column("GVC_VALUE")]
        public string GvcValue { get; set; }
        [Column("GVC_FREQ_GUID")]
        [StringLength(36)]
        public string GvcFreqGuid { get; set; }
        [Column("GVC_FREQ_CODE")]
        [StringLength(25)]
        public string GvcFreqCode { get; set; }
        [Column("GVC_FREQ_NAME")]
        [StringLength(255)]
        public string GvcFreqName { get; set; }
        [Required]
        [Column("TXN_TYPE_GUID")]
        [StringLength(36)]
        public string TxnTypeGuid { get; set; }
        [Column("TXN_TYPE_CODE")]
        [StringLength(60)]
        public string TxnTypeCode { get; set; }
        [Column("TXN_TYPE_NAME")]
        [StringLength(255)]
        public string TxnTypeName { get; set; }
        [Required]
        [Column("TXN_CLASS_GUID")]
        [StringLength(36)]
        public string TxnClassGuid { get; set; }
        [Column("TXN_CLASS_CODE")]
        [StringLength(25)]
        public string TxnClassCode { get; set; }
        [Column("TXN_CLASS_NAME")]
        [StringLength(255)]
        public string TxnClassName { get; set; }
        [Column("CYCLE_DURATION", TypeName = "NUMBER")]
        public decimal? CycleDuration { get; set; }
        [Column("CYCLE_DAYS_GUID")]
        [StringLength(36)]
        public string CycleDaysGuid { get; set; }
        [Column("CYCLE_DAYS_CODE")]
        [StringLength(25)]
        public string CycleDaysCode { get; set; }
        [Column("CYCLE_DAYS_NAME")]
        [StringLength(255)]
        public string CycleDaysName { get; set; }
        [Column("GVC_OBJ_VER_NO")]
        public byte? GvcObjVerNo { get; set; }
        [Required]
        [Column("SEC_GUID")]
        [StringLength(36)]
        public string SecGuid { get; set; }
        [Required]
        [Column("LE_GUID")]
        [StringLength(36)]
        public string LeGuid { get; set; }
        [Required]
        [Column("LE_NAME")]
        [StringLength(200)]
        public string LeName { get; set; }
        [Column("LE_CODE")]
        [StringLength(200)]
        public string LeCode { get; set; }
        [Required]
        [Column("CITY_GUID")]
        [StringLength(36)]
        public string CityGuid { get; set; }
        [Required]
        [Column("CITY_NAME")]
        [StringLength(200)]
        public string CityName { get; set; }
        [Column("CITY_CODE")]
        [StringLength(100)]
        public string CityCode { get; set; }
        [Column("BRAND_GUID")]
        [StringLength(36)]
        public string BrandGuid { get; set; }
        [Column("BRAND_NAME")]
        [StringLength(200)]
        public string BrandName { get; set; }
        [Column("BRAND_CODE")]
        [StringLength(200)]
        public string BrandCode { get; set; }
        [Column("GL_SEMENT4")]
        [StringLength(1000)]
        public string GlSement4 { get; set; }
        [Column("MODEL_GUID")]
        [StringLength(36)]
        public string ModelGuid { get; set; }
        [Column("MODEL_NAME")]
        [StringLength(200)]
        public string ModelName { get; set; }
        [Column("MODEL_CODE")]
        [StringLength(200)]
        public string ModelCode { get; set; }
        [Column("GL_SEMENT6")]
        [StringLength(1000)]
        public string GlSement6 { get; set; }
        [Required]
        [Column("LEBRANCH_GUID")]
        [StringLength(36)]
        public string LebranchGuid { get; set; }
        [Column("ORG_ID")]
        public byte? OrgId { get; set; }
        [Column("GL_SEGMENT1")]
        [StringLength(1000)]
        public string GlSegment1 { get; set; }
        [Column("SEC_OBJ_VER_NO")]
        public int? SecObjVerNo { get; set; }
    }
}
