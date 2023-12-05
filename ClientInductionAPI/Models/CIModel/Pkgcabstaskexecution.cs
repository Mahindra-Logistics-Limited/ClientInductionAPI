using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("PKGCABSTASKEXECUTION")]
    public partial class Pkgcabstaskexecution
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("ACTIVITYNAME")]
        [StringLength(255)]
        public string Activityname { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("STATUSCODE")]
        [StringLength(50)]
        public string Statuscode { get; set; }
        [Column("DATEUPDATED", TypeName = "DATE")]
        public DateTime? Dateupdated { get; set; }
        [Column("REMARK1")]
        public string Remark1 { get; set; }
        [Column("REMARK2")]
        public string Remark2 { get; set; }
        [Column("SETTLEMENTDATE", TypeName = "DATE")]
        public DateTime? Settlementdate { get; set; }
    }
}
