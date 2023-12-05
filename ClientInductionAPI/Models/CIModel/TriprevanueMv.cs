using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    [Table("TRIPREVANUE_MV")]
    [Index(nameof(Carregistrationno), Name = "MVCAR_IND")]
    [Index(nameof(Spid), Name = "MVSPID_IND")]
    [Index(nameof(Siteguid), Name = "SITE_IND")]
    public partial class TriprevanueMv
    {
        [Column("SPID", TypeName = "NUMBER")]
        public decimal? Spid { get; set; }
        [Column("CARREGISTRATIONNO")]
        [StringLength(36)]
        public string Carregistrationno { get; set; }
        [Column("SITEGUID")]
        [StringLength(36)]
        public string Siteguid { get; set; }
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
        [Column("SECURITYCOMBINATIONGUID")]
        [StringLength(36)]
        public string Securitycombinationguid { get; set; }
        [Column("SERVICEPROVIDERGUID")]
        [StringLength(36)]
        public string Serviceproviderguid { get; set; }
        [Column("TRIPCOUNT", TypeName = "NUMBER")]
        public decimal? Tripcount { get; set; }
        [Column("TRIPRECEIVEDDATE", TypeName = "DATE")]
        public DateTime? Tripreceiveddate { get; set; }
        [Column("METERFARE", TypeName = "NUMBER")]
        public decimal? Meterfare { get; set; }
        [Column("CONVENIENCECHARGE", TypeName = "NUMBER")]
        public decimal? Conveniencecharge { get; set; }
        [Column("AIRPORTCHARGES", TypeName = "NUMBER")]
        public decimal? Airportcharges { get; set; }
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
    }
}
