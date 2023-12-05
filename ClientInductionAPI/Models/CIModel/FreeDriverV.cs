using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class FreeDriverV
    {
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("PERSONGUID")]
        [StringLength(36)]
        public string Personguid { get; set; }
        [Column("DRIVERID")]
        [StringLength(1000)]
        public string Driverid { get; set; }
        [Column("DRIVER_FNAME")]
        [StringLength(255)]
        public string DriverFname { get; set; }
        [Column("DRIVER_MNAME")]
        [StringLength(255)]
        public string DriverMname { get; set; }
        [Column("DRIVER_LNAME")]
        [StringLength(255)]
        public string DriverLname { get; set; }
        [Column("DRIVER_BIOID")]
        [StringLength(255)]
        public string DriverBioid { get; set; }
        [Column("DRIVER_STATUS")]
        [StringLength(25)]
        public string DriverStatus { get; set; }
        [Column("DRIVER_OBJ_VER_NO")]
        public int? DriverObjVerNo { get; set; }
        [Column("DRIVER_READYFLAG")]
        [StringLength(100)]
        public string DriverReadyflag { get; set; }
        [Column("PERS_STATUS")]
        [StringLength(25)]
        public string PersStatus { get; set; }
        [Column("SPGUID")]
        [StringLength(36)]
        public string Spguid { get; set; }
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("SP_FNAME")]
        [StringLength(255)]
        public string SpFname { get; set; }
        [Column("SP_MNAME")]
        [StringLength(255)]
        public string SpMname { get; set; }
        [Column("SP_LNAME")]
        [StringLength(255)]
        public string SpLname { get; set; }
        [Column("SP_BIOID")]
        [StringLength(255)]
        public string SpBioid { get; set; }
        [Column("SP_STATUS")]
        [StringLength(25)]
        public string SpStatus { get; set; }
        [Column("CONTACT_NO")]
        [StringLength(255)]
        public string ContactNo { get; set; }
        [Column("DSEFLAG")]
        public bool? Dseflag { get; set; }
        [Column("SPFLAG")]
        public bool? Spflag { get; set; }
        [Column("DRIVERFLAG")]
        public bool? Driverflag { get; set; }
    }
}
