using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("ZIPDIAL_MAPPING")]
    public partial class ZipdialMapping
    {
        [Column("CITYNAME")]
        [StringLength(100)]
        public string Cityname { get; set; }
        [Column("OPERATOR")]
        [StringLength(100)]
        public string Operator { get; set; }
        [Column("MISSEDCALLNO", TypeName = "NUMBER")]
        public decimal? Missedcallno { get; set; }
        [Column("CITY_NAME")]
        [StringLength(100)]
        public string CityName1 { get; set; }
    }
}
