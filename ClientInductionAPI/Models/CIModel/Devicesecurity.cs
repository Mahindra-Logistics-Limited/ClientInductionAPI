using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("DEVICESECURITY")]
    public partial class Devicesecurity
    {
        [Column("LE_NAME")]
        [StringLength(50)]
        public string LeName { get; set; }
        [Column("CITY_NAME")]
        [StringLength(50)]
        public string CityName { get; set; }
        [Column("BRAND_NAME")]
        [StringLength(50)]
        public string BrandName { get; set; }
        [Column("MODEL_NAME")]
        [StringLength(50)]
        public string ModelName { get; set; }
        [Column("IDENTIFYINGCODE", TypeName = "NUMBER")]
        public decimal? Identifyingcode { get; set; }
        [Column("MAXNUMBER", TypeName = "NUMBER")]
        public decimal? Maxnumber { get; set; }
        [Column("LASTNUMBER", TypeName = "NUMBER")]
        public decimal? Lastnumber { get; set; }
        [Column("GUID")]
        [StringLength(36)]
        public string Guid { get; set; }
        [Column("ID_LENGTH", TypeName = "NUMBER")]
        public decimal? IdLength { get; set; }
    }
}
