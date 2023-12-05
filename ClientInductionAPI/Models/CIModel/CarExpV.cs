using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CarExpV
    {
        [Column("REGISTRATIONNO")]
        [StringLength(255)]
        public string Registrationno { get; set; }
        [Column("INSURANCE_DOC_NO")]
        [StringLength(255)]
        public string InsuranceDocNo { get; set; }
        [Column("INSURANCE_ST_DATE", TypeName = "DATE")]
        public DateTime? InsuranceStDate { get; set; }
        [Column("INSURANCE_END_DATE", TypeName = "DATE")]
        public DateTime? InsuranceEndDate { get; set; }
        [Column("FITNESSCERTIFICATE_DOC_NO")]
        [StringLength(255)]
        public string FitnesscertificateDocNo { get; set; }
        [Column("FITNESSCERTIFICATE_ST_DATE", TypeName = "DATE")]
        public DateTime? FitnesscertificateStDate { get; set; }
        [Column("FITNESSCERTIFICATE_END_DATE", TypeName = "DATE")]
        public DateTime? FitnesscertificateEndDate { get; set; }
        [Column("RC_DOC_NO")]
        [StringLength(255)]
        public string RcDocNo { get; set; }
        [Column("RC_ST_DATE", TypeName = "DATE")]
        public DateTime? RcStDate { get; set; }
        [Column("RC_END_DATE", TypeName = "DATE")]
        public DateTime? RcEndDate { get; set; }
        [Column("ROADTAX_DOC_NO")]
        [StringLength(255)]
        public string RoadtaxDocNo { get; set; }
        [Column("ROADTAX_ST_DATE", TypeName = "DATE")]
        public DateTime? RoadtaxStDate { get; set; }
        [Column("ROADTAX_END_DATE", TypeName = "DATE")]
        public DateTime? RoadtaxEndDate { get; set; }
        [Column("PERMIT_DOC_NO")]
        [StringLength(255)]
        public string PermitDocNo { get; set; }
        [Column("PERMIT_ST_DATE", TypeName = "DATE")]
        public DateTime? PermitStDate { get; set; }
        [Column("PERMIT_END_DATE", TypeName = "DATE")]
        public DateTime? PermitEndDate { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Required]
        [Column("SEC_GUID")]
        [StringLength(36)]
        public string SecGuid { get; set; }
        [Required]
        [Column("LE_NAME")]
        [StringLength(200)]
        public string LeName { get; set; }
        [Required]
        [Column("CITY_NAME")]
        [StringLength(200)]
        public string CityName { get; set; }
        [Column("BRAND_NAME")]
        [StringLength(200)]
        public string BrandName { get; set; }
        [Column("MODEL_NAME")]
        [StringLength(200)]
        public string ModelName { get; set; }
        [Column("STATUS_NAME")]
        [StringLength(200)]
        public string StatusName { get; set; }
        [Column("RE1GUID")]
        [StringLength(36)]
        public string Re1guid { get; set; }
        [Column("RE2GUID")]
        [StringLength(36)]
        public string Re2guid { get; set; }
        [Column("PERSONID")]
        [StringLength(1000)]
        public string Personid { get; set; }
        [Column("FIRSTNAME")]
        [StringLength(255)]
        public string Firstname { get; set; }
        [Column("MIDDLENAME")]
        [StringLength(255)]
        public string Middlename { get; set; }
        [Column("LASTNAME")]
        [StringLength(255)]
        public string Lastname { get; set; }
        [Column("CMGUID")]
        [StringLength(36)]
        public string Cmguid { get; set; }
        [Column("RE3GUID")]
        [StringLength(36)]
        public string Re3guid { get; set; }
    }
}
