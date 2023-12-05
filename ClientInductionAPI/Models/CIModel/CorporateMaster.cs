using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("CORPORATE_MASTER")]
    public partial class CorporateMaster
    {
        [Key]
        [Column("GUID")]
        [StringLength(32)]
        public string Guid { get; set; }
        [Column("NAME")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("DESCRIPTION")]
        [StringLength(2000)]
        public string Description { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime? Datecreated { get; set; }
        [Column("CODE")]
        [StringLength(100)]
        public string Code { get; set; }
    }
}
