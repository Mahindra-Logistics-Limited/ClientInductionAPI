using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("SEDANTOFLEXI")]
    public partial class Sedantoflexi
    {
        [Column("CARNO")]
        [StringLength(15)]
        public string Carno { get; set; }
        [Column("MASTER_STATUS")]
        [StringLength(1)]
        public string MasterStatus { get; set; }
        [Column("DATEUPDATED_MASTER", TypeName = "DATE")]
        public DateTime? DateupdatedMaster { get; set; }
        [Column("OFFROAD_STATUS")]
        [StringLength(1)]
        public string OffroadStatus { get; set; }
        [Column("DATEUPDATED_OFFROAD", TypeName = "DATE")]
        public DateTime? DateupdatedOffroad { get; set; }
        [Column("ONROAD_STATUS")]
        [StringLength(1)]
        public string OnroadStatus { get; set; }
        [Column("DATEUPDATED_ONROAD", TypeName = "DATE")]
        public DateTime? DateupdatedOnroad { get; set; }
        [Column("DEVICE_STATUS")]
        [StringLength(1)]
        public string DeviceStatus { get; set; }
        [Column("DATEUPDATED_DEVICE", TypeName = "DATE")]
        public DateTime? DateupdatedDevice { get; set; }
        [Column("DATECREATED", TypeName = "DATE")]
        public DateTime Datecreated { get; set; }
        [Column("OFFROAD_INTERFACE_STATUS")]
        [StringLength(1)]
        public string OffroadInterfaceStatus { get; set; }
        [Column("ONROAD_INTERFACE_STATUS")]
        [StringLength(1)]
        public string OnroadInterfaceStatus { get; set; }
        [Column("ANCHORLOCATION")]
        [StringLength(500)]
        public string Anchorlocation { get; set; }
        [Column("SHIFT")]
        [StringLength(20)]
        public string Shift { get; set; }
        [Column("GARAGELOCATION")]
        [StringLength(500)]
        public string Garagelocation { get; set; }
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("USER_MASTER_GUID")]
        [StringLength(40)]
        public string UserMasterGuid { get; set; }
        [Column("OLD_SC")]
        [StringLength(40)]
        public string OldSc { get; set; }
        [Column("OLD_GV")]
        [StringLength(255)]
        public string OldGv { get; set; }
        [Column("NEW_SC")]
        [StringLength(40)]
        public string NewSc { get; set; }
        [Column("NEW_GV")]
        [StringLength(255)]
        public string NewGv { get; set; }
    }
}
