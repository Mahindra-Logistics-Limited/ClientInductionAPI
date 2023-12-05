using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TEMPDEVICE")]
    public partial class Tempdevice
    {
        [Column("DEVICEID")]
        [StringLength(50)]
        public string Deviceid { get; set; }
        [Column("DEVICENAME")]
        [StringLength(10)]
        public string Devicename { get; set; }
        [Column("MOBILENO")]
        [StringLength(30)]
        public string Mobileno { get; set; }
        [Column("SIMCARDNO")]
        [StringLength(100)]
        public string Simcardno { get; set; }
    }
}
