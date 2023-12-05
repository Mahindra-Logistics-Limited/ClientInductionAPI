using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClientInductionAPI.Models.CIModel
{
    [Keyless]
    public partial class DispAllActiveCarsV
    {
        [Required]
        [Column("PERSONID")]
        [StringLength(1000)]
        public string Personid { get; set; }
        [Column("NAME")]
        [StringLength(520)]
        public string Name { get; set; }
        [Column("GENDER")]
        [StringLength(10)]
        public string Gender { get; set; }
        [Column("DOB", TypeName = "DATE")]
        public DateTime Dob { get; set; }
        [Column("PERSONROLE")]
        [StringLength(3)]
        public string Personrole { get; set; }
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
        [Column("COLOR")]
        [StringLength(255)]
        public string Color { get; set; }
        [Required]
        [Column("SPPERSONMASTERGUID")]
        [StringLength(36)]
        public string Sppersonmasterguid { get; set; }
        [Required]
        [Column("CARMASTERGUID")]
        [StringLength(36)]
        public string Carmasterguid { get; set; }
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
        [Column("MANTHANCITYID")]
        public byte? Manthancityid { get; set; }
        [Column("MANTHANBRANDID")]
        public byte? Manthanbrandid { get; set; }
        [Column("CONTACTNO")]
        [StringLength(255)]
        public string Contactno { get; set; }
        [Column("ISLBO", TypeName = "NUMBER")]
        public decimal? Islbo { get; set; }
        [Column("ISCMP", TypeName = "NUMBER")]
        public decimal? Iscmp { get; set; }
        [Column("BUSINESSCATEGORY")]
        [StringLength(50)]
        public string Businesscategory { get; set; }
        [Column("SHIFTFROMTIME")]
        [StringLength(5)]
        public string Shiftfromtime { get; set; }
        [Column("SHIFTTOTIME")]
        [StringLength(5)]
        public string Shifttotime { get; set; }
        [Column("MANTHANBUSINESSCATEGORYID")]
        public int? Manthanbusinesscategoryid { get; set; }
    }
}
