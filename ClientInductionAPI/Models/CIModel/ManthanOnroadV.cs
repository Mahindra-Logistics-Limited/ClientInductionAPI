using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class ManthanOnroadV
    {
        [Column("CABREGISTRATIONNO")]
        [StringLength(255)]
        public string Cabregistrationno { get; set; }
        [Required]
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("SIEBELDEVICENO")]
        [StringLength(50)]
        public string Siebeldeviceno { get; set; }
        [Column("CABCOMPANYNAME")]
        [StringLength(25)]
        public string Cabcompanyname { get; set; }
        [Column("CABMODELNAME")]
        [StringLength(25)]
        public string Cabmodelname { get; set; }
        [Column("CABYEARMAKE", TypeName = "DATE")]
        public DateTime? Cabyearmake { get; set; }
        [Column("CHASISNO")]
        [StringLength(255)]
        public string Chasisno { get; set; }
        [Column("ENGINENO")]
        [StringLength(100)]
        public string Engineno { get; set; }
        [Column("REGISTRATIONDATE", TypeName = "DATE")]
        public DateTime? Registrationdate { get; set; }
        [Column("EMAILID")]
        [StringLength(16)]
        public string Emailid { get; set; }
        [Required]
        [Column("CITYNAME")]
        [StringLength(200)]
        public string Cityname { get; set; }
        [Column("SIMCARDNO")]
        [StringLength(20)]
        public string Simcardno { get; set; }
        [Column("BRANDTYPE")]
        [StringLength(200)]
        public string Brandtype { get; set; }
        [Column("BUSSNIESMODEL")]
        [StringLength(200)]
        public string Bussniesmodel { get; set; }
        [Required]
        [Column("SIEBELSUBSCRIBERID")]
        [StringLength(1000)]
        public string Siebelsubscriberid { get; set; }
        [Required]
        [Column("SUBSCRIBERFIRSTNAME")]
        [StringLength(255)]
        public string Subscriberfirstname { get; set; }
        [Column("SUBSCRIBERMIDDLENAME")]
        [StringLength(255)]
        public string Subscribermiddlename { get; set; }
        [Required]
        [Column("SUBSCRIBERLASTNAME")]
        [StringLength(255)]
        public string Subscriberlastname { get; set; }
        [Column("SUBSCRIBERMOBILENO")]
        [StringLength(255)]
        public string Subscribermobileno { get; set; }
    }
}
