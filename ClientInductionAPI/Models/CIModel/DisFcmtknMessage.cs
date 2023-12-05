using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("DIS_FCMTKN_MESSAGE")]
    [Index(nameof(Datecreated), Name = "DIS_FCM_MSG_DATECREATED")]
    [Index(nameof(Fcmtoken), Name = "DIS_FCM_MSG_FCMTOKEN")]
    [Index(nameof(Hwdeviceid), Name = "DIS_FCM_MSG_HWDEVICEID")]
    public partial class DisFcmtknMessage
    {
        [Key]
        [Column("GUID")]
        [StringLength(50)]
        public string Guid { get; set; }
        [Required]
        [Column("HWDEVICEID")]
        [StringLength(50)]
        public string Hwdeviceid { get; set; }
        [Column("PRAGATIDEVICEID")]
        [StringLength(250)]
        public string Pragatideviceid { get; set; }
        [Required]
        [Column("FCMTOKEN")]
        [StringLength(500)]
        public string Fcmtoken { get; set; }
        [Required]
        [Column("MESSAGE")]
        [StringLength(1000)]
        public string Message { get; set; }
        [Column("MOBILENO")]
        [StringLength(10)]
        public string Mobileno { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("SERVERRESPONSE")]
        public string Serverresponse { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
    }
}
