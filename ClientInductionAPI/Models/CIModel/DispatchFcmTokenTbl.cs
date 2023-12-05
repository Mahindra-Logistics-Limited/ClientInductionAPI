using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("DISPATCH_FCM_TOKEN_TBL")]
    [Index(nameof(Hwdeviceid), Name = "DISPFCMTKNTBL_HWDEVICEID_UK", IsUnique = true)]
    public partial class DispatchFcmTokenTbl
    {
        [Key]
        [Column("GUID")]
        [StringLength(50)]
        public string Guid { get; set; }
        [Required]
        [Column("HWDEVICEID")]
        [StringLength(50)]
        public string Hwdeviceid { get; set; }
        [Column("MOBILENO")]
        [StringLength(10)]
        public string Mobileno { get; set; }
        [Required]
        [Column("FCMTOKEN")]
        [StringLength(250)]
        public string Fcmtoken { get; set; }
        [Column("AUTH")]
        [StringLength(50)]
        public string Auth { get; set; }
        [Required]
        [Column("USERCREATED")]
        [StringLength(100)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("USERUPDATED")]
        [StringLength(100)]
        public string Userupdated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
    }
}
