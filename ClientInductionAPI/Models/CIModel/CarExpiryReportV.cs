using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CarExpiryReportV
    {
        [Required]
        [Column("SPM_PERSONID")]
        [StringLength(1000)]
        public string SpmPersonid { get; set; }
        [Column("SPM_FULLNAME")]
        [StringLength(511)]
        public string SpmFullname { get; set; }
        [Column("PM_REGISTRATIONNO")]
        [StringLength(255)]
        public string PmRegistrationno { get; set; }
        [Column("PER1_DOCUMENTNO")]
        [StringLength(255)]
        public string Per1Documentno { get; set; }
        [Column("PER1_QUICKACCESSCODE")]
        [StringLength(25)]
        public string Per1Quickaccesscode { get; set; }
        [Column("PER1_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Per1Effectivestartdate { get; set; }
        [Column("PER1_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Per1Effectiveenddate { get; set; }
        [Column("TX1_DOCUMENTNO")]
        [StringLength(255)]
        public string Tx1Documentno { get; set; }
        [Column("TX1_QUICKACCESSCODE")]
        [StringLength(25)]
        public string Tx1Quickaccesscode { get; set; }
        [Column("TX1_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Tx1Effectivestartdate { get; set; }
        [Column("TX1_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Tx1Effectiveenddate { get; set; }
        [Column("RC1_DOCUMENTNO")]
        [StringLength(255)]
        public string Rc1Documentno { get; set; }
        [Column("RC1_QUICKACCESSCODE")]
        [StringLength(25)]
        public string Rc1Quickaccesscode { get; set; }
        [Column("RC1_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Rc1Effectivestartdate { get; set; }
        [Column("RC1_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Rc1Effectiveenddate { get; set; }
        [Column("FIT1_DOCUMENTNO")]
        [StringLength(255)]
        public string Fit1Documentno { get; set; }
        [Column("FIT1_QUICKACCESSCODE")]
        [StringLength(25)]
        public string Fit1Quickaccesscode { get; set; }
        [Column("FIT1_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Fit1Effectivestartdate { get; set; }
        [Column("FIT1_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Fit1Effectiveenddate { get; set; }
        [Column("INS1_DOCUMENTNO")]
        [StringLength(255)]
        public string Ins1Documentno { get; set; }
        [Column("INS1_QUICKACCESSCODE")]
        [StringLength(25)]
        public string Ins1Quickaccesscode { get; set; }
        [Column("INS1_EFFECTIVESTARTDATE", TypeName = "DATE")]
        public DateTime? Ins1Effectivestartdate { get; set; }
        [Column("INS1_EFFECTIVEENDDATE", TypeName = "DATE")]
        public DateTime? Ins1Effectiveenddate { get; set; }
        [Required]
        [Column("SEC_GUID")]
        [StringLength(36)]
        public string SecGuid { get; set; }
        [Required]
        [Column("LE_NAME")]
        [StringLength(200)]
        public string LeName { get; set; }
        [Column("LE_CODE")]
        [StringLength(200)]
        public string LeCode { get; set; }
        [Required]
        [Column("CITY_NAME")]
        [StringLength(200)]
        public string CityName { get; set; }
        [Column("CITY_CODE")]
        [StringLength(100)]
        public string CityCode { get; set; }
        [Column("BRAND_NAME")]
        [StringLength(200)]
        public string BrandName { get; set; }
        [Column("BRAND_CODE")]
        [StringLength(200)]
        public string BrandCode { get; set; }
        [Column("MODEL_NAME")]
        [StringLength(200)]
        public string ModelName { get; set; }
        [Column("MODEL_CODE")]
        [StringLength(200)]
        public string ModelCode { get; set; }
        [Column("SEC_QUICKACCESSCODE")]
        [StringLength(200)]
        public string SecQuickaccesscode { get; set; }
        [Column("SV_STATUS_CODE")]
        [StringLength(25)]
        public string SvStatusCode { get; set; }
    }
}
