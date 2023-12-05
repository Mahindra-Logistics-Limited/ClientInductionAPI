using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Table("SALES_DRIVER_INTERFACE_V3")]
    [Index(nameof(Ownerguid), Name = "SALES_DRIVER_INTERFACE_V3_OWNERGUID")]
    public partial class SalesDriverInterfaceV3
    {
        [Key]
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("OWNERGUID")]
        [StringLength(36)]
        public string Ownerguid { get; set; }
        [Column("DRIVERNAME")]
        [StringLength(200)]
        public string Drivername { get; set; }
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
        [Column("DRIVERID")]
        [StringLength(36)]
        public string Driverid { get; set; }
        [Column("ISSPCUMDRIVER", TypeName = "NUMBER")]
        public decimal? Isspcumdriver { get; set; }
        [Column("USERCREATED")]
        [StringLength(36)]
        public string Usercreated { get; set; }
        [Column("ADDRESSLINE1")]
        [StringLength(255)]
        public string Addressline1 { get; set; }
        [Column("ADDRESSLINE2")]
        [StringLength(255)]
        public string Addressline2 { get; set; }
        [Column("DATEOFBIRTH", TypeName = "DATE")]
        public DateTime? Dateofbirth { get; set; }
        [Column("MOBILENUMBER")]
        [StringLength(20)]
        public string Mobilenumber { get; set; }
        [Column("SOURCE")]
        [StringLength(50)]
        public string Source { get; set; }
    }
}
