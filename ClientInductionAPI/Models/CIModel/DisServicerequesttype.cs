using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("DIS_SERVICEREQUESTTYPE")]
    public partial class DisServicerequesttype
    {
        [Key]
        [Column("SERVICETYPENO", TypeName = "NUMBER")]
        public decimal Servicetypeno { get; set; }
        [Column("NAME")]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("DISABLED", TypeName = "NUMBER")]
        public decimal? Disabled { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
    }
}
