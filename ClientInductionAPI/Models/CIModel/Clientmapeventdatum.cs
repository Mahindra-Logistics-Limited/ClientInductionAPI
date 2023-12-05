using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("CLIENTMAPEVENTDATA")]
    public partial class Clientmapeventdatum
    {
        [Column("ID", TypeName = "NUMBER")]
        public decimal? Id { get; set; }
        [Column("EVENT_CODE")]
        [StringLength(100)]
        public string EventCode { get; set; }
        [Column("PARAM_STRING")]
        [StringLength(100)]
        public string ParamString { get; set; }
        [Column("PROCESSED_STATUS")]
        [StringLength(20)]
        public string ProcessedStatus { get; set; }
        [Column("CREATION_DATE", TypeName = "DATE")]
        public DateTime? CreationDate { get; set; }
        [Column("PROCESSED_DATE", TypeName = "DATE")]
        public DateTime? ProcessedDate { get; set; }
        [Column("VEHICLE_PROCESSED_RESULT")]
        [StringLength(3000)]
        public string VehicleProcessedResult { get; set; }
        [Column("UPDATED_DATE", TypeName = "DATE")]
        public DateTime? UpdatedDate { get; set; }
        [Column("BUSINESS_CATEGORY")]
        [StringLength(20)]
        public string BusinessCategory { get; set; }
        [Column("DRIVER_PROCESSED_RESULT")]
        [StringLength(3000)]
        public string DriverProcessedResult { get; set; }
        [Column("VENDOR_PROCESSED_RESULT")]
        [StringLength(3000)]
        public string VendorProcessedResult { get; set; }
    }
}
