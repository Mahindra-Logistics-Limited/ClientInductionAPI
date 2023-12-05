using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("SALES_VEHICLE_INTERFACE_V3")]
    [Index(nameof(Ownerguid), Name = "SALES_VEHICLE_INTERFACE_V3_GUID")]
    [Index(nameof(Vehiclecity), Name = "SALES_VEHICLE_INTERFACE_V3_VEHICLECITY")]
    public partial class SalesVehicleInterfaceV3
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("OWNERGUID")]
        [StringLength(36)]
        public string Ownerguid { get; set; }
        [Column("VEHICLECITY")]
        [StringLength(200)]
        public string Vehiclecity { get; set; }
        [Column("VEHICLESTATE")]
        [StringLength(200)]
        public string Vehiclestate { get; set; }
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
        [Column("DEVICEID")]
        [StringLength(100)]
        public string Deviceid { get; set; }
        [Column("CHASSISNO")]
        [StringLength(36)]
        public string Chassisno { get; set; }
        [Column("BUSINESSCATEGORYMASTERGUID")]
        [StringLength(36)]
        public string Businesscategorymasterguid { get; set; }
        [Column("BUSINESSCATEGORYMASTERGUID2")]
        [StringLength(200)]
        public string Businesscategorymasterguid2 { get; set; }
        [Column("NOOFSEATS", TypeName = "NUMBER(38)")]
        public decimal? Noofseats { get; set; }
        [Column("ISAC")]
        public bool? Isac { get; set; }
        [Column("VEHICLE_TYPE_GUID")]
        [StringLength(36)]
        public string VehicleTypeGuid { get; set; }
        [Column("VEHICLE_OWNER_NAME")]
        [StringLength(100)]
        public string VehicleOwnerName { get; set; }
        [Column("REGISTRATIONDATE", TypeName = "DATE")]
        public DateTime? Registrationdate { get; set; }
        [Column("PERMITTYPE")]
        [StringLength(36)]
        public string Permittype { get; set; }
        [Column("VEHICLE_OWNER_MOBILENUMBER")]
        [StringLength(20)]
        public string VehicleOwnerMobilenumber { get; set; }
        [Column("SENTBUSINESSCATEGORY")]
        public bool? Sentbusinesscategory { get; set; }
        [Column("SOURCE")]
        [StringLength(10)]
        public string Source { get; set; }
    }
}
