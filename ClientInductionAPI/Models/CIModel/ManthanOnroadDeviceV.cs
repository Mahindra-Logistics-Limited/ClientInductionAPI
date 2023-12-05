using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class ManthanOnroadDeviceV
    {
        [Column("CABREGISTRATIONNO")]
        [StringLength(255)]
        public string Cabregistrationno { get; set; }
        [Required]
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("SPNAME")]
        [StringLength(767)]
        public string Spname { get; set; }
        [Column("SPADDRESS")]
        [StringLength(511)]
        public string Spaddress { get; set; }
        [Column("SPCONTACTNO")]
        [StringLength(255)]
        public string Spcontactno { get; set; }
        [Column("SIEBELDEVICENO")]
        [StringLength(50)]
        public string Siebeldeviceno { get; set; }
        [Required]
        [Column("CABCOMPANYNAME")]
        [StringLength(255)]
        public string Cabcompanyname { get; set; }
        [Column("CABMODELNAME")]
        [StringLength(255)]
        public string Cabmodelname { get; set; }
        [Column("CABYEARMAKE")]
        [StringLength(4)]
        public string Cabyearmake { get; set; }
        [Column("CHASISNO")]
        [StringLength(255)]
        public string Chasisno { get; set; }
        [Column("ENGINENO")]
        [StringLength(100)]
        public string Engineno { get; set; }
        [Column("REGISTRATIONDATE")]
        [StringLength(19)]
        public string Registrationdate { get; set; }
        [Column("CABCOLOR")]
        [StringLength(255)]
        public string Cabcolor { get; set; }
        [Column("EMAILID")]
        [StringLength(16)]
        public string Emailid { get; set; }
        [Column("CITYNAME")]
        public byte? Cityname { get; set; }
        [Column("SIMCARDNO")]
        [StringLength(20)]
        public string Simcardno { get; set; }
        [Column("BRANDTYPE")]
        [StringLength(200)]
        public string Brandtype { get; set; }
        [Column("BUSSNIESMODEL")]
        [StringLength(200)]
        public string Bussniesmodel { get; set; }
        [Column("ALLOCATIONDATETIME")]
        [StringLength(19)]
        public string Allocationdatetime { get; set; }
        [Column("PAYTMQRCODE")]
        [StringLength(20)]
        public string Paytmqrcode { get; set; }
        [Column("PRIMARYBUSINESSCATEGORY")]
        [StringLength(50)]
        public string Primarybusinesscategory { get; set; }
        [Column("ANCHORLOCATIONID")]
        [StringLength(36)]
        public string Anchorlocationid { get; set; }
        [Column("SHIFTID")]
        [StringLength(36)]
        public string Shiftid { get; set; }
        [Column("PERMITTYPE")]
        [StringLength(255)]
        public string Permittype { get; set; }
        [Column("ACTUALSTATE")]
        [StringLength(255)]
        public string Actualstate { get; set; }
        [Column("ACTUALCITY")]
        [StringLength(255)]
        public string Actualcity { get; set; }
    }
}
