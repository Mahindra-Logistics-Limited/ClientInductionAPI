using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DriverDetailsV
    {
        [Required]
        [Column("PERSONMASTERGUID")]
        [StringLength(36)]
        public string Personmasterguid { get; set; }
        [Required]
        [Column("DRIVERID")]
        [StringLength(1000)]
        public string Driverid { get; set; }
        [Column("NAME")]
        [StringLength(511)]
        public string Name { get; set; }
        [Required]
        [Column("LE_NAME")]
        [StringLength(200)]
        public string LeName { get; set; }
        [Required]
        [Column("MODEL")]
        [StringLength(200)]
        public string Model { get; set; }
        [Column("ADDRESSLINE1")]
        [StringLength(255)]
        public string Addressline1 { get; set; }
        [Column("ADDRESSLINE2")]
        [StringLength(255)]
        public string Addressline2 { get; set; }
        [Required]
        [Column("CITY")]
        [StringLength(200)]
        public string City { get; set; }
        [Required]
        [Column("STATE")]
        [StringLength(255)]
        public string State { get; set; }
        [Column("CONTACTNO")]
        [StringLength(255)]
        public string Contactno { get; set; }
        [Column("PINCODE")]
        [StringLength(10)]
        public string Pincode { get; set; }
    }
}
