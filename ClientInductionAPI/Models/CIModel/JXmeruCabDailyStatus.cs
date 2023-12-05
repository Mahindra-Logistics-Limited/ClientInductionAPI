using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("J$XMERU_CAB_DAILY_STATUS")]
    public partial class JXmeruCabDailyStatus
    {
        [Required]
        [Column("JRN_SUBSCRIBER")]
        [StringLength(50)]
        public string JrnSubscriber { get; set; }
        [Column("JRN_CONSUMED")]
        [StringLength(1)]
        public string JrnConsumed { get; set; }
        [Column("JRN_FLAG")]
        [StringLength(1)]
        public string JrnFlag { get; set; }
        [Column("JRN_DATE", TypeName = "DATE")]
        public DateTime? JrnDate { get; set; }
        [Column("VEHICLE_NUM")]
        [StringLength(30)]
        public string VehicleNum { get; set; }
        [Column("STATUS_DATE", TypeName = "DATE")]
        public DateTime? StatusDate { get; set; }
    }
}
