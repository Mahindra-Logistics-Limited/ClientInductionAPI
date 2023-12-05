using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TAX_MASTER")]
    public partial class TaxMaster
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("NAME")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("QUICKACCESSCODE")]
        [StringLength(60)]
        public string Quickaccesscode { get; set; }
        [Column("PERCENTAGE", TypeName = "NUMBER(10,3)")]
        public decimal? Percentage { get; set; }
        [Column("DISABLE")]
        [StringLength(1)]
        public string Disable { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("TRANSACTIONTYPEGUID")]
        [StringLength(36)]
        public string Transactiontypeguid { get; set; }
        [Column("OTHERCHARGES")]
        [StringLength(1)]
        public string Othercharges { get; set; }
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
    }
}
