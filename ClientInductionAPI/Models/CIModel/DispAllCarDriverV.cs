using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DispAllCarDriverV
    {
        [Required]
        [Column("DRIVERID")]
        [StringLength(1000)]
        public string Driverid { get; set; }
        [Column("NAME")]
        [StringLength(522)]
        public string Name { get; set; }
        [Column("PERSONROLE")]
        [StringLength(3)]
        public string Personrole { get; set; }
        [Required]
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("CARNO")]
        [StringLength(255)]
        public string Carno { get; set; }
        [Column("OWNERSHIPTYPE")]
        [StringLength(255)]
        public string Ownershiptype { get; set; }
        [Required]
        [Column("BRAND")]
        [StringLength(255)]
        public string Brand { get; set; }
        [Column("MODEL")]
        [StringLength(255)]
        public string Model { get; set; }
        [Required]
        [Column("LE_NAME")]
        [StringLength(200)]
        public string LeName { get; set; }
        [Required]
        [Column("CITY_NAME")]
        [StringLength(200)]
        public string CityName { get; set; }
        [Column("BRAND_NAME")]
        [StringLength(200)]
        public string BrandName { get; set; }
        [Column("MODEL_NAME")]
        [StringLength(200)]
        public string ModelName { get; set; }
        [Required]
        [Column("SPID")]
        [StringLength(1000)]
        public string Spid { get; set; }
        [Column("SPNAME")]
        [StringLength(520)]
        public string Spname { get; set; }
        [Column("MANTHANCITYID")]
        public byte? Manthancityid { get; set; }
        [Column("MANTHANBRANDID")]
        public byte? Manthanbrandid { get; set; }
        [Column("CONTACTNO")]
        [StringLength(255)]
        public string Contactno { get; set; }
    }
}
