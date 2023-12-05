using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("DIS_SERVICEREQUEST")]
    public partial class DisServicerequest
    {
        [Key]
        [Column("SERVICEREQUESTNO", TypeName = "NUMBER")]
        public decimal Servicerequestno { get; set; }
        [Column("PERSONID")]
        [StringLength(36)]
        public string Personid { get; set; }
        [Column("SERVICETYPENO", TypeName = "NUMBER")]
        public decimal? Servicetypeno { get; set; }
        [Column("REQUESTREASONNO", TypeName = "NUMBER")]
        public decimal? Requestreasonno { get; set; }
        [Column("REQUESTDETAILS")]
        [StringLength(2000)]
        public string Requestdetails { get; set; }
        [Column("ATTRIBUTE1")]
        [StringLength(36)]
        public string Attribute1 { get; set; }
        [Column("ATTRIBUTE2")]
        [StringLength(36)]
        public string Attribute2 { get; set; }
        [Column("ATTRIBUTE3")]
        [StringLength(36)]
        public string Attribute3 { get; set; }
        [Required]
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("USERUPDATED")]
        [StringLength(36)]
        public string Userupdated { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("STATUS")]
        [StringLength(36)]
        public string Status { get; set; }
        [Column("MENTOR")]
        [StringLength(36)]
        public string Mentor { get; set; }
        [Column("MENTOROPERATIONSTATUS")]
        [StringLength(100)]
        public string Mentoroperationstatus { get; set; }
        [Column("FROMDATE", TypeName = "DATE")]
        public DateTime? Fromdate { get; set; }
        [Column("TODATE", TypeName = "DATE")]
        public DateTime? Todate { get; set; }
    }
}
