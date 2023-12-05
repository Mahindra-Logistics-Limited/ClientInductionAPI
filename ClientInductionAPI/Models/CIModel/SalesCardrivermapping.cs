using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("SALES_CARDRIVERMAPPING")]
    public partial class SalesCardrivermapping
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("CARGUID")]
        [StringLength(36)]
        public string Carguid { get; set; }
        [Column("DRIVERGUID")]
        [StringLength(36)]
        public string Driverguid { get; set; }
        [Column("OWNERGUID")]
        [StringLength(36)]
        public string Ownerguid { get; set; }
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

        [ForeignKey(nameof(Carguid))]
        [InverseProperty(nameof(SalesCarInterface.SalesCardrivermappings))]
        public virtual SalesCarInterface Cargu { get; set; }
        [ForeignKey(nameof(Driverguid))]
        [InverseProperty(nameof(SalesDriverInterface.SalesCardrivermappings))]
        public virtual SalesDriverInterface Drivergu { get; set; }
    }
}
