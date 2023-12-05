using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class SpCarDriDeatilsV
    {
        [Required]
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("REGISTRATIONNO")]
        [StringLength(255)]
        public string Registrationno { get; set; }
        [Required]
        [Column("CARGUID")]
        [StringLength(36)]
        public string Carguid { get; set; }
        [Required]
        [Column("SP_PERSON_GUID")]
        [StringLength(36)]
        public string SpPersonGuid { get; set; }
        [Column("DRIVER_PERSON_GUID")]
        [StringLength(36)]
        public string DriverPersonGuid { get; set; }
    }
}
