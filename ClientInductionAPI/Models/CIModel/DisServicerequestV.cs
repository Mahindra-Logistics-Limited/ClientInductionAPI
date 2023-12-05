using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DisServicerequestV
    {
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
        [Column("STATUS")]
        [StringLength(36)]
        public string Status { get; set; }
        [Column("MENTOR")]
        [StringLength(36)]
        public string Mentor { get; set; }
        [Column("SERVICETYPENAME")]
        [StringLength(100)]
        public string Servicetypename { get; set; }
        [Column("REASON")]
        [StringLength(100)]
        public string Reason { get; set; }
    }
}
