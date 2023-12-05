using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class ManthanDriverAttachedV
    {
        [Required]
        [Column("CARDRIVERGUID")]
        [StringLength(36)]
        public string Cardriverguid { get; set; }
        [Column("CABREGISTRATIONNO")]
        [StringLength(255)]
        public string Cabregistrationno { get; set; }
        [Column("DRIVERID")]
        [StringLength(1000)]
        public string Driverid { get; set; }
        [Column("DRIVERNAME")]
        [StringLength(255)]
        public string Drivername { get; set; }
        [Column("DRIVERMIDDLENAME")]
        [StringLength(255)]
        public string Drivermiddlename { get; set; }
        [Column("DRIVERLASTNAME")]
        [StringLength(255)]
        public string Driverlastname { get; set; }
        [Column("DRIVERMOBILENO")]
        [StringLength(255)]
        public string Drivermobileno { get; set; }
        [Column("CITYNAME")]
        public byte? Cityname { get; set; }
        [Column("BRANDTYPE")]
        [StringLength(200)]
        public string Brandtype { get; set; }
        [Column("BUSSNIESMODEL")]
        [StringLength(200)]
        public string Bussniesmodel { get; set; }
        [Column("ALLOCATIONDATETIME")]
        [StringLength(19)]
        public string Allocationdatetime { get; set; }
        [Required]
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
    }
}
