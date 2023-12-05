using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisFcmTokenV
    {
        [Required]
        [Column("GUID")]
        [StringLength(50)]
        public string Guid { get; set; }
        [Column("PERSONID")]
        [StringLength(1000)]
        public string Personid { get; set; }
        [Column("NAME")]
        [StringLength(767)]
        public string Name { get; set; }
        [Column("SPFLAG")]
        public bool? Spflag { get; set; }
        [Column("DSEFLAG")]
        public bool? Dseflag { get; set; }
        [Column("DRIVERFLAG")]
        public bool? Driverflag { get; set; }
        [Required]
        [Column("FCMTOKEN")]
        [StringLength(250)]
        public string Fcmtoken { get; set; }
        [Column("AUTH")]
        [StringLength(50)]
        public string Auth { get; set; }
        [Column("MOBILENO")]
        [StringLength(10)]
        public string Mobileno { get; set; }
        [Required]
        [Column("HWDEVICEID")]
        [StringLength(50)]
        public string Hwdeviceid { get; set; }
    }
}
