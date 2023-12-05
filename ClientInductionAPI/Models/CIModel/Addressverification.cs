using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("ADDRESSVERIFICATION")]
    public partial class Addressverification
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("DRIVERID")]
        [StringLength(20)]
        public string Driverid { get; set; }
        [Key]
        [Column("POSTCARDCODE")]
        [StringLength(36)]
        public string Postcardcode { get; set; }
        [Column("CYCLE1STARTDATE", TypeName = "DATE")]
        public DateTime Cycle1startdate { get; set; }
        [Column("CYCLE1STATUS")]
        [StringLength(15)]
        public string Cycle1status { get; set; }
        [Column("CYCLE1USERCREATED")]
        [StringLength(36)]
        public string Cycle1usercreated { get; set; }
        [Column("SMSDATE", TypeName = "DATE")]
        public DateTime? Smsdate { get; set; }
        [Column("POSTCARDUPLOADDATE", TypeName = "DATE")]
        public DateTime? Postcarduploaddate { get; set; }
        [Column("POSTCARDPATH")]
        [StringLength(500)]
        public string Postcardpath { get; set; }
        [Column("POSTCARDUSERCREATED")]
        [StringLength(36)]
        public string Postcardusercreated { get; set; }
        [Column("CYCLE2STARTDATE", TypeName = "DATE")]
        public DateTime? Cycle2startdate { get; set; }
        [Column("CYCLE2STATUS")]
        [StringLength(15)]
        public string Cycle2status { get; set; }
        [Column("CYCLE2USERCREATED")]
        [StringLength(36)]
        public string Cycle2usercreated { get; set; }
        [Column("LOCKDATE", TypeName = "DATE")]
        public DateTime? Lockdate { get; set; }
        [Column("UNLOCKDATE", TypeName = "DATE")]
        public DateTime? Unlockdate { get; set; }
        [Column("UNLOCKBYUSER")]
        [StringLength(36)]
        public string Unlockbyuser { get; set; }
        [Column("SETID")]
        public int? Setid { get; set; }
        [Column("UNLOCKREASON")]
        [StringLength(1000)]
        public string Unlockreason { get; set; }
    }
}
