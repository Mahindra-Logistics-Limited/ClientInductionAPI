using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("DIS_FCM_TOKEN_TBL")]
    [Index(nameof(Hwdeviceid), Name = "DISFCMTOKENTBL_HWDEVICEID_UK", IsUnique = true)]
    [Index(nameof(Datecreated), Name = "DIS_FCM_DATECREATED")]
    [Index(nameof(Fcmtoken), Name = "DIS_FCM_FCMTOKEN")]
    [Index(nameof(Mobileno), Name = "DIS_FCM_MOBILENO")]
    public partial class DisFcmTokenTbl
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
