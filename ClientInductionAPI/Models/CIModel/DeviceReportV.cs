using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DeviceReportV
    {
        [Column("CARNUMBER")]
        [StringLength(255)]
        public string Carnumber { get; set; }
        [Column("MOBILE")]
        [StringLength(255)]
        public string Mobile { get; set; }
        [Column("MOBILE_ID")]
        [StringLength(50)]
        public string MobileId { get; set; }
        [Column("MOBILE_SERIALNO")]
        [StringLength(255)]
        public string MobileSerialno { get; set; }
        [Column("MOBILE_OWNERSHIPTYPE")]
        [StringLength(255)]
        public string MobileOwnershiptype { get; set; }
        [Column("MOBILE_STATUS")]
        [StringLength(200)]
        public string MobileStatus { get; set; }
        [Column("MDT")]
        [StringLength(255)]
        public string Mdt { get; set; }
        [Column("MDT_ID")]
        [StringLength(50)]
        public string MdtId { get; set; }
        [Column("MDT_SERIALNO")]
        [StringLength(255)]
        public string MdtSerialno { get; set; }
        [Column("MDT_OWNERSHIPTYPE")]
        [StringLength(255)]
        public string MdtOwnershiptype { get; set; }
        [Column("MDT_STATUS")]
        [StringLength(200)]
        public string MdtStatus { get; set; }
        [Column("METER")]
        [StringLength(255)]
        public string Meter { get; set; }
        [Column("METER_ID")]
        [StringLength(50)]
        public string MeterId { get; set; }
        [Column("METER_SERIALNO")]
        [StringLength(255)]
        public string MeterSerialno { get; set; }
        [Column("METER_OWNERSHIPTYPE")]
        [StringLength(255)]
        public string MeterOwnershiptype { get; set; }
        [Column("METER_STATUS")]
        [StringLength(200)]
        public string MeterStatus { get; set; }
        [Column("SIM")]
        [StringLength(255)]
        public string Sim { get; set; }
        [Column("SIM_ID")]
        [StringLength(50)]
        public string SimId { get; set; }
        [Column("SIM_SERIALNO")]
        [StringLength(255)]
        public string SimSerialno { get; set; }
        [Column("SIM_OWNERSHIPTYPE")]
        [StringLength(255)]
        public string SimOwnershiptype { get; set; }
        [Column("SIM_STATUS")]
        [StringLength(200)]
        public string SimStatus { get; set; }
        [Column("PRINTER")]
        [StringLength(255)]
        public string Printer { get; set; }
        [Column("PRINTER_ID")]
        [StringLength(50)]
        public string PrinterId { get; set; }
        [Column("PRINTER_SERIALNO")]
        [StringLength(255)]
        public string PrinterSerialno { get; set; }
        [Column("PRINTER_OWNERSHIPTYPE")]
        [StringLength(255)]
        public string PrinterOwnershiptype { get; set; }
        [Column("PRINTER_STATUS")]
        [StringLength(200)]
        public string PrinterStatus { get; set; }
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
        [Required]
        [Column("CAR_GUID")]
        [StringLength(36)]
        public string CarGuid { get; set; }
        [Column("CAR_SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string CarSecuritycombinationguid { get; set; }
    }
}
