using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("SALES_CAR_INTERFACE")]
    public partial class SalesCarInterface
    {
        public SalesCarInterface()
        {
            SalesCabqcInterfaces = new HashSet<SalesCabqcInterface>();
            SalesCardrivermappings = new HashSet<SalesCardrivermapping>();
        }

        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("OWNERGUID")]
        [StringLength(36)]
        public string Ownerguid { get; set; }
        [Column("LE")]
        [StringLength(100)]
        public string Le { get; set; }
        [Column("CITY")]
        [StringLength(100)]
        public string City { get; set; }
        [Column("BRAND")]
        [StringLength(100)]
        public string Brand { get; set; }
        [Column("MODEL")]
        [StringLength(100)]
        public string Model { get; set; }
        [Column("FUELTYPE")]
        [StringLength(100)]
        public string Fueltype { get; set; }
        [Column("COLOR")]
        [StringLength(100)]
        public string Color { get; set; }
        [Column("CARMAKE")]
        [StringLength(200)]
        public string Carmake { get; set; }
        [Column("CARMODEL")]
        [StringLength(200)]
        public string Carmodel { get; set; }
        [Column("GROUPVARIANTGUID")]
        [StringLength(36)]
        public string Groupvariantguid { get; set; }
        [Column("CARNO")]
        [StringLength(50)]
        public string Carno { get; set; }
        [Column("YEAROFREG")]
        [StringLength(50)]
        public string Yearofreg { get; set; }
        [Column("OWNERNO", TypeName = "NUMBER")]
        public decimal? Ownerno { get; set; }
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
        [Column("ORASTATUS")]
        [StringLength(100)]
        public string Orastatus { get; set; }
        [Column("DEVICEID")]
        [StringLength(100)]
        public string Deviceid { get; set; }
        [Column("CHASSISNO")]
        [StringLength(36)]
        public string Chassisno { get; set; }
        [Column("MOBILENO")]
        [StringLength(20)]
        public string Mobileno { get; set; }
        [Column("CARMAKENAME")]
        [StringLength(100)]
        public string Carmakename { get; set; }
        [Column("CARMODELNAME")]
        [StringLength(100)]
        public string Carmodelname { get; set; }
        [Column("FUELTYPENAME")]
        [StringLength(100)]
        public string Fueltypename { get; set; }
        [Column("COLORNAME")]
        [StringLength(100)]
        public string Colorname { get; set; }
        [Column("BUSINESSCATEGORYMASTERGUID")]
        [StringLength(36)]
        public string Businesscategorymasterguid { get; set; }
        [Column("ANCHORLOCATIONGUID")]
        [StringLength(36)]
        public string Anchorlocationguid { get; set; }
        [Column("SHIFTMASTERGUID")]
        [StringLength(36)]
        public string Shiftmasterguid { get; set; }
        [Column("GARAGELOCATION")]
        [StringLength(500)]
        public string Garagelocation { get; set; }
        [Column("SENTNORMSDATATOMNATHAN", TypeName = "NUMBER")]
        public decimal? Sentnormsdatatomnathan { get; set; }
        [Column("PERMITTYPE")]
        [StringLength(36)]
        public string Permittype { get; set; }
        [Column("NOOFSEATS", TypeName = "NUMBER(38)")]
        public decimal? Noofseats { get; set; }
        [Column("ISAC")]
        public bool? Isac { get; set; }
        [Column("ACTUALSTATE")]
        [StringLength(255)]
        public string Actualstate { get; set; }
        [Column("ACTUALCITY")]
        [StringLength(255)]
        public string Actualcity { get; set; }
        [Column("CLIENTMAPGUID")]
        [StringLength(36)]
        public string Clientmapguid { get; set; }

        [ForeignKey(nameof(Ownerguid))]
        [InverseProperty(nameof(SalesOwnerInterface.SalesCarInterfaces))]
        public virtual SalesOwnerInterface Ownergu { get; set; }
        [InverseProperty(nameof(SalesCabqcInterface.Cargu))]
        public virtual ICollection<SalesCabqcInterface> SalesCabqcInterfaces { get; set; }
        [InverseProperty(nameof(SalesCardrivermapping.Cargu))]
        public virtual ICollection<SalesCardrivermapping> SalesCardrivermappings { get; set; }
    }
}
