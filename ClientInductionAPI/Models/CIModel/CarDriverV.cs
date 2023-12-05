using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class CarDriverV
    {
        [Column("CARDRIVER_GUID")]
        [StringLength(36)]
        public string CardriverGuid { get; set; }
        [Column("CAR_GUID")]
        [StringLength(36)]
        public string CarGuid { get; set; }
        [Column("CAR_REGN_NO")]
        [StringLength(255)]
        public string CarRegnNo { get; set; }
        [Column("CAR_STATUS_CODE")]
        [StringLength(25)]
        public string CarStatusCode { get; set; }
        [Column("DRIVER_GUID")]
        [StringLength(36)]
        public string DriverGuid { get; set; }
        [Column("DRIVER_PERS_GUID")]
        [StringLength(36)]
        public string DriverPersGuid { get; set; }
        [Column("DRIVER_ID")]
        [StringLength(1000)]
        public string DriverId { get; set; }
        [Column("DRIVER_NAME")]
        [StringLength(767)]
        public string DriverName { get; set; }
        [Column("DRIVER_STATUS")]
        [StringLength(25)]
        public string DriverStatus { get; set; }
        [Column("CAR_DRIVER_OBJ_VER_NO")]
        public int? CarDriverObjVerNo { get; set; }
        [Column("CARDRIVER_STATUSENTITYGUID")]
        [StringLength(36)]
        public string CardriverStatusentityguid { get; set; }
        [Column("STATUS_ENT_STSGUID")]
        [StringLength(36)]
        public string StatusEntStsguid { get; set; }
        [Column("STATUS_ENT_ENTGUID")]
        [StringLength(36)]
        public string StatusEntEntguid { get; set; }
        [Column("STATUS_ENT_OBJ_VER_NO")]
        public int? StatusEntObjVerNo { get; set; }
        [Column("STATUS_CODE")]
        [StringLength(25)]
        public string StatusCode { get; set; }
        [Column("STATUS_NAME")]
        [StringLength(200)]
        public string StatusName { get; set; }
        [Column("STATUS_DESC")]
        [StringLength(1000)]
        public string StatusDesc { get; set; }
        [Column("ENTITY_CODE")]
        [StringLength(50)]
        public string EntityCode { get; set; }
    }
}
