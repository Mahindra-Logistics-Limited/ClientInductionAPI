using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("SALES_CABQC_INTERFACE")]
    public partial class SalesCabqcInterface
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("OWNERGUID")]
        [StringLength(36)]
        public string Ownerguid { get; set; }
        [Column("CARGUID")]
        [StringLength(36)]
        public string Carguid { get; set; }
        [Column("VEHICLECONDITION")]
        [StringLength(1)]
        public string Vehiclecondition { get; set; }
        [Column("DRIVINGSKILL")]
        [StringLength(1)]
        public string Drivingskill { get; set; }
        [Column("TRAININGREQUIRD")]
        [StringLength(1)]
        public string Trainingrequird { get; set; }
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
        [StringLength(200)]
        public string Status { get; set; }

        [ForeignKey(nameof(Carguid))]
        [InverseProperty(nameof(SalesCarInterface.SalesCabqcInterfaces))]
        public virtual SalesCarInterface Cargu { get; set; }
        [ForeignKey(nameof(Ownerguid))]
        [InverseProperty(nameof(SalesOwnerInterface.SalesCabqcInterfaces))]
        public virtual SalesOwnerInterface Ownergu { get; set; }
    }
}
