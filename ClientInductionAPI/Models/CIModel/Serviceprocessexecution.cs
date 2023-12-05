using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("SERVICEPROCESSEXECUTION")]
    public partial class Serviceprocessexecution
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Required]
        [Column("SERVICENAME")]
        [StringLength(255)]
        public string Servicename { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("STARTDATE", TypeName = "DATE")]
        public DateTime Startdate { get; set; }
        [Column("ENDDATE", TypeName = "DATE")]
        public DateTime? Enddate { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(15)]
        public string Status { get; set; }
    }
}
